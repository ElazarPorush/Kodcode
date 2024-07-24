namespace Student
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
            this.lblName = new System.Windows.Forms.Label();
            this.btnOkey = new System.Windows.Forms.Button();
            this.txtAddChoice = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblCourses = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(23, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 26);
            this.lblName.TabIndex = 35;
            this.lblName.Text = "שם";
            // 
            // btnOkey
            // 
            this.btnOkey.Location = new System.Drawing.Point(98, 427);
            this.btnOkey.Name = "btnOkey";
            this.btnOkey.Size = new System.Drawing.Size(121, 70);
            this.btnOkey.TabIndex = 30;
            this.btnOkey.Text = "אישור";
            this.btnOkey.UseVisualStyleBackColor = true;
            // 
            // txtAddChoice
            // 
            this.txtAddChoice.Location = new System.Drawing.Point(304, 427);
            this.txtAddChoice.Name = "txtAddChoice";
            this.txtAddChoice.Size = new System.Drawing.Size(148, 22);
            this.txtAddChoice.TabIndex = 29;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(555, 427);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 70);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "הירשם";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblCourses
            // 
            this.lblCourses.AutoSize = true;
            this.lblCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblCourses.Location = new System.Drawing.Point(333, 21);
            this.lblCourses.Name = "lblCourses";
            this.lblCourses.Size = new System.Drawing.Size(102, 32);
            this.lblCourses.TabIndex = 27;
            this.lblCourses.Text = "קורסים";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(695, 321);
            this.dataGridView1.TabIndex = 24;
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(304, 463);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(148, 34);
            this.btnPay.TabIndex = 36;
            this.btnPay.Text = "תשלום";
            this.btnPay.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 537);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnOkey);
            this.Controls.Add(this.txtAddChoice);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblCourses);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "קורסים";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnOkey;
        private System.Windows.Forms.TextBox txtAddChoice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblCourses;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPay;
    }
}