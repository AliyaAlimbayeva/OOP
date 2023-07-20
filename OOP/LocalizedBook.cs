namespace OOP
{
    public class LocalizedBook : Book
    {
        public string OriginalPublisher { get; set; }
        public string Country { get; set; }
        public string LocalPublisher { get; set; }
        public override Dictionary<string, object> GetCardInfo()
        {
            var cardInfo = base.GetCardInfo();
            cardInfo.Add("original_publisher", OriginalPublisher);
            cardInfo.Add("country", Country);
            cardInfo.Add("local_publisher", LocalPublisher);
            return cardInfo;
        }
    }
}
