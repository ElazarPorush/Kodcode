namespace Exercise
{
    partial class Form1
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
            this.txtAddCar = new System.Windows.Forms.TextBox();
            this.btnPrintCar = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAddCar
            // 
            this.txtAddCar.Location = new System.Drawing.Point(304, 117);
            this.txtAddCar.Name = "txtAddCar";
            this.txtAddCar.Size = new System.Drawing.Size(245, 22);
            this.txtAddCar.TabIndex = 0;
            // 
            // btnPrintCar
            // 
            this.btnPrintCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnPrintCar.Location = new System.Drawing.Point(304, 184);
            this.btnPrintCar.Name = "btnPrintCar";
            this.btnPrintCar.Size = new System.Drawing.Size(245, 125);
            this.btnPrintCar.TabIndex = 1;
            this.btnPrintCar.Text = "Print Cars";
            this.btnPrintCar.UseVisualStyleBackColor = true;
            this.btnPrintCar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnStudent.Location = new System.Drawing.Point(44, 184);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(225, 125);
            this.btnStudent.TabIndex = 2;
            this.btnStudent.Text = "Print student";
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnEmployee.Location = new System.Drawing.Point(304, 333);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(245, 118);
            this.btnEmployee.TabIndex = 3;
            this.btnEmployee.Text = "Print Employees";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 450);
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.btnStudent);
            this.Controls.Add(this.btnPrintCar);
            this.Controls.Add(this.txtAddCar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAddCar;
        private System.Windows.Forms.Button btnPrintCar;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnEmployee;
    }
}

