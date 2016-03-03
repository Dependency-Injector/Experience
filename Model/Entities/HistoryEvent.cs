using System;
using Model.Enums;

namespace Model.Entities
{
    public class HistoryEvent
    {
        public HistoryEvent()
        {
        }

        public int Id { get; set; }
        public HistoryEventType Type { get; set; }
        public DateTime Occured { get; set; }
        public String Description { get; set; }
        public int? AssociatedEntityId { get; set; }
        public String AdditionalInfo { get; set; }
        
        public virtual Profile Owner { get; set; }
    }

}
