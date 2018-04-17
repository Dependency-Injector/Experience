using BussinessLogicLayer.Enums;

namespace BussinessLogicLayer.Events
{
    /// <summary>
    /// Event triggered when todo list is modified by adding, removing or editing item
    /// </summary>
    public class TasksChangedEvent
    {
        public ListChangeType TypeOfChange;
        public int TaskId;

        public TasksChangedEvent(ListChangeType typeOfChange, int taskId)
        {
            TypeOfChange = typeOfChange;
            TaskId = taskId;
        }
    }
}
