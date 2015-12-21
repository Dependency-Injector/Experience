using System;
using System.ComponentModel;

namespace BussinessLogicLayer.GridRowTemplates
{
    /// <summary>
    /// Representation of player improvement on grid row, displayed on Profile tab 
    /// </summary>
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
