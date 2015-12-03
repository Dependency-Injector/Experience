using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BussinessLogicLayer.GridRowTemplates;
using BussinessLogicLayer.Interfaces;
using BussinessLogicLayer.Templates;
using MetroFramework.Controls;

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

        public String Age
        {
            set { ageLabel.Text = value; }
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
                int years = (int)(age.TotalDays / 365);
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

        public String Experience
        {
            get
            {
                return experienceLabel.Text;
            }
            set
            {
                experienceLabel.Text = value;
            }
        }

        public int LevelProgress
        {
            get { return experienceProgressBar.Value; }
            set { experienceProgressBar.Value = value; }
        }

        public int? SelectedSkill {
            get
            {
                if (skillsGrid.SelectedRows != null && skillsGrid.SelectedRows.Count > 0)
                {
                    var skillSelected = skillsGrid.SelectedRows[0].DataBoundItem as SkillGridItem;
                    if (skillSelected != null)
                        return skillSelected.Id;
                }

                return null;
            }
            set
            {
                
            }
        }

        public BindingSource Skills
        {
            set
            {
                skillsGrid.DataSource = null;
                skillsGrid.DataSource = value;
            }
        }
        
        public BindingSource ProfileRelatedEvents
        {
            set
            {
                profileRelatedEventsGrid.DataSource = null;
                profileRelatedEventsGrid.DataSource = value;
            }
        }

        public bool AddNewSkillPanelVisible
        {
            set { addNewSkillPanel.Visible = value; }
        }

        public bool EditProfileButtonVisible
        {
            set { editProfileButton.Visible = value; }
        }

        public bool CancelChangesButtonVisible
        {
            set { cancelChangesButton.Visible = value; }
        }

        public bool SaveChangesButtonVisible
        {
            set { saveChangesButton.Visible = value; }
        }

        public string NewSkillName
        {
            get { return newSkillNameTextBox.Text; }
            set { newSkillNameTextBox.Text = value; }
        }

        public event EventHandler<EventArgs> AddNewSkill;
        public event EventHandler<int> RemoveSkill;
        public event EventHandler<EventArgs> EditProfile;
        public event EventHandler<EventArgs> SaveChanges;
        public event EventHandler<EventArgs> CancelChanges;
        public event Action SkillSelected;

        private void editButton_Click(object sender, EventArgs e)
        {
            if (EditProfile != null)
                EditProfile(this, e);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (SaveChanges != null)
                SaveChanges(this, e);
        }

        private void addNewSkillButton_Click(object sender, EventArgs e)
        {
            if (AddNewSkill != null)
                AddNewSkill(this, e);
        }

        private void cancelChangesButton_Click(object sender, EventArgs e)
        {
            if (CancelChanges != null)
                CancelChanges(this, e);
        }

        private void skillsGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (SkillSelected != null)
                SkillSelected();
        }

        private void profileRelatedEventsGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.profileRelatedEventsGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.profileRelatedEventsGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
