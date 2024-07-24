namespace Public_Domain
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
            this.txtHight = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.lblHight = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.pnlArea = new System.Windows.Forms.Panel();
            this.rdbtnRY = new System.Windows.Forms.RadioButton();
            this.rdbtnCR = new System.Windows.Forms.RadioButton();
            this.rdbtnRR = new System.Windows.Forms.RadioButton();
            this.lblArea = new System.Windows.Forms.Label();
            this.btnResult = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.pnlArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtHight
            // 
            this.txtHight.Location = new System.Drawing.Point(207, 128);
            this.txtHight.Name = "txtHight";
            this.txtHight.Size = new System.Drawing.Size(100, 22);
            this.txtHight.TabIndex = 0;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(405, 127);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 22);
            this.txtWidth.TabIndex = 1;
            // 
            // lblHight
            // 
            this.lblHight.AutoSize = true;
            this.lblHight.Location = new System.Drawing.Point(236, 98);
            this.lblHight.Name = "lblHight";
            this.lblHight.Size = new System.Drawing.Size(38, 16);
            this.lblHight.TabIndex = 2;
            this.lblHight.Text = "Hight";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(436, 98);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(41, 16);
            this.lblWidth.TabIndex = 3;
            this.lblWidth.Text = "Width";
            // 
            // pnlArea
            // 
            this.pnlArea.Controls.Add(this.rdbtnRY);
            this.pnlArea.Controls.Add(this.rdbtnCR);
            this.pnlArea.Controls.Add(this.rdbtnRR);
            this.pnlArea.Location = new System.Drawing.Point(582, 128);
            this.pnlArea.Name = "pnlArea";
            this.pnlArea.Size = new System.Drawing.Size(149, 193);
            this.pnlArea.TabIndex = 4;
            // 
            // rdbtnRY
            // 
            this.rdbtnRY.AutoSize = true;
            this.rdbtnRY.Location = new System.Drawing.Point(28, 144);
            this.rdbtnRY.Name = "rdbtnRY";
            this.rdbtnRY.Size = new System.Drawing.Size(95, 20);
            this.rdbtnRY.TabIndex = 2;
            this.rdbtnRY.TabStop = true;
            this.rdbtnRY.Text = "רשות היחיד";
            this.rdbtnRY.UseVisualStyleBackColor = true;
            // 
            // rdbtnCR
            // 
            this.rdbtnCR.AutoSize = true;
            this.rdbtnCR.Location = new System.Drawing.Point(28, 85);
            this.rdbtnCR.Name = "rdbtnCR";
            this.rdbtnCR.Size = new System.Drawing.Size(72, 20);
            this.rdbtnCR.TabIndex = 1;
            this.rdbtnCR.TabStop = true;
            this.rdbtnCR.Text = "כרמלית";
            this.rdbtnCR.UseVisualStyleBackColor = true;
            // 
            // rdbtnRR
            // 
            this.rdbtnRR.AutoSize = true;
            this.rdbtnRR.Location = new System.Drawing.Point(28, 28);
            this.rdbtnRR.Name = "rdbtnRR";
            this.rdbtnRR.Size = new System.Drawing.Size(97, 20);
            this.rdbtnRR.TabIndex = 0;
            this.rdbtnRR.TabStop = true;
            this.rdbtnRR.Text = "רשות הרבים";
            this.rdbtnRR.UseVisualStyleBackColor = true;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(639, 98);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(36, 16);
            this.lblArea.TabIndex = 5;
            this.lblArea.Text = "Area";
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(199, 256);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(75, 23);
            this.btnResult.TabIndex = 6;
            this.btnResult.Text = "Result";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblResult.Location = new System.Drawing.Point(217, 308);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 25);
            this.lblResult.TabIndex = 7;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.pnlArea);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblHight);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtHight);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlArea.ResumeLayout(false);
            this.pnlArea.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label lblHight;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Panel pnlArea;
        private System.Windows.Forms.RadioButton rdbtnRY;
        private System.Windows.Forms.RadioButton rdbtnCR;
        private System.Windows.Forms.RadioButton rdbtnRR;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Label lblResult;
    }
}

