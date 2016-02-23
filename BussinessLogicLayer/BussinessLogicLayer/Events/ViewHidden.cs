using System;
using BussinessLogicLayer.Interfaces;

namespace BussinessLogicLayer.Events
{
    public class ViewHidden : EventArgs
    {
        public SubViewType ViewType;

        public ViewHidden(SubViewType viewType)
        {
            this.ViewType = viewType;
        }
    }
}
