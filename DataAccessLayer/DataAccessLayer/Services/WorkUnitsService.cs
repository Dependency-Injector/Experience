using System;
using DataAccessLayer.Repositories.Interfaces;
using DataAccessLayer.Services.Interfaces;
using Model.Entities;
using Model.Enums;

namespace DataAccessLayer.Services
{
    public class WorkUnitsService : IWorkUnitsService
    {
        private ITasksRepository tasksRepository;
        private IWorkUnitsRepository workUnitsRepository;
        private IHistoryService historyService;

        public WorkUnitsService(IWorkUnitsRepository workUnitsRepository, ITasksRepository tasksRepository, IHistoryService historyService)
        {
            this.workUnitsRepository = workUnitsRepository;
            this.tasksRepository = tasksRepository;
            this.historyService = historyService;
        }

        public WorkUnit CreateNewWorkUnit(int? taskId, DateTime startTime)
        {
            WorkUnit workUnit = new WorkUnit();
            workUnit.StartTime = startTime;

            if (taskId.HasValue)
                workUnit.Task = tasksRepository.Get(taskId.Value);

            return workUnit;
        }
        
        public void AddWorkUnit(WorkUnit workUnit)
        {
            workUnitsRepository.Add(workUnit);
            //historyService.AddHistoryEvent(HistoryEventType.WorkStarted, workUnit.Id);
        }

        public void UpdateWorkUnit(WorkUnit workUnitToUpdate)
        {
            workUnitsRepository.Update(workUnitToUpdate);
            //historyService.AddHistoryEvent(HistoryEventType.WorkStopped, workUnitToUpdate.Id);
        }
    }
}
