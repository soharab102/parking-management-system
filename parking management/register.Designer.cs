namespace parking_management
{
    partial class register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.registerButtom = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.repeatPassword = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.Location = new System.Drawing.Point(184, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(343, 30);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox2.Location = new System.Drawing.Point(184, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(343, 30);
            this.textBox2.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox3.Location = new System.Drawing.Point(184, 107);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(343, 30);
            this.textBox3.TabIndex = 0;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Window;
            this.textBox4.Location = new System.Drawing.Point(184, 153);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(343, 30);
            this.textBox4.TabIndex = 0;
            // 
            // registerButtom
            // 
            this.registerButtom.BackColor = System.Drawing.Color.Lime;
            this.registerButtom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButtom.ForeColor = System.Drawing.Color.Black;
            this.registerButtom.Location = new System.Drawing.Point(18, 245);
            this.registerButtom.Name = "registerButtom";
            this.registerButtom.Size = new System.Drawing.Size(515, 34);
            this.registerButtom.TabIndex = 1;
            this.registerButtom.Text = "Register";
            this.registerButtom.UseVisualStyleBackColor = false;
            this.registerButtom.Click += new System.EventHandler(this.registerButtom_Click);
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.Red;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.Cornsilk;
            this.login.Location = new System.Drawing.Point(18, 330);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(515, 34);
            this.login.TabIndex = 1;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.ForeColor = System.Drawing.Color.White;
            this.username.Location = new System.Drawing.Point(2, 24);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(102, 25);
            this.username.TabIndex = 2;
            this.username.Text = "Username";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.ForeColor = System.Drawing.Color.White;
            this.email.Location = new System.Drawing.Point(2, 66);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(60, 25);
            this.email.TabIndex = 2;
            this.email.Text = "Email";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.ForeColor = System.Drawing.Color.White;
            this.password.Location = new System.Drawing.Point(2, 112);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(98, 25);
            this.password.TabIndex = 2;
            this.password.Text = "Password";
            // 
            // repeatPassword
            // 
            this.repeatPassword.AutoSize = true;
            this.repeatPassword.ForeColor = System.Drawing.Color.White;
            this.repeatPassword.Location = new System.Drawing.Point(2, 156);
            this.repeatPassword.Name = "repeatPassword";
            this.repeatPassword.Size = new System.Drawing.Size(165, 25);
            this.repeatPassword.TabIndex = 2;
            this.repeatPassword.Text = "Repeat Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(152, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Have an  accoount? LOGIN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.repeatPassword);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(10, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 197);
            this.panel1.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.White;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(505, 115);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(14, 13);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-39, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(524, 729);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vrinda", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(665, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 51);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome to";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.login);
            this.panel2.Controls.Add(this.registerButtom);
            this.panel2.Location = new System.Drawing.Point(491, 200);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(554, 391);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(124, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 57);
            this.label2.TabIndex = 4;
            this.label2.Text = "PARKING ";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(67, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(325, 57);
            this.label3.TabIndex = 4;
            this.label3.Text = "MANAGEMENT";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Cornsilk;
            this.label5.Location = new System.Drawing.Point(132, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 57);
            this.label5.TabIndex = 4;
            this.label5.Text = "SYSTEM";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Vrinda", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Cornsilk;
            this.label6.Location = new System.Drawing.Point(619, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(298, 51);
            this.label6.TabIndex = 4;
            this.label6.Text = "Registration page";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(11, 252);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(463, 180);
            this.panel3.TabIndex = 6;
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1062, 753);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "register";
            this.Load += new System.EventHandler(this.register_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button registerButtom;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label repeatPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
    }
}