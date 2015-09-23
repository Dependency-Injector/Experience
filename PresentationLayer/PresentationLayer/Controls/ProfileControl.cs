using System;
using System.Collections;
using System.Windows.Forms;
using BussinessLogicLayer.Interfaces;
using MetroFramework.Controls;
using Model.Entities;

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

        public ICollection Skills
        {
            set { AddSkillsToDataGrid(value); }
        }

        public DateTime Joined
        {
            set
            {
            }
        }

        public ICollection ExperienceEventData
        {
            set
            {
                if (value != null && value.Count > 0)
                {
                    ClearExperienceEventsGrid();
                    FillExperienceEventsGrid(value);
                }
                else
                {
                }
            }
        }

        public bool RemoveSkillColumnVisible
        {
            set { RemoveSkillButtonColumn.Visible = value; }
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

        private void FillExperienceEventsGrid(ICollection worksUnitRowData)
        {
            if (worksUnitRowData != null && worksUnitRowData.Count > 0)
            {
                foreach (var workUnit in worksUnitRowData)
                {
                    if (workUnit is string[])
                    {
                        string[] rowCells = (string[])workUnit;
                        workUnitsGrid.Rows.Add(rowCells[0], rowCells[1]);
                    }
                }

            }
        }

        private void ClearExperienceEventsGrid()
        {
            workUnitsGrid.DataSource = null;
        }

        private void AddSkillsToDataGrid(ICollection skills)
        {
            foreach (var skillObject in skills)
            {
                if (skillObject is Skill)
                {
                    Skill skill = (Skill)skillObject;
                    skillsGrid.Columns[0].Name = "Id";
                    skillsGrid.Columns[1].Name = "Name";
                    skillsGrid.Columns[2].Name = "Level";
                    skillsGrid.Columns[3].Name = "Exp";
                    skillsGrid.Columns[4].Name = "NewLevelProgress";
                    skillsGrid.Columns[5].Name = "Remove";

                    string[] skillRow = new string[]
                    {
                        $"{skill.Id}",
                        $"{skill.Name}",
                        $"{skill.Level}",
                        $"{skill.Experience}",
                        $"{skill.GetNewLevelProgress()}",
                        "X"
                    };

                    skillsGrid.Rows.Add(skillRow);
                }
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (EditProfile != null)
                EditProfile(this, e);

            //editProfileButton.Enabled = false;
            //saveChangesButton.Enabled = true;
            //TODO
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (SaveChanges != null)
                SaveChanges(this, e);

           // editProfileButton.Enabled = true;
            //saveChangesButton.Enabled = false;
            // TODO
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

        private void skillsGrid_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (RemoveSkill != null)
            {
                var senderGrid = (MetroGrid) sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {
                    var idColumn = senderGrid.Rows[e.RowIndex].Cells["Id"];
                    int skillToRemoveId;
                    if (int.TryParse(idColumn.Value.ToString(), out skillToRemoveId))
                    {
                        RemoveSkill(this, skillToRemoveId);
                    }
                }
            }
        }
    }
}
