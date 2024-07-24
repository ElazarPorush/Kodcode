namespace CoffeeMachine
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.lblShuger = new System.Windows.Forms.Label();
            this.lblCoffee = new System.Windows.Forms.Label();
            this.lblmilk = new System.Windows.Forms.Label();
            this.lblCackahu = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbtxtShuger = new System.Windows.Forms.ComboBox();
            this.cmbtxtCoffee = new System.Windows.Forms.ComboBox();
            this.cmbtxtMilk = new System.Windows.Forms.ComboBox();
            this.cmbtxtCackau = new System.Windows.Forms.ComboBox();
            this.txtbxPrice = new System.Windows.Forms.TextBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.שם = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.סוכר = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.קפה = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.חלב = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.קקאו = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.מחיר = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblName.Location = new System.Drawing.Point(629, 60);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(80, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "שם השתייה";
            // 
            // txtbxName
            // 
            this.txtbxName.Location = new System.Drawing.Point(516, 57);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(100, 22);
            this.txtbxName.TabIndex = 1;
            this.txtbxName.TextChanged += new System.EventHandler(this.txtbxName_TextChanged);
            // 
            // lblShuger
            // 
            this.lblShuger.AutoSize = true;
            this.lblShuger.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblShuger.Location = new System.Drawing.Point(671, 134);
            this.lblShuger.Name = "lblShuger";
            this.lblShuger.Size = new System.Drawing.Size(38, 16);
            this.lblShuger.TabIndex = 2;
            this.lblShuger.Text = "סוכר";
            // 
            // lblCoffee
            // 
            this.lblCoffee.AutoSize = true;
            this.lblCoffee.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblCoffee.Location = new System.Drawing.Point(558, 135);
            this.lblCoffee.Name = "lblCoffee";
            this.lblCoffee.Size = new System.Drawing.Size(32, 16);
            this.lblCoffee.TabIndex = 3;
            this.lblCoffee.Text = "קפה";
            // 
            // lblmilk
            // 
            this.lblmilk.AutoSize = true;
            this.lblmilk.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblmilk.Location = new System.Drawing.Point(462, 135);
            this.lblmilk.Name = "lblmilk";
            this.lblmilk.Size = new System.Drawing.Size(34, 16);
            this.lblmilk.TabIndex = 4;
            this.lblmilk.Text = "חלב";
            // 
            // lblCackahu
            // 
            this.lblCackahu.AutoSize = true;
            this.lblCackahu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblCackahu.Location = new System.Drawing.Point(361, 134);
            this.lblCackahu.Name = "lblCackahu";
            this.lblCackahu.Size = new System.Drawing.Size(38, 16);
            this.lblCackahu.TabIndex = 5;
            this.lblCackahu.Text = "קקאו";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPrice.Location = new System.Drawing.Point(267, 134);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(39, 16);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "מחיר";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAdd.Location = new System.Drawing.Point(101, 268);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 51);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "הוספה";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnUpdate.Location = new System.Drawing.Point(12, 349);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 51);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "עדכון";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSave.Location = new System.Drawing.Point(12, 268);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 51);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "שמירה";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbtxtShuger
            // 
            this.cmbtxtShuger.FormattingEnabled = true;
            this.cmbtxtShuger.Items.AddRange(new object[] {
            "0",
            "0.5",
            "1",
            "1.5",
            "2",
            "2.5",
            "3",
            "3.5",
            "4"});
            this.cmbtxtShuger.Location = new System.Drawing.Point(659, 165);
            this.cmbtxtShuger.Name = "cmbtxtShuger";
            this.cmbtxtShuger.Size = new System.Drawing.Size(58, 24);
            this.cmbtxtShuger.TabIndex = 10;
            this.cmbtxtShuger.Text = "0.5";
            // 
            // cmbtxtCoffee
            // 
            this.cmbtxtCoffee.FormattingEnabled = true;
            this.cmbtxtCoffee.Items.AddRange(new object[] {
            "0",
            "0.5",
            "1",
            "1.5",
            "2",
            "2.5",
            "3",
            "3.5",
            "4"});
            this.cmbtxtCoffee.Location = new System.Drawing.Point(554, 164);
            this.cmbtxtCoffee.Name = "cmbtxtCoffee";
            this.cmbtxtCoffee.Size = new System.Drawing.Size(62, 24);
            this.cmbtxtCoffee.TabIndex = 11;
            this.cmbtxtCoffee.Text = "0.5";
            // 
            // cmbtxtMilk
            // 
            this.cmbtxtMilk.FormattingEnabled = true;
            this.cmbtxtMilk.Items.AddRange(new object[] {
            "0",
            "0.5",
            "1",
            "1.5",
            "2",
            "2.5",
            "3",
            "3.5",
            "4"});
            this.cmbtxtMilk.Location = new System.Drawing.Point(456, 164);
            this.cmbtxtMilk.Name = "cmbtxtMilk";
            this.cmbtxtMilk.Size = new System.Drawing.Size(56, 24);
            this.cmbtxtMilk.TabIndex = 12;
            this.cmbtxtMilk.Text = "0.5";
            // 
            // cmbtxtCackau
            // 
            this.cmbtxtCackau.FormattingEnabled = true;
            this.cmbtxtCackau.Items.AddRange(new object[] {
            "0",
            "0.5",
            "1",
            "1.5",
            "2",
            "2.5",
            "3",
            "3.5",
            "4"});
            this.cmbtxtCackau.Location = new System.Drawing.Point(356, 164);
            this.cmbtxtCackau.Name = "cmbtxtCackau";
            this.cmbtxtCackau.Size = new System.Drawing.Size(55, 24);
            this.cmbtxtCackau.TabIndex = 13;
            this.cmbtxtCackau.Text = "0.5";
            // 
            // txtbxPrice
            // 
            this.txtbxPrice.Location = new System.Drawing.Point(260, 165);
            this.txtbxPrice.Name = "txtbxPrice";
            this.txtbxPrice.ReadOnly = true;
            this.txtbxPrice.Size = new System.Drawing.Size(57, 22);
            this.txtbxPrice.TabIndex = 14;
            this.txtbxPrice.Text = "4";
            // 
            // btnUp
            // 
            this.btnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnUp.Location = new System.Drawing.Point(217, 151);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(23, 23);
            this.btnUp.TabIndex = 15;
            this.btnUp.Text = "+";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnDown.Location = new System.Drawing.Point(217, 180);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(23, 23);
            this.btnDown.TabIndex = 16;
            this.btnDown.Text = "-";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.שם,
            this.סוכר,
            this.קפה,
            this.חלב,
            this.קקאו,
            this.מחיר});
            this.dataGridView1.Location = new System.Drawing.Point(199, 224);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(518, 207);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // שם
            // 
            this.שם.HeaderText = "שם";
            this.שם.MinimumWidth = 6;
            this.שם.Name = "שם";
            this.שם.Width = 60;
            // 
            // סוכר
            // 
            this.סוכר.HeaderText = "סוכר";
            this.סוכר.MinimumWidth = 6;
            this.סוכר.Name = "סוכר";
            this.סוכר.Width = 55;
            // 
            // קפה
            // 
            this.קפה.HeaderText = "קפה";
            this.קפה.MinimumWidth = 6;
            this.קפה.Name = "קפה";
            this.קפה.Width = 55;
            // 
            // חלב
            // 
            this.חלב.HeaderText = "חלב";
            this.חלב.MinimumWidth = 6;
            this.חלב.Name = "חלב";
            this.חלב.Width = 55;
            // 
            // קקאו
            // 
            this.קקאו.HeaderText = "קקאו";
            this.קקאו.MinimumWidth = 6;
            this.קקאו.Name = "קקאו";
            this.קקאו.Width = 55;
            // 
            // מחיר
            // 
            this.מחיר.HeaderText = "מחיר";
            this.מחיר.MinimumWidth = 6;
            this.מחיר.Name = "מחיר";
            this.מחיר.Width = 55;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnDelete.Location = new System.Drawing.Point(101, 349);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 51);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "מחיקה";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 501);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.txtbxPrice);
            this.Controls.Add(this.cmbtxtCackau);
            this.Controls.Add(this.cmbtxtMilk);
            this.Controls.Add(this.cmbtxtCoffee);
            this.Controls.Add(this.cmbtxtShuger);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblCackahu);
            this.Controls.Add(this.lblmilk);
            this.Controls.Add(this.lblCoffee);
            this.Controls.Add(this.lblShuger);
            this.Controls.Add(this.txtbxName);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "מכונת שתייה";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.Label lblShuger;
        private System.Windows.Forms.Label lblCoffee;
        private System.Windows.Forms.Label lblmilk;
        private System.Windows.Forms.Label lblCackahu;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbtxtShuger;
        private System.Windows.Forms.ComboBox cmbtxtCoffee;
        private System.Windows.Forms.ComboBox cmbtxtMilk;
        private System.Windows.Forms.ComboBox cmbtxtCackau;
        private System.Windows.Forms.TextBox txtbxPrice;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn שם;
        private System.Windows.Forms.DataGridViewTextBoxColumn סוכר;
        private System.Windows.Forms.DataGridViewTextBoxColumn קפה;
        private System.Windows.Forms.DataGridViewTextBoxColumn חלב;
        private System.Windows.Forms.DataGridViewTextBoxColumn קקאו;
        private System.Windows.Forms.DataGridViewTextBoxColumn מחיר;
    }
}

