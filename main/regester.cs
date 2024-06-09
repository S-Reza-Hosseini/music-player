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
    public partial class Frm_regester : Form
    {
        SqlConnection cnn;
        public Frm_regester()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_login frm_login = new Frm_login();
            this.Hide();
            frm_login.ShowDialog();
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_regester_Click(object sender, EventArgs e)
        {
            /* if(txt_name.Text== string.Empty)
             {
                 label10.Visible = true;

             }
             else
             {
                 label10.Visible = false;
             }*/

            User user = new User(txt_name.Text, txt_lastname.Text, txt_email.Text,txt_user.Text,txt_pass.Text);
            /* MessageBox.Show(user.toString());*/


            /*////////////////////////////////////////////////////////////*/

            if (txt_pass.Text != txt_confirmPass.Text)
            {
                MessageBox.Show("your password doesn't match ");
            }
            else
            {
                openDb();

                SqlCommand command;
                SqlDataAdapter adapter = new SqlDataAdapter();
                String Sql = "";

                Sql = "Insert into Users  values( '" + txt_name.Text + "','" + txt_lastname.Text + "','" + txt_user.Text + "' ,'" + txt_email.Text + "' , '" + txt_pass.Text + "' , '"+ txtbx_petName.Text + "' , " +
                    ""+Convert.ToInt32(txtbx_age.Text) +")";

                command = new SqlCommand(Sql, cnn);

                adapter.InsertCommand = new SqlCommand(Sql, cnn);
                adapter.InsertCommand.ExecuteNonQuery();

                command.Dispose();
                closeDb();

                /*///////////////////////////////////////////////////////////////////////*/
                FrmMain frm_main = new FrmMain(txt_name.Text);
                this.Hide();
                frm_main.ShowDialog();
                this.Close();
            }


        }
        public void openDb()
        {
            String connectionString;

            connectionString = @"Data Source = .; initial Catalog = asProject;Integrated Security = true
                ;User ID= ;";
            cnn = new SqlConnection(connectionString);

            cnn.Open();

        }
        public void closeDb()
        {
            cnn.Close();
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void gbx_intrested_Enter(object sender, EventArgs e)
        {

        }

        private void rdb_male_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        { 

            txt_name.Text = "";
            txt_lastname.Text = "";
            txt_user.Text = "";
            txt_pass.Text = "";
            txt_email.Text = "";
            txt_confirmPass.Text = "";



        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
