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
    public partial class AddNewEmployee : UserControl
    {
        IAddEmployeeRepo<Employee> addNewEmployeeRepo;
        public AddNewEmployee()
        {
            InitializeComponent();
            string? connectToDB = ConfigurationManager.ConnectionStrings["ssmsConnection"]?.ConnectionString;
            //BoxID.ReadOnly = true;
            BoxSalary.ReadOnly = true;
            addNewEmployeeRepo = new AddEmployee<Employee>(connectToDB);
            BoxDeptOptions.DataSource = Enum.GetValues(typeof(Department));
        }

        private void BttnAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(BoxName.Text) || string.IsNullOrEmpty(BoxAge.Text))
            {
                MessageBox.Show("Please fill all fields");
                return;
            }
            string Name = BoxName.Text;
            if(Name.Length < 3)
            {
                MessageBox.Show("Name should be greater than 3 characters");
                return;
            }
            int Age;
            if (int.TryParse(BoxAge.Text, out int age))
            {
                Age = Convert.ToInt32(BoxAge.Text);
                if(age<19 || age>100)
                {
                    MessageBox.Show("Please enter a valid age");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid age");
                return;
            }
            if (BoxDeptOptions.SelectedItem != null)
            {
                Department selectedDepartment = (Department)BoxDeptOptions.SelectedItem;
                Employee emp = addNewEmployeeRepo.AddEmployee(new Employee(Name, Age, selectedDepartment));
                if (emp != null)
                {
                    MessageBox.Show($"Employee {Name} added successfully!");
                    BoxSalary.Text= emp.Salary.ToString();
                }
                else
                {
                    MessageBox.Show("Employee not added");
                }
            }
            else
            {
                MessageBox.Show("Please select a department");
                return;
            }
        }
    }
}
