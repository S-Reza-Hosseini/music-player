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
    public partial class FrmUpdatePass : Form
    {
        SqlConnection cnn;
        public FrmUpdatePass()
        {
            InitializeComponent();
        }

        private void btn_updatePass_Click(object sender, EventArgs e)
        {
            if (txtbx_newPass.Text != txtbx_cpass.Text)
            {
                MessageBox.Show(" your password is'nt match !!");
            }
            else
            {
                openDb();

                SqlCommand command;
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                String sql;

                sql = "Update Users set Upassword = '" + txtbx_cpass + "' where UPetName = '" + txtbx_petName + "'";

                command = new SqlCommand(sql, cnn);

                dataAdapter.UpdateCommand = new SqlCommand(sql, cnn);
                dataAdapter.UpdateCommand.ExecuteNonQuery();

                MessageBox.Show("Update your Password was Sucsesfully");

                dataAdapter.Dispose();
                closeDb();


                Frm_login login = new Frm_login();
                this.Hide();
                login.ShowDialog();
                this.Close();
            }
        }
        
        private void openDb()
        {
            String connectionString;

            connectionString = @"Data Source = . ; Initial Catalog = asProject ; Integrated Security = true ; 
                User Id = ;";

            cnn = new SqlConnection(connectionString);

            cnn.Open();

        }
        private void closeDb()
        {
            cnn.Close();
        }

    }
}
