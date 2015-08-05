using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using PresentationLayer.Presenters;

namespace PresentationLayer
{
    public partial class TestForm : MetroForm
    {
        private TaskPresenter taskPresenter;

        public TestForm()
        {
            InitializeComponent();

            taskPresenter = new TaskPresenter(this.tasksControl1);
        }

        private void TestForm_Load(object sender, EventArgs e)
        {

        }
    }
}
