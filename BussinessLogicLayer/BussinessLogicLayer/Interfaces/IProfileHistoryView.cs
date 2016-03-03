using System.Collections.Generic;
using BussinessLogicLayer.GridRowTemplates;

namespace BussinessLogicLayer.Interfaces
{
    public interface IProfileHistoryView
    {
        //BindingSource ProfileRelatedEvents { set; }
        IList<ImprovementGridItem> ProfileEventsGridItems { set; }
    }
}
