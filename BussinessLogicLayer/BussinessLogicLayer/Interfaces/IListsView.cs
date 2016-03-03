using System;
using System.Collections.Generic;
using Model.Entities;

namespace BussinessLogicLayer.Interfaces
{
    public interface IListsView
    {
        IList<NotesList> Lists { set; }

        event EventHandler<EventArgs> AddList;
        event EventHandler<EventArgs> AddListItem;
    }
}
