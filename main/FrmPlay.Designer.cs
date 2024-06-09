
namespace az_payegahDadeh
{
    partial class FrmPlay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlay));
            panel4 = new System.Windows.Forms.Panel();
            trackBar1 = new System.Windows.Forms.TrackBar();
            btn_pause = new System.Windows.Forms.Button();
            btn_next = new System.Windows.Forms.Button();
            btn_prev = new System.Windows.Forms.Button();
            btn_play = new System.Windows.Forms.Button();
            lbl_timeSong = new System.Windows.Forms.Label();
            btn_exit = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            panel2 = new System.Windows.Forms.Panel();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            btn_media = new System.Windows.Forms.Button();
            btn_file = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            btn_music = new System.Windows.Forms.Button();
            btn_logout = new System.Windows.Forms.Button();
            btn_help = new System.Windows.Forms.Button();
            btn_tool = new System.Windows.Forms.Button();
            pnl_playlist = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            pnl_media = new System.Windows.Forms.Panel();
            panel1 = new System.Windows.Forms.Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnl_playlist.SuspendLayout();
            panel3.SuspendLayout();
            pnl_media.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = System.Drawing.Color.FromArgb(35, 35, 79);
            panel4.Controls.Add(trackBar1);
            panel4.Controls.Add(btn_pause);
            panel4.Controls.Add(btn_next);
            panel4.Controls.Add(btn_prev);
            panel4.Controls.Add(btn_play);
            panel4.Controls.Add(lbl_timeSong);
            panel4.Controls.Add(btn_exit);
            panel4.Controls.Add(pictureBox1);
            panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            panel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            panel4.Location = new System.Drawing.Point(233, 0);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(504, 393);
            panel4.TabIndex = 3;
            panel4.Paint += panel4_Paint_1;
            // 
            // trackBar1
            // 
            trackBar1.Location = new System.Drawing.Point(47, 253);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new System.Drawing.Size(404, 45);
            trackBar1.TabIndex = 9;
            // 
            // btn_pause
            // 
            btn_pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_pause.Image = (System.Drawing.Image)resources.GetObject("btn_pause.Image");
            btn_pause.Location = new System.Drawing.Point(243, 304);
            btn_pause.Name = "btn_pause";
            btn_pause.Size = new System.Drawing.Size(45, 41);
            btn_pause.TabIndex = 8;
            btn_pause.UseVisualStyleBackColor = true;
            btn_pause.Click += button1_Click_1;
            // 
            // btn_next
            // 
            btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_next.Image = (System.Drawing.Image)resources.GetObject("btn_next.Image");
            btn_next.Location = new System.Drawing.Point(310, 304);
            btn_next.Name = "btn_next";
            btn_next.Size = new System.Drawing.Size(41, 41);
            btn_next.TabIndex = 7;
            btn_next.UseVisualStyleBackColor = true;
            btn_next.Click += button5_Click;
            // 
            // btn_prev
            // 
            btn_prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_prev.Image = (System.Drawing.Image)resources.GetObject("btn_prev.Image");
            btn_prev.Location = new System.Drawing.Point(132, 304);
            btn_prev.Name = "btn_prev";
            btn_prev.Size = new System.Drawing.Size(39, 41);
            btn_prev.TabIndex = 6;
            btn_prev.UseVisualStyleBackColor = true;
            btn_prev.Click += button4_Click_1;
            // 
            // btn_play
            // 
            btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_play.Image = (System.Drawing.Image)resources.GetObject("btn_play.Image");
            btn_play.Location = new System.Drawing.Point(190, 304);
            btn_play.Name = "btn_play";
            btn_play.Size = new System.Drawing.Size(32, 41);
            btn_play.TabIndex = 5;
            btn_play.UseVisualStyleBackColor = true;
            btn_play.Click += button3_Click_1;
            // 
            // lbl_timeSong
            // 
            lbl_timeSong.AutoSize = true;
            lbl_timeSong.Location = new System.Drawing.Point(16, 229);
            lbl_timeSong.Name = "lbl_timeSong";
            lbl_timeSong.Size = new System.Drawing.Size(57, 21);
            lbl_timeSong.TabIndex = 3;
            lbl_timeSong.Text = "label1";
            lbl_timeSong.Click += label1_Click;
            // 
            // btn_exit
            // 
            btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_exit.ForeColor = System.Drawing.Color.DarkRed;
            btn_exit.Location = new System.Drawing.Point(453, 0);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new System.Drawing.Size(51, 38);
            btn_exit.TabIndex = 2;
            btn_exit.Text = "X";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(132, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(219, 202);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(233, 100);
            panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(64, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(98, 69);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // btn_media
            // 
            btn_media.Dock = System.Windows.Forms.DockStyle.Top;
            btn_media.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_media.ForeColor = System.Drawing.Color.Red;
            btn_media.Location = new System.Drawing.Point(0, 0);
            btn_media.Name = "btn_media";
            btn_media.Size = new System.Drawing.Size(233, 36);
            btn_media.TabIndex = 1;
            btn_media.Text = "Media";
            btn_media.UseVisualStyleBackColor = true;
            btn_media.Click += btn_media_Click;
            // 
            // btn_file
            // 
            btn_file.Dock = System.Windows.Forms.DockStyle.Top;
            btn_file.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_file.ForeColor = System.Drawing.Color.Red;
            btn_file.Location = new System.Drawing.Point(0, 36);
            btn_file.Name = "btn_file";
            btn_file.Size = new System.Drawing.Size(233, 36);
            btn_file.TabIndex = 3;
            btn_file.Text = "Open File";
            btn_file.UseVisualStyleBackColor = true;
            btn_file.Click += btn_file_Click;
            // 
            // button2
            // 
            button2.Dock = System.Windows.Forms.DockStyle.Top;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.ForeColor = System.Drawing.Color.Red;
            button2.Location = new System.Drawing.Point(0, 112);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(233, 38);
            button2.TabIndex = 2;
            button2.Text = "Play List";
            button2.UseVisualStyleBackColor = true;
            // 
            // btn_music
            // 
            btn_music.Dock = System.Windows.Forms.DockStyle.Top;
            btn_music.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_music.ForeColor = System.Drawing.Color.Red;
            btn_music.Location = new System.Drawing.Point(0, 0);
            btn_music.Name = "btn_music";
            btn_music.Size = new System.Drawing.Size(233, 36);
            btn_music.TabIndex = 2;
            btn_music.Text = "Open Music";
            btn_music.UseVisualStyleBackColor = true;
            btn_music.Click += btn_music_Click;
            // 
            // btn_logout
            // 
            btn_logout.Dock = System.Windows.Forms.DockStyle.Top;
            btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_logout.ForeColor = System.Drawing.Color.Red;
            btn_logout.Location = new System.Drawing.Point(0, 74);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new System.Drawing.Size(233, 37);
            btn_logout.TabIndex = 4;
            btn_logout.Text = "Log Out";
            btn_logout.UseVisualStyleBackColor = true;
            // 
            // btn_help
            // 
            btn_help.Dock = System.Windows.Forms.DockStyle.Top;
            btn_help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_help.ForeColor = System.Drawing.Color.Red;
            btn_help.Location = new System.Drawing.Point(0, 38);
            btn_help.Name = "btn_help";
            btn_help.Size = new System.Drawing.Size(233, 36);
            btn_help.TabIndex = 3;
            btn_help.Text = "Help";
            btn_help.UseVisualStyleBackColor = true;
            // 
            // btn_tool
            // 
            btn_tool.Dock = System.Windows.Forms.DockStyle.Top;
            btn_tool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_tool.ForeColor = System.Drawing.Color.Red;
            btn_tool.Location = new System.Drawing.Point(0, 0);
            btn_tool.Name = "btn_tool";
            btn_tool.Size = new System.Drawing.Size(233, 38);
            btn_tool.TabIndex = 2;
            btn_tool.Text = "Tools";
            btn_tool.UseVisualStyleBackColor = true;
            // 
            // pnl_playlist
            // 
            pnl_playlist.Controls.Add(btn_logout);
            pnl_playlist.Controls.Add(btn_help);
            pnl_playlist.Controls.Add(btn_tool);
            pnl_playlist.Dock = System.Windows.Forms.DockStyle.Top;
            pnl_playlist.Location = new System.Drawing.Point(0, 150);
            pnl_playlist.Name = "pnl_playlist";
            pnl_playlist.Size = new System.Drawing.Size(233, 111);
            pnl_playlist.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(pnl_playlist);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(pnl_media);
            panel3.Controls.Add(btn_media);
            panel3.Dock = System.Windows.Forms.DockStyle.Top;
            panel3.Location = new System.Drawing.Point(0, 100);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(233, 338);
            panel3.TabIndex = 1;
            // 
            // pnl_media
            // 
            pnl_media.Controls.Add(btn_file);
            pnl_media.Controls.Add(btn_music);
            pnl_media.Dock = System.Windows.Forms.DockStyle.Top;
            pnl_media.Location = new System.Drawing.Point(0, 36);
            pnl_media.Name = "pnl_media";
            pnl_media.Size = new System.Drawing.Size(233, 76);
            pnl_media.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(31, 30, 68);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = System.Windows.Forms.DockStyle.Left;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(233, 393);
            panel1.TabIndex = 2;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick_1;
            // 
            // FrmPlay
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ClientSize = new System.Drawing.Size(737, 393);
            Controls.Add(panel4);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "FrmPlay";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Khafan";
            Load += Ho3ein_Load_1;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnl_playlist.ResumeLayout(false);
            panel3.ResumeLayout(false);
            pnl_media.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_media;
        private System.Windows.Forms.Button btn_file;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_music;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.Button btn_tool;
        private System.Windows.Forms.Panel pnl_playlist;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnl_media;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_timeSong;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}