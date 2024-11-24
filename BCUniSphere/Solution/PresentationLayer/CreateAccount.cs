using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCUniSphere.DataLayer;

namespace BCUniSphere
{
    public partial class CreateAccount : Form
    {
        DataHandler handler = new DataHandler();
        public CreateAccount()
        {
            InitializeComponent();
        }
        
        private void CreateAccount_Load(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lblClearCreate_Click(object sender, EventArgs e)
        {
            txtUsernameCreate.Clear();
            txtPasswordCreate.Clear();
            txtPasswordConfirm.Clear();
            txtPasswordCreate.Focus();
            txtPasswordConfirm.Focus();
            txtUsernameCreate.Focus();
        }

        private void lblExitClear_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsernameCreate.Text) || txtUsernameCreate.Text == "Username" ||
                string.IsNullOrEmpty(txtPasswordCreate.Text) || txtPasswordCreate.Text == "Password" ||
                string.IsNullOrEmpty(txtPasswordConfirm.Text) || txtPasswordConfirm.Text == "Password")
            {
                MessageBox.Show("Please enter a Username and Password");
                return;
            }

            if (txtPasswordCreate.Text != txtPasswordConfirm.Text)
            {
                MessageBox.Show("Passwords do not match");
                return;
            }

            DataHandler handler = new DataHandler();
            if (handler.checkExsist(txtUsernameCreate.Text) == true)
            {
                handler.signUp(txtUsernameCreate.Text, txtPasswordCreate.Text);
                new LoginIn().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username and Password does not match");
            }
        }


        private void lblLogin_Click(object sender, EventArgs e)
        {
            new LoginIn().Show();
            this.Hide();
        }

        private void txtUsernameCreate_Enter(object sender, EventArgs e)
        {
            if (txtUsernameCreate.Text == "Username")
            {
                txtUsernameCreate.Text = "";
                txtUsernameCreate.ForeColor = Color.Goldenrod;
            }
        }

        private void txtUsernameCreate_Leave(object sender, EventArgs e)
        {
            if (txtUsernameCreate.Text == "")
            {
                txtUsernameCreate.Text = "Username";
                txtUsernameCreate.ForeColor = Color.Silver;
            }
        }

        private void txtPasswordCreate_Enter(object sender, EventArgs e)
        {
            if (txtPasswordCreate.Text == "Password")
            {
                txtPasswordCreate.Text = "";
                txtPasswordCreate.ForeColor = Color.Goldenrod;
            }
            txtPasswordCreate.PasswordChar = '*';
        }

        private void txtPasswordCreate_Leave(object sender, EventArgs e)
        {
            if (txtPasswordCreate.Text == "")
            {
                txtPasswordCreate.Text = "Password";
                txtPasswordCreate.ForeColor = Color.Silver;
                txtPasswordCreate.PasswordChar = '\0';
            }
        }

        private void txtPasswordConfirm_Enter(object sender, EventArgs e)
        {
            if (txtPasswordConfirm.Text == "Password")
            {
                txtPasswordConfirm.Text = "";
                txtPasswordConfirm.ForeColor = Color.Goldenrod;
            }
            txtPasswordConfirm.PasswordChar = '*';
        }

        private void txtPasswordConfirm_Leave(object sender, EventArgs e)
        {
            if (txtPasswordConfirm.Text == "")
            {
                txtPasswordConfirm.Text = "Password";
                txtPasswordConfirm.ForeColor = Color.Silver;
                txtPasswordConfirm.PasswordChar = '\0';
            }
        }
    }
}
