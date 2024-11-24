using BCUniSphere.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace BCUniSphere.PresentationLayer
{
    public partial class ModulesDetails : Form
    {
        DataHandler handler = new DataHandler();
        public ModulesDetails()
        {
            InitializeComponent();
            dgvModuleDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnModCreate_Click(object sender, EventArgs e)
        {
            if (txtModCode.Text != "Module Code")
            {
                string moduleCode = txtModCode.Text;
                string moduleName = txtModName.Text;
                string moduleDescription = txtModDesc.Text;
                string moduleLinks = txtModLink.Text;
                int courseId = (int)cbModCourse.SelectedValue;

                handler.AddModule(courseId, moduleCode, moduleName, moduleDescription, moduleLinks);
                MessageBox.Show("Module created successfully");
                dgvModuleDetails.DataSource = DataHandler.GetModules();
            }
            else
            {
                MessageBox.Show("Please enter a valid module you would like to create", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnModBack_Click(object sender, EventArgs e)
        {
            MainDetail mainForm = new MainDetail();
            mainForm.Show();
            this.Hide();
        }

        private void btnModDelete_Click(object sender, EventArgs e)
        {
            int moduleID = GetSelectedModuleID();

            if (txtModCode.Text != "Module Code")
            {
                if (moduleID > 0)
                {
                    DataHandler handler = new DataHandler();
                    handler.DeleteModule(moduleID);

                    MessageBox.Show("Module deleted successfully");
                    dgvModuleDetails.DataSource = DataHandler.GetModules();
                }
                else
                {
                    MessageBox.Show("Please select a module to delete.");
                }
            }
            else
            {
                MessageBox.Show("Please select a module you would like to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModUpdate_Click(object sender, EventArgs e)
        {
            if (txtModCode.Text != "Module Code")
            {
                int moduleID = GetSelectedModuleID();
                string moduleCode = txtModCode.Text;
                string moduleName = txtModName.Text;
                string moduleDescription = txtModDesc.Text;
                string moduleLinks = txtModLink.Text;
                int courseId = (int)cbModCourse.SelectedValue;

                handler.UpdateModule(moduleID, moduleCode, moduleName, moduleDescription, moduleLinks, courseId);

                MessageBox.Show("Module updated successfully");
                dgvModuleDetails.DataSource = DataHandler.GetModules();
            }
            else
            {
                MessageBox.Show("Please select a module you would like to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetSelectedModuleID()
        {
            int moduleID = 0;
            foreach (DataGridViewRow row in dgvModuleDetails.SelectedRows)
            {
                moduleID = Convert.ToInt32(row.Cells["ModuleID"].Value);
            }

            return moduleID;
        }

        private void btnModSearch_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter Module ID", "Search Module", "", -1, -1);
            if (int.TryParse(input, out int moduleId))
            {
                dgvModuleDetails.DataSource = handler.SearchModule(moduleId);
            }
            else
            {
                MessageBox.Show("Invalid Module ID entered.");
            }
        }

        private void txtModCode_Enter(object sender, EventArgs e)
        {
            if (txtModCode.Text == "Module Code")
            {
                txtModCode.Text = "";
                txtModCode.ForeColor = Color.IndianRed;
            }
        }

        private void txtModCode_Leave(object sender, EventArgs e)
        {
            if (txtModCode.Text == "")
            {
                txtModCode.Text = "Module Code";
                txtModCode.ForeColor = Color.Silver;
            }
        }

        private void txtModName_Enter(object sender, EventArgs e)
        {
            if (txtModName.Text == "Module Name")
            {
                txtModName.Text = "";
                txtModName.ForeColor = Color.IndianRed;
            }
        }

        private void txtModName_Leave(object sender, EventArgs e)
        {
            if (txtModName.Text == "")
            {
                txtModName.Text = "Module Name";
                txtModName.ForeColor = Color.Silver;
            }
        }

        private void txtModDesc_Enter(object sender, EventArgs e)
        {
            if (txtModDesc.Text == "Module Description")
            {
                txtModDesc.Text = "";
                txtModDesc.ForeColor = Color.IndianRed;
            }
        }

        private void txtModDesc_Leave(object sender, EventArgs e)
        {
            if (txtModDesc.Text == "")
            {
                txtModDesc.Text = "Module Description";
                txtModDesc.ForeColor = Color.Silver;
            }
        }

        private void txtModLink_Enter(object sender, EventArgs e)
        {
            if (txtModLink.Text == "Module Link")
            {
                txtModLink.Text = "";
                txtModLink.ForeColor = Color.IndianRed;
            }
        }

        private void txtModLink_Leave(object sender, EventArgs e)
        {
            if (txtModLink.Text == "")
            {
                txtModLink.Text = "Module Link";
                txtModLink.ForeColor = Color.Silver;
            }
        }

        private void ModulesDetails_Load(object sender, EventArgs e)
        {
            dgvModuleDetails.DataSource = DataHandler.GetModules();
            PopulateCoursesComboBoxMod();
        }

        private void PopulateCoursesComboBoxMod()
        {
            DataTable courses = handler.GetCourses();
            cbModCourse.DataSource = courses;
            cbModCourse.DisplayMember = "CourseName";
            cbModCourse.ValueMember = "CourseID";
        }

        private void dgvModuleDetails_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvModuleDetails.Rows.Count -1)
            {
                cbModCourse.ForeColor = Color.IndianRed;
                txtModCode.ForeColor = Color.IndianRed;
                txtModName.ForeColor = Color.IndianRed;
                txtModDesc.ForeColor = Color.IndianRed;
                txtModLink.ForeColor = Color.IndianRed;

                object modCode = dgvModuleDetails.Rows[e.RowIndex].Cells["ModuleCode"].Value;
                txtModCode.Clear();
                txtModCode.Text = modCode.ToString();
                object modName = dgvModuleDetails.Rows[e.RowIndex].Cells["ModuleName"].Value;
                txtModName.Text = modName.ToString();
                object modDesc = dgvModuleDetails.Rows[e.RowIndex].Cells["ModuleDescription"].Value;
                txtModDesc.Text = modDesc.ToString();
                object modLink = dgvModuleDetails.Rows[e.RowIndex].Cells["ModuleLinks"].Value;
                txtModLink.Text = modLink.ToString();
                object moduleCodes = dgvModuleDetails.Rows[e.RowIndex].Cells["CourseID"].Value;

                if (moduleCodes != null)
                {
                    int courseId = Convert.ToInt32(moduleCodes);
                    string courseName = GetCourseNameFromIDMod(courseId);
                    cbModCourse.Text = courseName;
                }
                else
                {
                    MessageBox.Show("Invalid Input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a valid row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetCourseNameFromIDMod(int courseId)
        {
            DataTable courses = handler.GetCourses();
            foreach (DataRow row in courses.Rows)
            {
                if (Convert.ToInt32(row["CourseID"]) == courseId)
                {
                    return row["CourseName"].ToString();
                }
            }
            return "";
        }
    }
}
