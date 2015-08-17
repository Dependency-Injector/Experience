using System;
using MetroFramework;
using MetroFramework.Forms;
using PresentationLayer.Presenters;

namespace PresentationLayer.Forms
{
    public partial class TestForm : MetroForm
    {
        private TaskPresenter taskPresenter;
        private ProfilePresenter profilePresenter;
        private OptionsPresenter optionsPresenter;

        public TestForm()
        {
            InitializeComponent();

            this.StyleManager = optionsControl.GetStyleManager();
            this.StyleManager.Owner = this;

            taskPresenter = new TaskPresenter(this.tasksControl1);
            profilePresenter = new ProfilePresenter(this.profileControl);
            optionsPresenter = new OptionsPresenter(this.optionsControl);


        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            this.tasksControl1.SetColumnNames();
            this.contentTabControl.SelectedTab = tasksTabPage;

            AddStyles();
        }

        private void themeLightButton_Click(object sender, EventArgs e)
        {
            ChangeTheme(MetroThemeStyle.Light);
        }

        private void ChangeTheme(MetroThemeStyle theme)
        {
            /*styleManagerMain.Theme = theme;
            if (theme == MetroThemeStyle.Light)
            {
                themeLightButton.Enabled = false;
                themeDarkButton.Enabled = true;
            }
            else
            {
                themeLightButton.Enabled = true;
                themeDarkButton.Enabled = false;
            }
                */
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            ChangeTheme(MetroThemeStyle.Dark);
        }

        private void themeLabel_Click(object sender, EventArgs e)
        {

        }

        private void styleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*MetroColorStyle style;
            Enum.TryParse<MetroColorStyle>(styleComboBox.SelectedValue.ToString(), out style);

            styleManagerMain.Style = style;*/
        }


        private void AddStyles()
        {/*
            styleComboBox.DataSource = Enum.GetValues(typeof(MetroFramework.MetroColorStyle));*/
        }

    }
}
