namespace PresentationLayer
{
    partial class TestForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tasksControl1 = new PresentationLayer.Controls.Panels.TasksControl();
            this.SuspendLayout();
            // 
            // tasksControl1
            // 
            this.tasksControl1.DueDate = null;
            this.tasksControl1.FinishDate = null;
            this.tasksControl1.IsDirty = false;
            this.tasksControl1.IsFinished = false;
            this.tasksControl1.Location = new System.Drawing.Point(23, 63);
            this.tasksControl1.Name = "tasksControl1";
            this.tasksControl1.Priority = 0;
            this.tasksControl1.Size = new System.Drawing.Size(561, 551);
            //this.tasksControl1.Status = null;
            this.tasksControl1.TabIndex = 0;
            this.tasksControl1.TaskName = "qwwe";
            this.tasksControl1.Tasks = null;
            this.tasksControl1.UseSelectable = true;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 622);
            this.Controls.Add(this.tasksControl1);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.Panels.TasksControl tasksControl1;
    }
}