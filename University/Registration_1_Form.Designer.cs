namespace University
{
    partial class Account
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
            this.FirstName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Pass_lbl = new System.Windows.Forms.Label();
            this.conPass_lbl = new System.Windows.Forms.Label();
            this.Pass_txt = new System.Windows.Forms.TextBox();
            this.conPass_txt = new System.Windows.Forms.TextBox();
            this.userName_lbl = new System.Windows.Forms.Label();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.showPass = new System.Windows.Forms.CheckBox();
            this.Acc_btn = new System.Windows.Forms.Button();
            this.persInfo = new System.Windows.Forms.Button();
            this.nextPage = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.studentCheck = new System.Windows.Forms.CheckBox();
            this.lecturerCheck = new System.Windows.Forms.CheckBox();
            this.passCheck = new System.Windows.Forms.Label();
            this.redPanel = new System.Windows.Forms.Panel();
            this.orangePanel = new System.Windows.Forms.Panel();
            this.greenPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FirstName
            // 
            this.FirstName.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.FirstName.Location = new System.Drawing.Point(26, 165);
            this.FirstName.Multiline = true;
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(175, 23);
            this.FirstName.TabIndex = 0;
            // 
            // LastName
            // 
            this.LastName.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 8.25F);
            this.LastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.LastName.Location = new System.Drawing.Point(291, 165);
            this.LastName.Multiline = true;
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(175, 23);
            this.LastName.TabIndex = 1;
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 8.25F);
            this.Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.Email.Location = new System.Drawing.Point(24, 225);
            this.Email.Multiline = true;
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(442, 23);
            this.Email.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(24, 285);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(273, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.cancel_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.ForeColor = System.Drawing.Color.White;
            this.cancel_btn.Location = new System.Drawing.Point(368, 595);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(97, 29);
            this.cancel_btn.TabIndex = 6;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(23, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(288, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enter Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Location = new System.Drawing.Point(23, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Enter E-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Location = new System.Drawing.Point(23, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Enter Birth Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label5.Location = new System.Drawing.Point(23, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Selcet Your Role:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label6.Location = new System.Drawing.Point(74, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(332, 33);
            this.label6.TabIndex = 12;
            this.label6.Text = "REGISTRATION FORM";
            // 
            // Pass_lbl
            // 
            this.Pass_lbl.AutoSize = true;
            this.Pass_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass_lbl.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Pass_lbl.Location = new System.Drawing.Point(288, 385);
            this.Pass_lbl.Name = "Pass_lbl";
            this.Pass_lbl.Size = new System.Drawing.Size(111, 15);
            this.Pass_lbl.TabIndex = 13;
            this.Pass_lbl.Text = "Enter Password:";
            // 
            // conPass_lbl
            // 
            this.conPass_lbl.AutoSize = true;
            this.conPass_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conPass_lbl.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.conPass_lbl.Location = new System.Drawing.Point(286, 464);
            this.conPass_lbl.Name = "conPass_lbl";
            this.conPass_lbl.Size = new System.Drawing.Size(127, 15);
            this.conPass_lbl.TabIndex = 14;
            this.conPass_lbl.Text = "Confirm Password:";
            // 
            // Pass_txt
            // 
            this.Pass_txt.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.Pass_txt.Location = new System.Drawing.Point(291, 410);
            this.Pass_txt.Multiline = true;
            this.Pass_txt.Name = "Pass_txt";
            this.Pass_txt.PasswordChar = '•';
            this.Pass_txt.Size = new System.Drawing.Size(175, 23);
            this.Pass_txt.TabIndex = 15;
            this.Pass_txt.TextChanged += new System.EventHandler(this.Pass_txt_TextChanged);
            // 
            // conPass_txt
            // 
            this.conPass_txt.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conPass_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.conPass_txt.Location = new System.Drawing.Point(290, 489);
            this.conPass_txt.Multiline = true;
            this.conPass_txt.Name = "conPass_txt";
            this.conPass_txt.PasswordChar = '•';
            this.conPass_txt.Size = new System.Drawing.Size(175, 23);
            this.conPass_txt.TabIndex = 16;
            // 
            // userName_lbl
            // 
            this.userName_lbl.AutoSize = true;
            this.userName_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName_lbl.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.userName_lbl.Location = new System.Drawing.Point(23, 385);
            this.userName_lbl.Name = "userName_lbl";
            this.userName_lbl.Size = new System.Drawing.Size(117, 15);
            this.userName_lbl.TabIndex = 17;
            this.userName_lbl.Text = "Enter UserName:";
            // 
            // username_txt
            // 
            this.username_txt.BackColor = System.Drawing.Color.White;
            this.username_txt.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 8.25F);
            this.username_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.username_txt.Location = new System.Drawing.Point(24, 410);
            this.username_txt.Multiline = true;
            this.username_txt.Name = "username_txt";
            this.username_txt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.username_txt.Size = new System.Drawing.Size(175, 23);
            this.username_txt.TabIndex = 18;
            // 
            // showPass
            // 
            this.showPass.AutoSize = true;
            this.showPass.Font = new System.Drawing.Font("Verdana Pro Cond", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.showPass.Location = new System.Drawing.Point(175, 494);
            this.showPass.Name = "showPass";
            this.showPass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.showPass.Size = new System.Drawing.Size(101, 17);
            this.showPass.TabIndex = 19;
            this.showPass.Text = "Show Password";
            this.showPass.UseVisualStyleBackColor = true;
            this.showPass.CheckedChanged += new System.EventHandler(this.showPass_CheckedChanged);
            // 
            // Acc_btn
            // 
            this.Acc_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.Acc_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Acc_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Acc_btn.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Acc_btn.ForeColor = System.Drawing.Color.White;
            this.Acc_btn.Location = new System.Drawing.Point(24, 73);
            this.Acc_btn.Name = "Acc_btn";
            this.Acc_btn.Size = new System.Drawing.Size(221, 42);
            this.Acc_btn.TabIndex = 20;
            this.Acc_btn.Text = "Account";
            this.Acc_btn.UseVisualStyleBackColor = false;
            // 
            // persInfo
            // 
            this.persInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.persInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.persInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.persInfo.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.persInfo.ForeColor = System.Drawing.Color.White;
            this.persInfo.Location = new System.Drawing.Point(244, 73);
            this.persInfo.Name = "persInfo";
            this.persInfo.Size = new System.Drawing.Size(221, 42);
            this.persInfo.TabIndex = 21;
            this.persInfo.Text = "Additional Info";
            this.persInfo.UseVisualStyleBackColor = false;
            this.persInfo.Click += new System.EventHandler(this.persInfo_Click);
            // 
            // nextPage
            // 
            this.nextPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.nextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextPage.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextPage.ForeColor = System.Drawing.Color.White;
            this.nextPage.Location = new System.Drawing.Point(115, 527);
            this.nextPage.Name = "nextPage";
            this.nextPage.Size = new System.Drawing.Size(241, 51);
            this.nextPage.TabIndex = 22;
            this.nextPage.Text = "Next";
            this.nextPage.UseVisualStyleBackColor = false;
            this.nextPage.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button2.Location = new System.Drawing.Point(12, 595);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 29);
            this.button2.TabIndex = 23;
            this.button2.Text = "Back To Login Page";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // studentCheck
            // 
            this.studentCheck.AutoSize = true;
            this.studentCheck.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.studentCheck.Location = new System.Drawing.Point(26, 355);
            this.studentCheck.Name = "studentCheck";
            this.studentCheck.Size = new System.Drawing.Size(71, 19);
            this.studentCheck.TabIndex = 24;
            this.studentCheck.Text = "Student";
            this.studentCheck.UseVisualStyleBackColor = true;
            this.studentCheck.CheckedChanged += new System.EventHandler(this.studentCheck_CheckedChanged);
            // 
            // lecturerCheck
            // 
            this.lecturerCheck.AutoSize = true;
            this.lecturerCheck.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecturerCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.lecturerCheck.Location = new System.Drawing.Point(115, 355);
            this.lecturerCheck.Name = "lecturerCheck";
            this.lecturerCheck.Size = new System.Drawing.Size(74, 19);
            this.lecturerCheck.TabIndex = 25;
            this.lecturerCheck.Text = "Lecturer";
            this.lecturerCheck.UseVisualStyleBackColor = true;
            this.lecturerCheck.CheckedChanged += new System.EventHandler(this.lecturerCheck_CheckedChanged);
            // 
            // passCheck
            // 
            this.passCheck.AutoSize = true;
            this.passCheck.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passCheck.Location = new System.Drawing.Point(288, 448);
            this.passCheck.Name = "passCheck";
            this.passCheck.Size = new System.Drawing.Size(0, 13);
            this.passCheck.TabIndex = 26;
            this.passCheck.Click += new System.EventHandler(this.passCheck_Click);
            // 
            // redPanel
            // 
            this.redPanel.Location = new System.Drawing.Point(291, 439);
            this.redPanel.Name = "redPanel";
            this.redPanel.Size = new System.Drawing.Size(58, 5);
            this.redPanel.TabIndex = 27;
            // 
            // orangePanel
            // 
            this.orangePanel.Location = new System.Drawing.Point(349, 439);
            this.orangePanel.Name = "orangePanel";
            this.orangePanel.Size = new System.Drawing.Size(58, 5);
            this.orangePanel.TabIndex = 28;
            // 
            // greenPanel
            // 
            this.greenPanel.Location = new System.Drawing.Point(407, 439);
            this.greenPanel.Name = "greenPanel";
            this.greenPanel.Size = new System.Drawing.Size(58, 5);
            this.greenPanel.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(312, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "label7";
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(491, 636);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.greenPanel);
            this.Controls.Add(this.orangePanel);
            this.Controls.Add(this.redPanel);
            this.Controls.Add(this.passCheck);
            this.Controls.Add(this.lecturerCheck);
            this.Controls.Add(this.studentCheck);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.nextPage);
            this.Controls.Add(this.persInfo);
            this.Controls.Add(this.Acc_btn);
            this.Controls.Add(this.showPass);
            this.Controls.Add(this.username_txt);
            this.Controls.Add(this.userName_lbl);
            this.Controls.Add(this.conPass_txt);
            this.Controls.Add(this.Pass_txt);
            this.Controls.Add(this.conPass_lbl);
            this.Controls.Add(this.Pass_lbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account_Page";
            this.Load += new System.EventHandler(this.Account_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Pass_lbl;
        private System.Windows.Forms.Label conPass_lbl;
        private System.Windows.Forms.TextBox Pass_txt;
        private System.Windows.Forms.TextBox conPass_txt;
        private System.Windows.Forms.Label userName_lbl;
        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.CheckBox showPass;
        private System.Windows.Forms.Button Acc_btn;
        private System.Windows.Forms.Button persInfo;
        private System.Windows.Forms.Button nextPage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox studentCheck;
        private System.Windows.Forms.CheckBox lecturerCheck;
        private System.Windows.Forms.Label passCheck;
        private System.Windows.Forms.Panel redPanel;
        private System.Windows.Forms.Panel orangePanel;
        private System.Windows.Forms.Panel greenPanel;
        private System.Windows.Forms.Label label7;
    }
}