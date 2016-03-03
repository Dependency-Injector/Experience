using System;
using BussinessLogicLayer.Enums;
using BussinessLogicLayer.Events;
using BussinessLogicLayer.Interfaces;
using DataAccessLayer.Repositories.Interfaces;
using DataAccessLayer.Utilities;
using Model.Entities;
using Model.Enums;

namespace BussinessLogicLayer.Presenters
{
    public class TaskCompositePresenter : ICanHandle<OpenWindowEvent>
    {
        private readonly ITaskEditView editView;
        private readonly ITaskDisplayView displayView;
        private readonly ITaskCompositeView compositeView;
        private readonly ITasksRepository tasksRepository;
        private readonly TaskDisplayPresenter taskDisplayPresenter;
        private readonly TaskEditPresenter taskEditPresenter;
        
        private readonly ISubscriber subscriber;
        private readonly IPublisher publisher;

        public TaskCompositePresenter(ITaskCompositeView compositeView, ITaskDisplayView displayView, ITaskEditView editView, ITasksRepository tasksRepository,
            IPublisher publisher, ISubscriber subscriber, TaskDisplayPresenter taskDisplayPresenter, TaskEditPresenter taskEditPresenter)
        {
            this.compositeView = compositeView;
            this.displayView = displayView;
            this.editView = editView;
            this.subscriber = subscriber;
            this.publisher = publisher;

            this.taskDisplayPresenter = taskDisplayPresenter;
            this.taskEditPresenter = taskEditPresenter;
            this.tasksRepository = tasksRepository;
        }

        public void Initialize()
        {
            try
            {
                subscriber.Subscribe(this);

                taskDisplayPresenter.Initialize();
                taskEditPresenter.Initialize();

                AttachEvents();

                SetDisplayMode(DisplayMode.View);
            }
            catch (Exception ex)
            {
                Logger.Exception(ex);
            }
        }


        private void AttachEvents()
        {
            this.displayView.EditTask += OnEditTask;
            this.displayView.FinishTask += OnFinishTask;
            this.editView.RemoveTask += OnRemoveTask;
            this.editView.SaveTask += OnSaveTask;
            this.editView.CancelTaskEditing += OnCancelTaskEditing;
        }

        private void OnSaveTask(object sender, EventArgs e)
        {
            compositeView.IsVisible = false;
        }

        private void OnRemoveTask(object sender, EventArgs e)
        {
            compositeView.IsVisible = false;
        }

        private void OnFinishTask(object sender, EventArgs eventArgs)
        {
            compositeView.IsVisible = false;
        }

        private void OnCancelTaskEditing(object sender, EventArgs e)
        {
            SetDisplayMode(DisplayMode.View);
        }

        private void OnEditTask(object sender, EventArgs e)
        {
            SetDisplayMode(DisplayMode.Edit);
        }

        private void SetDisplayMode(DisplayMode displayMode)
        {
            if (displayMode == DisplayMode.Edit)
            {
                compositeView.Title = "Edit task";
                taskDisplayPresenter.HideView();
                taskEditPresenter.ShowView();
            }
            else if (displayMode == DisplayMode.View)
            {
                compositeView.Title = "Task details";
                taskDisplayPresenter.ShowView();
                taskEditPresenter.HideView();
            }
        }
        
        public void Handle(OpenWindowEvent openWindowEventArgs)
        {
            if (openWindowEventArgs.WindowType != WindowType.TaskWindow)
                return;

            // Open window for existing task
            if (openWindowEventArgs.EntityId.HasValue)
            {
                int taskId = openWindowEventArgs.EntityId.Value;
                Task task = tasksRepository.Get(taskId);

                taskDisplayPresenter.SetTask(task);
                taskDisplayPresenter.DisplayTaskDetails();

                taskEditPresenter.SetTask(task);
                taskEditPresenter.EditTask();
            }
            // Open window for new task
            else if (!openWindowEventArgs.EntityId.HasValue)
            {
                taskEditPresenter.NewTask();
            }

            SetDisplayMode(openWindowEventArgs.DisplayMode);
        }
    }
}
