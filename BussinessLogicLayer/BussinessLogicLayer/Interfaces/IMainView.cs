using System;
using BussinessLogicLayer.Enums;

namespace BussinessLogicLayer.Interfaces
{
    public interface IMainView
    {
        IDayView DayView { get; }
        ITodoListView TodoListView { get; }
        IProfileView ProfileView { get; }
        IHistoryView HistoryView { get; }
        IOptionsView OptionsView { get; }
        IListsView ListsView { get; }

        SubViewType SelectedSubView { get; }
        
        event EventHandler<EventArgs> SubViewDisplayed;
    }
}
