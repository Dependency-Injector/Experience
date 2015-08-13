using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer.Model;
using DataAccessLayer.Repositories;
using PresentationLayer.Views;

namespace PresentationLayer.Presenters
{
    public class ProfilePresenter
    {
        private readonly IProfileView view;
        private ProfileRepository profileRepository;

        public ProfilePresenter(IProfileView view)
        {
            this.view = view;
            profileRepository = new ProfileRepository();

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
                MessageBox.Show(e.Message);
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
        }

        private Profile ObtainProfile()
        {
            return profileRepository.HasProfile() ? profileRepository.GetAll().First() : null;
        }
    }
}
