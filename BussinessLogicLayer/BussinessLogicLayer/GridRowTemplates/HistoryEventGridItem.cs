using System;

namespace BussinessLogicLayer.Templates
{
    public class HistoryEventGridItem
    {
        public String Occured { get; set; }
        public String Type { get; set; }
        public String Description { get; set; }

        public HistoryEventGridItem(String occured, String type, String description)
        {
            Occured = occured;
            Type = type;
            Description = description;
        }
    }
}
