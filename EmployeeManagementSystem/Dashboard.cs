using System.Windows.Forms;
using EmployeeManagementSystem.UserControls;
namespace EmployeeManagementSystem
{
    public partial class Dashboard : Form
    {
        private UserControl homePanel;

        public Dashboard()
        {
            InitializeComponent();
            InitializeHomePanel();
        }

        private void InitializeHomePanel()
        {
            homePanel = new Home();
            homePanel.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(homePanel);
        }

        private void OpenForm(UserControl control)
        {
            contentPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(control);
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(homePanel);
        }

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new AddNewEmployee());
        }

        private void uPDATEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new UpdateEmployeeDetails());
        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new DeleteEmployeeDetails());
        }
        private void sEARCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new SearchEmployee());
        }
        private void VIEWALLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new ViewAllEmployeeDetails());
        }

    }
}
