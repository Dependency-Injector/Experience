using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Note
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AdditionalInfo { get; set; }
        public bool? Checked { get; set; }
    }
}
