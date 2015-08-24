using System;
using System.Collections.Generic;
using System.Linq;
using BussinessLogicLayer.Interfaces;
using DataAccessLayer.Repositories;
using DataAccessLayer.Utilities;
using Model.Entities;
using Model.Enums;

namespace BussinessLogicLayer.Presenters
{
    public class ProfilePresenter
    {
        private readonly IProfileView view;
        private readonly ProfileRepository profileRepository;
        private readonly HistoryEventsRepository historyEventsRepository;

        public ProfilePresenter(IProfileView view)
        {
            this.view = view;
            profileRepository = new ProfileRepository();
            historyEventsRepository = new HistoryEventsRepository();

            Initialize();
        }

        private void Initialize()
        {
            try
            {
                Profile profile = ObtainProfile();
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
            //view.BirthDate = profile.BirthDate;
            view.Experience = profile.Experience;
            view.Level = profile.Level;
            view.LevelProgress = profile.LevelProgressInPercent();
            view.Skills = profile.Skills.ToList();
            var experienceEvents =
                historyEventsRepository.Find(
                    he =>
                        he.Type == HistoryEventType.ExperienceGained ||
                        he.Type == HistoryEventType.SkillExperienceGained).ToList();
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

        private Profile ObtainProfile()
        {
            return profileRepository.HasProfile() ? profileRepository.GetAll().First() : null;
        }
    }
}
