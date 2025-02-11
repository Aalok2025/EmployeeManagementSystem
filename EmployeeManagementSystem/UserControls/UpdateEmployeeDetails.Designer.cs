namespace EmployeeManagementSystem.UserControls
{
    partial class UpdateEmployeeDetails
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
            BoxSalary = new TextBox();
            BoxDepartment = new TextBox();
            BoxAge = new TextBox();
            BoxName = new TextBox();
            BoxID = new TextBox();
            LoadDataGridView = new DataGridView();
            BttnLoad = new Button();
            BttnUpdate = new Button();
            SALARYText = new Label();
            DEPARTMENTText = new Label();
            AgeText = new Label();
            NameText = new Label();
            IDText = new Label();
            ((System.ComponentModel.ISupportInitialize)LoadDataGridView).BeginInit();
            SuspendLayout();
            // 
            // BoxSalary
            // 
            BoxSalary.Location = new Point(184, 264);
            BoxSalary.Name = "BoxSalary";
            BoxSalary.Size = new Size(230, 31);
            BoxSalary.TabIndex = 31;
            // 
            // BoxDepartment
            // 
            BoxDepartment.Location = new Point(184, 228);
            BoxDepartment.Name = "BoxDepartment";
            BoxDepartment.Size = new Size(230, 31);
            BoxDepartment.TabIndex = 30;
            // 
            // BoxAge
            // 
            BoxAge.Location = new Point(184, 191);
            BoxAge.Name = "BoxAge";
            BoxAge.Size = new Size(230, 31);
            BoxAge.TabIndex = 29;
            // 
            // BoxName
            // 
            BoxName.Location = new Point(184, 154);
            BoxName.Name = "BoxName";
            BoxName.Size = new Size(230, 31);
            BoxName.TabIndex = 28;
            // 
            // BoxID
            // 
            BoxID.Location = new Point(184, 118);
            BoxID.Name = "BoxID";
            BoxID.Size = new Size(230, 31);
            BoxID.TabIndex = 27;
            // 
            // LoadDataGridView
            // 
            LoadDataGridView.BackgroundColor = SystemColors.Control;
            LoadDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LoadDataGridView.Location = new Point(429, 118);
            LoadDataGridView.Name = "LoadDataGridView";
            LoadDataGridView.RowHeadersWidth = 62;
            LoadDataGridView.Size = new Size(341, 177);
            LoadDataGridView.TabIndex = 26;
            LoadDataGridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // BttnLoad
            // 
            BttnLoad.Location = new Point(658, 328);
            BttnLoad.Name = "BttnLoad";
            BttnLoad.Size = new Size(112, 34);
            BttnLoad.TabIndex = 25;
            BttnLoad.Text = "LOAD";
            BttnLoad.UseVisualStyleBackColor = true;
            BttnLoad.Click += BttnLoad_Click;
            // 
            // BttnUpdate
            // 
            BttnUpdate.Location = new Point(184, 328);
            BttnUpdate.Name = "BttnUpdate";
            BttnUpdate.Size = new Size(112, 34);
            BttnUpdate.TabIndex = 24;
            BttnUpdate.Text = "UPDATE";
            BttnUpdate.UseVisualStyleBackColor = true;
            BttnUpdate.Click += BttnUpdate_Click;
            // 
            // SALARYText
            // 
            SALARYText.AutoSize = true;
            SALARYText.Location = new Point(49, 270);
            SALARYText.Name = "SALARYText";
            SALARYText.Size = new Size(76, 25);
            SALARYText.TabIndex = 21;
            SALARYText.Text = "SALARY";
            // 
            // DEPARTMENTText
            // 
            DEPARTMENTText.AutoSize = true;
            DEPARTMENTText.Location = new Point(49, 231);
            DEPARTMENTText.Name = "DEPARTMENTText";
            DEPARTMENTText.Size = new Size(121, 25);
            DEPARTMENTText.TabIndex = 20;
            DEPARTMENTText.Text = "DEPARTMENT";
            // 
            // AgeText
            // 
            AgeText.AutoSize = true;
            AgeText.Location = new Point(49, 193);
            AgeText.Name = "AgeText";
            AgeText.Size = new Size(45, 25);
            AgeText.TabIndex = 19;
            AgeText.Text = "AGE";
            // 
            // NameText
            // 
            NameText.AutoSize = true;
            NameText.Location = new Point(49, 158);
            NameText.Name = "NameText";
            NameText.Size = new Size(62, 25);
            NameText.TabIndex = 18;
            NameText.Text = "NAME";
            // 
            // IDText
            // 
            IDText.AutoSize = true;
            IDText.Location = new Point(49, 124);
            IDText.Name = "IDText";
            IDText.Size = new Size(30, 25);
            IDText.TabIndex = 17;
            IDText.Text = "ID";
            // 
            // UpdateEmployeeDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(BoxSalary);
            Controls.Add(BoxDepartment);
            Controls.Add(BoxAge);
            Controls.Add(BoxName);
            Controls.Add(BoxID);
            Controls.Add(LoadDataGridView);
            Controls.Add(BttnLoad);
            Controls.Add(BttnUpdate);
            Controls.Add(SALARYText);
            Controls.Add(DEPARTMENTText);
            Controls.Add(AgeText);
            Controls.Add(NameText);
            Controls.Add(IDText);
            Name = "UpdateEmployeeDetails";
            Size = new Size(843, 498);
            ((System.ComponentModel.ISupportInitialize)LoadDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox BoxSalary;
        private TextBox BoxDepartment;
        private TextBox BoxAge;
        private TextBox BoxName;
        private TextBox BoxID;
        private DataGridView LoadDataGridView;
        private Button BttnLoad;
        private Button BttnUpdate;
        private Label SALARYText;
        private Label DEPARTMENTText;
        private Label AgeText;
        private Label NameText;
        private Label IDText;
    }
}
