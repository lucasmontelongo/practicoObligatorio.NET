using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayerWinform
{
    public partial class updateEmployeeForm : Form
    {
        public updateEmployeeForm()
        {
            InitializeComponent();
            this.loadDataEmployee();
        }

        private void loadDataEmployee()
        {
            ServiceLayer.ServiceEmployeeProxy proxy = new ServiceLayer.ServiceEmployeeProxy();
            Shared.Entities.Employee emp = proxy.GetEmployee(indexForm.idEmployeeGlobal);
            if(emp.GetType().Name == "FullTimeEmployee")
            {
                Shared.Entities.FullTimeEmployee employee = (Shared.Entities.FullTimeEmployee)emp;
                nameTextBox.Text = employee.Name;
                datePicker.Value = employee.StartDate;
                typeEmployeeBox.Text = "FullTime";
                salaryBox.Value = employee.Salary;
            }
            else
            {
                Shared.Entities.PartTimeEmployee employee = (Shared.Entities.PartTimeEmployee)emp;
                nameTextBox.Text = employee.Name;
                datePicker.Value = employee.StartDate;
                typeEmployeeBox.Text = "PartTime";
                hourlyRateBox.Value = (int)employee.HourlyRate;
            }
        }

        private void updateEmployeeButton_Click(object sender, EventArgs e)
        {
            ServiceLayer.ServiceEmployeeProxy proxy = new ServiceLayer.ServiceEmployeeProxy();
            if (indexForm.typeEmployeeGlobal == "FullTime")
            {
                Shared.Entities.FullTimeEmployee emp = new Shared.Entities.FullTimeEmployee()
                {
                    Id = indexForm.idEmployeeGlobal,
                    Name = nameTextBox.Text,
                    StartDate = datePicker.Value,
                    Salary = (int)salaryBox.Value
                };
                proxy.UpdateEmployee(emp);
            }
            else
            {
                Shared.Entities.PartTimeEmployee emp = new Shared.Entities.PartTimeEmployee()
                {
                    Id = indexForm.idEmployeeGlobal,
                    Name = nameTextBox.Text,
                    StartDate = datePicker.Value,
                    HourlyRate = (int)hourlyRateBox.Value
                };
                proxy.UpdateEmployee(emp);
            }
            this.Close();
        }
    }
}
