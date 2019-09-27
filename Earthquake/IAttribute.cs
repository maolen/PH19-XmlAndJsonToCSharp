namespace Earthquake
{
    interface IAttribute
    {
        string Datasource { get; set; }
        string Eventsource { get; set; }
        string EventId { get; set; }
        string PublicId { get; set; }
    }
}
