using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    public class Preferences
    {
        public int Id { get; set; }
        public String ThemeName { get; set; }
        public String StyleName { get; set; }
        public bool ShowFinishedTasks { get; set; }
    }
}
