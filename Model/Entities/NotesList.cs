using System.Collections.Generic;

namespace Model.Entities
{
    public class NotesList
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public virtual ICollection<Note> Notes { get; set; }
        public virtual Profile Owner { get; set; }
    }
}
