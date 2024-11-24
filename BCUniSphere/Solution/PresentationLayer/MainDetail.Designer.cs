namespace BCUniSphere.PresentationLayer
{
    partial class MainDetail
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMainDetails = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMainExit = new System.Windows.Forms.Button();
            this.btnEditModules = new System.Windows.Forms.Button();
            this.btnEditStudents = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.IndianRed;
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(536, 91);
            this.lblHeader.TabIndex = 15;
            this.lblHeader.Text = "BCUniSphere";
            // 
            // pb1
            // 
            this.pb1.Image = global::BCUniSphere.Properties.Resources.header1;
            this.pb1.Location = new System.Drawing.Point(788, 0);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(754, 177);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 14;
            this.pb1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(115, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Choose an Option";
            // 
            // dgvMainDetails
            // 
            this.dgvMainDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMainDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvMainDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvMainDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMainDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMainDetails.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvMainDetails.Location = new System.Drawing.Point(12, 176);
            this.dgvMainDetails.Name = "dgvMainDetails";
            this.dgvMainDetails.Size = new System.Drawing.Size(1426, 483);
            this.dgvMainDetails.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(42, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(471, 37);
            this.label2.TabIndex = 29;
            this.label2.Text = "List of all Students and Modules";
            // 
            // btnMainExit
            // 
            this.btnMainExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnMainExit.BackColor = System.Drawing.Color.IndianRed;
            this.btnMainExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainExit.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainExit.ForeColor = System.Drawing.Color.White;
            this.btnMainExit.Location = new System.Drawing.Point(921, 674);
            this.btnMainExit.Name = "btnMainExit";
            this.btnMainExit.Size = new System.Drawing.Size(140, 33);
            this.btnMainExit.TabIndex = 3;
            this.btnMainExit.Text = "Exit";
            this.btnMainExit.UseVisualStyleBackColor = false;
            this.btnMainExit.Click += new System.EventHandler(this.btnMainExit_Click);
            // 
            // btnEditModules
            // 
            this.btnEditModules.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnEditModules.BackColor = System.Drawing.Color.IndianRed;
            this.btnEditModules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditModules.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditModules.ForeColor = System.Drawing.Color.White;
            this.btnEditModules.Location = new System.Drawing.Point(565, 674);
            this.btnEditModules.Name = "btnEditModules";
            this.btnEditModules.Size = new System.Drawing.Size(140, 33);
            this.btnEditModules.TabIndex = 2;
            this.btnEditModules.Text = "Edit Modules";
            this.btnEditModules.UseVisualStyleBackColor = false;
            this.btnEditModules.Click += new System.EventHandler(this.btnEditModules_Click);
            // 
            // btnEditStudents
            // 
            this.btnEditStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnEditStudents.BackColor = System.Drawing.Color.IndianRed;
            this.btnEditStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditStudents.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditStudents.ForeColor = System.Drawing.Color.White;
            this.btnEditStudents.Location = new System.Drawing.Point(388, 674);
            this.btnEditStudents.Name = "btnEditStudents";
            this.btnEditStudents.Size = new System.Drawing.Size(139, 33);
            this.btnEditStudents.TabIndex = 1;
            this.btnEditStudents.Text = "Edit Students";
            this.btnEditStudents.UseVisualStyleBackColor = false;
            this.btnEditStudents.Click += new System.EventHandler(this.btnEditStudents_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnLogOut.BackColor = System.Drawing.Color.IndianRed;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(746, 674);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(140, 33);
            this.btnLogOut.TabIndex = 30;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // MainDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1450, 719);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnMainExit);
            this.Controls.Add(this.btnEditModules);
            this.Controls.Add(this.btnEditStudents);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvMainDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.pb1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose";
            this.Load += new System.EventHandler(this.MainDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMainDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMainExit;
        private System.Windows.Forms.Button btnEditModules;
        private System.Windows.Forms.Button btnEditStudents;
        private System.Windows.Forms.Button btnLogOut;
    }
}