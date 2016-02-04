using System;

namespace BussinessLogicLayer.Interfaces
{
    public interface IMainView
    {
        IDayView DayView { get; }
        ITasksListView TasksListView { get; }
        IProfileView ProfileView { get; }
        IHistoryView HistoryView { get; }
        IOptionsView OptionsView { get; }

        SubViewType SelectedSubView { get; }

        

        event EventHandler<EventArgs> SubViewDisplayed;

    }

    public enum SubViewType
    {
        Day,
        History,
        Options,
        Profile,
        Tasks,
        Unknown
    }
}
