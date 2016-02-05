using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLogicLayer.Interfaces;
using MetroFramework.Controls;
using Model.Classes;
using Model.Enums;

namespace PresentationLayer.Controls
{
    public partial class TaskEditControl : MetroUserControl, ITaskEditView
    {
        public TaskEditControl()
        {
            InitializeComponent();
        }

        public string Title
        {
            get { return nameTextBox.Text; }
            set { nameTextBox.Text = value; }
        }

        public bool CanBeFinished { get; set; }

        public bool IsVisible
        {
            set { this.Visible = value; }
        }

        public DisplayMode DisplayMode { get; set; }

        public int TaskId { get; set; }

        public string TaskName
        {
            get { return nameTextBox.Text; }
            set
            {
                nameTextBox.Text = value;
            }
        }
        public string TaskDescription
        {
            get { return descriptionTextBox.Text; }
            set
            {
                descriptionTextBox.Text = value;
            }
        }
        public int Priority
        {
            get { return GetSelectedPriority(); }

            set { SelectPriority(value); }
        }

        public int Difficulty
        {
            get { return GetSelectedDifficulty(); }
            set { SelectDifficulty(value); }
        }

        public DateTime? DueDate
        {
            get { return dueDateTime.Value; }
            set
            {
                if (value.HasValue)
                {
                    dueDateTime.Value = value.Value;
                }
            }
        }

        public DateTime MinDueDate
        {
            get { return dueDateTime.MinDate; }
            set { dueDateTime.MinDate = value; }
        }

        public bool IsFinished
        {
            set
            {
                //if(value)
                //    ShowActionButtons(false);
                //else
                //    ShowActionButtons(true);
            }
        }
        public DateTime? FinishDate { get; set; }
        
        public bool IsDirty
        {
            set { bool x = false; }
        }

        public int? SkillToTrainId
        {
            get
            {
                if (skillToTrainComboBox.SelectedItem != null)
                {
                    var selectedSkill = (KeyValuePair<int, string>)skillToTrainComboBox.SelectedItem;

                    // To avoid returning empty item as skill to train (no task has id = 0)
                    if (selectedSkill.Key > 0)
                        return selectedSkill.Key;
                }

                return null;
            }
            set
            {
                if (skillToTrainComboBox.Items.Count > 0)
                {
                    if (value.HasValue)
                    {
                        skillToTrainComboBox.SelectItemByValue(value.Value);
                    }
                    else
                    {
                        skillToTrainComboBox.SelectedIndex = 0;
                    }
                }

            }
        }
        public int? ParentTaskId
        {
            get
            {
                if (parentTaskComboBox.SelectedItem != null)
                {
                    var selectedTask = (KeyValuePair<int, string>)parentTaskComboBox.SelectedItem;

                    // To avoid returning empty item as parent (no task has id = 0)
                    if (selectedTask.Key > 0)
                        return selectedTask.Key;
                }

                return null;
            }
            set
            {
                if (parentTaskComboBox.Items.Count > 0)
                {
                    if (value.HasValue)
                        parentTaskComboBox.SelectItemByValue(value.Value);
                    else
                    {
                        parentTaskComboBox.SelectedIndex = 0;
                    }
                }
            }
        }

        public string ParentTaskName { get; set; }

        public event EventHandler SaveTask;
        public event EventHandler RemoveTask;
        public event EventHandler<EventArgs> NewTask;
        public event EventHandler<EventArgs> EditTask;
        public event EventHandler<EventArgs> CancelTaskEditing;
        public event EventHandler<EventArgs> FinishTask;
        public event EventHandler<EventArgs> StartWorkingOnTask;
        public event EventHandler<EventArgs> StopWorkingOnTask;
        public event EventHandler<EventArgs> ParentTaskChanged;
        public event EventHandler<EventArgs> CloseViewEditWindow;
        public ICollection WorkUnits { get; set; }
        public ICollection SkillsAvailable { get; set; }
        public ICollection ChildrenTasks { get; set; }
        
        
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (SaveTask != null)
                SaveTask(this, e);
        }
        
        private void removeButton_Click(object sender, EventArgs e)
        {
            if (RemoveTask != null)
                RemoveTask(this, e);
        }

        private void SelectPriority(int value)
        {
            if (TaskDefaults.Priorities.ContainsKey(value))
            {
                PriorityLevel priority = TaskDefaults.Priorities[value];

                switch (priority.Severity)
                {
                    case Severity.Low:
                        lowPriorityRadioButton.Checked = true;
                        break;
                    case Severity.Medium:
                        mediumPriorityRadioButton.Checked = true;
                        break;
                    case Severity.High:
                        highPriorityRadioButton.Checked = true;
                        break;
                }

                //priorityLabel.Text = priority.Name;
                //priorityLabel.BackColor = priority.Color;
            }
        }

        private void SelectDifficulty(int value)
        {
            if (TaskDefaults.Difficulties.ContainsKey(value))
            {
                DifficultyLevel difficulty = TaskDefaults.Difficulties[value];

                switch (difficulty.Difficulty)
                {

                    case Model.Enums.Difficulty.Easy:
                        easyTaskRadioButton.Checked = true;
                        break;
                    case Model.Enums.Difficulty.Medium:
                        normalTaskRadioButton.Checked = true;
                        break;
                    case Model.Enums.Difficulty.Hard:
                        hardTaskRadioButton.Checked = true;
                        break;
                }

                //priorityLabel.Text = difficulty.Name;
                //priorityLabel.BackColor = difficulty.Color;
            }
        }


        private int GetSelectedPriority()
        {

            if (lowPriorityRadioButton.Checked)
                return 1;
            else if (mediumPriorityRadioButton.Checked)
                return 2;
            else if (highPriorityRadioButton.Checked)
                return 3;
            else
                return 0;
        }

        private int GetSelectedDifficulty()
        {
            if (easyTaskRadioButton.Checked)
                return 1;
            else if (normalTaskRadioButton.Checked)
                return 2;
            else if (hardTaskRadioButton.Checked)
                return 3;
            else
                return 0;
        }

        private void finishedButton_Click(object sender, EventArgs e)
        {
            if (FinishTask != null)
                FinishTask(this, e);
        }

        private void startWorkButton_Click(object sender, EventArgs e)
        {
            if (StartWorkingOnTask != null)
                StartWorkingOnTask(this, e);
            
        }

        private void stopWorkingButton_Click(object sender, EventArgs e)
        {
            if (StopWorkingOnTask != null)
                StopWorkingOnTask(this, e);
            
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (EditTask != null)
                EditTask(this, e);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (CancelTaskEditing != null)
                CancelTaskEditing(this, e);
        }

        private void closeEditFormButton_Click(object sender, EventArgs e)
        {
            if (CloseViewEditWindow != null)
                CloseViewEditWindow(this, e);
        }
    }
}
