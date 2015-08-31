using System;
using System.Collections.Generic;
using System.Linq;
using BussinessLogicLayer.Interfaces;
using DataAccessLayer.Repositories;
using DataAccessLayer.Repositories.Interfaces;
using DataAccessLayer.Utilities;
using Model.Entities;
using Model.Enums;
using Utilities;

namespace BussinessLogicLayer.Presenters
{
    public class ProfilePresenter
    {
        private readonly IProfileView view;
        private readonly IProfileRepository profileRepository;
        private readonly IHistoryEventsRepository historyEventsRepository;

        public ProfilePresenter(IProfileView view, IProfileRepository profileRepository, IHistoryEventsRepository historyEventsRepository)
        {
            this.view = view;
            this.profileRepository = profileRepository;
            this.historyEventsRepository = historyEventsRepository;

            Initialize();
        }

        private void Initialize()
        {
            try
            {
                int currentUserId = ApplicationSettings.Current.CurrentUserId.Value;
                Profile profile = ObtainProfile(currentUserId);
                if (profile != null)
                {
                    DisplayProfileInfo(profile);
                }
            }
            catch (Exception e)
            {
                Logger.Exception(e);
            }
        }

        private void DisplayProfileInfo(Profile profile)
        {
            view.PlayerName = profile.Name;
            view.History = profile.History;
            view.Age = profile.AgeInYears();
            view.Experience = profile.Experience;
            view.Level = profile.Level;
            view.LevelProgress = profile.LevelProgressInPercent();
            view.Skills = profile.Skills.ToList();
            var experienceEvents =
                historyEventsRepository.Find(
                    he =>
                        he.Type == HistoryEventType.ExperienceGained ||
                        he.Type == HistoryEventType.LevelGained ||
                        he.Type == HistoryEventType.SkillExperienceGained ||
                        he.Type == HistoryEventType.SkillLevelGained).ToList();
            
            view.ExperienceEventData = GetExperienceEventRows(experienceEvents);
        }

        private List<string[]> GetExperienceEventRows(List<HistoryEvent> historyEvents)
        {
            List<string[]> workUnitsRows = new List<string[]>();

            foreach (var historyEvent in historyEvents)
            {
                String occuredDate = historyEvent.Occured.ToString("dddd, d MMMM HH:mm");
                String eventType = historyEvent.Type.ToString();
                
                string[] taskRow = new string[]
                {
                    $"{occuredDate}",
                    $"{eventType}",
/*                    $"{durationLiteral}"*/
                };

                workUnitsRows.Add(taskRow);
            }

            return workUnitsRows;
        }

        private Profile ObtainProfile(int profileId)
        {
            return profileRepository.HasProfile() ? profileRepository.First(p => p.Id == profileId) : null;
        }
    }
}
