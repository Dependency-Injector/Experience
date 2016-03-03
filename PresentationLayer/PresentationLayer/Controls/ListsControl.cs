using System;
using System.Collections.Generic;
using BussinessLogicLayer.Interfaces;
using MetroFramework.Controls;
using Model.Entities;

namespace View.Controls
{
    public partial class ListsControl : MetroUserControl, IListsView
    {
        public ListsControl()
        {
            InitializeComponent();
        }

        public IList<NotesList> Lists { get; set; }

        public event EventHandler<EventArgs> AddList;
        public event EventHandler<EventArgs> AddListItem;
    }

    
}
