namespace BCUniSphere
{
    partial class StudentsDetails
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
            this.lblDetailsH = new System.Windows.Forms.Label();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.txtStudentNum = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtStudentSurname = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnStudCreate = new System.Windows.Forms.Button();
            this.btnStudUpdate = new System.Windows.Forms.Button();
            this.btnStudDelete = new System.Windows.Forms.Button();
            this.btnStudBack = new System.Windows.Forms.Button();
            this.btnStudSearch = new System.Windows.Forms.Button();
            this.btnStudExit = new System.Windows.Forms.Button();
            this.btnStudProfile = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.cbStudCourse = new System.Windows.Forms.ComboBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.cbGender = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDetailsH
            // 
            this.lblDetailsH.AutoSize = true;
            this.lblDetailsH.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailsH.ForeColor = System.Drawing.Color.IndianRed;
            this.lblDetailsH.Location = new System.Drawing.Point(40, 170);
            this.lblDetailsH.Name = "lblDetailsH";
            this.lblDetailsH.Size = new System.Drawing.Size(464, 55);
            this.lblDetailsH.TabIndex = 0;
            this.lblDetailsH.Text = "STUDENT DETAILS";
            // 
            // dgvStudents
            // 
            this.dgvStudents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvStudents.BackgroundColor = System.Drawing.Color.White;
            this.dgvStudents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvStudents.Location = new System.Drawing.Point(524, 12);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(914, 696);
            this.dgvStudents.TabIndex = 0;
            this.dgvStudents.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStudents_CellMouseClick);
            // 
            // txtStudentNum
            // 
            this.txtStudentNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStudentNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentNum.ForeColor = System.Drawing.Color.Silver;
            this.txtStudentNum.Location = new System.Drawing.Point(19, 393);
            this.txtStudentNum.Name = "txtStudentNum";
            this.txtStudentNum.Size = new System.Drawing.Size(236, 17);
            this.txtStudentNum.TabIndex = 1;
            this.txtStudentNum.Text = "Student Number";
            this.txtStudentNum.Enter += new System.EventHandler(this.txtStudentNum_Enter);
            this.txtStudentNum.Leave += new System.EventHandler(this.txtStudentNum_Leave);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Location = new System.Drawing.Point(14, 424);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 1);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.Location = new System.Drawing.Point(14, 488);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 1);
            this.panel2.TabIndex = 19;
            // 
            // txtStudentName
            // 
            this.txtStudentName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentName.ForeColor = System.Drawing.Color.Silver;
            this.txtStudentName.Location = new System.Drawing.Point(19, 457);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(236, 17);
            this.txtStudentName.TabIndex = 2;
            this.txtStudentName.Text = "Student Name";
            this.txtStudentName.Enter += new System.EventHandler(this.txtStudentName_Enter);
            this.txtStudentName.Leave += new System.EventHandler(this.txtStudentName_Leave);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel3.BackColor = System.Drawing.Color.IndianRed;
            this.panel3.Location = new System.Drawing.Point(14, 551);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(236, 1);
            this.panel3.TabIndex = 19;
            // 
            // txtStudentSurname
            // 
            this.txtStudentSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStudentSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentSurname.ForeColor = System.Drawing.Color.Silver;
            this.txtStudentSurname.Location = new System.Drawing.Point(19, 520);
            this.txtStudentSurname.Name = "txtStudentSurname";
            this.txtStudentSurname.Size = new System.Drawing.Size(236, 17);
            this.txtStudentSurname.TabIndex = 3;
            this.txtStudentSurname.Text = "Student Surname";
            this.txtStudentSurname.Enter += new System.EventHandler(this.txtStudentSurname_Enter);
            this.txtStudentSurname.Leave += new System.EventHandler(this.txtStudentSurname_Leave);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel4.BackColor = System.Drawing.Color.IndianRed;
            this.panel4.Location = new System.Drawing.Point(277, 283);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(236, 1);
            this.panel4.TabIndex = 19;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel5.BackColor = System.Drawing.Color.IndianRed;
            this.panel5.Location = new System.Drawing.Point(277, 353);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(236, 1);
            this.panel5.TabIndex = 19;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel6.BackColor = System.Drawing.Color.IndianRed;
            this.panel6.Location = new System.Drawing.Point(277, 488);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(236, 1);
            this.panel6.TabIndex = 19;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel7.BackColor = System.Drawing.Color.IndianRed;
            this.panel7.Location = new System.Drawing.Point(277, 424);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(236, 1);
            this.panel7.TabIndex = 19;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel8.BackColor = System.Drawing.Color.IndianRed;
            this.panel8.Location = new System.Drawing.Point(277, 551);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(236, 1);
            this.panel8.TabIndex = 19;
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.Silver;
            this.txtAddress.Location = new System.Drawing.Point(282, 457);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(236, 17);
            this.txtAddress.TabIndex = 7;
            this.txtAddress.Text = "Address";
            this.txtAddress.Enter += new System.EventHandler(this.txtAddress_Enter);
            this.txtAddress.Leave += new System.EventHandler(this.txtAddress_Leave);
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.Color.Silver;
            this.txtPhone.Location = new System.Drawing.Point(282, 393);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(236, 17);
            this.txtPhone.TabIndex = 6;
            this.txtPhone.Text = "Phone Number";
            this.txtPhone.Enter += new System.EventHandler(this.txtPhone_Enter);
            this.txtPhone.Leave += new System.EventHandler(this.txtPhone_Leave);
            // 
            // btnStudCreate
            // 
            this.btnStudCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnStudCreate.BackColor = System.Drawing.Color.IndianRed;
            this.btnStudCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudCreate.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudCreate.ForeColor = System.Drawing.Color.White;
            this.btnStudCreate.Location = new System.Drawing.Point(14, 574);
            this.btnStudCreate.Name = "btnStudCreate";
            this.btnStudCreate.Size = new System.Drawing.Size(236, 33);
            this.btnStudCreate.TabIndex = 10;
            this.btnStudCreate.Text = "Create Student";
            this.btnStudCreate.UseVisualStyleBackColor = false;
            this.btnStudCreate.Click += new System.EventHandler(this.btnCreateNew_Click);
            // 
            // btnStudUpdate
            // 
            this.btnStudUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnStudUpdate.BackColor = System.Drawing.Color.IndianRed;
            this.btnStudUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudUpdate.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudUpdate.ForeColor = System.Drawing.Color.White;
            this.btnStudUpdate.Location = new System.Drawing.Point(14, 626);
            this.btnStudUpdate.Name = "btnStudUpdate";
            this.btnStudUpdate.Size = new System.Drawing.Size(236, 33);
            this.btnStudUpdate.TabIndex = 12;
            this.btnStudUpdate.Text = "Update Student";
            this.btnStudUpdate.UseVisualStyleBackColor = false;
            this.btnStudUpdate.Click += new System.EventHandler(this.btnUpdateStudent_Click);
            // 
            // btnStudDelete
            // 
            this.btnStudDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnStudDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnStudDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudDelete.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudDelete.ForeColor = System.Drawing.Color.White;
            this.btnStudDelete.Location = new System.Drawing.Point(277, 574);
            this.btnStudDelete.Name = "btnStudDelete";
            this.btnStudDelete.Size = new System.Drawing.Size(236, 33);
            this.btnStudDelete.TabIndex = 11;
            this.btnStudDelete.Text = "Delete Student";
            this.btnStudDelete.UseVisualStyleBackColor = false;
            this.btnStudDelete.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnStudBack
            // 
            this.btnStudBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnStudBack.BackColor = System.Drawing.Color.IndianRed;
            this.btnStudBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudBack.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudBack.ForeColor = System.Drawing.Color.White;
            this.btnStudBack.Location = new System.Drawing.Point(14, 675);
            this.btnStudBack.Name = "btnStudBack";
            this.btnStudBack.Size = new System.Drawing.Size(236, 33);
            this.btnStudBack.TabIndex = 14;
            this.btnStudBack.Text = "Back";
            this.btnStudBack.UseVisualStyleBackColor = false;
            this.btnStudBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnStudSearch
            // 
            this.btnStudSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnStudSearch.BackColor = System.Drawing.Color.IndianRed;
            this.btnStudSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudSearch.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudSearch.ForeColor = System.Drawing.Color.White;
            this.btnStudSearch.Location = new System.Drawing.Point(277, 626);
            this.btnStudSearch.Name = "btnStudSearch";
            this.btnStudSearch.Size = new System.Drawing.Size(236, 33);
            this.btnStudSearch.TabIndex = 13;
            this.btnStudSearch.Text = "Search Student";
            this.btnStudSearch.UseVisualStyleBackColor = false;
            this.btnStudSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnStudExit
            // 
            this.btnStudExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnStudExit.BackColor = System.Drawing.Color.IndianRed;
            this.btnStudExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudExit.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudExit.ForeColor = System.Drawing.Color.White;
            this.btnStudExit.Location = new System.Drawing.Point(277, 675);
            this.btnStudExit.Name = "btnStudExit";
            this.btnStudExit.Size = new System.Drawing.Size(236, 33);
            this.btnStudExit.TabIndex = 15;
            this.btnStudExit.Text = "Exit";
            this.btnStudExit.UseVisualStyleBackColor = false;
            this.btnStudExit.Click += new System.EventHandler(this.btnStudExit_Click);
            // 
            // btnStudProfile
            // 
            this.btnStudProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnStudProfile.BackColor = System.Drawing.Color.IndianRed;
            this.btnStudProfile.FlatAppearance.BorderSize = 0;
            this.btnStudProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudProfile.Font = new System.Drawing.Font("Bahnschrift", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudProfile.ForeColor = System.Drawing.Color.White;
            this.btnStudProfile.Location = new System.Drawing.Point(145, 338);
            this.btnStudProfile.Name = "btnStudProfile";
            this.btnStudProfile.Size = new System.Drawing.Size(59, 34);
            this.btnStudProfile.TabIndex = 9;
            this.btnStudProfile.Text = "Add Profile Image";
            this.btnStudProfile.UseVisualStyleBackColor = false;
            this.btnStudProfile.Click += new System.EventHandler(this.btnStudProfile_Click);
            // 
            // pbImage
            // 
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Location = new System.Drawing.Point(19, 252);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(120, 120);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbImage.TabIndex = 22;
            this.pbImage.TabStop = false;
            // 
            // pb4
            // 
            this.pb4.Image = global::BCUniSphere.Properties.Resources.header1;
            this.pb4.Location = new System.Drawing.Point(1, 0);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(563, 150);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb4.TabIndex = 2;
            this.pb4.TabStop = false;
            // 
            // cbStudCourse
            // 
            this.cbStudCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cbStudCourse.ForeColor = System.Drawing.Color.Silver;
            this.cbStudCourse.FormattingEnabled = true;
            this.cbStudCourse.Location = new System.Drawing.Point(277, 517);
            this.cbStudCourse.Name = "cbStudCourse";
            this.cbStudCourse.Size = new System.Drawing.Size(236, 26);
            this.cbStudCourse.TabIndex = 23;
            this.cbStudCourse.Text = "Course";
            this.cbStudCourse.Leave += new System.EventHandler(this.cbStudCourse_Leave);
            // 
            // dtpDOB
            // 
            this.dtpDOB.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.dtpDOB.Location = new System.Drawing.Point(277, 252);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(236, 20);
            this.dtpDOB.TabIndex = 24;
            // 
            // cbGender
            // 
            this.cbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cbGender.ForeColor = System.Drawing.Color.Silver;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(277, 317);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(236, 26);
            this.cbGender.TabIndex = 25;
            this.cbGender.Text = "Gender";
            this.cbGender.SelectedIndexChanged += new System.EventHandler(this.cbGender_SelectedIndexChanged);
            // 
            // StudentsDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1450, 722);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.cbStudCourse);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.btnStudProfile);
            this.Controls.Add(this.btnStudSearch);
            this.Controls.Add(this.btnStudExit);
            this.Controls.Add(this.btnStudBack);
            this.Controls.Add(this.btnStudDelete);
            this.Controls.Add(this.btnStudUpdate);
            this.Controls.Add(this.btnStudCreate);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtStudentSurname);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.txtStudentNum);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.lblDetailsH);
            this.Controls.Add(this.pb4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentsDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Details";
            this.Load += new System.EventHandler(this.Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDetailsH;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.TextBox txtStudentNum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtStudentSurname;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnStudCreate;
        private System.Windows.Forms.Button btnStudUpdate;
        private System.Windows.Forms.Button btnStudDelete;
        private System.Windows.Forms.Button btnStudBack;
        private System.Windows.Forms.Button btnStudSearch;
        private System.Windows.Forms.Button btnStudExit;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.Button btnStudProfile;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.ComboBox cbStudCourse;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.ComboBox cbGender;
    }
}