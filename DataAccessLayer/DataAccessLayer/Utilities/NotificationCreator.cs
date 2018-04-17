using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Utilities
{
    public static class NotificationCreator
    {
        private static ProfileRepository profileRepository = new ProfileRepository();
        private static SkillsRepository skillsRepository = new SkillsRepository();
        private static TasksRepository tasksRepository = new TasksRepository();

        static NotificationCreator()
        {
        }

        public static string GetNotificationText()
        {
            return "some notification about something";
        }
    }
}
