using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace az_payegahDadeh
{
    public partial class FrmDeletAccount : Form
    {
        SqlConnection cnn;
        public FrmDeletAccount()
        {
            InitializeComponent();
        }

        private void FrmDeletAccount_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {

            if (CheckCredentials(txtbx_user.Text, txtbx_pass.Text))
            {
                openDb();
                SqlCommand command;
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                String sql;
                String user = txtbx_user.Text;

                sql = "Delete Users where Username = '"+ user + "'";

                command = new SqlCommand(sql, cnn);

                dataAdapter.DeleteCommand = new SqlCommand(sql, cnn);
                dataAdapter.DeleteCommand.ExecuteNonQuery();


                dataAdapter.Dispose();
                closDb();

                MessageBox.Show("Your account succesfully deleted.\r\n\r\n\r\nPlease let us know if we can help you to reconsider ");

                Frm_login login = new Frm_login();
                this.Hide();
                login.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }

        }

        private bool CheckCredentials(String username, String password)
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
        private void openDb()
        {
            String connectionString;


            connectionString = @"Data Source = .; Initial Catalog = asProject; Integrated security = true ; User Id =;";

            cnn = new SqlConnection(connectionString);

            cnn.Open();


        }
        private void closDb()
        {
            cnn.Close();
        }
    }
}
