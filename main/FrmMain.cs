﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace az_payegahDadeh
{
    public partial class FrmMain : Form
    {
        private String welcome;
        public FrmMain(String welcome)
        {
            setWelcome(welcome);
            InitializeComponent();
            hide();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            lbl_welcome.Text = "welcome Dear " + getWelcome();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_login frm_Login = new Frm_login();
            this.Hide();
            frm_Login.ShowDialog();
            this.Close();
        }

        public void setWelcome(String welcome)
        {
            this.welcome = welcome;
        }
        public String getWelcome()
        {
            return welcome;
        }

        private void lbl_welcome_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void txt_hiphop_Click(object sender, EventArgs e)
        {

        }

        private void link_lbl_ho3ein_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmPlay play = new FrmPlay();
            this.Hide();
            play.ShowDialog();
            this.Close();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel13_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void linkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
        }

        private void linkLabel19_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void linkLabel18_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void linkLabel17_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void linkLabel16_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void linkLabel15_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void linkLabel14_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pnl_oldmusic_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pnl_metal_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pnl_pop_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pnl_hiphop_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox20_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmDeletAccount frmDelet = new FrmDeletAccount();
            this.Hide();
            frmDelet.ShowDialog();
            this.Close();
        }
    }
}
