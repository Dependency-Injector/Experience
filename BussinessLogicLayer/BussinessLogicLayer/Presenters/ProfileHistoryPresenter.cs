using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BussinessLogicLayer.Enums;
using BussinessLogicLayer.Events;
using BussinessLogicLayer.GridRowTemplates;
using BussinessLogicLayer.Interfaces;
using DataAccessLayer.Repositories.Interfaces;
using DataAccessLayer.Services.Interfaces;
using DataAccessLayer.Utilities;
using Model.Entities;
using Model.Enums;
using Utilities;

namespace BussinessLogicLayer.Presenters
{
    public class ProfileHistoryPresenter
    {
        private readonly IProfileHistoryView view;
        private readonly IProfileRepository profileRepository;

        private readonly IImprovementsRepository improvementsRepository;
        private readonly IImprovementsService improvementsService;
        
        private Profile currentUser;

        public ProfileHistoryPresenter(IProfileHistoryView view, IProfileRepository profileRepository, IImprovementsRepository improvementsRepository, IImprovementsService improvementsService)
        {
            this.view = view;
            this.profileRepository = profileRepository;
            this.improvementsRepository = improvementsRepository;
            this.improvementsService = improvementsService;
         }

        public void Initialize()
        {
            try
            {
                    int currentUserId = Globals.DmitruUserId;
                    currentUser = ObtainProfile(currentUserId);
                    if (currentUser != null)
                    {
                        DisplayProfileInfo(currentUser);
                    }
            }
            catch (Exception e)
            {
                Logger.Exception(e);
            }
        }

        
        private void DisplayProfileInfo(Profile profile)
        {
            var userImprovements = improvementsRepository.Find(i => i.Owner.Id == profile.Id).ToList();
            var userImprovementsGridItems = GetImprovementsGridItems(userImprovements).OrderByDescending(ui => ui.When).ToList(); 

            view.ProfileRelatedEvents = MakeBindingSourceFromList(userImprovementsGridItems);
        }
        
        private List<ImprovementGridItem> GetImprovementsGridItems(List<Improvement> improvements)
        {
            List<ImprovementGridItem> profileRelatedEvents = new List<ImprovementGridItem>();

            foreach (var improvement in improvements)
            {
                String occuredDate = improvement.Occured.ToString("dddd, d MMMM HH:mm");
                String eventType = improvement.Type.ToString();
                String improvementDescription = improvementsService.GetImprovementDescription(improvement);

                profileRelatedEvents.Add(new ImprovementGridItem(improvement.Occured, occuredDate, improvementDescription));
            }

            return profileRelatedEvents;
        }
        
        private Profile ObtainProfile(int profileId)
        {
            return profileRepository.HasProfile() ? profileRepository.First(p => p.Id == profileId) : null;
        }
        
        public static BindingSource MakeBindingSourceFromList(IList list)
        {
            BindingSource source = new BindingSource();
            source.DataSource = list;
            return source;
        }
    }
}
