using System;
using System.Collections.Generic;
using BussinessLogicLayer.GridRowTemplates;

namespace BussinessLogicLayer.Interfaces
{
    public interface ITodoListView
    {
        IList<TaskGridItem> TasksGridItems { set; }
             
        event EventHandler<EventArgs> NewTask;
        event EventHandler<int> TaskDoubleClick;
        event EventHandler<bool> ShowFinishedTasks;
    }
}
