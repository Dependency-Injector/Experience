using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BussinessLogicLayer.Enums;
using BussinessLogicLayer.Events;
using BussinessLogicLayer.GridRowTemplates;
using BussinessLogicLayer.Interfaces;
using MetroFramework;
using MetroFramework.Controls;
using Model.Classes;
using Model.Enums;

namespace PresentationLayer.Controls
{
    /*public partial class TasksListControl : MetroUserControl, ITasksListView
    {
        private static Color BasicColor;
        private bool selectionByCode = false;

        public TasksListControl()
        {
            InitializeComponent();
        }

        #region Properties and events

        public int TaskId { get; set; }

        public string TaskName
        {
            get { return nameTextBox.Text; }
            set
            {
                nameLabel.Text = value;
                nameTextBox.Text = value;
            }
        }
        public string TaskDescription
        {
            get { return descriptionTextBox.Text; }
            set
            {
                descriptionLabel.Text = value;
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
                    startAndDueDate.Text = value.Value.ToString("M");
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
        public string TotalWorkload
        {
            set
            {
                totalWorkloadLabel.Text = value;
            }
        }
        public string TotalExperienceGained
        {
            set { totalExpGainedLabel.Text = value; }
        }
        public string AssociatedSkillName
        {
            set { attachedSkillNameLabel.Text = value; }
        }
        public string ParentTaskName
        {
            set { parentTaskLabel.Text = value; }
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

        public int SelectedTaskIndex
        {
            set
            {
                selectionByCode = true;
                DeselectAllTasksRows();
                tasksListGrid.Rows[value].Selected = true;
                selectionByCode = false;
            }
        }

        public bool CanBeFinished
        {
            set { finishedButton.Enabled = value; }
        }
        public bool TaskListEnabled
        {
            set
            {
                tasksListGrid.Enabled = value;
            }
        }
        public bool TaskDetailsPanelVisible
        {
            set { taskDetailsPanel.Visible = value; }
        }
        public bool TaskEditPanelVisible
        {
            set { taskEditPanel.Visible = value; }
        }
        public bool ActionButtonsVisible
        {
            set { taskActionButtonsPanel.Visible = value; }
        }
        public bool WorkUnitsPanelVisible
        {
            set { workUnitsPanel.Visible = value; }
        }

        public ICollection WorkUnits
        {
            set
            {
                ClearWorkUnitsGrid();
                FillWorkUnitsGrid(value);
            }
        }
        public ICollection SkillsAvailable
        {
            set
            {
                ClearSkillsComboBox();
                FillSkillsComboBox(value);
            }
        }
        public ICollection ChildrenTasks
        {
            set
            {
                ClearChildrenTasksPanel();
                FillChildrenTasksList(value);
            }
        }
        public Dictionary<int, string> Tasks
        {
            set
            {
                //ClearTasksGrid();
                //FillTasksGrid(value);

                ClearParentTaskComboBox();
                FillParentTasksComboBox(value);
            }
        }
        public IList<TaskGridItem> TasksGridItems
        {
            set
            {
                selectionByCode = true;
                tasksListGrid.DataSource = null;
                tasksListGrid.DataSource = value;
                selectionByCode = false;
            }
        }

        public event EventHandler<EventArgs> NewTask;
        public event EventHandler<EventArgs> SaveTask;
        public event EventHandler<EventArgs> EditTask;
        public event EventHandler<EventArgs> RemoveTask;
        public event EventHandler<EventArgs> CancelTaskEditing;
        public event EventHandler<EventArgs> FinishTask;

        public event EventHandler<EventArgs> PreviousTask;
        public event EventHandler<EventArgs> NextTask;
        public event EventHandler<EventArgs> ParentTaskChanged;
        public event EventHandler<int> SelectTask;
        public event EventHandler<int> TaskDoubleClick;

        public event EventHandler<EventArgs> StartWorkingOnTask;
        public event EventHandler<EventArgs> StopWorkingOnTask;

        public event EventHandler<bool> ShowFinishedTasks;

        #endregion

        #region Events

        private void TasksControl_Load(object sender, EventArgs e)
        {
            IsDirty = true;


            BasicColor = tasksListGrid.DefaultCellStyle.ForeColor;
            //metroToolTip1.SetToolTip(this.lowPriorityRadioButton, "Rather unimportant");
            //metroToolTip1.SetToolTip(this.mediumPriorityRadioButton, "Standard priority");
            //metroToolTip1.SetToolTip(this.highPriorityRadioButton, "Urgent and important");
        }

        private void nextTaskButton_Click(object sender, EventArgs e)
        {
            if (NextTask != null)
                NextTask(this, e);
        }

        private void previousTaskButton_Click(object sender, EventArgs e)
        {
            if (PreviousTask != null)
                PreviousTask(this, e);
        }

        private void newTaskButton_Click(object sender, EventArgs e)
        {
            if (NewTask != null)
                NewTask(this, e);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (EditTask != null)
                EditTask(this, e);
        }

        private void finishedButton_Click(object sender, EventArgs e)
        {
            if (FinishTask != null)
                FinishTask(this, e);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (SaveTask != null)
                SaveTask(this, e);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (CancelTaskEditing != null)
                CancelTaskEditing(this, e);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (RemoveTask != null)
                RemoveTask(this, e);
        }

        private void tasksListGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (selectionByCode == true)
                return;

            if (SelectTask != null)
            {
                if (tasksListGrid.SelectedRows.Count > 0)
                {
                    TaskGridItem selectedItem = (TaskGridItem)tasksListGrid.CurrentRow.DataBoundItem;
                    SelectTask(tasksListGrid, selectedItem.Id);
                }
            }
        }

        private void tasksListGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.tasksListGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.tasksListGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.tasksListGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void startWorkButton_Click(object sender, EventArgs e)
        {
            if (StartWorkingOnTask != null)
                StartWorkingOnTask(this, e);

            stopWorkingButton.Enabled = true;
            startWorkButton.Enabled = false;
        }

        private void stopWorkingButton_Click(object sender, EventArgs e)
        {
            if (StopWorkingOnTask != null)
                StopWorkingOnTask(this, e);

            startWorkButton.Enabled = true;
            stopWorkingButton.Enabled = false;
        }

        private void showFinishedTasksCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowFinishedTasks != null)
                ShowFinishedTasks(this, showFinishedTasksCheckBox.Checked);
        }

        private void parentTaskComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ParentTaskChanged != null)
                ParentTaskChanged(this, e);
        }

        private void tasksListGrid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = e.RowIndex; i <= e.RowIndex + e.RowCount - 1; i++)
            {
                DataGridViewRow row = tasksListGrid.Rows[i];
                if (row.DataBoundItem is TaskGridItem)
                {
                    TaskGridItem task = row.DataBoundItem as TaskGridItem;
                    switch (task.TaskTextColor)
                    {
                        case TaskTextColor.Red:
                            row.DefaultCellStyle.ForeColor = Color.Red;
                            break;
                        case TaskTextColor.Yellow:
                            row.DefaultCellStyle.ForeColor = Color.DarkOrange;
                            break;
                        case TaskTextColor.Normal:
                            row.DefaultCellStyle.ForeColor = BasicColor;
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }
            }
        }

        #endregion Events

        #region Private methods

        private void ShowActionButtons(bool show)
        {
            taskActionButtonsPanel.Visible = show;
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

                priorityLabel.Text = priority.Name;
                priorityLabel.BackColor = priority.Color;
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

        private void ClearParentTaskComboBox()
        {
            parentTaskComboBox.Items.Clear();
        }

        private void ClearWorkUnitsGrid()
        {
            workUnitsGrid.Rows.Clear();
        }

        private void ClearSkillsComboBox()
        {
            skillToTrainComboBox.Items.Clear();
        }

        private void ClearChildrenTasksPanel()
        {
            childrenTasksPanel.Controls.Clear();
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

                            childrenTasksPanel.Controls.Add(childTaskCheckBox);
                        }
                    }
                }
            }
        }

        private void FillParentTasksComboBox(Dictionary<int, String> parentTasks)
        {
            if (parentTasks != null && parentTasks.Count > 0)
            {
                KeyValuePair<int, string> emptyItem = new KeyValuePair<int, string>(0, "");
                parentTaskComboBox.Items.Add(emptyItem);

                foreach (var parentTask in parentTasks)
                {
                    parentTaskComboBox.Items.Add(parentTask);
                }
            }
        }

        private void FillWorkUnitsGrid(ICollection worksUnitRowData)
        {
            if (worksUnitRowData != null && worksUnitRowData.Count > 0)
            {
                foreach (var workUnit in worksUnitRowData)
                {
                    if (workUnit is string[])
                    {
                        string[] rowCells = (string[])workUnit;

                        workUnitsGrid.Rows.Add(rowCells[0], rowCells[1], rowCells[2]);
                    }
                }

            }
        }

        private void DeselectAllTasksRows()
        {
            if (tasksListGrid.Rows != null && tasksListGrid.Rows.Count > 0)
            {
                for (int i = 0; i < tasksListGrid.Rows.Count; i++)
                {
                    tasksListGrid.Rows[i].Selected = false;
                }
            }
        }

        #endregion

        private void tasksListGrid_DoubleClick(object sender, EventArgs e)
        {
            if (tasksListGrid.SelectedRows.Count > 0)
            {
                if (TaskDoubleClick != null)
                {
                    TaskGridItem selectedItem = (TaskGridItem)tasksListGrid.CurrentRow.DataBoundItem;
                    TaskDoubleClick(this, selectedItem.Id);
                }
            }
        }

        private void addTaskMetroLink_Click(object sender, EventArgs e)
        {
            if (NewTask != null)
                NewTask(this, e);
        }
    }*/
}
