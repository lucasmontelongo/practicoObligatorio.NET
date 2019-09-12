﻿using System;
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
    public partial class deleteEmployeeForm : Form
    {
        public deleteEmployeeForm()
        {
            InitializeComponent();
            this.deleteEmployeeFormLoad();
        }

        private void deleteEmployeeFormLoad()
        {
            nameBox.Text = indexForm.nameEmployeeGlobal;
            typeEmployeeBox.Text = indexForm.typeEmployeeGlobal;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DataAccessLayer.DALEmployeesEF dalef = new DataAccessLayer.DALEmployeesEF();
            BusinessLogicLayer.BLEmployees bl = new BusinessLogicLayer.BLEmployees(dalef);
            bl.DeleteEmployee(indexForm.idEmployeeGlobal);
            this.Close();
        }
    }
}