namespace DataAccessLayer.Services.Interfaces
{
    public interface IProfileService
    {
        void UserGainedExperience(int userId, int experienceGained);
        void UserReachedNewLevel(int userId, int levelReached);
        void UserSkillGainedExperience(int skillId, int experienceGained);
        void UserSkillReachedNewLevel(int skillId, int levelReached);
    }
}