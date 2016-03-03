using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLogicLayer.Events;
using BussinessLogicLayer.Interfaces;
using Model.Entities;

namespace BussinessLogicLayer.Presenters
{
    public class ListsPresenter : IPresenter
    {
        private readonly IListsView view;
        private List<NotesList> lists;
          
        public ListsPresenter(IListsView listsView)
        {
            this.view = listsView;
        }

        public void Initialize()
        {
            //throw new NotImplementedException();
        }

        public void OnViewDisplayed()
        {
            //throw new NotImplementedException();
        }

        public event EventHandler<ShowNotificationEventArgs> NotificationAppeared;
    }
}
