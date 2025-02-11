namespace EmployeeManagementSystem
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            hOMEToolStripMenuItem = new ToolStripMenuItem();
            aDDToolStripMenuItem = new ToolStripMenuItem();
            uPDATEToolStripMenuItem = new ToolStripMenuItem();
            dELETEToolStripMenuItem = new ToolStripMenuItem();
            VIEWALLToolStripMenuItem = new ToolStripMenuItem();
            sEARCHToolStripMenuItem = new ToolStripMenuItem();
            contentPanel = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hOMEToolStripMenuItem, aDDToolStripMenuItem, uPDATEToolStripMenuItem, dELETEToolStripMenuItem, VIEWALLToolStripMenuItem, sEARCHToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(808, 33);
            menuStrip1.TabIndex = 17;
            menuStrip1.Text = "menuStrip1";
            // 
            // hOMEToolStripMenuItem
            // 
            hOMEToolStripMenuItem.Name = "hOMEToolStripMenuItem";
            hOMEToolStripMenuItem.Size = new Size(80, 29);
            hOMEToolStripMenuItem.Text = "HOME";
            hOMEToolStripMenuItem.Click += hOMEToolStripMenuItem_Click;
            // 
            // aDDToolStripMenuItem
            // 
            aDDToolStripMenuItem.Name = "aDDToolStripMenuItem";
            aDDToolStripMenuItem.Size = new Size(66, 29);
            aDDToolStripMenuItem.Text = "ADD";
            aDDToolStripMenuItem.Click += aDDToolStripMenuItem_Click;
            // 
            // uPDATEToolStripMenuItem
            // 
            uPDATEToolStripMenuItem.Name = "uPDATEToolStripMenuItem";
            uPDATEToolStripMenuItem.Size = new Size(92, 29);
            uPDATEToolStripMenuItem.Text = "UPDATE";
            uPDATEToolStripMenuItem.Click += uPDATEToolStripMenuItem_Click;
            // 
            // dELETEToolStripMenuItem
            // 
            dELETEToolStripMenuItem.Name = "dELETEToolStripMenuItem";
            dELETEToolStripMenuItem.Size = new Size(85, 29);
            dELETEToolStripMenuItem.Text = "DELETE";
            dELETEToolStripMenuItem.Click += dELETEToolStripMenuItem_Click;
            // 
            // VIEWALLToolStripMenuItem
            // 
            VIEWALLToolStripMenuItem.Name = "VIEWALLToolStripMenuItem";
            VIEWALLToolStripMenuItem.Size = new Size(103, 29);
            VIEWALLToolStripMenuItem.Text = "VIEW ALL";
            VIEWALLToolStripMenuItem.Click += VIEWALLToolStripMenuItem_Click;
            // 
            // sEARCHToolStripMenuItem
            // 
            sEARCHToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            sEARCHToolStripMenuItem.Name = "sEARCHToolStripMenuItem";
            sEARCHToolStripMenuItem.Size = new Size(94, 29);
            sEARCHToolStripMenuItem.Text = "SEARCH";
            sEARCHToolStripMenuItem.Click += sEARCHToolStripMenuItem_Click;
            // 
            // contentPanel
            // 
            contentPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            contentPanel.AutoScroll = true;
            contentPanel.Location = new Point(0, 36);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(808, 469);
            contentPanel.TabIndex = 18;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(808, 514);
            Controls.Add(contentPanel);
            Controls.Add(menuStrip1);
            Name = "Dashboard";
            Text = "Employee Management System";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aDDToolStripMenuItem;
        private ToolStripMenuItem uPDATEToolStripMenuItem;
        private ToolStripMenuItem dELETEToolStripMenuItem;
        private ToolStripMenuItem VIEWALLToolStripMenuItem;
        private ToolStripMenuItem hOMEToolStripMenuItem;
        private ToolStripMenuItem sEARCHToolStripMenuItem;
        private Panel contentPanel;
    }
}
