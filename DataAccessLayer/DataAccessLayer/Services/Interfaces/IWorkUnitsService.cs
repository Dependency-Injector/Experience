using System;
using Model.Entities;

namespace DataAccessLayer.Services.Interfaces
{
    public interface IWorkUnitsService
    {
        void AddWorkUnit(WorkUnit workUnit);
        WorkUnit CreateNewWorkUnit(int? taskId, DateTime startTime);
        void UpdateWorkUnit(WorkUnit workUnitToUpdate);
    }
}