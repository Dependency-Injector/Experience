using System;

namespace BussinessLogicLayer.GridRowTemplates
{
    public class ProfileEventGridItem
    {
        public String Occured { get; set; }
        public String Type { get; set; }
        public String Description { get; set; }

        public ProfileEventGridItem(String occured, String type, String description)
        {
            Occured = occured;
            Type = type;
            Description = description;
        }
    }
}
