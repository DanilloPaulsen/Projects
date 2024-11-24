namespace BCUniSphere.PresentationLayer
{
    partial class ModulesDetails
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
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.dgvModuleDetails = new System.Windows.Forms.DataGridView();
            this.cbModCourse = new System.Windows.Forms.ComboBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnModSearch = new System.Windows.Forms.Button();
            this.btnModExit = new System.Windows.Forms.Button();
            this.btnModBack = new System.Windows.Forms.Button();
            this.btnModDelete = new System.Windows.Forms.Button();
            this.btnModUpdate = new System.Windows.Forms.Button();
            this.btnModCreate = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtModLink = new System.Windows.Forms.TextBox();
            this.txtModName = new System.Windows.Forms.TextBox();
            this.txtModDesc = new System.Windows.Forms.TextBox();
            this.txtModCode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModuleDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDetailsH
            // 
            this.lblDetailsH.AutoSize = true;
            this.lblDetailsH.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailsH.ForeColor = System.Drawing.Color.IndianRed;
            this.lblDetailsH.Location = new System.Drawing.Point(51, 170);
            this.lblDetailsH.Name = "lblDetailsH";
            this.lblDetailsH.Size = new System.Drawing.Size(443, 55);
            this.lblDetailsH.TabIndex = 0;
            this.lblDetailsH.Text = "MODULE DETAILS";
            // 
            // pb4
            // 
            this.pb4.Image = global::BCUniSphere.Properties.Resources.header1;
            this.pb4.Location = new System.Drawing.Point(1, 1);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(563, 150);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb4.TabIndex = 4;
            this.pb4.TabStop = false;
            // 
            // dgvModuleDetails
            // 
            this.dgvModuleDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvModuleDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dgvModuleDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvModuleDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvModuleDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModuleDetails.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvModuleDetails.Location = new System.Drawing.Point(553, 12);
            this.dgvModuleDetails.Name = "dgvModuleDetails";
            this.dgvModuleDetails.Size = new System.Drawing.Size(885, 516);
            this.dgvModuleDetails.TabIndex = 0;
            this.dgvModuleDetails.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvModuleDetails_CellMouseClick);
            // 
            // cbModCourse
            // 
            this.cbModCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cbModCourse.ForeColor = System.Drawing.Color.Silver;
            this.cbModCourse.FormattingEnabled = true;
            this.cbModCourse.Location = new System.Drawing.Point(25, 239);
            this.cbModCourse.Name = "cbModCourse";
            this.cbModCourse.Size = new System.Drawing.Size(506, 26);
            this.cbModCourse.TabIndex = 74;
            this.cbModCourse.Text = "Course";
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel8.BackColor = System.Drawing.Color.IndianRed;
            this.panel8.Location = new System.Drawing.Point(25, 273);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(506, 1);
            this.panel8.TabIndex = 73;
            // 
            // btnModSearch
            // 
            this.btnModSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnModSearch.BackColor = System.Drawing.Color.IndianRed;
            this.btnModSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModSearch.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModSearch.ForeColor = System.Drawing.Color.White;
            this.btnModSearch.Location = new System.Drawing.Point(295, 446);
            this.btnModSearch.Name = "btnModSearch";
            this.btnModSearch.Size = new System.Drawing.Size(236, 33);
            this.btnModSearch.TabIndex = 66;
            this.btnModSearch.Text = "Search Module";
            this.btnModSearch.UseVisualStyleBackColor = false;
            this.btnModSearch.Click += new System.EventHandler(this.btnModSearch_Click);
            // 
            // btnModExit
            // 
            this.btnModExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnModExit.BackColor = System.Drawing.Color.IndianRed;
            this.btnModExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModExit.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModExit.ForeColor = System.Drawing.Color.White;
            this.btnModExit.Location = new System.Drawing.Point(295, 495);
            this.btnModExit.Name = "btnModExit";
            this.btnModExit.Size = new System.Drawing.Size(236, 33);
            this.btnModExit.TabIndex = 68;
            this.btnModExit.Text = "Exit";
            this.btnModExit.UseVisualStyleBackColor = false;
            this.btnModExit.Click += new System.EventHandler(this.btnModExit_Click);
            // 
            // btnModBack
            // 
            this.btnModBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnModBack.BackColor = System.Drawing.Color.IndianRed;
            this.btnModBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModBack.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModBack.ForeColor = System.Drawing.Color.White;
            this.btnModBack.Location = new System.Drawing.Point(25, 495);
            this.btnModBack.Name = "btnModBack";
            this.btnModBack.Size = new System.Drawing.Size(236, 33);
            this.btnModBack.TabIndex = 67;
            this.btnModBack.Text = "Back";
            this.btnModBack.UseVisualStyleBackColor = false;
            this.btnModBack.Click += new System.EventHandler(this.btnModBack_Click);
            // 
            // btnModDelete
            // 
            this.btnModDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnModDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnModDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModDelete.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModDelete.ForeColor = System.Drawing.Color.White;
            this.btnModDelete.Location = new System.Drawing.Point(295, 394);
            this.btnModDelete.Name = "btnModDelete";
            this.btnModDelete.Size = new System.Drawing.Size(236, 33);
            this.btnModDelete.TabIndex = 64;
            this.btnModDelete.Text = "Delete Module";
            this.btnModDelete.UseVisualStyleBackColor = false;
            this.btnModDelete.Click += new System.EventHandler(this.btnModDelete_Click);
            // 
            // btnModUpdate
            // 
            this.btnModUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnModUpdate.BackColor = System.Drawing.Color.IndianRed;
            this.btnModUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModUpdate.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModUpdate.ForeColor = System.Drawing.Color.White;
            this.btnModUpdate.Location = new System.Drawing.Point(25, 446);
            this.btnModUpdate.Name = "btnModUpdate";
            this.btnModUpdate.Size = new System.Drawing.Size(236, 33);
            this.btnModUpdate.TabIndex = 65;
            this.btnModUpdate.Text = "Update Module";
            this.btnModUpdate.UseVisualStyleBackColor = false;
            this.btnModUpdate.Click += new System.EventHandler(this.btnModUpdate_Click);
            // 
            // btnModCreate
            // 
            this.btnModCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnModCreate.BackColor = System.Drawing.Color.IndianRed;
            this.btnModCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModCreate.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModCreate.ForeColor = System.Drawing.Color.White;
            this.btnModCreate.Location = new System.Drawing.Point(25, 394);
            this.btnModCreate.Name = "btnModCreate";
            this.btnModCreate.Size = new System.Drawing.Size(236, 33);
            this.btnModCreate.TabIndex = 63;
            this.btnModCreate.Text = "Create Module";
            this.btnModCreate.UseVisualStyleBackColor = false;
            this.btnModCreate.Click += new System.EventHandler(this.btnModCreate_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel4.BackColor = System.Drawing.Color.IndianRed;
            this.panel4.Location = new System.Drawing.Point(295, 370);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(236, 1);
            this.panel4.TabIndex = 72;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel3.BackColor = System.Drawing.Color.IndianRed;
            this.panel3.Location = new System.Drawing.Point(295, 323);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(236, 1);
            this.panel3.TabIndex = 71;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.Location = new System.Drawing.Point(25, 370);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 1);
            this.panel2.TabIndex = 70;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Location = new System.Drawing.Point(25, 323);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 1);
            this.panel1.TabIndex = 69;
            // 
            // txtModLink
            // 
            this.txtModLink.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModLink.ForeColor = System.Drawing.Color.Silver;
            this.txtModLink.Location = new System.Drawing.Point(295, 340);
            this.txtModLink.Name = "txtModLink";
            this.txtModLink.Size = new System.Drawing.Size(236, 17);
            this.txtModLink.TabIndex = 62;
            this.txtModLink.Text = "Module Link";
            this.txtModLink.Enter += new System.EventHandler(this.txtModLink_Enter);
            this.txtModLink.Leave += new System.EventHandler(this.txtModLink_Leave);
            // 
            // txtModName
            // 
            this.txtModName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModName.ForeColor = System.Drawing.Color.Silver;
            this.txtModName.Location = new System.Drawing.Point(25, 341);
            this.txtModName.Name = "txtModName";
            this.txtModName.Size = new System.Drawing.Size(236, 17);
            this.txtModName.TabIndex = 60;
            this.txtModName.Text = "Module Name";
            this.txtModName.Enter += new System.EventHandler(this.txtModName_Enter);
            this.txtModName.Leave += new System.EventHandler(this.txtModName_Leave);
            // 
            // txtModDesc
            // 
            this.txtModDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModDesc.ForeColor = System.Drawing.Color.Silver;
            this.txtModDesc.Location = new System.Drawing.Point(295, 294);
            this.txtModDesc.Name = "txtModDesc";
            this.txtModDesc.Size = new System.Drawing.Size(236, 17);
            this.txtModDesc.TabIndex = 61;
            this.txtModDesc.Text = "Module Description";
            this.txtModDesc.Enter += new System.EventHandler(this.txtModDesc_Enter);
            this.txtModDesc.Leave += new System.EventHandler(this.txtModDesc_Leave);
            // 
            // txtModCode
            // 
            this.txtModCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModCode.ForeColor = System.Drawing.Color.Silver;
            this.txtModCode.Location = new System.Drawing.Point(25, 293);
            this.txtModCode.Name = "txtModCode";
            this.txtModCode.Size = new System.Drawing.Size(236, 17);
            this.txtModCode.TabIndex = 59;
            this.txtModCode.Text = "Module Code";
            this.txtModCode.Enter += new System.EventHandler(this.txtModCode_Enter);
            this.txtModCode.Leave += new System.EventHandler(this.txtModCode_Leave);
            // 
            // ModulesDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1450, 540);
            this.Controls.Add(this.cbModCourse);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.btnModSearch);
            this.Controls.Add(this.btnModExit);
            this.Controls.Add(this.btnModBack);
            this.Controls.Add(this.btnModDelete);
            this.Controls.Add(this.btnModUpdate);
            this.Controls.Add(this.btnModCreate);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtModLink);
            this.Controls.Add(this.txtModName);
            this.Controls.Add(this.txtModDesc);
            this.Controls.Add(this.txtModCode);
            this.Controls.Add(this.dgvModuleDetails);
            this.Controls.Add(this.lblDetailsH);
            this.Controls.Add(this.pb4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModulesDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modules";
            this.Load += new System.EventHandler(this.ModulesDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModuleDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDetailsH;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.DataGridView dgvModuleDetails;
        private System.Windows.Forms.ComboBox cbModCourse;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnModSearch;
        private System.Windows.Forms.Button btnModExit;
        private System.Windows.Forms.Button btnModBack;
        private System.Windows.Forms.Button btnModDelete;
        private System.Windows.Forms.Button btnModUpdate;
        private System.Windows.Forms.Button btnModCreate;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtModLink;
        private System.Windows.Forms.TextBox txtModName;
        private System.Windows.Forms.TextBox txtModDesc;
        private System.Windows.Forms.TextBox txtModCode;
    }
}