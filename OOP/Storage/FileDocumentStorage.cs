using System.IO;
using Newtonsoft.Json;

namespace OOP
{
    public class FileDocumentStorage : IDocumentStorage
    {
        private readonly string storagePath;

        public FileDocumentStorage(string storagePath)
        {
            this.storagePath = storagePath;
        }

        public Dictionary<string, object> SearchDocumentByNumber(string documentType, string documentNumber)
        {
            var filename = $"{documentType}_{documentNumber}.json";
            var filePath = Path.Combine(storagePath, filename);

            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
                var cardInfo = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);
                return cardInfo;
            }

            return null;
        }
    }
}
