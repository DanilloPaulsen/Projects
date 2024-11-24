using BCUniSphere.DataLayer;
using BCUniSphere.PresentationLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCUniSphere
{
    public partial class LoginIn : Form
    {
        public LoginIn()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataHandler handler = new DataHandler();
            if (txtPasswordLogin.Text != "Username" || txtUsernameLogin.Text != "Password")
            {
                if (handler.newLogin(txtUsernameLogin.Text, txtPasswordLogin.Text) == true)
                {
                    MainDetail mainForm = new MainDetail();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("The Username and Password you have entered does exist");
                    txtUsernameLogin.Clear();
                    txtPasswordLogin.Clear();
                    txtPasswordLogin.Focus();
                    txtUsernameLogin.Focus();
                    txtUsernameLogin.ForeColor = Color.IndianRed;
                }
            }
            else
            {
                MessageBox.Show("Please enter a username and password");
            }
        }

        private void lblClearLogin_Click(object sender, EventArgs e)
        {
            txtUsernameLogin.Clear();
            txtPasswordLogin.Clear();
            txtUsernameLogin.Focus();
        }

        private void lblExitLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblCreate_Click(object sender, EventArgs e)
        {
            new CreateAccount().Show();
            this.Hide();
        }

        private void txtUsernameLogin_Enter(object sender, EventArgs e)
        {
            if (txtUsernameLogin.Text == "Username")
            {
                txtUsernameLogin.Text = "";
                txtUsernameLogin.ForeColor = Color.IndianRed;
            }
        }

        private void txtUsernameLogin_Leave(object sender, EventArgs e)
        {
            if (txtUsernameLogin.Text == "")
            {
                txtUsernameLogin.Text = "Username";
                txtUsernameLogin.ForeColor = Color.Silver;
            }
        }

        private void txtPasswordLogin_Enter(object sender, EventArgs e)
        {
            if (txtPasswordLogin.Text == "Password")
            {
                txtPasswordLogin.Text = "";
                txtPasswordLogin.ForeColor = Color.IndianRed;
            }
            txtPasswordLogin.PasswordChar = '*';
        }

        private void txtPasswordLogin_Leave(object sender, EventArgs e)
        {
            if (txtPasswordLogin.Text == "")
            {
                txtPasswordLogin.Text = "Password";
                txtPasswordLogin.ForeColor = Color.Silver;
                txtPasswordLogin.PasswordChar = '\0';
            }
        }
    }
}
