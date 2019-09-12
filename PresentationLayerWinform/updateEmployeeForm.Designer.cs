namespace PresentationLayerWinform
{
    partial class updateEmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.updateEmployeeButton = new System.Windows.Forms.Button();
            this.hourlyRateBox = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.salaryBox = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.typeEmployeeBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.hourlyRateBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryBox)).BeginInit();
            this.SuspendLayout();
            // 
            // updateEmployeeButton
            // 
            this.updateEmployeeButton.Location = new System.Drawing.Point(160, 290);
            this.updateEmployeeButton.Name = "updateEmployeeButton";
            this.updateEmployeeButton.Size = new System.Drawing.Size(161, 29);
            this.updateEmployeeButton.TabIndex = 22;
            this.updateEmployeeButton.Text = "Actualizar empleado";
            this.updateEmployeeButton.UseVisualStyleBackColor = true;
            this.updateEmployeeButton.Click += new System.EventHandler(this.updateEmployeeButton_Click);
            // 
            // hourlyRateBox
            // 
            this.hourlyRateBox.Location = new System.Drawing.Point(138, 213);
            this.hourlyRateBox.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.hourlyRateBox.Name = "hourlyRateBox";
            this.hourlyRateBox.Size = new System.Drawing.Size(282, 20);
            this.hourlyRateBox.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Pago horario(PartTime)";
            // 
            // salaryBox
            // 
            this.salaryBox.Location = new System.Drawing.Point(138, 166);
            this.salaryBox.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.salaryBox.Name = "salaryBox";
            this.salaryBox.Size = new System.Drawing.Size(282, 20);
            this.salaryBox.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Salario(FullTime)";
            // 
            // typeEmployeeBox
            // 
            this.typeEmployeeBox.FormattingEnabled = true;
            this.typeEmployeeBox.Items.AddRange(new object[] {
            "FullTime",
            "PartTime"});
            this.typeEmployeeBox.Location = new System.Drawing.Point(138, 118);
            this.typeEmployeeBox.Name = "typeEmployeeBox";
            this.typeEmployeeBox.Size = new System.Drawing.Size(282, 21);
            this.typeEmployeeBox.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tipo de empleado";
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(138, 68);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(282, 20);
            this.datePicker.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Fecha de inicio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(138, 17);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(282, 20);
            this.nameTextBox.TabIndex = 12;
            // 
            // updateEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 355);
            this.Controls.Add(this.updateEmployeeButton);
            this.Controls.Add(this.hourlyRateBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.salaryBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.typeEmployeeBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextBox);
            this.Name = "updateEmployeeForm";
            this.Text = "Editar empleado";
            ((System.ComponentModel.ISupportInitialize)(this.hourlyRateBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateEmployeeButton;
        private System.Windows.Forms.NumericUpDown hourlyRateBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown salaryBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox typeEmployeeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
    }
}