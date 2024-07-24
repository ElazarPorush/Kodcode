namespace Courses
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnListSubjects = new System.Windows.Forms.Button();
            this.lstbxCorses = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblWelcome.Location = new System.Drawing.Point(232, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(77, 32);
            this.lblWelcome.TabIndex = 20;
            this.lblWelcome.Text = "מנהל";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnDelete.Location = new System.Drawing.Point(223, 148);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 35);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "מחק";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnListSubjects
            // 
            this.btnListSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnListSubjects.Location = new System.Drawing.Point(12, 386);
            this.btnListSubjects.Name = "btnListSubjects";
            this.btnListSubjects.Size = new System.Drawing.Size(116, 61);
            this.btnListSubjects.TabIndex = 18;
            this.btnListSubjects.Text = "הסתכל ברשימה";
            this.btnListSubjects.UseVisualStyleBackColor = true;
            this.btnListSubjects.Click += new System.EventHandler(this.btnListSubjects_Click);
            // 
            // lstbxCorses
            // 
            this.lstbxCorses.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbxCorses.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lstbxCorses.FormattingEnabled = true;
            this.lstbxCorses.ItemHeight = 22;
            this.lstbxCorses.Location = new System.Drawing.Point(182, 201);
            this.lstbxCorses.Name = "lstbxCorses";
            this.lstbxCorses.Size = new System.Drawing.Size(179, 180);
            this.lstbxCorses.TabIndex = 17;
            this.lstbxCorses.DoubleClick += new System.EventHandler(this.lstbxCorses_DoubleClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAdd.Location = new System.Drawing.Point(393, 386);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(122, 61);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "להוספת קורס";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCourse
            // 
            this.txtCourse.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtCourse.Location = new System.Drawing.Point(179, 115);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(182, 27);
            this.txtCourse.TabIndex = 15;
            this.txtCourse.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCourse_KeyUp);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTitle.Location = new System.Drawing.Point(219, 87);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(90, 25);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "הכנס קורס";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 461);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnListSubjects);
            this.Controls.Add(this.lstbxCorses);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "מנהל";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnListSubjects;
        private System.Windows.Forms.ListBox lstbxCorses;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.Label lblTitle;
    }
}

