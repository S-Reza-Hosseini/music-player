using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace az_payegahDadeh
{
    public partial class FrmForgetPassword : Form
    {
        SqlConnection cnn;
        public FrmForgetPassword()
        {
            InitializeComponent();
        }

        private void txtbx_email_TextChanged(object sender, EventArgs e)
        {

        }
        private bool CheckCredentials(String email)
        {
            String connectionString;

            connectionString = @"Data Source = .; initial Catalog = asProject;Integrated Security = true
                ;User ID= ;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Users WHERE UEmail = @email";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@email", email);
                

                int count = (int)command.ExecuteScalar();

                return count > 0;

                connection.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckCredentials(txtbx_email.Text))
            {
                FrmUpdatePass frmUpdate = new FrmUpdatePass();
                this.Hide();
                frmUpdate.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("your email Dosen't exist");
            }



            //ba estefade az security Question drost shavad
        }
        



        private void openDb()
        {
            String connectionString;

            connectionString = @"Data Source = .; Initial Catalog = asProject ; Integrated Security = true ; User Id = ;";

            cnn = new SqlConnection(connectionString);

            cnn.Open();

        }
        private void closeDb()
        {
            cnn.Close();
        }

       
    }
}
