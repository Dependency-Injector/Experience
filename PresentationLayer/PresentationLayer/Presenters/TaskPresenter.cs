using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DataAccessLayer.Model;
using DataAccessLayer.Repositories;
using PresentationLayer.Views;

namespace PresentationLayer.Presenters
{
    public class TaskPresenter
    {
        #region Private fields

        private readonly ITasksView view;
        private TasksRepository taskRepository;
        private WorkUnitsRepository workUnitsRepository;
        private SkillsRepository skillsRepository;
        private List<Task> tasks;
        private WorkUnit currentWorkUnit;
        private int selectedTaskIndex;
        private bool isTaskNew = true;

        #endregion

        public TaskPresenter(ITasksView view)
        {
            this.view = view;
            taskRepository = new TasksRepository();
            workUnitsRepository = new WorkUnitsRepository();
            skillsRepository = new SkillsRepository();

            Initialize();
        }

        #region Events

        private void Initialize()
        {
            try
            {
                AttachEvents();
                ObtainTasksList();
                tasks = SortTasks(tasks);
                
                if (tasks != null && tasks.Count > 0)
                {
                    DisplaySingleTaskInfo(tasks[0]);
                    DisplayTasksList(tasks);
                    selectedTaskIndex = tasks.Count - 1;
                }
                else
                {
                    DisplayBlankTask();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowPrevious(object sender, EventArgs e)
        {
            if (selectedTaskIndex > 0)
            {
                selectedTaskIndex--;
                DisplaySingleTaskInfo(GetTaskAtIndex(selectedTaskIndex));
                view.IsDirty = false;
            }
        }

        private void ShowNext(object sender, EventArgs e)
        {
            if (selectedTaskIndex + 1 < tasks.Count)
            {
                selectedTaskIndex++;
                DisplaySingleTaskInfo(GetTaskAtIndex(selectedTaskIndex));
                view.IsDirty = false;
            }
        }

        private void New(object sender, EventArgs e)
        {
            DisplayBlankTask();
            isTaskNew = true;
            view.IsDirty = false;
            selectedTaskIndex = tasks.Count - 1;
        }

        private void Save(object sender, EventArgs e)
        {
            var task = isTaskNew ? new Task() : GetSelectedTask();

            task.Name = view.TaskName;
            task.Description = view.TaskDescription;
            task.Priority = view.Priority;
            task.DueDate = view.DueDate;

            if (isTaskNew)
            {
                task.CreationDate = DateTime.Now;
                taskRepository.Add(task);
            }
            else
            {
                taskRepository.Update(task);
            }

            isTaskNew = false;
            view.IsDirty = false;
            ObtainTasksList();
            RefreshTasksGridview();
            SelectTask(task);
        }

        private void Remove(object sender, EventArgs e)
        {
            if (isTaskNew)
            {
                MessageBox.Show("This task is not saved yet, so it can't be deleted");
            }
            else
            {
                Task task = GetSelectedTask();
                if (task == null)
                {
                    MessageBox.Show("No task to remove");
                }

                taskRepository.Delete(task);

                tasks = taskRepository.GetAll().ToList();
                selectedTaskIndex = tasks.Count - 1;

                if (selectedTaskIndex > 0)
                {
                    DisplaySingleTaskInfo(tasks[selectedTaskIndex]);
                    isTaskNew = false;
                }
                else
                {
                    New(sender, e);
                    isTaskNew = true;
                }

                RefreshTasksGridview();
                DisplaySingleTaskInfo(task);
            }

        }

        private void Finish(object sender, EventArgs e)
        {
            var taskToFinish = GetSelectedTask();
            taskToFinish.IsFinished = true;
            taskToFinish.FinishedDate = DateTime.Now;
            taskRepository.Update(taskToFinish);
            DisplaySingleTaskInfo(taskToFinish);
        }

        private void StopWorkingOnTask(object sender, EventArgs e)
        {
            if (currentWorkUnit != null)
            {
                currentWorkUnit.EndTime = DateTime.Now;

                if (currentWorkUnit.StartTime.HasValue)
                {
                    TimeSpan workingTime = currentWorkUnit.EndTime.Value - currentWorkUnit.StartTime.Value;
                    currentWorkUnit.Duration = Convert.ToInt16(workingTime.TotalSeconds);
                }

                workUnitsRepository.Add(currentWorkUnit);

                Task task = taskRepository.Get(currentWorkUnit.Task.Id);
                if (task.SkillToTrain != null)
                {
                    SkillTrainer.SkillTrained(task.SkillToTrain.Id, currentWorkUnit.Duration.Value);
                }

                RefreshWorkUnitsGridView();
            }
        }

        private void StartWorkingOnTask(object sender, EventArgs e)
        {
            currentWorkUnit = new WorkUnit
            {
                StartTime = DateTime.Now,
                Task = GetSelectedTask()
            };
        }

        #endregion

        #region Helper methods

        private void AttachEvents()
        {
            view.NewTask += New;
            view.SaveTask += Save;
            view.RemoveTask += Remove;
            view.FinishTask += Finish;
            view.PreviousTask += ShowPrevious;
            view.NextTask += ShowNext;
            view.SelectTask += SelectTask;
            view.StartWorkingOnTask += StartWorkingOnTask;
            view.StopWorkingOnTask += StopWorkingOnTask;
        }

        private void ObtainTasksList()
        {
            tasks = taskRepository.HasTasks() ? taskRepository.GetAll().ToList() : new List<Task>();
        }

        private void RefreshTasksGridview()
        {
            view.Tasks = tasks;
        }

        private void RefreshWorkUnitsGridView()
        {
            view.WorkUnits = GetSelectedTask().WorkUnits.ToList();
        }

        private void DisplayTasksList(List<Task> tasksList)
        {
            view.Tasks = SortTasks(tasksList);
        }

        private void DisplayBlankTask()
        {
            view.TaskName = "[Name something to be done]";
            view.Priority = 1;
            view.TaskDescription = "[Describe your task]";
            view.DueDate = DateTime.Now.AddDays(7);
            view.IsFinished = false;
            view.FinishDate = null;
        }

        private void DisplaySingleTaskInfo(Task task)
        {
            view.TaskName = task.Name;
            view.TaskDescription = task.Description;
            view.Priority = task.Priority;
            view.DueDate = task.DueDate;
            view.IsFinished = task.IsFinished;
            view.FinishDate = task.FinishedDate;
            view.WorkUnits = task.WorkUnits.ToList();
            isTaskNew = false;
        }

        private Task GetTaskAtIndex(int index)
        {
            if (tasks != null && tasks.Count > 0 && index < tasks.Count)
                return tasks[index];

            return null;
        }

        private Task GetSelectedTask()
        {
            return GetTaskAtIndex(selectedTaskIndex);
        }

        private void SelectTask(object sender, int id)
        {
            var indexOfTask = tasks.FindIndex(t => t.Id == id);
            var selectedTask = GetTaskAtIndex(indexOfTask);
            selectedTaskIndex = indexOfTask;
            DisplaySingleTaskInfo(selectedTask);
        }

        private void SelectTask(Task task)
        {
            SelectTask(this, task.Id);
        }


        private IEnumerable<Task> SortUnfinishedFirst(IEnumerable<Task> tasks)
        {
            return tasks.OrderByDescending(t => t.IsFinished);
        }

        private IEnumerable<Task> SortByDeadline(IEnumerable<Task> tasks)
        {
            return tasks.OrderBy(t => t.DueDate);
        }

        private IEnumerable<Task> SortByPriority(IEnumerable<Task> tasks)
        {
            return tasks.OrderByDescending(t => t.Priority);
        }

        private List<Task> SortTasks(List<Task> tasksUnsorted)
        {
            return SortByPriority(
                        SortByDeadline(
                            SortUnfinishedFirst(tasksUnsorted))).ToList();
        }

        #endregion
    }

    internal static class SkillTrainer
    {
        private static ProfileRepository profileRepository = new ProfileRepository();
        private static SkillsRepository skillsRepository = new SkillsRepository();

        static SkillTrainer()
        {
            
        }

        public static void SkillTrained(int id, int duration)
        {
            if (profileRepository != null)
            {
                Profile profile = profileRepository.GetAll().First();
                Skill skillTrained = profile.Skills.First(s => s.Id == id);
                float hours = (float)duration/360;
                float gainedExperience = hours * 10;

                skillTrained.Experience += (int) gainedExperience;

                profile.Experience += (int) gainedExperience;

                skillsRepository.Update(skillTrained);
                profileRepository.Update(profile);
            }

           
        }
    }
}
