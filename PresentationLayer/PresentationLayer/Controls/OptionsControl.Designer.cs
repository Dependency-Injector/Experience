namespace PresentationLayer.Controls
{
    partial class OptionsControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.styleComboBox = new MetroFramework.Controls.MetroComboBox();
            this.styleLabel = new MetroFramework.Controls.MetroLabel();
            this.themeLabel = new MetroFramework.Controls.MetroLabel();
            this.styleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.themeToggle = new MetroFramework.Controls.MetroToggle();
            this.lightThemeTextLabel = new MetroFramework.Controls.MetroLabel();
            this.darkThemeTextLabel = new MetroFramework.Controls.MetroLabel();
            this.saveOptionsButton = new MetroFramework.Controls.MetroButton();
            this.languageLabel = new MetroFramework.Controls.MetroLabel();
            this.polishLanguageButton = new MetroFramework.Controls.MetroButton();
            this.englishLanguageButton = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.styleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // styleComboBox
            // 
            this.styleComboBox.FormattingEnabled = true;
            this.styleComboBox.ItemHeight = 23;
            this.styleComboBox.Location = new System.Drawing.Point(145, 75);
            this.styleComboBox.Name = "styleComboBox";
            this.styleComboBox.Size = new System.Drawing.Size(181, 29);
            this.styleComboBox.TabIndex = 9;
            this.styleComboBox.UseSelectable = true;
            this.styleComboBox.SelectedIndexChanged += new System.EventHandler(this.styleComboBox_SelectedIndexChanged);
            // 
            // styleLabel
            // 
            this.styleLabel.AutoSize = true;
            this.styleLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.styleLabel.Location = new System.Drawing.Point(19, 79);
            this.styleLabel.Name = "styleLabel";
            this.styleLabel.Size = new System.Drawing.Size(47, 25);
            this.styleLabel.TabIndex = 7;
            this.styleLabel.Text = "Style";
            // 
            // themeLabel
            // 
            this.themeLabel.AutoSize = true;
            this.themeLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.themeLabel.Location = new System.Drawing.Point(19, 20);
            this.themeLabel.Name = "themeLabel";
            this.themeLabel.Size = new System.Drawing.Size(64, 25);
            this.themeLabel.TabIndex = 8;
            this.themeLabel.Text = "Theme";
            // 
            // styleManager
            // 
            this.styleManager.Owner = null;
            // 
            // themeToggle
            // 
            this.themeToggle.AutoSize = true;
            this.themeToggle.DisplayStatus = false;
            this.themeToggle.Location = new System.Drawing.Point(213, 26);
            this.themeToggle.Name = "themeToggle";
            this.themeToggle.Size = new System.Drawing.Size(50, 17);
            this.themeToggle.TabIndex = 11;
            this.themeToggle.Text = "Off";
            this.themeToggle.UseSelectable = true;
            this.themeToggle.CheckedChanged += new System.EventHandler(this.themeToggle_CheckedChanged);
            // 
            // lightThemeTextLabel
            // 
            this.lightThemeTextLabel.AutoSize = true;
            this.lightThemeTextLabel.Location = new System.Drawing.Point(145, 26);
            this.lightThemeTextLabel.Name = "lightThemeTextLabel";
            this.lightThemeTextLabel.Size = new System.Drawing.Size(37, 19);
            this.lightThemeTextLabel.TabIndex = 12;
            this.lightThemeTextLabel.Text = "Light";
            // 
            // darkThemeTextLabel
            // 
            this.darkThemeTextLabel.AutoSize = true;
            this.darkThemeTextLabel.Location = new System.Drawing.Point(290, 26);
            this.darkThemeTextLabel.Name = "darkThemeTextLabel";
            this.darkThemeTextLabel.Size = new System.Drawing.Size(36, 19);
            this.darkThemeTextLabel.TabIndex = 12;
            this.darkThemeTextLabel.Text = "Dark";
            // 
            // saveOptionsButton
            // 
            this.saveOptionsButton.Location = new System.Drawing.Point(211, 212);
            this.saveOptionsButton.Name = "saveOptionsButton";
            this.saveOptionsButton.Size = new System.Drawing.Size(115, 32);
            this.saveOptionsButton.TabIndex = 13;
            this.saveOptionsButton.Text = "Save";
            this.saveOptionsButton.UseSelectable = true;
            this.saveOptionsButton.Click += new System.EventHandler(this.saveOptionsButton_Click);
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.languageLabel.Location = new System.Drawing.Point(19, 144);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(87, 25);
            this.languageLabel.TabIndex = 14;
            this.languageLabel.Text = "Language";
            // 
            // polishLanguageButton
            // 
            this.polishLanguageButton.Location = new System.Drawing.Point(145, 144);
            this.polishLanguageButton.Name = "polishLanguageButton";
            this.polishLanguageButton.Size = new System.Drawing.Size(86, 32);
            this.polishLanguageButton.TabIndex = 15;
            this.polishLanguageButton.Text = "Polish";
            this.polishLanguageButton.UseSelectable = true;
            this.polishLanguageButton.Click += new System.EventHandler(this.polishLanguageButton_Click);
            // 
            // englishLanguageButton
            // 
            this.englishLanguageButton.Location = new System.Drawing.Point(237, 144);
            this.englishLanguageButton.Name = "englishLanguageButton";
            this.englishLanguageButton.Size = new System.Drawing.Size(89, 32);
            this.englishLanguageButton.TabIndex = 16;
            this.englishLanguageButton.Text = "English";
            this.englishLanguageButton.UseSelectable = true;
            this.englishLanguageButton.Click += new System.EventHandler(this.englishLanguageButton_Click);
            // 
            // OptionsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.englishLanguageButton);
            this.Controls.Add(this.polishLanguageButton);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.saveOptionsButton);
            this.Controls.Add(this.darkThemeTextLabel);
            this.Controls.Add(this.lightThemeTextLabel);
            this.Controls.Add(this.themeToggle);
            this.Controls.Add(this.styleComboBox);
            this.Controls.Add(this.styleLabel);
            this.Controls.Add(this.themeLabel);
            this.Name = "OptionsControl";
            this.Size = new System.Drawing.Size(338, 262);
            ((System.ComponentModel.ISupportInitialize)(this.styleManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox styleComboBox;
        private MetroFramework.Controls.MetroLabel styleLabel;
        private MetroFramework.Controls.MetroLabel themeLabel;
        private MetroFramework.Components.MetroStyleManager styleManager;
        private MetroFramework.Controls.MetroToggle themeToggle;
        private MetroFramework.Controls.MetroLabel lightThemeTextLabel;
        private MetroFramework.Controls.MetroLabel darkThemeTextLabel;
        private MetroFramework.Controls.MetroButton saveOptionsButton;
        private MetroFramework.Controls.MetroLabel languageLabel;
        private MetroFramework.Controls.MetroButton polishLanguageButton;
        private MetroFramework.Controls.MetroButton englishLanguageButton;
    }
}
