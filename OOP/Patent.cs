namespace OOP
{
    public class Patent: Document
    {
        public DateTime ExpirationDate { get; set; }
        public int UniqueId { get; set; }
        public override Dictionary<string, object> GetCardInfo()
        {
            return new Dictionary<string, object>
            {
                { "title", Title },
                { "authors", Authors },
                { "date_published", DatePublished },
                { "expiration_date", ExpirationDate },
                { "unique_id", UniqueId }
            };
        }
    }
}
