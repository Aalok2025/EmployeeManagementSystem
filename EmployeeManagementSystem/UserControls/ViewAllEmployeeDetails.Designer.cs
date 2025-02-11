namespace EmployeeManagementSystem.UserControls
{
    partial class ViewAllEmployeeDetails
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
            LoadDataGridView = new DataGridView();
            BttnLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)LoadDataGridView).BeginInit();
            SuspendLayout();
            // 
            // LoadDataGridView
            // 
            LoadDataGridView.BackgroundColor = SystemColors.Control;
            LoadDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LoadDataGridView.Location = new Point(123, 153);
            LoadDataGridView.Name = "LoadDataGridView";
            LoadDataGridView.RowHeadersWidth = 62;
            LoadDataGridView.Size = new Size(629, 265);
            LoadDataGridView.TabIndex = 26;
            // 
            // BttnLoad
            // 
            BttnLoad.Location = new Point(366, 97);
            BttnLoad.Name = "BttnLoad";
            BttnLoad.Size = new Size(112, 34);
            BttnLoad.TabIndex = 25;
            BttnLoad.Text = "LOAD";
            BttnLoad.UseVisualStyleBackColor = true;
            BttnLoad.Click += BttnLoad_Click;
            // 
            // ViewAllEmployeeDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(LoadDataGridView);
            Controls.Add(BttnLoad);
            Name = "ViewAllEmployeeDetails";
            Size = new Size(847, 542);
            ((System.ComponentModel.ISupportInitialize)LoadDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView LoadDataGridView;
        private Button BttnLoad;
    }
}
