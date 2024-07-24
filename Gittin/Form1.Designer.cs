namespace Gittin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblDateTitle = new System.Windows.Forms.Label();
            this.lblDayInWeek = new System.Windows.Forms.Label();
            this.lblDayInMonth = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.cmbxDayInWeek = new System.Windows.Forms.ComboBox();
            this.cmbxDayInMonth = new System.Windows.Forms.ComboBox();
            this.cmbxMonth = new System.Windows.Forms.ComboBox();
            this.cmbxYear = new System.Windows.Forms.ComboBox();
            this.btnConforme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDateTitle
            // 
            this.lblDateTitle.AutoSize = true;
            this.lblDateTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblDateTitle.ForeColor = System.Drawing.Color.Black;
            this.lblDateTitle.Location = new System.Drawing.Point(224, 44);
            this.lblDateTitle.Name = "lblDateTitle";
            this.lblDateTitle.Size = new System.Drawing.Size(178, 32);
            this.lblDateTitle.TabIndex = 0;
            this.lblDateTitle.Text = "כתיבת תאריך";
            this.lblDateTitle.Click += new System.EventHandler(this.lblDateTitle_Click);
            // 
            // lblDayInWeek
            // 
            this.lblDayInWeek.AutoSize = true;
            this.lblDayInWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblDayInWeek.ForeColor = System.Drawing.Color.Black;
            this.lblDayInWeek.Location = new System.Drawing.Point(470, 116);
            this.lblDayInWeek.Name = "lblDayInWeek";
            this.lblDayInWeek.Size = new System.Drawing.Size(84, 16);
            this.lblDayInWeek.TabIndex = 1;
            this.lblDayInWeek.Text = "היום בשבוע";
            // 
            // lblDayInMonth
            // 
            this.lblDayInMonth.AutoSize = true;
            this.lblDayInMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblDayInMonth.ForeColor = System.Drawing.Color.Black;
            this.lblDayInMonth.Location = new System.Drawing.Point(331, 116);
            this.lblDayInMonth.Name = "lblDayInMonth";
            this.lblDayInMonth.Size = new System.Drawing.Size(84, 16);
            this.lblDayInMonth.TabIndex = 2;
            this.lblDayInMonth.Text = "היום בחודש";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblMonth.ForeColor = System.Drawing.Color.Black;
            this.lblMonth.Location = new System.Drawing.Point(217, 116);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(41, 16);
            this.lblMonth.TabIndex = 3;
            this.lblMonth.Text = "חודש";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblYear.ForeColor = System.Drawing.Color.Black;
            this.lblYear.Location = new System.Drawing.Point(85, 116);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(32, 16);
            this.lblYear.TabIndex = 4;
            this.lblYear.Text = "שנה";
            // 
            // cmbxDayInWeek
            // 
            this.cmbxDayInWeek.ForeColor = System.Drawing.Color.Black;
            this.cmbxDayInWeek.FormattingEnabled = true;
            this.cmbxDayInWeek.Items.AddRange(new object[] {
            "ראשון",
            "שני",
            "שלישי",
            "רביעי",
            "חמישי",
            "ששי"});
            this.cmbxDayInWeek.Location = new System.Drawing.Point(460, 145);
            this.cmbxDayInWeek.Name = "cmbxDayInWeek";
            this.cmbxDayInWeek.Size = new System.Drawing.Size(103, 24);
            this.cmbxDayInWeek.TabIndex = 5;
            this.cmbxDayInWeek.Text = "ראשון";
            // 
            // cmbxDayInMonth
            // 
            this.cmbxDayInMonth.ForeColor = System.Drawing.Color.Black;
            this.cmbxDayInMonth.FormattingEnabled = true;
            this.cmbxDayInMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.cmbxDayInMonth.Location = new System.Drawing.Point(321, 145);
            this.cmbxDayInMonth.Name = "cmbxDayInMonth";
            this.cmbxDayInMonth.Size = new System.Drawing.Size(103, 24);
            this.cmbxDayInMonth.TabIndex = 6;
            this.cmbxDayInMonth.Text = "1";
            // 
            // cmbxMonth
            // 
            this.cmbxMonth.ForeColor = System.Drawing.Color.Black;
            this.cmbxMonth.FormattingEnabled = true;
            this.cmbxMonth.Items.AddRange(new object[] {
            "תשרי",
            "מרחשון",
            "כסלו",
            "טבת",
            "שבט",
            "אדר",
            "אדר הראשון",
            "אדר השני",
            "ניסן",
            "אייר",
            "סיון",
            "תמוז",
            "אב",
            "אלול"});
            this.cmbxMonth.Location = new System.Drawing.Point(184, 145);
            this.cmbxMonth.Name = "cmbxMonth";
            this.cmbxMonth.Size = new System.Drawing.Size(103, 24);
            this.cmbxMonth.TabIndex = 7;
            this.cmbxMonth.Text = "תשרי";
            // 
            // cmbxYear
            // 
            this.cmbxYear.ForeColor = System.Drawing.Color.Black;
            this.cmbxYear.FormattingEnabled = true;
            this.cmbxYear.Items.AddRange(new object[] {
            "תשפ\'ד",
            "תשפ\'ה",
            "תשפ\'ו",
            "תשפ\'ז",
            "תשפ\'ח",
            "תשפ\'ט",
            "תש\'ץ",
            "תשצ\'א",
            "תשצ\'ב",
            "תשצ\'ג"});
            this.cmbxYear.Location = new System.Drawing.Point(48, 145);
            this.cmbxYear.Name = "cmbxYear";
            this.cmbxYear.Size = new System.Drawing.Size(103, 24);
            this.cmbxYear.TabIndex = 8;
            this.cmbxYear.Text = "תשפ\'ד";
            // 
            // btnConforme
            // 
            this.btnConforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnConforme.ForeColor = System.Drawing.Color.Black;
            this.btnConforme.Location = new System.Drawing.Point(230, 286);
            this.btnConforme.Name = "btnConforme";
            this.btnConforme.Size = new System.Drawing.Size(146, 59);
            this.btnConforme.TabIndex = 9;
            this.btnConforme.Text = "בדיקה";
            this.btnConforme.UseVisualStyleBackColor = true;
            this.btnConforme.Click += new System.EventHandler(this.btnConforme_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(618, 450);
            this.Controls.Add(this.btnConforme);
            this.Controls.Add(this.cmbxYear);
            this.Controls.Add(this.cmbxMonth);
            this.Controls.Add(this.cmbxDayInMonth);
            this.Controls.Add(this.cmbxDayInWeek);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblDayInMonth);
            this.Controls.Add(this.lblDayInWeek);
            this.Controls.Add(this.lblDateTitle);
            this.Name = "Form1";
            this.Text = "כתיבת תאריך";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDateTitle;
        private System.Windows.Forms.Label lblDayInWeek;
        private System.Windows.Forms.Label lblDayInMonth;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cmbxDayInWeek;
        private System.Windows.Forms.ComboBox cmbxDayInMonth;
        private System.Windows.Forms.ComboBox cmbxMonth;
        private System.Windows.Forms.ComboBox cmbxYear;
        private System.Windows.Forms.Button btnConforme;
    }
}

