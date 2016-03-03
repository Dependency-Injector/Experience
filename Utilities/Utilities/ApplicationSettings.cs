using System;
using System.IO;
using Newtonsoft.Json;

namespace Utilities
{
    public class ApplicationSettings
    {
        #region Settings

        public bool IsAnyUserLoggedIn = false;
        public int? CurrentUserId = null;
        public string CurrentUserName = null;
        public int LastlyViewedTab = 1;

        #endregion


        private static ApplicationSettings current;
        public static ApplicationSettings Current
        {
            get
            {
                if(current == null)
                    current = new ApplicationSettings();

                return current;
            }

            private set { current = value; }
        }

        private const string DefaultFilename = "settings.jsn";

        public static void Save(string fileName = DefaultFilename)
        {
            var settingsInJson = JsonConvert.SerializeObject(Current);
            File.WriteAllText(fileName, settingsInJson);
        }

        public static void Load(string fileName = DefaultFilename)
        {
            ApplicationSettings settingsObject = new ApplicationSettings();
            if (File.Exists(fileName))
            {
                String settingsInJson = File.ReadAllText(fileName);
                settingsObject = JsonConvert.DeserializeObject<ApplicationSettings>(settingsInJson);
            }

            Current = settingsObject;
        }

    }
}
