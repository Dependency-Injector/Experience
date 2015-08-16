﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DataAccessLayer.Migrations;
using MetroFramework.Controls;
using PresentationLayer.Others;
using PresentationLayer.Views;
using Utilities;

namespace PresentationLayer.Controls
{
    public partial class TasksControl : MetroUserControl, ITasksView
    {
        public TasksControl()
        {
            InitializeComponent();
        }

        #region Properties and events

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
        public bool IsFinished
        {
            set
            {
                if(value)
                    ShowActionButtons(false);
                else
                    ShowActionButtons(true);
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
        public bool IsDirty { get; set; }
        public int? SkillToTrainId
        {
            get
            {
                if (skillToTrainComboBox.SelectedItem != null)
                {
                    var selectedSkill = (KeyValuePair<int, string>)skillToTrainComboBox.SelectedItem;
                    return selectedSkill.Key;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (value.HasValue)
                {
                    skillToTrainComboBox.SelectItemByValue(value.Value);
                }
            }
        }
        public int? ParentTaskId
        {
            get
            {
                int selectedSkillId;
                if (int.TryParse(skillToTrainComboBox.SelectedValue.ToString(), out selectedSkillId) && selectedSkillId > 0)
                    return selectedSkillId;
                else
                    return null;
            }
            set
            {
                if (value.HasValue)
                    parentTaskComboBox.SelectItemByValue(value.Value);
            }
        }

        public ICollection WorkUnits
        {
            set
            {
                if (value != null && value.Count > 0)
                {
                    ClearWorkUnitsGrid();
                    FillWorkUnitsGrid(value);
                    ShowWorkUnitsPanel(true);
                }
                else
                {
                    ShowWorkUnitsPanel(false);
                }
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
        public ICollection Tasks
        {
            set
            {
                ClearTasksGrid();
                FillTasksGrid(value);
                FillParentTasksComboBox(value);
            }
        }

        public event EventHandler<EventArgs> NewTask;
        public event EventHandler<EventArgs> SaveTask;
        public event EventHandler<EventArgs> RemoveTask;
        public event EventHandler<EventArgs> FinishTask;

        public event EventHandler<EventArgs> PreviousTask;
        public event EventHandler<EventArgs> NextTask;
        public event EventHandler<int> SelectTask;

        public event EventHandler<EventArgs> StartWorkingOnTask;
        public event EventHandler<EventArgs> StopWorkingOnTask;

        #endregion

        #region Events

        private void TasksControl_Load(object sender, EventArgs e)
        {
            IsDirty = true;
            SetDisplayMode(DisplayMode.View);
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

            SetDisplayMode(DisplayMode.Edit);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            SetDisplayMode(DisplayMode.Edit);
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

            SetDisplayMode(DisplayMode.View);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            SetDisplayMode(DisplayMode.View);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (RemoveTask != null)
                RemoveTask(this, e);

            SetDisplayMode(DisplayMode.View);
        }

        private void tasksListGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (SelectTask != null)
            {
                if (tasksListGrid.SelectedRows.Count > 0)
                {
                    var selectedRow = tasksListGrid.SelectedRows[0];
                    if (selectedRow.Cells[0].Value != null)
                    {
                        var cellValue = selectedRow.Cells[0].Value;

                        int selectedTaskId;
                        if (int.TryParse(cellValue.ToString(), out selectedTaskId))
                            SelectTask(tasksListGrid, selectedTaskId);
                    }
                }
            }
        }

        private void tasksListGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (e.ListChangedType != ListChangedType.ItemDeleted)
            {
                /* DataGridViewCellStyle lowPriorityStyle = tasksListGrid.DefaultCellStyle.Clone();
                 DataGridViewCellStyle mediumPriorityStyle = tasksListGrid.DefaultCellStyle.Clone();
                 DataGridViewCellStyle highPriorityStyle = tasksListGrid.DefaultCellStyle.Clone();

                 lowPriorityStyle.BackColor = TaskDefaults.Priorities[1].Color;
                 lowPriorityStyle.SelectionBackColor = TaskDefaults.Priorities[1].SelectionColor;
                 mediumPriorityStyle.BackColor = TaskDefaults.Priorities[2].Color;
                 mediumPriorityStyle.SelectionBackColor = TaskDefaults.Priorities[2].SelectionColor;
                 highPriorityStyle.BackColor = TaskDefaults.Priorities[3].Color;
                 highPriorityStyle.SelectionBackColor = TaskDefaults.Priorities[3].SelectionColor;

                 var dataGridViewColumn = tasksListGrid.Columns["Priority"];
                 if (dataGridViewColumn == null)
                 {
                     SetColumnNames();
                     dataGridViewColumn = tasksListGrid.Columns["Priority"];
                 }

                 if (dataGridViewColumn != null)
                 {
                     int priorityColumnIndex = dataGridViewColumn.Index;

                     foreach (DataGridViewRow row in tasksListGrid.Rows)
                     {
                         if (row.Cells[priorityColumnIndex].Value.ToString() == "1")
                         {
                             row.DefaultCellStyle = lowPriorityStyle;

                         }
                         else if (row.Cells[priorityColumnIndex].Value.ToString() == "2")
                         {
                             row.DefaultCellStyle = mediumPriorityStyle;
                         }
                         else if (row.Cells[priorityColumnIndex].Value.ToString() == "3")
                         {
                             row.DefaultCellStyle = highPriorityStyle;
                         }

                     }
                 }*/
            }

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

        #endregion Events

        #region Private methods

        private void SetDisplayMode(DisplayMode displayMode)
        {
            if (displayMode == DisplayMode.Edit)
            {
                taskDetailsPanel.Hide();
                taskEditPanel.Show();
            }
            else if (displayMode == DisplayMode.View)
            {
                taskEditPanel.Hide();
                taskDetailsPanel.Show();
            }
        }

        public void SetColumnNames()
        {
            taskIdColumn.Name = "Id";
            taskPriorityColumn.Name = "Priority";
        }

        private void ShowActionButtons(bool show)
        {
                taskActionButtonsPanel.Visible = show;
         /*       finishedButton.Visible = false;
                editButton.Visible = false;
                startWorkButton.Visible = false;
                stopWorkingButton.Visible = false;
            }
            else
            {
                editButton.Visible = true;
                finishedButton.Visible = true;
                startWorkButton.Visible = true;
                stopWorkingButton.Visible = true;
                startWorkButton.Enabled = true;
            }*/
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

        private void ClearTasksGrid()
        {
            tasksListGrid.Rows.Clear();
        }

        private void ClearWorkUnitsGrid()
        {
            workUnitsGrid.Rows.Clear();
        }

        private void ClearSkillsComboBox()
        {
            skillToTrainComboBox.Items.Clear();
        }

        private void FillSkillsComboBox(ICollection skillRowData)
        {
            if (skillRowData != null && skillRowData.Count > 0)
            {
                List<object> skillsComboBoxItems = new List<object>()
                {
                    new {Id = 0, Name = ""}
                };

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

        private void FillTasksGrid(ICollection tasksRowData)
        {
            if (tasksRowData != null && tasksRowData.Count > 0)
            {
                foreach (var row in tasksRowData)
                {
                    if (row is string[])
                    {
                        string[] rowCells = (string[])row;
                        tasksListGrid.Rows.Add(rowCells[0], rowCells[1], rowCells[2], rowCells[3], rowCells[4],
                            rowCells[5]);

                    }
                }

            }

        }

        private void FillParentTasksComboBox(ICollection tasksRowData)
        {
            if (tasksRowData != null && tasksRowData.Count > 0)
            {
                KeyValuePair<int, string> emptyItem = new KeyValuePair<int, string>(0, "");
                parentTaskComboBox.Items.Add(emptyItem);

                foreach (var row in tasksRowData)
                {
                    var cells = row as string[];
                    if (cells != null)
                    {
                        string[] rowCells = cells;
                        
                        KeyValuePair<int, string> comboItem = new KeyValuePair<int, string>(int.Parse(rowCells[0]), rowCells[1]);
                        parentTaskComboBox.Items.Add(comboItem);
                    }
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

        private void ShowWorkUnitsPanel(bool show)
        {
            workUnitsPanel.Visible = show;
        }
        #endregion

    }
}
