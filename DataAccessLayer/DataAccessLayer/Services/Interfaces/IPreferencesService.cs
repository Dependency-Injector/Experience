using Model.Entities;

namespace DataAccessLayer.Services.Interfaces
{
    public interface IPreferencesService
    {
        Preferences CreateNewPreferences(int? ownerId);
    }
}