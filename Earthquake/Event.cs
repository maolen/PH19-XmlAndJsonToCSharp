namespace Earthquake
{
    public class Event : IAttribute
    {
        public string Datasource { get; set; }
        public string Eventsource { get; set; }
        public string EventId { get; set; }
        public string PublicId { get; set; }
        public Description Description { get; set; }
        public Origin Origin { get; set; }
        public Magnitude Magnitude { get; set; }
        public string PreferredOriginID { get; set; }
        public string PreferredMagnitudeID { get; set; }
        public CreationInfo CreationInfo { get; set; }
    }
}
