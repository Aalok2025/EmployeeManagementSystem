namespace EmployeeManagementSystem
{
    partial class SearchEmployee
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
            BttnSearch = new Button();
            BoxSearch = new TextBox();
            LoadDataGridView = new DataGridView();
            IDText = new Label();
            NameText = new Label();
            AgeText = new Label();
            DEPARTMENTText = new Label();
            SALARYText = new Label();
            BoxID = new TextBox();
            BoxName = new TextBox();
            BoxAge = new TextBox();
            BoxDepartment = new TextBox();
            BoxSalary = new TextBox();
            ((System.ComponentModel.ISupportInitialize)LoadDataGridView).BeginInit();
            SuspendLayout();
            // 
            // BttnSearch
            // 
            BttnSearch.Cursor = Cursors.Hand;
            BttnSearch.Location = new Point(724, 106);
            BttnSearch.Name = "BttnSearch";
            BttnSearch.Size = new Size(40, 34);
            BttnSearch.TabIndex = 33;
            BttnSearch.Text = "🔍";
            BttnSearch.UseVisualStyleBackColor = true;
            BttnSearch.Click += BttnSearch_Click;
            // 
            // BoxSearch
            // 
            BoxSearch.Location = new Point(399, 108);
            BoxSearch.Name = "BoxSearch";
            BoxSearch.PlaceholderText = "SEARCH BY NAME OR EMPLOYEE ID";
            BoxSearch.Size = new Size(314, 31);
            BoxSearch.TabIndex = 32;
            // 
            // LoadDataGridView
            // 
            LoadDataGridView.BackgroundColor = SystemColors.Control;
            LoadDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LoadDataGridView.Location = new Point(36, 108);
            LoadDataGridView.Name = "LoadDataGridView";
            LoadDataGridView.RowHeadersWidth = 62;
            LoadDataGridView.Size = new Size(327, 229);
            LoadDataGridView.TabIndex = 26;
            LoadDataGridView.CellContentClick += LoadDataGridView_CellContentClick;
            // 
            // IDText
            // 
            IDText.AutoSize = true;
            IDText.Location = new Point(399, 160);
            IDText.Name = "IDText";
            IDText.Size = new Size(30, 25);
            IDText.TabIndex = 17;
            IDText.Text = "ID";
            // 
            // NameText
            // 
            NameText.AutoSize = true;
            NameText.Location = new Point(399, 194);
            NameText.Name = "NameText";
            NameText.Size = new Size(62, 25);
            NameText.TabIndex = 18;
            NameText.Text = "NAME";
            // 
            // AgeText
            // 
            AgeText.AutoSize = true;
            AgeText.Location = new Point(399, 229);
            AgeText.Name = "AgeText";
            AgeText.Size = new Size(45, 25);
            AgeText.TabIndex = 19;
            AgeText.Text = "AGE";
            // 
            // DEPARTMENTText
            // 
            DEPARTMENTText.AutoSize = true;
            DEPARTMENTText.Location = new Point(399, 267);
            DEPARTMENTText.Name = "DEPARTMENTText";
            DEPARTMENTText.Size = new Size(121, 25);
            DEPARTMENTText.TabIndex = 20;
            DEPARTMENTText.Text = "DEPARTMENT";
            // 
            // SALARYText
            // 
            SALARYText.AutoSize = true;
            SALARYText.Location = new Point(399, 306);
            SALARYText.Name = "SALARYText";
            SALARYText.Size = new Size(76, 25);
            SALARYText.TabIndex = 21;
            SALARYText.Text = "SALARY";
            // 
            // BoxID
            // 
            BoxID.Location = new Point(534, 154);
            BoxID.Name = "BoxID";
            BoxID.Size = new Size(230, 31);
            BoxID.TabIndex = 27;
            // 
            // BoxName
            // 
            BoxName.Location = new Point(534, 191);
            BoxName.Name = "BoxName";
            BoxName.Size = new Size(230, 31);
            BoxName.TabIndex = 28;
            // 
            // BoxAge
            // 
            BoxAge.Location = new Point(534, 229);
            BoxAge.Name = "BoxAge";
            BoxAge.Size = new Size(230, 31);
            BoxAge.TabIndex = 29;
            // 
            // BoxDepartment
            // 
            BoxDepartment.Location = new Point(534, 267);
            BoxDepartment.Name = "BoxDepartment";
            BoxDepartment.Size = new Size(230, 31);
            BoxDepartment.TabIndex = 30;
            // 
            // BoxSalary
            // 
            BoxSalary.Location = new Point(534, 303);
            BoxSalary.Name = "BoxSalary";
            BoxSalary.Size = new Size(230, 31);
            BoxSalary.TabIndex = 31;
            // 
            // SearchEmployee
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(BttnSearch);
            Controls.Add(BoxSearch);
            Controls.Add(BoxSalary);
            Controls.Add(BoxDepartment);
            Controls.Add(BoxAge);
            Controls.Add(BoxName);
            Controls.Add(BoxID);
            Controls.Add(LoadDataGridView);
            Controls.Add(SALARYText);
            Controls.Add(DEPARTMENTText);
            Controls.Add(AgeText);
            Controls.Add(NameText);
            Controls.Add(IDText);
            Name = "SearchEmployee";
            Size = new Size(829, 409);
            ((System.ComponentModel.ISupportInitialize)LoadDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BttnSearch;
        private TextBox BoxSearch;
        private DataGridView LoadDataGridView;
        private Label IDText;
        private Label NameText;
        private Label AgeText;
        private Label DEPARTMENTText;
        private Label SALARYText;
        private TextBox BoxID;
        private TextBox BoxName;
        private TextBox BoxAge;
        private TextBox BoxDepartment;
        private TextBox BoxSalary;
    }
}
