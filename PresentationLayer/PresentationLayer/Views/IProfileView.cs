using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Views
{
    public interface IProfileView
    {
        String PlayerName { get; set; }
        String History { get; set; }
        int Age { get; set; }
        DateTime BirthDate { get; set; }
        int Level { get; set; }
        int Experience { get; set; }
        int LevelProgress { get; set; }
    }
}
