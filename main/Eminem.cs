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
    public partial class Eminem : Form
    {

        SqlConnection cnn;
        public Eminem()
        {
            InitializeComponent();
            hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            openDb();



            SqlCommand command;
            SqlDataReader dataReader;
            String sql, OutPut = "";

            sql = "Select AID , AName , ASong , ACategory , ANationality , Albums from Artist Where AID = 4";

            command = new SqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                OutPut = OutPut + dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + " - " + dataReader.GetValue(2) +
                    " - " + dataReader.GetValue(3) + " - " + dataReader.GetValue(4) + " - "
                    + dataReader.GetValue(5) + "\n";
            }

            MessageBox.Show(OutPut);

            dataReader.Close();
            command.Dispose();
            closDb();
        }

        private void hide()
        {
            pnl_hiphop.Visible = false;
            pnl_pop.Visible = false;
            pnl_metal.Visible = false;
            pnl_oldmusic.Visible = false;
        }

        private void presentlyHiphop()
        {


            if (pnl_hiphop.Visible == false)
                pnl_hiphop.Visible = true;
        }
        private void presentlyPop()
        {
            if (pnl_pop.Visible == false)
                pnl_pop.Visible = true;
        }
        private void presentlyMetal()
        {

            if (pnl_metal.Visible == false)
                pnl_metal.Visible = true;
        }
        private void presentlyOldmusic()
        {

            if (pnl_oldmusic.Visible == false)
                pnl_oldmusic.Visible = true;
        }

        private void btn_hiphop_Click(object sender, EventArgs e)
        {
            presentlyHiphop();
        }
        private void btn_eminem_Click(object sender, EventArgs e)
        {
            hide();

            Eminem eminem = new Eminem();
            this.hide();
            eminem.ShowDialog();
            this.Close();
        }

        private void btn_ho3ein_Click(object sender, EventArgs e)
        {
            hide();

            Ho3ein ho3Ein = new Ho3ein();
            this.hide();
            ho3Ein.ShowDialog();
            this.Close();
        }

        private void btn_zedbazi_Click(object sender, EventArgs e)
        {
            hide();

            Zedbazi zedbazi = new Zedbazi();
            this.hide();
            zedbazi.ShowDialog();
            this.Close();
        }

        private void btn_pop_Click(object sender, EventArgs e)
        {
            presentlyPop();
        }

        private void btn_farhad_Click(object sender, EventArgs e)
        {
            hide();

            Farhad farhad = new Farhad();
            this.hide();
            farhad.ShowDialog();
            this.Close();
        }

        private void btn_metal_Click(object sender, EventArgs e)
        {
            presentlyMetal();
        }

        private void btn_anathema_Click(object sender, EventArgs e)
        {
            hide();

            Anathema anathema = new Anathema();
            this.hide();
            anathema.ShowDialog();
            this.Close();
        }

        private void btn_oldmusic_Click(object sender, EventArgs e)
        {
            presentlyOldmusic();
        }

        private void btn_homay_Click(object sender, EventArgs e)
        {
            hide();

            ParvazHomay homay = new ParvazHomay();
            this.hide();
            homay.ShowDialog();
            this.Close();
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

        private void btn_play_Click(object sender, EventArgs e)
        {
            FrmPlay play = new FrmPlay();
            this.hide();
            play.ShowDialog();
            this.Close();
        }

        private void btn_songInfo_Click(object sender, EventArgs e)
        {
            openDb();


            SqlCommand command;
            SqlDataReader dataReader;
            String sql, OutPut = "";

            sql = "Select SID , SName , SArtist , SCategory , SAlbum , STime from Song where SId = 2";

            command = new SqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                OutPut = OutPut + dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + " - " + dataReader.GetValue(2) +
                    " - " + dataReader.GetValue(3) + " - " + dataReader.GetValue(4) + " - "
                    + dataReader.GetValue(5) + "\n";
            }

            MessageBox.Show(OutPut);

            dataReader.Close();
            command.Dispose();
            closDb();
        }
    }
}
