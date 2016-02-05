using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BussinessLogicLayer.Enums;
using BussinessLogicLayer.GridRowTemplates;
using BussinessLogicLayer.Interfaces;
using MetroFramework.Controls;

namespace PresentationLayer.Controls
{
    public partial class TodoListControl : MetroUserControl, ITodoListView
    {
        private static Color BasicColor;

        public TodoListControl()
        {
            InitializeComponent();
        }

        #region Properties and events

        public IList<TaskGridItem> TasksGridItems
        {
            set
            {
                tasksListGrid.DataSource = null;
                tasksListGrid.DataSource = value;
            }
        }
        public event EventHandler<EventArgs> NewTask;
        public event EventHandler<int> TaskDoubleClick;
        public event EventHandler<bool> ShowFinishedTasks;

        #endregion

        #region Events

        private void TasksControl_Load(object sender, EventArgs e)
        {
            BasicColor = tasksListGrid.DefaultCellStyle.ForeColor;
        }

        private void newTaskButton_Click(object sender, EventArgs e)
        {
            if (NewTask != null)
                NewTask(this, e);
        }

        private void addTaskMetroLink_Click(object sender, EventArgs e)
        {
            if (NewTask != null)
                NewTask(this, e);
        }

        private void showFinishedTasksCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowFinishedTasks != null)
                ShowFinishedTasks(this, showFinishedTasksCheckBox.Checked);
        }

        private void tasksListGrid_DoubleClick(object sender, EventArgs e)
        {
            if (tasksListGrid.SelectedRows.Count > 0 && tasksListGrid.CurrentRow != null)
            {
                if (TaskDoubleClick != null)
                {
                    TaskGridItem selectedItem = (TaskGridItem)tasksListGrid.CurrentRow.DataBoundItem;
                    TaskDoubleClick(this, selectedItem.Id);
                }
            }
        }

        private void tasksListGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            tasksListGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tasksListGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            tasksListGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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
    }
}
