using System;

namespace Earthquake
{
    public class Origin : IAttribute
    {
        public string Datasource { get; set; }
        public string Eventsource { get; set; }
        public string EventId { get; set; }
        public string PublicId { get; set; }
        public DateTime Time { get; set; }
        public float Longitude { get; set; }
        public float Latitude { get; set; }
        public Depth Depth { get; set; }
        public OriginUncertainty OriginUncertainty { get; set; }
        public Quality Quality { get; set; }
        public string EvaluationMode { get; set; }
        public CreationInfo CreationInfo { get; set; }
    }
}
