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
    public partial class addEmployeeForm : Form
    {
        public addEmployeeForm()
        {
            InitializeComponent();
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            ServiceLayer.ServiceEmployeeProxy proxy = new ServiceLayer.ServiceEmployeeProxy();
            if (typeEmployeeBox.Text == "FullTime")
            {
                Shared.Entities.FullTimeEmployee emp = new Shared.Entities.FullTimeEmployee()
                {
                    Name = nameTextBox.Text,
                    StartDate = datePicker.Value,
                    Salary = (int)salaryBox.Value
                };
                proxy.AddEmployee(emp);
            }
            else
            {
                Shared.Entities.PartTimeEmployee emp = new Shared.Entities.PartTimeEmployee()
                {
                    Name = nameTextBox.Text,
                    StartDate = datePicker.Value,
                    HourlyRate = (int)hourlyRateBox.Value
                };
                proxy.AddEmployee(emp);
            }
            this.Close();
        }
    }
}
