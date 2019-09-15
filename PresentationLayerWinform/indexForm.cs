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
    public partial class indexForm : Form
    {
        public indexForm()
        {
            InitializeComponent();
            this.refreshList();
        }

        //variables globales
        public static int idEmployeeGlobal = 0;
        public static string nameEmployeeGlobal = "";
        public static string typeEmployeeGlobal = "";

        private void refreshList()
        {
            ServiceLayer.ServiceEmployeeProxy proxy = new ServiceLayer.ServiceEmployeeProxy();
            List<Shared.Entities.Employee> empleados = proxy.GetAllEmployees();
            List<Shared.Entities.EmployeeMuestraWinform> empleadosTabla = new List<Shared.Entities.EmployeeMuestraWinform>();
            empleados.ForEach(x =>
            {
                if (x.GetType().Name == "FullTimeEmployee")
                {
                    Shared.Entities.FullTimeEmployee emp = (Shared.Entities.FullTimeEmployee)x;
                    empleadosTabla.Add(new Shared.Entities.EmployeeMuestraWinform()
                    {
                        Id = emp.Id,
                        Name = emp.Name,
                        StartDate = emp.StartDate,
                        TypeEmp = "FullTime"
                    });
                }
                else
                {
                    Shared.Entities.PartTimeEmployee emp = (Shared.Entities.PartTimeEmployee)x;
                    empleadosTabla.Add(new Shared.Entities.EmployeeMuestraWinform()
                    {
                        Id = emp.Id,
                        Name = emp.Name,
                        StartDate = emp.StartDate,
                        TypeEmp = "PartTime"
                    });
                }
            });

            dataGridView1.DataSource = empleadosTabla;
        }

        private void UpdateEmployeeButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.SelectedRows[0];
            nameEmployeeGlobal = (string)row.Cells["Name"].Value;
            idEmployeeGlobal = (int)row.Cells["Id"].Value;
            typeEmployeeGlobal = (string)row.Cells["TypeEmp"].Value;
            updateEmployeeForm updateEmployeeVentana = new updateEmployeeForm();
            updateEmployeeVentana.Show();
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            addEmployeeForm addEmployeeVentana = new addEmployeeForm();
            addEmployeeVentana.Show();
        }

        private void DeleteEmployeeButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                nameEmployeeGlobal = (string)row.Cells["Name"].Value;
                idEmployeeGlobal = (int)row.Cells["Id"].Value;
                typeEmployeeGlobal = (string)row.Cells["TypeEmp"].Value;
                deleteEmployeeForm deleteEmployeeVentana = new deleteEmployeeForm();
                deleteEmployeeVentana.Show();
            }
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void RefreshListButton_Click(object sender, EventArgs e)
        {
            this.refreshList();
        }
    }
}
