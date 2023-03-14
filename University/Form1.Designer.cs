namespace University
{
    partial class WelcomePage
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
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.Login_btn = new System.Windows.Forms.Button();
            this.userName = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ExitApp = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.ShowPass = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Nirmala UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.WelcomeLabel.Location = new System.Drawing.Point(124, 89);
            this.WelcomeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(314, 71);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Login Form";
            // 
            // Login_btn
            // 
            this.Login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.Login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_btn.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_btn.ForeColor = System.Drawing.Color.White;
            this.Login_btn.Location = new System.Drawing.Point(150, 480);
            this.Login_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(243, 77);
            this.Login_btn.TabIndex = 1;
            this.Login_btn.Text = "Sign-In";
            this.Login_btn.UseVisualStyleBackColor = false;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // userName
            // 
            this.userName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userName.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.userName.Location = new System.Drawing.Point(123, 245);
            this.userName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userName.Multiline = true;
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(297, 34);
            this.userName.TabIndex = 3;
            this.userName.TextChanged += new System.EventHandler(this.userName_TextChanged);
            // 
            // Password
            // 
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.Password.Location = new System.Drawing.Point(123, 360);
            this.Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Password.Multiline = true;
            this.Password.Name = "Password";
            this.Password.PasswordChar = '•';
            this.Password.Size = new System.Drawing.Size(297, 32);
            this.Password.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::University.Properties.Resources._8147182;
            this.pictureBox2.Location = new System.Drawing.Point(57, 352);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 58);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::University.Properties.Resources._123;
            this.pictureBox1.Location = new System.Drawing.Point(57, 235);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 58);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.panel1.Location = new System.Drawing.Point(123, 271);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 5);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.panel2.Location = new System.Drawing.Point(123, 385);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(297, 5);
            this.panel2.TabIndex = 8;
            // 
            // ExitApp
            // 
            this.ExitApp.BackColor = System.Drawing.Color.Plum;
            this.ExitApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitApp.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitApp.ForeColor = System.Drawing.Color.White;
            this.ExitApp.Location = new System.Drawing.Point(393, 652);
            this.ExitApp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExitApp.Name = "ExitApp";
            this.ExitApp.Size = new System.Drawing.Size(112, 40);
            this.ExitApp.TabIndex = 9;
            this.ExitApp.Text = "Exit";
            this.ExitApp.UseVisualStyleBackColor = false;
            this.ExitApp.Click += new System.EventHandler(this.ExitApp_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(132, 600);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(290, 23);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Don\'t Have An Account? Click Here";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // ShowPass
            // 
            this.ShowPass.AutoSize = true;
            this.ShowPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.ShowPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.ShowPass.Location = new System.Drawing.Point(354, 418);
            this.ShowPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ShowPass.Name = "ShowPass";
            this.ShowPass.Size = new System.Drawing.Size(155, 24);
            this.ShowPass.TabIndex = 11;
            this.ShowPass.Text = "Show Password";
            this.ShowPass.UseVisualStyleBackColor = true;
            this.ShowPass.CheckedChanged += new System.EventHandler(this.ShowPass_CheckedChanged);
            // 
            // WelcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(530, 725);
            this.Controls.Add(this.ShowPass);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.ExitApp);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.Login_btn);
            this.Controls.Add(this.WelcomeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "WelcomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ExitApp;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox ShowPass;
    }
}

