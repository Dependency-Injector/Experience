using System;
using System.Collections.Generic;
using BussinessLogicLayer.GridRowTemplates;
using BussinessLogicLayer.Enums;

namespace BussinessLogicLayer.Interfaces
{
    public interface ITodoListView
    {
        IList<TaskGridItem> TasksGridItems { set; }
        SortingType SortingType { get; set; }

        event EventHandler<EventArgs> NewTask;
        event EventHandler<int> TaskDoubleClick;
        event EventHandler<bool> ShowFinishedTasks;
        event EventHandler<SortingType> ChangeSorting;
    }
}
