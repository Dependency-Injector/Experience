using Model.Enums;

namespace DataAccessLayer.Services.Interfaces
{
    public interface IHistoryService
    {
        void AddHistoryEvent(HistoryEventType type, int associatedTaskId, int? xpForEvent = default(int?), int? newLevel = default(int?));
        void AddHistoryEvent(HistoryEventType type, int? associatedEntityId = default(int?), string description = "", int? xpGained = default(int?), int? levelGained = default(int?));
    }
}