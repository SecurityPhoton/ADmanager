namespace ADmanager
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
            this.ButtonDo = new System.Windows.Forms.Button();
            this.ConsoleBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OUlabel = new System.Windows.Forms.Label();
            this.Domain = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MobileBox = new System.Windows.Forms.MaskedTextBox();
            this.WorkPhoneBox = new System.Windows.Forms.MaskedTextBox();
            this.DateTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.OUBox = new System.Windows.Forms.TextBox();
            this.DomainBox = new System.Windows.Forms.TextBox();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.GroupOUBox = new System.Windows.Forms.TextBox();
            this.GroupBox = new System.Windows.Forms.TextBox();
            this.ShortBox = new System.Windows.Forms.TextBox();
            this.SubDepBox = new System.Windows.Forms.TextBox();
            this.Dep2Box = new System.Windows.Forms.TextBox();
            this.DepartmentBox = new System.Windows.Forms.TextBox();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.PasswordConfirmBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SecondNameBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonDo
            // 
            this.ButtonDo.Location = new System.Drawing.Point(556, 317);
            this.ButtonDo.Name = "ButtonDo";
            this.ButtonDo.Size = new System.Drawing.Size(100, 23);
            this.ButtonDo.TabIndex = 0;
            this.ButtonDo.Text = "Add user";
            this.ButtonDo.UseVisualStyleBackColor = true;
            this.ButtonDo.Click += new System.EventHandler(this.ButtonDo_Click);
            // 
            // ConsoleBox
            // 
            this.ConsoleBox.Location = new System.Drawing.Point(12, 391);
            this.ConsoleBox.Multiline = true;
            this.ConsoleBox.Name = "ConsoleBox";
            this.ConsoleBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ConsoleBox.Size = new System.Drawing.Size(805, 84);
            this.ConsoleBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(433, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get domain name";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(674, 373);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.ButtonDo);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.OUlabel);
            this.tabPage1.Controls.Add(this.Domain);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.MobileBox);
            this.tabPage1.Controls.Add(this.WorkPhoneBox);
            this.tabPage1.Controls.Add(this.DateTextBox1);
            this.tabPage1.Controls.Add(this.OUBox);
            this.tabPage1.Controls.Add(this.DomainBox);
            this.tabPage1.Controls.Add(this.SecondNameBox);
            this.tabPage1.Controls.Add(this.SurnameBox);
            this.tabPage1.Controls.Add(this.GroupOUBox);
            this.tabPage1.Controls.Add(this.GroupBox);
            this.tabPage1.Controls.Add(this.ShortBox);
            this.tabPage1.Controls.Add(this.SubDepBox);
            this.tabPage1.Controls.Add(this.Dep2Box);
            this.tabPage1.Controls.Add(this.DepartmentBox);
            this.tabPage1.Controls.Add(this.TitleBox);
            this.tabPage1.Controls.Add(this.PasswordConfirmBox);
            this.tabPage1.Controls.Add(this.PasswordBox);
            this.tabPage1.Controls.Add(this.LoginBox);
            this.tabPage1.Controls.Add(this.NameBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(666, 347);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add user";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 298);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Mobile";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 272);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Work Phone";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Date of birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Short (ext3)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "SubDep (ext2)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Dep (ext1)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Department";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-2, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Confirm password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Login";
            // 
            // OUlabel
            // 
            this.OUlabel.AutoSize = true;
            this.OUlabel.Location = new System.Drawing.Point(273, 295);
            this.OUlabel.Name = "OUlabel";
            this.OUlabel.Size = new System.Drawing.Size(53, 13);
            this.OUlabel.TabIndex = 2;
            this.OUlabel.Text = "Users OU";
            // 
            // Domain
            // 
            this.Domain.AutoSize = true;
            this.Domain.Location = new System.Drawing.Point(273, 323);
            this.Domain.Name = "Domain";
            this.Domain.Size = new System.Drawing.Size(43, 13);
            this.Domain.TabIndex = 2;
            this.Domain.Text = "Domain";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name\\Surname";
            // 
            // MobileBox
            // 
            this.MobileBox.Location = new System.Drawing.Point(88, 295);
            this.MobileBox.Mask = "+38 999 000 00 00";
            this.MobileBox.Name = "MobileBox";
            this.MobileBox.Size = new System.Drawing.Size(100, 20);
            this.MobileBox.TabIndex = 1;
            // 
            // WorkPhoneBox
            // 
            this.WorkPhoneBox.Location = new System.Drawing.Point(88, 269);
            this.WorkPhoneBox.Mask = "+38 999 000 00 00";
            this.WorkPhoneBox.Name = "WorkPhoneBox";
            this.WorkPhoneBox.Size = new System.Drawing.Size(100, 20);
            this.WorkPhoneBox.TabIndex = 1;
            // 
            // DateTextBox1
            // 
            this.DateTextBox1.Location = new System.Drawing.Point(88, 243);
            this.DateTextBox1.Mask = "00/00/0000";
            this.DateTextBox1.Name = "DateTextBox1";
            this.DateTextBox1.Size = new System.Drawing.Size(100, 20);
            this.DateTextBox1.TabIndex = 1;
            this.DateTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // OUBox
            // 
            this.OUBox.Location = new System.Drawing.Point(332, 292);
            this.OUBox.Name = "OUBox";
            this.OUBox.Size = new System.Drawing.Size(309, 20);
            this.OUBox.TabIndex = 0;
            this.OUBox.Text = "cn=Users,dc=113tv,dc=com";
            // 
            // DomainBox
            // 
            this.DomainBox.Location = new System.Drawing.Point(332, 318);
            this.DomainBox.Name = "DomainBox";
            this.DomainBox.Size = new System.Drawing.Size(100, 20);
            this.DomainBox.TabIndex = 0;
            this.DomainBox.Text = "113tv.com";
            // 
            // SurnameBox
            // 
            this.SurnameBox.Location = new System.Drawing.Point(192, 6);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(100, 20);
            this.SurnameBox.TabIndex = 0;
            this.SurnameBox.Text = "Fry";
            // 
            // GroupOUBox
            // 
            this.GroupOUBox.Location = new System.Drawing.Point(289, 240);
            this.GroupOUBox.Name = "GroupOUBox";
            this.GroupOUBox.Size = new System.Drawing.Size(352, 20);
            this.GroupOUBox.TabIndex = 0;
            // 
            // GroupBox
            // 
            this.GroupBox.Location = new System.Drawing.Point(289, 266);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(352, 20);
            this.GroupBox.TabIndex = 0;
            // 
            // ShortBox
            // 
            this.ShortBox.Location = new System.Drawing.Point(88, 214);
            this.ShortBox.Name = "ShortBox";
            this.ShortBox.Size = new System.Drawing.Size(298, 20);
            this.ShortBox.TabIndex = 0;
            this.ShortBox.Text = "helpdesk engenner";
            // 
            // SubDepBox
            // 
            this.SubDepBox.Location = new System.Drawing.Point(88, 188);
            this.SubDepBox.Name = "SubDepBox";
            this.SubDepBox.Size = new System.Drawing.Size(298, 20);
            this.SubDepBox.TabIndex = 0;
            this.SubDepBox.Text = "second";
            // 
            // Dep2Box
            // 
            this.Dep2Box.Location = new System.Drawing.Point(88, 162);
            this.Dep2Box.Name = "Dep2Box";
            this.Dep2Box.Size = new System.Drawing.Size(298, 20);
            this.Dep2Box.TabIndex = 0;
            this.Dep2Box.Text = "helpdesk";
            // 
            // DepartmentBox
            // 
            this.DepartmentBox.Location = new System.Drawing.Point(88, 136);
            this.DepartmentBox.Name = "DepartmentBox";
            this.DepartmentBox.Size = new System.Drawing.Size(204, 20);
            this.DepartmentBox.TabIndex = 0;
            this.DepartmentBox.Text = "it dep";
            // 
            // TitleBox
            // 
            this.TitleBox.Location = new System.Drawing.Point(88, 110);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(204, 20);
            this.TitleBox.TabIndex = 0;
            this.TitleBox.Text = "engenner";
            // 
            // PasswordConfirmBox
            // 
            this.PasswordConfirmBox.Location = new System.Drawing.Point(88, 84);
            this.PasswordConfirmBox.MaxLength = 32;
            this.PasswordConfirmBox.Name = "PasswordConfirmBox";
            this.PasswordConfirmBox.PasswordChar = '*';
            this.PasswordConfirmBox.Size = new System.Drawing.Size(100, 20);
            this.PasswordConfirmBox.TabIndex = 0;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(88, 58);
            this.PasswordBox.MaxLength = 32;
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(100, 20);
            this.PasswordBox.TabIndex = 0;
            this.PasswordBox.Text = "P@ssw0rd";
            // 
            // LoginBox
            // 
            this.LoginBox.Location = new System.Drawing.Point(88, 32);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(100, 20);
            this.LoginBox.TabIndex = 0;
            this.LoginBox.Text = "a.fry";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(88, 6);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 20);
            this.NameBox.TabIndex = 0;
            this.NameBox.Text = "Arnold";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(666, 347);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modify user";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(692, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Get all groups";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(228, 243);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Group OU";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(228, 269);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Groups";
            // 
            // SecondNameBox
            // 
            this.SecondNameBox.Location = new System.Drawing.Point(298, 6);
            this.SecondNameBox.Name = "SecondNameBox";
            this.SecondNameBox.Size = new System.Drawing.Size(111, 20);
            this.SecondNameBox.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(737, 130);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 487);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ConsoleBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "AD Manager";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonDo;
        private System.Windows.Forms.TextBox ConsoleBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MobileBox;
        private System.Windows.Forms.MaskedTextBox WorkPhoneBox;
        private System.Windows.Forms.MaskedTextBox DateTextBox1;
        private System.Windows.Forms.TextBox OUBox;
        private System.Windows.Forms.TextBox DomainBox;
        private System.Windows.Forms.TextBox SurnameBox;
        private System.Windows.Forms.TextBox GroupOUBox;
        private System.Windows.Forms.TextBox GroupBox;
        private System.Windows.Forms.TextBox SubDepBox;
        private System.Windows.Forms.TextBox Dep2Box;
        private System.Windows.Forms.TextBox DepartmentBox;
        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.TextBox PasswordConfirmBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ShortBox;
        private System.Windows.Forms.Label Domain;
        private System.Windows.Forms.Label OUlabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox SecondNameBox;
        private System.Windows.Forms.Button button3;
    }
}

