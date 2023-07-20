namespace OOP
{
    public class DocumentSearch
    {
        private IDocumentStorage documentStorage;

        public DocumentSearch(IDocumentStorage storage)
        {
            documentStorage = storage;
        }

        public Dictionary<string, object> SearchDocumentByNumber(string documentType, string number)
        {
            return documentStorage.SearchDocumentByNumber(documentType, number);
        }
    }

}
