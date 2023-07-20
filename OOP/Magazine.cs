namespace OOP
{
    class Magazine : Document
    {
        public string Publisher { get; set; }
        public int ReleaseNumber { get; set; }

        public override Dictionary<string, object> GetCardInfo()
        {
            return new Dictionary<string, object>
        {
            { "title", Title },
            { "publisher", Publisher },
            { "release_number", ReleaseNumber },
            { "date_published", DatePublished }
        };
        }
    }
}
