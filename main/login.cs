using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace az_payegahDadeh
{

    public partial class Frm_login : Form
    {

        SqlConnection cnn;
        public Frm_login()
        {
            InitializeComponent();
        }

        private void Frm_login_Load(object sender, EventArgs e)
        {
            txt_pass.PasswordChar = '*';
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_regester_MouseClick(object sender, MouseEventArgs e)
        {


            Frm_regester frm_register = new Frm_regester();
            this.Hide();
            frm_register.ShowDialog();
            this.Close();

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            /*  if (txt_pass.Text == "admin" && txt_user.Text != "")
              {
                  FrmMain frm_main = new FrmMain(txt_user.Text);
                  this.Hide();
                  frm_main.ShowDialog();
                  this.Close();
              }
              else
              {
                  MessageBox.Show("please enter correct password and username :");
              }*/

            if (CheckCredentials(txt_user.Text, txt_pass.Text))
            {
                FrmMain frm_main = new FrmMain(txt_user.Text);
                this.Hide();
                frm_main.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }



        }


        static bool CheckCredentials(String username, String password)
        {
            String connectionString;

            connectionString = @"Data Source = .; initial Catalog = asProject;Integrated Security = true
                ;User ID= ;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND UPassword = @Password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                int count = (int)command.ExecuteScalar();

                return count > 0;

                connection.Close();
            }

        }

      

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmForgetPassword frmForget = new FrmForgetPassword();
            this.Hide();
            frmForget.ShowDialog();
            this.Close();
        }
    }
}
