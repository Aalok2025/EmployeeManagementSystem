using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationServiceController.ServiceFunctionality;
using ApplicationServiceController.ServiceRepository;
using ApplicationServiceController;

namespace EmployeeManagementSystem
{
    public partial class SearchEmployee : UserControl
    {
        IGetEmployeeByNameOrId<Employee> getEmployeeByNameOrId;
        public SearchEmployee()
        {
            InitializeComponent();
            BoxAge.ReadOnly = false;
            BoxDepartment.ReadOnly = false;
            BoxID.ReadOnly = false;
            BoxName.ReadOnly = false;
            BoxSalary.ReadOnly = false;
            string? connectToDB = ConfigurationManager.ConnectionStrings["ssmsConnection"]?.ConnectionString;
            getEmployeeByNameOrId = new GetEmployeeByNameOrId<Employee>(connectToDB);
        }

        private void BttnSearch_Click(object sender, EventArgs e)
        {
            if (BoxSearch.Text == null)
            {
                MessageBox.Show("Please enter a valid name or ID");
                return;
            }
            string search = BoxSearch.Text;
            if (int.TryParse(search, out int id))
            {
                DataTable dt = getEmployeeByNameOrId.GetEmployeeById(id);
                if (dt != null)
                {
                    LoadDataGridView.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No data found");
                }
            }
            else
            {
                DataTable dt = getEmployeeByNameOrId.GetEmployeeByName(search);
                if (dt != null)
                {
                    LoadDataGridView.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No data found");
                }
            }
        }

        private void LoadDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = LoadDataGridView.Rows[e.RowIndex];
                BoxID.Text = row.Cells["Id"].Value.ToString();
                BoxName.Text = row.Cells["Name"].Value.ToString();
                BoxAge.Text = row.Cells["Age"].Value.ToString();
                BoxDepartment.Text = row.Cells["Department"].Value.ToString();
                BoxSalary.Text = row.Cells["Salary"].Value.ToString();
            }
        }
    }
}
