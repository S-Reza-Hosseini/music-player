
namespace az_payegahDadeh
{
    partial class Frm_login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_login));
            btn_login = new System.Windows.Forms.Button();
            picBox_login = new System.Windows.Forms.PictureBox();
            lbl_user = new System.Windows.Forms.Label();
            lbl_pass = new System.Windows.Forms.Label();
            txt_user = new System.Windows.Forms.TextBox();
            txt_pass = new System.Windows.Forms.TextBox();
            linkLabel1 = new System.Windows.Forms.LinkLabel();
            linkLabel2 = new System.Windows.Forms.LinkLabel();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            lbl_regester = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)picBox_login).BeginInit();
            SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.Location = new System.Drawing.Point(152, 291);
            btn_login.Name = "btn_login";
            btn_login.Size = new System.Drawing.Size(128, 28);
            btn_login.TabIndex = 3;
            btn_login.Text = "login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // picBox_login
            // 
            picBox_login.Image = (System.Drawing.Image)resources.GetObject("picBox_login.Image");
            picBox_login.ImageLocation = "";
            picBox_login.Location = new System.Drawing.Point(148, 12);
            picBox_login.Name = "picBox_login";
            picBox_login.Size = new System.Drawing.Size(132, 99);
            picBox_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picBox_login.TabIndex = 1;
            picBox_login.TabStop = false;
            picBox_login.Click += pictureBox1_Click;
            // 
            // lbl_user
            // 
            lbl_user.AutoSize = true;
            lbl_user.Location = new System.Drawing.Point(66, 156);
            lbl_user.Name = "lbl_user";
            lbl_user.Size = new System.Drawing.Size(59, 15);
            lbl_user.TabIndex = 2;
            lbl_user.Text = "username";
            // 
            // lbl_pass
            // 
            lbl_pass.AutoSize = true;
            lbl_pass.Location = new System.Drawing.Point(68, 208);
            lbl_pass.Name = "lbl_pass";
            lbl_pass.Size = new System.Drawing.Size(57, 15);
            lbl_pass.TabIndex = 3;
            lbl_pass.Text = "password";
            // 
            // txt_user
            // 
            txt_user.Location = new System.Drawing.Point(152, 156);
            txt_user.Name = "txt_user";
            txt_user.Size = new System.Drawing.Size(128, 23);
            txt_user.TabIndex = 0;
            // 
            // txt_pass
            // 
            txt_pass.Location = new System.Drawing.Point(152, 205);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new System.Drawing.Size(128, 23);
            txt_pass.TabIndex = 1;
            txt_pass.TextChanged += textBox2_TextChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new System.Drawing.Point(113, 400);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new System.Drawing.Size(0, 15);
            linkLabel1.TabIndex = 8;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new System.Drawing.Point(66, 263);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new System.Drawing.Size(127, 15);
            linkLabel2.TabIndex = 2;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Forgot your password?";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(152, 377);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(0, 15);
            label1.TabIndex = 10;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(68, 350);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(131, 15);
            label2.TabIndex = 4;
            label2.Text = "Don't have an account?";
            // 
            // lbl_regester
            // 
            lbl_regester.AutoSize = true;
            lbl_regester.Location = new System.Drawing.Point(228, 350);
            lbl_regester.Name = "lbl_regester";
            lbl_regester.Size = new System.Drawing.Size(52, 15);
            lbl_regester.TabIndex = 5;
            lbl_regester.TabStop = true;
            lbl_regester.Text = "Regester";
            lbl_regester.MouseClick += lbl_regester_MouseClick;
            // 
            // Frm_login
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Gainsboro;
            ClientSize = new System.Drawing.Size(367, 376);
            Controls.Add(lbl_regester);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(txt_pass);
            Controls.Add(txt_user);
            Controls.Add(lbl_pass);
            Controls.Add(lbl_user);
            Controls.Add(picBox_login);
            Controls.Add(btn_login);
            Name = "Frm_login";
            Text = "login";
            Load += Frm_login_Load;
            ((System.ComponentModel.ISupportInitialize)picBox_login).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.PictureBox picBox_login;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lbl_regester;
    }
}

