namespace EmployeeManagementSystem
{
    partial class AddNewEmployee
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
            BoxAge = new TextBox();
            BoxName = new TextBox();
            BttnAdd = new Button();
            SALARYText = new Label();
            DEPARTMENTText = new Label();
            AgeText = new Label();
            NameText = new Label();
            BoxDeptOptions = new ComboBox();
            SuspendLayout();
            // 
            // BoxSalary
            // 
            BoxSalary.Location = new Point(377, 265);
            BoxSalary.Name = "BoxSalary";
            BoxSalary.Size = new Size(230, 31);
            BoxSalary.TabIndex = 31;
            BoxSalary.Text = "NA";
            // 
            // BoxAge
            // 
            BoxAge.Location = new Point(377, 189);
            BoxAge.Name = "BoxAge";
            BoxAge.Size = new Size(230, 31);
            BoxAge.TabIndex = 29;
            // 
            // BoxName
            // 
            BoxName.Location = new Point(377, 151);
            BoxName.Name = "BoxName";
            BoxName.Size = new Size(230, 31);
            BoxName.TabIndex = 28;
            // 
            // BttnAdd
            // 
            BttnAdd.Location = new Point(433, 319);
            BttnAdd.Name = "BttnAdd";
            BttnAdd.Size = new Size(112, 34);
            BttnAdd.TabIndex = 22;
            BttnAdd.Text = "ADD";
            BttnAdd.UseVisualStyleBackColor = true;
            BttnAdd.Click += BttnAdd_Click;
            // 
            // SALARYText
            // 
            SALARYText.AutoSize = true;
            SALARYText.Location = new Point(242, 265);
            SALARYText.Name = "SALARYText";
            SALARYText.Size = new Size(76, 25);
            SALARYText.TabIndex = 21;
            SALARYText.Text = "SALARY";
            // 
            // DEPARTMENTText
            // 
            DEPARTMENTText.AutoSize = true;
            DEPARTMENTText.Location = new Point(242, 226);
            DEPARTMENTText.Name = "DEPARTMENTText";
            DEPARTMENTText.Size = new Size(121, 25);
            DEPARTMENTText.TabIndex = 20;
            DEPARTMENTText.Text = "DEPARTMENT";
            // 
            // AgeText
            // 
            AgeText.AutoSize = true;
            AgeText.Location = new Point(242, 188);
            AgeText.Name = "AgeText";
            AgeText.Size = new Size(45, 25);
            AgeText.TabIndex = 19;
            AgeText.Text = "AGE";
            // 
            // NameText
            // 
            NameText.AutoSize = true;
            NameText.Location = new Point(242, 153);
            NameText.Name = "NameText";
            NameText.Size = new Size(62, 25);
            NameText.TabIndex = 18;
            NameText.Text = "NAME";
            // 
            // BoxDeptOptions
            // 
            BoxDeptOptions.FormattingEnabled = true;
            BoxDeptOptions.Location = new Point(377, 226);
            BoxDeptOptions.Name = "BoxDeptOptions";
            BoxDeptOptions.Size = new Size(230, 33);
            BoxDeptOptions.TabIndex = 33;
            BoxDeptOptions.Text = "SELECT";
            // 
            // AddNewEmployee
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(BoxDeptOptions);
            Controls.Add(BoxSalary);
            Controls.Add(BoxAge);
            Controls.Add(BoxName);
            Controls.Add(BttnAdd);
            Controls.Add(SALARYText);
            Controls.Add(DEPARTMENTText);
            Controls.Add(AgeText);
            Controls.Add(NameText);
            Name = "AddNewEmployee";
            Size = new Size(861, 498);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox BoxSalary;
        private TextBox BoxAge;
        private TextBox BoxName;
        private Button BttnAdd;
        private Label SALARYText;
        private Label DEPARTMENTText;
        private Label AgeText;
        private Label NameText;
        private ComboBox BoxDeptOptions;
    }
}
