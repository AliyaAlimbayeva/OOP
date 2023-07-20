namespace OOP
{
    public interface IDocumentStorage
    {
        Dictionary<string, object> SearchDocumentByNumber(string documentType, string number);
    }
}
