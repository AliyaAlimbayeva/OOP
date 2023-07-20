namespace OOP
{
    public class ConsoleUI
    {
        private readonly FileDocumentStorage fileCabinet;

        public ConsoleUI(FileDocumentStorage fileCabinet)
        {
            this.fileCabinet = fileCabinet;
        }

        public void SearchDocuments()
        {
            Console.Write("Enter the document number: ");
            var documentNumber = Console.ReadLine();
            var documentTypes = new[] { "patent", "book", "localized_book", "magazine" }; 
            bool found = false;
            foreach (var documentType in documentTypes)
            {
                var cardInfo = fileCabinet.SearchDocumentByNumber(documentType, documentNumber);
                if (cardInfo != null)
                {
                    Console.WriteLine($"Found {documentType.ToUpperInvariant()}:");
                    PrintCardInfo(cardInfo);
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Document not found.");
            }
        }

        private void PrintCardInfo(Dictionary<string, object> cardInfo)
        {
            foreach (var entry in cardInfo)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }
    }
}

