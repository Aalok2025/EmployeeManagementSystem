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
using ApplicationServiceController;
using ApplicationServiceController.ServiceRepository;

namespace EmployeeManagementSystem.UserControls
{
    public partial class UpdateEmployeeDetails : UserControl
    {
        ILoadAllEmployeesRepo<Employee> loadAllEmployeesRepo;
        IUpdateEmployeeRepo<Employee> updateEmployeeRepo;
        public UpdateEmployeeDetails()
        {
            InitializeComponent();
            string? connectToDB = ConfigurationManager.ConnectionStrings["ssmsConnection"]?.ConnectionString;
            loadAllEmployeesRepo = new LoadAllEmployees<Employee>(connectToDB);
            updateEmployeeRepo = new UpdateEmployee<Employee>(connectToDB);
            BoxSalary.ReadOnly = true;
            BoxID.ReadOnly = true;
        }

        private void BttnUpdate_Click(object sender, EventArgs e)
        {
            if (BoxID.Text == "")
            {
                MessageBox.Show("Please select a valid entry to update!");
                return;
            }
            int Id = Convert.ToInt32(BoxID.Text);
            string Name = BoxName.Text;
            int Age = Convert.ToInt32(BoxAge.Text);
            Department dept= (Department)Enum.Parse(typeof(Department),BoxDepartment.Text);
            decimal Salary = Convert.ToDecimal(BoxSalary.Text);
            Employee emp = new Employee(Id,Name,Age,dept,Salary);
            bool sucess = updateEmployeeRepo.UpdateEmployeeById(emp);
            if (sucess)
            {
                MessageBox.Show("Updated sucessfully!");
                LoadDataGridView.DataSource = loadAllEmployeesRepo.LoadAllEmployees();
            }
            else
            {
                MessageBox.Show("Could not update sucessfully!");
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
