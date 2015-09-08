using System;
using Model.Entities;

namespace DataAccessLayer.Services.Interfaces
{
    public interface ITaskService
    {
        Task CreateNewTask(int? ownerId, string name, string description, DateTime dueDateTime, int priority, int? parentTaskId, int? associatedSkillId);
        void FinishTask(Task taskToFinish);
        bool IsFinishingAllowed(int id);
        void SaveTask(Task taskToSave);
        Task UpdateExistingTask(int taskId, string name, string description, DateTime dueDateTime, int priority, int? parentTaskId, int? associatedSkillId);
        void WorkedOnTask(Task task, WorkUnit workUnit);
    }
}