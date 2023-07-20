namespace OOP
{
    public class Book : Document
    {
        public string ISBN { get; set; }
        public int NumPages { get; set; }
        public string Publisher { get; set; }
        public override Dictionary<string, object> GetCardInfo()
        {
            return new Dictionary<string, object>
            {
                { "isbn", ISBN },
                { "title", Title },
                { "authors", Authors },
                { "num_pages", NumPages },
                { "publisher", Publisher },
                { "date_published", DatePublished }
            };
        }
    }
}
