using System;
using System.ComponentModel;

namespace BussinessLogicLayer.GridRowTemplates
{
    public class ImprovementGridItem
    {
        [DisplayName("When")]
        public String WhenLiteral { get; set; }

        public String Description { get; set; }

        [Browsable(false)]
        public DateTime When { get; set; }

        public ImprovementGridItem(DateTime when, String whenLiteral, String description)
        {
            When = when;
            WhenLiteral = whenLiteral;
            Description = description;
        }
    }

}
