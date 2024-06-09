using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace az_payegahDadeh
{


    public partial class FrmPlay : Form
    {
        WMPLib.WindowsMediaPlayer player1 = new WMPLib.WindowsMediaPlayer();
        String s;
        public FrmPlay()
        {
            InitializeComponent();
            hide();


        }
        public void changeLabelValue(Label label, int value)
        {
            label.Text = Convert.ToString(value);
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Ho3ein_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Ho3ein_Load_1(object sender, EventArgs e)
        {

        }

        /* private void button1_Click(object sender, EventArgs e)
         {
             Mp3Player mp3Player = new Mp3Player();

             using (OpenFileDialog ofd = new OpenFileDialog())
             {
                 ofd.Filter = "Mp3 Files |* .mp3";
                 if (ofd.ShowDialog() == DialogResult.OK)
                 {
                     mp3Player.open(ofd.FileName);
                 }

             }
         }*/

        /* private void button2_Click(object sender, EventArgs e)
         {
             Mp3Player mp3Player = new Mp3Player();
             mp3Player.play();
         }*/

        /* private void button5_Click(object sender, EventArgs e)
         {
             Mp3Player mp3Player = new Mp3Player();
             mp3Player.stop();
         }*/

        /* private void button6_Click(object sender, EventArgs e)
         {
             Mp3Player mp3Player = new Mp3Player();
             Application.Exit();
         }*/

        private void btn_media_Click(object sender, EventArgs e)
        {
            presently();
        }

        private void btn_music_Click(object sender, EventArgs e)
        {
            hide();
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                s = dlg.FileName;
                runMp3();
            }
        }

        private void btn_file_Click(object sender, EventArgs e)
        {
            hide();
        }

        private void hide()
        {
            pnl_media.Visible = false;
        }

        private void presently()
        {


            if (pnl_media.Visible == false)
                pnl_media.Visible = true;
        }



        private void runMp3()
        {
            player1.URL = s;
            player1.controls.play();
            lbl_timeSong.Text = trackBar1.Value.ToString();
        }



        private void progressBar1_Click(object sender, EventArgs e)
        {

        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (player1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                trackBar1.Maximum = (int)player1.controls.currentItem.duration;
                trackBar1.Value = (int)player1.controls.currentPosition;
                lbl_timeSong.Text = trackBar1.Value.ToString();
                //changeLabelValue(lbl_timeSong,progressBar1.Value);
            }
        }



        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //play
            player1.controls.play();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //next
            player1.controls.next();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //puase
            player1.controls.pause();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //prev
            player1.controls.previous();
        }
    }
}
