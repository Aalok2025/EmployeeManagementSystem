namespace EmployeeManagementSystem.UserControls
{
    partial class Home
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
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Azure;
            label1.Location = new Point(238, 174);
            label1.Name = "label1";
            label1.Padding = new Padding(5);
            label1.Size = new Size(416, 35);
            label1.TabIndex = 12;
            label1.Text = "WELCOME TO EMPLOYEE MANAGEMENT SYSTEM";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(label1);
            Name = "Home";
            Size = new Size(886, 556);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
    }
}
