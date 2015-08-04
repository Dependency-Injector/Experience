using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataAccessLayer;
using DataAccessLayer.Model;

namespace TestApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            /*using (var db = new TodoEntitiesContext())
            {
                var task = new Task() {Name = "Zadanie numer 3"};
                db.Tasks.Add(task);
                db.SaveChanges();
            }
            */
            Random random = new Random(234);

            try
            {
                using (var ctx = new EntitiesContext())
                {
                    for (int i = 0; i < 5; i++)
                    {
                        Task t = new Task();
                        t.Name = "Task " + i.ToString();
                        t.Description = "opis taska " + i.ToString() + ". ";
                        t.CreationDate = DateTime.Now;

                        ctx.Tasks.Add(t);

                    }

                    ctx.SaveChanges();
                }

                using (var context = new EntitiesContext())
                {
                    StringBuilder sb = new StringBuilder();

                    var tasks = from t in context.Tasks select t;

                    foreach (var t in tasks)
                    {
                        t.Name = t.Name + " a to dopisana " + random.Next().ToString() + " liczba";
                    }

                    context.SaveChanges();
                }

                using (var db = new EntitiesContext())
                {
                    StringBuilder sb = new StringBuilder();

                    var tasks = from t in db.Tasks select t;

                    foreach (var t in tasks)
                    {

                        sb.Append("Task id: ");
                        sb.Append(t.Id);
                        sb.Append("Task name: ");
                        sb.Append(t.Name);
                        sb.Append(Environment.NewLine);
                        sb.Append(Environment.NewLine);
                    }

                    textBox1.Text = sb.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            base.OnLoad(e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
