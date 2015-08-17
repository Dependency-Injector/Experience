using System;
using System.Collections;

namespace BussinessLogicLayer.Interfaces
{
    public interface IHistoryView
    {
        bool DisplayTaskEvents { get; set; }
        bool DisplayWorkUnitEvents { get; set; }
        bool DisplayExperienceEvents { get; set; }
        ICollection HistoryItems { set; } 
    }
}
