namespace Earthquake
{
    public class Magnitude : IAttribute
    {
        public string Datasource { get; set; }
        public string Eventsource { get; set; }
        public string EventId { get; set; }
        public string PublicId { get; set; }
        public double MagnitudeValue { get; set; }
        public string Type { get; set; }
        public string OriginId { get; set; }
        public string EvaluationMode { get; set; }
        public CreationInfo CreationInfo { get; set; }
    }
}
