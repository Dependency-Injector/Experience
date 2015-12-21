using System;

namespace BussinessLogicLayer.GridRowTemplates
{
    /// <summary>
    /// Representation of history event on grid row, displayed on History tab 
    /// </summary>
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
