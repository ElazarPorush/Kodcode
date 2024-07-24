namespace Courses
{
    partial class Form2
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
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.lblSubjects = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddSubject = new System.Windows.Forms.Button();
            this.btnDeleteSubject = new System.Windows.Forms.Button();
            this.txtDeleteSubject = new System.Windows.Forms.TextBox();
            this.btnDeleteSubjectOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLeft
            // 
            this.btnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnLeft.Location = new System.Drawing.Point(208, 441);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(143, 38);
            this.btnLeft.TabIndex = 14;
            this.btnLeft.Text = "<<<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnRight.Location = new System.Drawing.Point(377, 441);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(145, 38);
            this.btnRight.TabIndex = 13;
            this.btnRight.Text = ">>>";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // lblSubjects
            // 
            this.lblSubjects.AutoSize = true;
            this.lblSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSubjects.Location = new System.Drawing.Point(291, 9);
            this.lblSubjects.Name = "lblSubjects";
            this.lblSubjects.Size = new System.Drawing.Size(119, 38);
            this.lblSubjects.TabIndex = 12;
            this.lblSubjects.Text = "נושאים";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblCourse.Location = new System.Drawing.Point(323, 75);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(38, 16);
            this.lblCourse.TabIndex = 11;
            this.lblCourse.Text = "קורס";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(607, 261);
            this.dataGridView1.TabIndex = 10;
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAddSubject.Location = new System.Drawing.Point(390, 386);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(132, 49);
            this.btnAddSubject.TabIndex = 15;
            this.btnAddSubject.Text = "להוספת נושא";
            this.btnAddSubject.UseVisualStyleBackColor = true;
            this.btnAddSubject.Click += new System.EventHandler(this.btnAddSubject_Click);
            // 
            // btnDeleteSubject
            // 
            this.btnDeleteSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnDeleteSubject.Location = new System.Drawing.Point(208, 386);
            this.btnDeleteSubject.Name = "btnDeleteSubject";
            this.btnDeleteSubject.Size = new System.Drawing.Size(133, 49);
            this.btnDeleteSubject.TabIndex = 16;
            this.btnDeleteSubject.Text = "למחיקת  נושא";
            this.btnDeleteSubject.UseVisualStyleBackColor = true;
            this.btnDeleteSubject.Click += new System.EventHandler(this.btnDeleteSubject_Click);
            // 
            // txtDeleteSubject
            // 
            this.txtDeleteSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtDeleteSubject.Location = new System.Drawing.Point(78, 386);
            this.txtDeleteSubject.Multiline = true;
            this.txtDeleteSubject.Name = "txtDeleteSubject";
            this.txtDeleteSubject.Size = new System.Drawing.Size(100, 27);
            this.txtDeleteSubject.TabIndex = 17;
            // 
            // btnDeleteSubjectOk
            // 
            this.btnDeleteSubjectOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnDeleteSubjectOk.Location = new System.Drawing.Point(89, 419);
            this.btnDeleteSubjectOk.Name = "btnDeleteSubjectOk";
            this.btnDeleteSubjectOk.Size = new System.Drawing.Size(75, 34);
            this.btnDeleteSubjectOk.TabIndex = 18;
            this.btnDeleteSubjectOk.Text = "מחק";
            this.btnDeleteSubjectOk.UseVisualStyleBackColor = true;
            this.btnDeleteSubjectOk.Click += new System.EventHandler(this.btnDeleteSubjectOk_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 498);
            this.Controls.Add(this.btnDeleteSubjectOk);
            this.Controls.Add(this.txtDeleteSubject);
            this.Controls.Add(this.btnDeleteSubject);
            this.Controls.Add(this.btnAddSubject);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.lblSubjects);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "רשימת נושאים";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Label lblSubjects;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddSubject;
        private System.Windows.Forms.Button btnDeleteSubject;
        private System.Windows.Forms.TextBox txtDeleteSubject;
        private System.Windows.Forms.Button btnDeleteSubjectOk;
    }
}