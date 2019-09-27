using System.Collections.Generic;

namespace Earthquake
{
    public class EventParameters
    {
        public string PublicId { get; set; }
        public List<Event> Events { get; set; }
        public CreationInfo CreationInfo {get; set;}
    }
}
