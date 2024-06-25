using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
namespace VehicleRegistrationManagmentSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtPass.UseSystemPasswordChar = true;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;
            if(user == "" || pass == "")
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }
            if (checkUser(user, pass))
            {
                MainForm mainform = new MainForm();
                mainform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }

        }

        public bool checkUser(string user, string pass)
        {
            string connectionString = "Data Source=DESKTOP-P469VTF;Initial Catalog=VehicleOwnerData;Integrated Security=True;Encrypt=False";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM users WHERE username = @user AND password = @pass", connection);
            command.Parameters.AddWithValue("@user", user);
            command.Parameters.AddWithValue("@pass", pass);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                connection.Close();
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }
        }


        private void checkBoxPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPass.Checked)
            {

                txtPass.UseSystemPasswordChar = false;

            }
            else
            {

                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
