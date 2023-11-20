namespace University
{
    partial class Dashboard_Lecturer
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.roleLecturer = new System.Windows.Forms.Label();
            this.lectName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.settingsPanel = new System.Windows.Forms.Button();
            this.studentClasses = new System.Windows.Forms.Button();
            this.academicRegistration = new System.Windows.Forms.Button();
            this.personalInfo = new System.Windows.Forms.Button();
            this.lectSubjects = new System.Windows.Forms.DataGridView();
            this.universityDataSet = new University.UniversityDataSet();
            this.universityDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lectDetailedGrid = new System.Windows.Forms.DataGridView();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.homeWorkBox = new System.Windows.Forms.TextBox();
            this.midtermBox = new System.Windows.Forms.TextBox();
            this.finalBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectSubjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectDetailedGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(196)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.roleLecturer);
            this.panel1.Controls.Add(this.lectName);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.settingsPanel);
            this.panel1.Controls.Add(this.studentClasses);
            this.panel1.Controls.Add(this.academicRegistration);
            this.panel1.Controls.Add(this.personalInfo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 692);
            this.panel1.TabIndex = 1;
            // 
            // roleLecturer
            // 
            this.roleLecturer.AutoSize = true;
            this.roleLecturer.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleLecturer.ForeColor = System.Drawing.Color.White;
            this.roleLecturer.Location = new System.Drawing.Point(92, 174);
            this.roleLecturer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roleLecturer.Name = "roleLecturer";
            this.roleLecturer.Size = new System.Drawing.Size(90, 28);
            this.roleLecturer.TabIndex = 7;
            this.roleLecturer.Text = "Lecturer";
            // 
            // lectName
            // 
            this.lectName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lectName.ForeColor = System.Drawing.Color.White;
            this.lectName.Location = new System.Drawing.Point(44, 134);
            this.lectName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lectName.Name = "lectName";
            this.lectName.Size = new System.Drawing.Size(184, 35);
            this.lectName.TabIndex = 6;
            this.lectName.Text = "Lecturer Name";
            this.lectName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::University.Properties.Resources.userIcon1;
            this.pictureBox1.Location = new System.Drawing.Point(68, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // settingsPanel
            // 
            this.settingsPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsPanel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsPanel.ForeColor = System.Drawing.Color.White;
            this.settingsPanel.Location = new System.Drawing.Point(0, 552);
            this.settingsPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(273, 62);
            this.settingsPanel.TabIndex = 4;
            this.settingsPanel.Text = "Settings";
            this.settingsPanel.UseVisualStyleBackColor = true;
            // 
            // studentClasses
            // 
            this.studentClasses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentClasses.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentClasses.ForeColor = System.Drawing.Color.White;
            this.studentClasses.Location = new System.Drawing.Point(0, 443);
            this.studentClasses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.studentClasses.Name = "studentClasses";
            this.studentClasses.Size = new System.Drawing.Size(273, 62);
            this.studentClasses.TabIndex = 2;
            this.studentClasses.Text = "My Classes";
            this.studentClasses.UseVisualStyleBackColor = true;
            // 
            // academicRegistration
            // 
            this.academicRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.academicRegistration.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.academicRegistration.ForeColor = System.Drawing.Color.White;
            this.academicRegistration.Location = new System.Drawing.Point(0, 334);
            this.academicRegistration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.academicRegistration.Name = "academicRegistration";
            this.academicRegistration.Size = new System.Drawing.Size(273, 62);
            this.academicRegistration.TabIndex = 1;
            this.academicRegistration.Text = "Academic Registration";
            this.academicRegistration.UseVisualStyleBackColor = true;
            // 
            // personalInfo
            // 
            this.personalInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personalInfo.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalInfo.ForeColor = System.Drawing.Color.White;
            this.personalInfo.Location = new System.Drawing.Point(0, 225);
            this.personalInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.personalInfo.Name = "personalInfo";
            this.personalInfo.Size = new System.Drawing.Size(273, 62);
            this.personalInfo.TabIndex = 0;
            this.personalInfo.Text = "Personal Info";
            this.personalInfo.UseVisualStyleBackColor = true;
            // 
            // lectSubjects
            // 
            this.lectSubjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.lectSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lectSubjects.Location = new System.Drawing.Point(320, 93);
            this.lectSubjects.Name = "lectSubjects";
            this.lectSubjects.RowHeadersWidth = 62;
            this.lectSubjects.RowTemplate.Height = 28;
            this.lectSubjects.Size = new System.Drawing.Size(617, 179);
            this.lectSubjects.TabIndex = 2;
            this.lectSubjects.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lectSubjects_CellClick);
            // 
            // universityDataSet
            // 
            this.universityDataSet.DataSetName = "UniversityDataSet";
            this.universityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // universityDataSetBindingSource
            // 
            this.universityDataSetBindingSource.DataSource = this.universityDataSet;
            this.universityDataSetBindingSource.Position = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(196)))), ((int)(((byte)(57)))));
            this.label1.Location = new System.Drawing.Point(563, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Classes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(196)))), ((int)(((byte)(57)))));
            this.label2.Location = new System.Drawing.Point(566, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 45);
            this.label2.TabIndex = 4;
            this.label2.Text = "Details";
            // 
            // lectDetailedGrid
            // 
            this.lectDetailedGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lectDetailedGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.lectDetailedGrid.Location = new System.Drawing.Point(310, 351);
            this.lectDetailedGrid.Name = "lectDetailedGrid";
            this.lectDetailedGrid.RowHeadersWidth = 62;
            this.lectDetailedGrid.RowTemplate.Height = 28;
            this.lectDetailedGrid.Size = new System.Drawing.Size(617, 221);
            this.lectDetailedGrid.TabIndex = 5;
            this.lectDetailedGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lectDetailedGrid_CellClick);
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.SystemColors.HotTrack;
            this.nameBox.Location = new System.Drawing.Point(1168, 93);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(183, 26);
            this.nameBox.TabIndex = 6;
            // 
            // homeWorkBox
            // 
            this.homeWorkBox.BackColor = System.Drawing.SystemColors.HotTrack;
            this.homeWorkBox.Location = new System.Drawing.Point(1168, 192);
            this.homeWorkBox.Name = "homeWorkBox";
            this.homeWorkBox.Size = new System.Drawing.Size(183, 26);
            this.homeWorkBox.TabIndex = 7;
            // 
            // midtermBox
            // 
            this.midtermBox.BackColor = System.Drawing.SystemColors.HotTrack;
            this.midtermBox.Location = new System.Drawing.Point(1168, 290);
            this.midtermBox.Name = "midtermBox";
            this.midtermBox.Size = new System.Drawing.Size(183, 26);
            this.midtermBox.TabIndex = 8;
            // 
            // finalBox
            // 
            this.finalBox.BackColor = System.Drawing.SystemColors.HotTrack;
            this.finalBox.Location = new System.Drawing.Point(1168, 385);
            this.finalBox.Name = "finalBox";
            this.finalBox.Size = new System.Drawing.Size(183, 26);
            this.finalBox.TabIndex = 9;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(1168, 471);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(176, 46);
            this.updateButton.TabIndex = 10;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // Dashboard_Lecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1408, 636);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.finalBox);
            this.Controls.Add(this.midtermBox);
            this.Controls.Add(this.homeWorkBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.lectDetailedGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lectSubjects);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard_Lecturer";
            this.Text = "Dashboard_Lecturer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectSubjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectDetailedGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label roleLecturer;
        private System.Windows.Forms.Label lectName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button settingsPanel;
        private System.Windows.Forms.Button studentClasses;
        private System.Windows.Forms.Button academicRegistration;
        private System.Windows.Forms.Button personalInfo;
        private System.Windows.Forms.DataGridView lectSubjects;
        private System.Windows.Forms.BindingSource universityDataSetBindingSource;
        private UniversityDataSet universityDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView lectDetailedGrid;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox homeWorkBox;
        private System.Windows.Forms.TextBox midtermBox;
        private System.Windows.Forms.TextBox finalBox;
        private System.Windows.Forms.Button updateButton;
    }
}