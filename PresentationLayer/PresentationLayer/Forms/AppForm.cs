using BussinessLogicLayer.Interfaces;
using MetroFramework.Forms;

namespace PresentationLayer.Forms
{
    public partial class AppForm : MetroForm,  IAppView
    {
        public IDayView DayView { get; set; }
        public IProfileView ProfileView { get; set; }

        public AppForm(IDayView dayView, IProfileView profileView)
        {
            InitializeComponent();

            this.DayView = dayView;
            this.ProfileView = profileView;
        }
    }
}
