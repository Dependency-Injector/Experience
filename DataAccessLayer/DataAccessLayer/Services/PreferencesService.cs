using System;
using DataAccessLayer.Repositories.Interfaces;
using DataAccessLayer.Services.Interfaces;
using Model.Entities;
using Model.Enums;

namespace DataAccessLayer.Services
{
    public class PreferencesService : IPreferencesService
    {
        private IPreferencesRepository preferencesRepository;
        private IProfileRepository profileRepository;
        private IHistoryService historyService;

        public PreferencesService(IPreferencesRepository preferencesRepository, IProfileRepository profileRepository, IHistoryService historyService)
        {
            this.preferencesRepository = preferencesRepository;
            this.profileRepository = profileRepository;
            this.historyService = historyService;
        }

        public Preferences CreateNewPreferences(int? ownerId)
        {
            Preferences preferences = new Preferences();

            if (ownerId.HasValue)
                preferences.Owner = profileRepository.Get(ownerId.Value);

            return preferences;
        }
    }
}
