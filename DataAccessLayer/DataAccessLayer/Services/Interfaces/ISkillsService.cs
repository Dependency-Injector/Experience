using Model.Entities;

namespace DataAccessLayer.Services.Interfaces
{
    public interface ISkillsService
    {
        Skill CreateNewSkill(int? ownerId, string name);
        void SaveSkill(Skill skillToSave);
        void RemoveSkill(int skillToRemoveId);
    }
}