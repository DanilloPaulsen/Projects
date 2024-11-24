using BCUniSphere.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace BCUniSphere.PresentationLayer
{
    public partial class MainDetail : Form
    {
        public MainDetail()
        {
            InitializeComponent();
        }

        private void btnEditStudents_Click(object sender, EventArgs e)
        {
            StudentsDetails studentsForm = new StudentsDetails();
            this.Hide();
            studentsForm.Show();
        }

        private void btnEditModules_Click(object sender, EventArgs e)
        {
            ModulesDetails moduleForm = new ModulesDetails();
            this.Hide();
            moduleForm.Show();
        }

        private void btnMainExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainDetail_Load(object sender, EventArgs e)
        {
            dgvMainDetails.DataSource = DataHandler.GetStudents();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LoginIn loginForm = new LoginIn();
            loginForm.Show();
            this.Hide(); 
        }
    }
}
