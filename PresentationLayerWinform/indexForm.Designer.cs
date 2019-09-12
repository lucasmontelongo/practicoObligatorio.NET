namespace PresentationLayerWinform
{
    partial class indexForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RefreshListButton = new System.Windows.Forms.Button();
            this.UpdateEmployeeButton = new System.Windows.Forms.Button();
            this.AddEmployeeButton = new System.Windows.Forms.Button();
            this.DeleteEmployeeButton = new System.Windows.Forms.Button();
            this.bLEmployeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bLEmployeesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.typePartTimeEmployeeExceptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bLEmployeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bLEmployeesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typePartTimeEmployeeExceptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(453, 451);
            this.dataGridView1.TabIndex = 0;
            // 
            // RefreshListButton
            // 
            this.RefreshListButton.Location = new System.Drawing.Point(494, 402);
            this.RefreshListButton.Name = "RefreshListButton";
            this.RefreshListButton.Size = new System.Drawing.Size(92, 36);
            this.RefreshListButton.TabIndex = 1;
            this.RefreshListButton.Text = "Refrescar lista de empleados";
            this.RefreshListButton.UseVisualStyleBackColor = true;
            this.RefreshListButton.Click += new System.EventHandler(this.RefreshListButton_Click);
            // 
            // UpdateEmployeeButton
            // 
            this.UpdateEmployeeButton.Location = new System.Drawing.Point(494, 25);
            this.UpdateEmployeeButton.Name = "UpdateEmployeeButton";
            this.UpdateEmployeeButton.Size = new System.Drawing.Size(92, 36);
            this.UpdateEmployeeButton.TabIndex = 2;
            this.UpdateEmployeeButton.Text = "Editar datos del empleado";
            this.UpdateEmployeeButton.UseVisualStyleBackColor = true;
            this.UpdateEmployeeButton.Click += new System.EventHandler(this.UpdateEmployeeButton_Click);
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.Location = new System.Drawing.Point(494, 122);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(92, 36);
            this.AddEmployeeButton.TabIndex = 3;
            this.AddEmployeeButton.Text = "Añadir empleado";
            this.AddEmployeeButton.UseVisualStyleBackColor = true;
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // DeleteEmployeeButton
            // 
            this.DeleteEmployeeButton.Location = new System.Drawing.Point(494, 217);
            this.DeleteEmployeeButton.Name = "DeleteEmployeeButton";
            this.DeleteEmployeeButton.Size = new System.Drawing.Size(92, 36);
            this.DeleteEmployeeButton.TabIndex = 4;
            this.DeleteEmployeeButton.Text = "Eliminar empleado";
            this.DeleteEmployeeButton.UseVisualStyleBackColor = true;
            this.DeleteEmployeeButton.Click += new System.EventHandler(this.DeleteEmployeeButton_Click);
            // 
            // bLEmployeesBindingSource
            // 
            this.bLEmployeesBindingSource.DataSource = typeof(BusinessLogicLayer.BLEmployees);
            // 
            // bLEmployeesBindingSource1
            // 
            this.bLEmployeesBindingSource1.DataSource = typeof(BusinessLogicLayer.BLEmployees);
            // 
            // typePartTimeEmployeeExceptionBindingSource
            // 
            this.typePartTimeEmployeeExceptionBindingSource.DataSource = typeof(Shared.Exception.TypePartTimeEmployeeException);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(Shared.Entities.Employee);
            // 
            // indexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 450);
            this.Controls.Add(this.DeleteEmployeeButton);
            this.Controls.Add(this.AddEmployeeButton);
            this.Controls.Add(this.UpdateEmployeeButton);
            this.Controls.Add(this.RefreshListButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "indexForm";
            this.Text = "Gestión de empleados";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bLEmployeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bLEmployeesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typePartTimeEmployeeExceptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource typePartTimeEmployeeExceptionBindingSource;
        private System.Windows.Forms.BindingSource bLEmployeesBindingSource;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.BindingSource bLEmployeesBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button RefreshListButton;
        private System.Windows.Forms.Button UpdateEmployeeButton;
        private System.Windows.Forms.Button AddEmployeeButton;
        private System.Windows.Forms.Button DeleteEmployeeButton;
    }
}

