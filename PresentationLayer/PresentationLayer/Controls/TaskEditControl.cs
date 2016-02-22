using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BussinessLogicLayer.Interfaces;
using MetroFramework;
using MetroFramework.Controls;
using Model.Classes;
using Model.Enums;

namespace View.Controls
{
    public partial class TaskEditControl : MetroUserControl, ITaskEditView
    {
        public TaskEditControl()
        {
            InitializeComponent();
        }

        public bool CanBeFinished { get; set; }
        public bool IsVisible
        {
            set { this.Visible = value; }
        }
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

        public event EventHandler SaveTask;
        public event EventHandler RemoveTask;
        public event EventHandler<EventArgs> CancelTaskEditing;
        public event EventHandler<EventArgs> ParentTaskChanged;
        public ICollection WorkUnits { get; set; }

        public ICollection SkillsAvailable
        {
            set
            {
                ClearSkillsComboBox();
                FillSkillsComboBox(value);
            }
        }

        public ICollection ParentTasks
        {
            set
            {
                ClearParentTasksComboBox();
                FillParentTasksComboBox(value);
            }
        }

        private void ClearParentTasksComboBox()
        {
            parentTaskComboBox.Items.Clear();

        }

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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (CancelTaskEditing != null)
                CancelTaskEditing(this, e);
        }

        private void parentTaskComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ParentTaskChanged != null)
                ParentTaskChanged(this, e);
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

        private void ClearSkillsComboBox()
        {
            skillToTrainComboBox.Items.Clear();
        }
        
        private void FillSkillsComboBox(ICollection skillRowData)
        {
            if (skillRowData != null && skillRowData.Count > 0)
            {
                KeyValuePair<int, string> emptyComboItem = new KeyValuePair<int, string>(0, "");
                skillToTrainComboBox.Items.Add(emptyComboItem);

                foreach (var row in skillRowData)
                {
                    var cells = row as string[];
                    if (cells != null)
                    {
                        string[] rowCells = cells;
                        KeyValuePair<int, string> comboItem = new KeyValuePair<int, string>(int.Parse(rowCells[0]), rowCells[1]);
                        skillToTrainComboBox.Items.Add(comboItem);
                    }
                }
            }
        }

        private void FillChildrenTasksList(ICollection childrenTasksRowData)
        {
            if (childrenTasksRowData != null && childrenTasksRowData.Count > 0)
            {
                foreach (var row in childrenTasksRowData)
                {
                    var rowData = row as string[];
                    if (rowData != null && rowData.Any())
                    {
                        bool finished;
                        if (rowData.Count() > 0 && bool.TryParse(rowData[1], out finished))
                        {
                            MetroCheckBox childTaskCheckBox = new MetroCheckBox();
                            childTaskCheckBox.Text = rowData[0];
                            childTaskCheckBox.Checked = finished;
                            childTaskCheckBox.Theme = MetroThemeStyle.Dark;
                            childTaskCheckBox.Dock = DockStyle.Top;
                            childTaskCheckBox.Enabled = false;

                            if (finished)
                                childTaskCheckBox.Font = new Font(childTaskCheckBox.Font, FontStyle.Strikeout);

                            //childrenTasksPanel.Controls.Add(childTaskCheckBox);
                        }
                    }
                }
            }
        }

        private void FillParentTasksComboBox(ICollection parentTasksData)
        {
            if (parentTasksData != null && parentTasksData.Count > 0)
            {
                KeyValuePair<int, string> emptyItem = new KeyValuePair<int, string>(0, "");
                parentTaskComboBox.Items.Add(emptyItem);

                foreach (var parentTask in parentTasksData)
                {
                    parentTaskComboBox.Items.Add(parentTask);
                }
            }
        }
    }
}
