namespace Courses
{
    partial class Form4
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
            this.btnAddSubject = new System.Windows.Forms.Button();
            this.txtPriceTeacher = new System.Windows.Forms.TextBox();
            this.txtNameTeacher = new System.Windows.Forms.TextBox();
            this.txtHoursSubject = new System.Windows.Forms.TextBox();
            this.txtNameSubject = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAddSubject.Location = new System.Drawing.Point(182, 417);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(88, 46);
            this.btnAddSubject.TabIndex = 25;
            this.btnAddSubject.Text = "אישור";
            this.btnAddSubject.UseVisualStyleBackColor = true;
            this.btnAddSubject.Click += new System.EventHandler(this.btnAddSubject_Click);
            // 
            // txtPriceTeacher
            // 
            this.txtPriceTeacher.Location = new System.Drawing.Point(156, 329);
            this.txtPriceTeacher.Name = "txtPriceTeacher";
            this.txtPriceTeacher.Size = new System.Drawing.Size(100, 22);
            this.txtPriceTeacher.TabIndex = 23;
            // 
            // txtNameTeacher
            // 
            this.txtNameTeacher.Location = new System.Drawing.Point(156, 248);
            this.txtNameTeacher.Name = "txtNameTeacher";
            this.txtNameTeacher.Size = new System.Drawing.Size(100, 22);
            this.txtNameTeacher.TabIndex = 22;
            // 
            // txtHoursSubject
            // 
            this.txtHoursSubject.Location = new System.Drawing.Point(156, 166);
            this.txtHoursSubject.Name = "txtHoursSubject";
            this.txtHoursSubject.Size = new System.Drawing.Size(100, 22);
            this.txtHoursSubject.TabIndex = 21;
            // 
            // txtNameSubject
            // 
            this.txtNameSubject.Location = new System.Drawing.Point(156, 96);
            this.txtNameSubject.Name = "txtNameSubject";
            this.txtNameSubject.Size = new System.Drawing.Size(100, 22);
            this.txtNameSubject.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(295, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(269, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "מחיר מורה";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(269, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "שם מורה";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(269, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "שעות בסה\"כ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(269, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "שם";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(178, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(116, 22);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "הוספת נושא";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 491);
            this.Controls.Add(this.btnAddSubject);
            this.Controls.Add(this.txtPriceTeacher);
            this.Controls.Add(this.txtNameTeacher);
            this.Controls.Add(this.txtHoursSubject);
            this.Controls.Add(this.txtNameSubject);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form4";
            this.Text = "הוספת נושא";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddSubject;
        private System.Windows.Forms.TextBox txtPriceTeacher;
        private System.Windows.Forms.TextBox txtNameTeacher;
        private System.Windows.Forms.TextBox txtHoursSubject;
        private System.Windows.Forms.TextBox txtNameSubject;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitle;
    }
}