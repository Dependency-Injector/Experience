using System;
using Model.Entities;

namespace DataAccessLayer.Services.Interfaces
{
    public interface IProfileService
    {
        Profile CreateNewProfile(String name);
        void UserGainedExperience(int userId, int experienceGained);
        void UserReachedNewLevel(int userId, int levelReached);
        void UserSkillGainedExperience(int skillId, int experienceGained);
        void UserSkillReachedNewLevel(int skillId, int levelReached);
    }
}