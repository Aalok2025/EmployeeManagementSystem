using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationServiceController.ServiceRepository;
using ApplicationServiceController;
using System.Configuration;
using ApplicationServiceController.ServiceFunctionality;

namespace EmployeeManagementSystem.UserControls
{
    public partial class ViewAllEmployeeDetails : UserControl
    {
        ILoadAllEmployeesRepo<Employee> loadAllEmployeesRepo;
        public ViewAllEmployeeDetails()
        {
            InitializeComponent();
            string? connectToDB = ConfigurationManager.ConnectionStrings["ssmsConnection"]?.ConnectionString;
            loadAllEmployeesRepo=new LoadAllEmployees<Employee>(connectToDB);

        }

        private void BttnLoad_Click(object sender, EventArgs e)
        {
            DataTable dt= loadAllEmployeesRepo.LoadAllEmployees();
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
}
