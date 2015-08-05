using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Views
{
    public interface IToggleableLayer
    {
        event EventHandler<EventArgs> Hide;
        event EventHandler<EventArgs> Show;
    }
}
