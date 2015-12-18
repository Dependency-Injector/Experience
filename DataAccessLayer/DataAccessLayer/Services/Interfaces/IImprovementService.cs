using System;
using Model.Entities;

namespace DataAccessLayer.Services.Interfaces
{
    public interface IImprovementsService
    {
        Improvement CreateNewImprovement(int? ownerId, ImprovementType type, ImprovementOrigin origin, int amount, int? associatedEntityId = null, int? associatedSkillId = null);
        void SaveImprovement(Improvement ImprovementToSave);
        String GetImprovementDescription(Improvement improvement);
    }
}