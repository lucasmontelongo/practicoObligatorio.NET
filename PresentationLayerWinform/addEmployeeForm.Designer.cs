namespace PresentationLayerWinform
{
    partial class addEmployeeForm
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.typeEmployeeBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.salaryBox = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.hourlyRateBox = new System.Windows.Forms.NumericUpDown();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.salaryBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourlyRateBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(135, 27);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(282, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha de inicio";
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(135, 78);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(282, 20);
            this.datePicker.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo de empleado";
            // 
            // typeEmployeeBox
            // 
            this.typeEmployeeBox.FormattingEnabled = true;
            this.typeEmployeeBox.Items.AddRange(new object[] {
            "FullTime",
            "PartTime"});
            this.typeEmployeeBox.Location = new System.Drawing.Point(135, 128);
            this.typeEmployeeBox.Name = "typeEmployeeBox";
            this.typeEmployeeBox.Size = new System.Drawing.Size(282, 21);
            this.typeEmployeeBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Salario(FullTime)";
            // 
            // salaryBox
            // 
            this.salaryBox.Location = new System.Drawing.Point(135, 176);
            this.salaryBox.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.salaryBox.Name = "salaryBox";
            this.salaryBox.Size = new System.Drawing.Size(282, 20);
            this.salaryBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Pago horario(PartTime)";
            // 
            // hourlyRateBox
            // 
            this.hourlyRateBox.Location = new System.Drawing.Point(135, 223);
            this.hourlyRateBox.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.hourlyRateBox.Name = "hourlyRateBox";
            this.hourlyRateBox.Size = new System.Drawing.Size(282, 20);
            this.hourlyRateBox.TabIndex = 10;
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.Location = new System.Drawing.Point(157, 300);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(161, 29);
            this.addEmployeeButton.TabIndex = 11;
            this.addEmployeeButton.Text = "Añadir empleado";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // addEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 351);
            this.Controls.Add(this.addEmployeeButton);
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
            this.Name = "addEmployeeForm";
            this.Text = "Añadir nuevo empleado";
            ((System.ComponentModel.ISupportInitialize)(this.salaryBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourlyRateBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox typeEmployeeBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown salaryBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown hourlyRateBox;
        private System.Windows.Forms.Button addEmployeeButton;
    }
}