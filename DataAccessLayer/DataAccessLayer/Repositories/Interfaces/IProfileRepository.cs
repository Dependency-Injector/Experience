using Model.Entities;

namespace DataAccessLayer.Repositories.Interfaces
{
    public interface IProfileRepository : IRepository<Profile> 
    {
        Profile Get(int profileId);
        bool HasProfile();
    }
}