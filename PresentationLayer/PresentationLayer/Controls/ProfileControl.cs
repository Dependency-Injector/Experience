using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using PresentationLayer.Views;

namespace PresentationLayer.Controls
{
    public partial class ProfileControl : MetroUserControl, IProfileView
    {
        public ProfileControl()
        {
            InitializeComponent();
        }

        public String PlayerName
        {
            get { return nameLabel.Text; }
            set { nameLabel.Text = value; }
        }

        public String History
        {
            get { return historyLabel.Text; }
            set { historyLabel.Text = value; }
        }

        public int Age
        {
            get
            {
                int age;
                if (int.TryParse(ageLabel.Text, out age))
                    return age;
                else
                    return 0;
            }
            set { ageLabel.Text = value.ToString(); }
        }

        public DateTime BirthDate
        {
            get
            {
                int age;
                if (int.TryParse(ageLabel.Text, out age))
                {
                    DateTime birthYear = DateTime.Now.AddYears(-age);
                    return birthYear;
                }
                else
                    return DateTime.Now;
            }

            set
            {
                TimeSpan age = DateTime.Now - value;
                int years = (int) (age.TotalDays/365);
                ageLabel.Text = years.ToString();
            }
        }

        public int Level
        {
            get
            {
                int level;
                if (int.TryParse(levelLabel.Text, out level))
                    return level;
                else
                    return 0;
            }
            set { levelLabel.Text = value.ToString(); }
        }

        public int Experience
        {
            get
            {
                int experience;
                if (int.TryParse(experienceLabel.Text, out experience))
                    return experience;
                else
                    return 0;
            }
            set
            {
                experienceLabel.Text = value.ToString();
            }
        }

        public int LevelProgress
        {
            get { return experienceProgressBar.Value; }
            set { experienceProgressBar.Value = value; }
        }
    }
}
