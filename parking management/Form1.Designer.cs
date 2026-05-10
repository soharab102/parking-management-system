namespace parking_management
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.vehicleNo = new System.Windows.Forms.Label();
            this.enter = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxTotalCost = new System.Windows.Forms.TextBox();
            this.startTime = new System.Windows.Forms.Label();
            this.totalCost = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.paymentMethod = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.confirm = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.vehicleNo);
            this.panel1.Controls.Add(this.enter);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(36, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 108);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // vehicleNo
            // 
            this.vehicleNo.AutoSize = true;
            this.vehicleNo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleNo.Location = new System.Drawing.Point(19, 38);
            this.vehicleNo.Name = "vehicleNo";
            this.vehicleNo.Size = new System.Drawing.Size(125, 23);
            this.vehicleNo.TabIndex = 0;
            this.vehicleNo.Text = "Vehicle No :\r\n";
            // 
            // enter
            // 
            this.enter.BackColor = System.Drawing.Color.DimGray;
            this.enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter.ForeColor = System.Drawing.Color.White;
            this.enter.Location = new System.Drawing.Point(765, 39);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(83, 30);
            this.enter.TabIndex = 4;
            this.enter.Text = "Enter";
            this.enter.UseVisualStyleBackColor = false;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(164, 36);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(584, 36);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.textBoxTotalCost);
            this.panel2.Controls.Add(this.startTime);
            this.panel2.Controls.Add(this.totalCost);
            this.panel2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(36, 322);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(495, 262);
            this.panel2.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Location = new System.Drawing.Point(67, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calculate your total Cost";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(67, 54);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(375, 31);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
            // 
            // textBoxTotalCost
            // 
            this.textBoxTotalCost.Location = new System.Drawing.Point(67, 200);
            this.textBoxTotalCost.Multiline = true;
            this.textBoxTotalCost.Name = "textBoxTotalCost";
            this.textBoxTotalCost.Size = new System.Drawing.Size(250, 37);
            this.textBoxTotalCost.TabIndex = 5;
            // 
            // startTime
            // 
            this.startTime.AutoSize = true;
            this.startTime.Location = new System.Drawing.Point(63, 15);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(114, 23);
            this.startTime.TabIndex = 0;
            this.startTime.Text = "Exit Time : \r\n";
            // 
            // totalCost
            // 
            this.totalCost.AutoSize = true;
            this.totalCost.Location = new System.Drawing.Point(63, 169);
            this.totalCost.Name = "totalCost";
            this.totalCost.Size = new System.Drawing.Size(125, 23);
            this.totalCost.TabIndex = 0;
            this.totalCost.Text = "Total Cost  :\r\n";
            this.totalCost.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.paymentMethod);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.confirm);
            this.panel3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(554, 322);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(401, 262);
            this.panel3.TabIndex = 7;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(74, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 42);
            this.button2.TabIndex = 4;
            this.button2.Text = "CENCEL";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // paymentMethod
            // 
            this.paymentMethod.AutoSize = true;
            this.paymentMethod.Location = new System.Drawing.Point(70, 34);
            this.paymentMethod.Name = "paymentMethod";
            this.paymentMethod.Size = new System.Drawing.Size(250, 23);
            this.paymentMethod.TabIndex = 0;
            this.paymentMethod.Text = "Select Payment Method :";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Info;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(74, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(270, 31);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // confirm
            // 
            this.confirm.BackColor = System.Drawing.Color.LimeGreen;
            this.confirm.ForeColor = System.Drawing.Color.White;
            this.confirm.Location = new System.Drawing.Point(224, 139);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(120, 42);
            this.confirm.TabIndex = 2;
            this.confirm.Text = "CONFIRM";
            this.confirm.UseVisualStyleBackColor = false;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.Location = new System.Drawing.Point(36, 248);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(919, 50);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(351, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "User current data";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Location = new System.Drawing.Point(24, 81);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(996, 622);
            this.panel4.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SeaGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(362, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 36);
            this.label3.TabIndex = 11;
            this.label3.Text = "MAKE PAYMENT";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkCyan;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1105, 52);
            this.panel5.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(385, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Parking Management System";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1062, 753);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label vehicleNo;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxTotalCost;
        private System.Windows.Forms.Label startTime;
        private System.Windows.Forms.Label totalCost;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label paymentMethod;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

