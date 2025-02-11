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
using ApplicationServiceController;
using ApplicationServiceController.ServiceFunctionality;
using ApplicationServiceController.ServiceRepository;

namespace EmployeeManagementSystem
{
    public partial class DeleteEmployeeDetails : UserControl
    {
        ILoadAllEmployeesRepo<Employee> loadAllEmployeesRepo;
        IDeleteEmployeeRepo<Employee> deleteEmployeeRepo;
        public DeleteEmployeeDetails()
        {
            InitializeComponent();
            string? connectToDB = ConfigurationManager.ConnectionStrings["ssmsConnection"]?.ConnectionString;
            loadAllEmployeesRepo = new LoadAllEmployees<Employee>(connectToDB);
            deleteEmployeeRepo = new DeleteEmployee<Employee>(connectToDB);
        }

        private void BttnDelete_Click(object sender, EventArgs e)
        {
            if(BoxID.Text == "")
            {
                MessageBox.Show("Please select a valid entry to delete!");
                return;
            }
            int id = Convert.ToInt32(BoxID.Text);
            bool sucess=deleteEmployeeRepo.DeleteEmployeeById(id);
            if (sucess)
            {
                MessageBox.Show("Deleted sucessfully!");
                LoadDataGridView.DataSource = loadAllEmployeesRepo.LoadAllEmployees();
            }
            else
            {
                MessageBox.Show("Could not delete sucessfully!");
            }
        }

        private void BttnLoad_Click(object sender, EventArgs e)
        {
            DataTable dt = loadAllEmployeesRepo.LoadAllEmployees();
            if (dt != null)
            {
                LoadDataGridView.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No data found");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
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
