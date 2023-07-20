namespace OOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            var storagePath = "pathtodocumentcards";
            var fileCabinet = new FileDocumentStorage(storagePath);
            var ui = new ConsoleUI(fileCabinet);

            ui.SearchDocuments();
        }
    }
}