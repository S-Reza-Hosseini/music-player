
namespace az_payegahDadeh
{
    partial class Frm_regester
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_regester));
            this.btn_regester = new System.Windows.Forms.Button();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.lbl_havedAccount = new System.Windows.Forms.Label();
            this.lbl_Log = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gbx_mainInformation = new System.Windows.Forms.GroupBox();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.MaskedTextBox();
            this.txt_confirmPass = new System.Windows.Forms.TextBox();
            this.lbl_confirmPass = new System.Windows.Forms.Label();
            this.g = new System.Windows.Forms.GroupBox();
            this.rdb_female = new System.Windows.Forms.RadioButton();
            this.rdb_male = new System.Windows.Forms.RadioButton();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.lbl_age = new System.Windows.Forms.Label();
            this.gbx_intrested = new System.Windows.Forms.GroupBox();
            this.check_jaz = new System.Windows.Forms.CheckBox();
            this.check_rock = new System.Windows.Forms.CheckBox();
            this.check_metal = new System.Windows.Forms.CheckBox();
            this.check_pop = new System.Windows.Forms.CheckBox();
            this.check_hiphop = new System.Windows.Forms.CheckBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_petName = new System.Windows.Forms.Label();
            this.txtbx_petName = new System.Windows.Forms.TextBox();
            this.txtbx_age = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gbx_mainInformation.SuspendLayout();
            this.g.SuspendLayout();
            this.gbx_intrested.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_regester
            // 
            this.btn_regester.Location = new System.Drawing.Point(212, 450);
            this.btn_regester.Name = "btn_regester";
            this.btn_regester.Size = new System.Drawing.Size(132, 38);
            this.btn_regester.TabIndex = 15;
            this.btn_regester.Text = "Regester";
            this.btn_regester.UseVisualStyleBackColor = true;
            this.btn_regester.Click += new System.EventHandler(this.btn_regester_Click);
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(6, 93);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(59, 15);
            this.lbl_user.TabIndex = 2;
            this.lbl_user.Text = "username";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(14, 122);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(36, 15);
            this.lbl_email.TabIndex = 3;
            this.lbl_email.Text = "email";
            this.lbl_email.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Location = new System.Drawing.Point(6, 152);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(57, 15);
            this.lbl_pass.TabIndex = 4;
            this.lbl_pass.Text = "password";
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(125, 90);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(132, 23);
            this.txt_user.TabIndex = 2;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(125, 149);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(132, 23);
            this.txt_pass.TabIndex = 4;
            // 
            // lbl_havedAccount
            // 
            this.lbl_havedAccount.AutoSize = true;
            this.lbl_havedAccount.Location = new System.Drawing.Point(204, 491);
            this.lbl_havedAccount.Name = "lbl_havedAccount";
            this.lbl_havedAccount.Size = new System.Drawing.Size(140, 15);
            this.lbl_havedAccount.TabIndex = 15;
            this.lbl_havedAccount.Text = "Do you have an account?";
            // 
            // lbl_Log
            // 
            this.lbl_Log.AutoSize = true;
            this.lbl_Log.Location = new System.Drawing.Point(397, 491);
            this.lbl_Log.Name = "lbl_Log";
            this.lbl_Log.Size = new System.Drawing.Size(37, 15);
            this.lbl_Log.TabIndex = 17;
            this.lbl_Log.TabStop = true;
            this.lbl_Log.Text = "Login";
            this.lbl_Log.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.ImageLocation = "";
            this.pictureBox2.Location = new System.Drawing.Point(290, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(132, 99);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // gbx_mainInformation
            // 
            this.gbx_mainInformation.Controls.Add(this.txt_lastname);
            this.gbx_mainInformation.Controls.Add(this.label3);
            this.gbx_mainInformation.Controls.Add(this.txt_name);
            this.gbx_mainInformation.Controls.Add(this.lbl_name);
            this.gbx_mainInformation.Controls.Add(this.txt_email);
            this.gbx_mainInformation.Controls.Add(this.lbl_user);
            this.gbx_mainInformation.Controls.Add(this.txt_user);
            this.gbx_mainInformation.Controls.Add(this.txt_confirmPass);
            this.gbx_mainInformation.Controls.Add(this.txt_pass);
            this.gbx_mainInformation.Controls.Add(this.lbl_email);
            this.gbx_mainInformation.Controls.Add(this.lbl_confirmPass);
            this.gbx_mainInformation.Controls.Add(this.lbl_pass);
            this.gbx_mainInformation.Location = new System.Drawing.Point(12, 117);
            this.gbx_mainInformation.Name = "gbx_mainInformation";
            this.gbx_mainInformation.Size = new System.Drawing.Size(311, 227);
            this.gbx_mainInformation.TabIndex = 0;
            this.gbx_mainInformation.TabStop = false;
            this.gbx_mainInformation.Text = "main Information";
            this.gbx_mainInformation.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_lastname
            // 
            this.txt_lastname.Location = new System.Drawing.Point(125, 61);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(132, 23);
            this.txt_lastname.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "family";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(125, 32);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(132, 23);
            this.txt_name.TabIndex = 0;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(14, 35);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(39, 15);
            this.lbl_name.TabIndex = 12;
            this.lbl_name.Text = "Name";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(125, 119);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(132, 23);
            this.txt_email.TabIndex = 3;
            this.txt_email.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // txt_confirmPass
            // 
            this.txt_confirmPass.Location = new System.Drawing.Point(125, 178);
            this.txt_confirmPass.Name = "txt_confirmPass";
            this.txt_confirmPass.Size = new System.Drawing.Size(132, 23);
            this.txt_confirmPass.TabIndex = 5;
            // 
            // lbl_confirmPass
            // 
            this.lbl_confirmPass.AutoSize = true;
            this.lbl_confirmPass.Location = new System.Drawing.Point(0, 181);
            this.lbl_confirmPass.Name = "lbl_confirmPass";
            this.lbl_confirmPass.Size = new System.Drawing.Size(104, 15);
            this.lbl_confirmPass.TabIndex = 4;
            this.lbl_confirmPass.Text = "Confirm password";
            // 
            // g
            // 
            this.g.Controls.Add(this.txtbx_age);
            this.g.Controls.Add(this.rdb_female);
            this.g.Controls.Add(this.rdb_male);
            this.g.Controls.Add(this.lbl_gender);
            this.g.Controls.Add(this.lbl_age);
            this.g.Location = new System.Drawing.Point(361, 117);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(343, 95);
            this.g.TabIndex = 1;
            this.g.TabStop = false;
            this.g.Text = "optional Info";
            this.g.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // rdb_female
            // 
            this.rdb_female.AutoSize = true;
            this.rdb_female.Location = new System.Drawing.Point(215, 59);
            this.rdb_female.Name = "rdb_female";
            this.rdb_female.Size = new System.Drawing.Size(63, 19);
            this.rdb_female.TabIndex = 9;
            this.rdb_female.TabStop = true;
            this.rdb_female.Text = "Female";
            this.rdb_female.UseVisualStyleBackColor = true;
            // 
            // rdb_male
            // 
            this.rdb_male.AutoSize = true;
            this.rdb_male.Location = new System.Drawing.Point(115, 59);
            this.rdb_male.Name = "rdb_male";
            this.rdb_male.Size = new System.Drawing.Size(51, 19);
            this.rdb_male.TabIndex = 8;
            this.rdb_male.TabStop = true;
            this.rdb_male.Text = "Male";
            this.rdb_male.UseVisualStyleBackColor = true;
            this.rdb_male.CheckedChanged += new System.EventHandler(this.rdb_male_CheckedChanged);
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Location = new System.Drawing.Point(22, 61);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(44, 15);
            this.lbl_gender.TabIndex = 2;
            this.lbl_gender.Text = "gender";
            this.lbl_gender.Click += new System.EventHandler(this.label9_Click_1);
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.Location = new System.Drawing.Point(22, 23);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(28, 15);
            this.lbl_age.TabIndex = 0;
            this.lbl_age.Text = "Age";
            // 
            // gbx_intrested
            // 
            this.gbx_intrested.Controls.Add(this.check_jaz);
            this.gbx_intrested.Controls.Add(this.check_rock);
            this.gbx_intrested.Controls.Add(this.check_metal);
            this.gbx_intrested.Controls.Add(this.check_pop);
            this.gbx_intrested.Controls.Add(this.check_hiphop);
            this.gbx_intrested.Location = new System.Drawing.Point(12, 350);
            this.gbx_intrested.Name = "gbx_intrested";
            this.gbx_intrested.Size = new System.Drawing.Size(715, 77);
            this.gbx_intrested.TabIndex = 2;
            this.gbx_intrested.TabStop = false;
            this.gbx_intrested.Text = "intrested";
            this.gbx_intrested.Enter += new System.EventHandler(this.gbx_intrested_Enter);
            // 
            // check_jaz
            // 
            this.check_jaz.AutoSize = true;
            this.check_jaz.Location = new System.Drawing.Point(318, 35);
            this.check_jaz.Name = "check_jaz";
            this.check_jaz.Size = new System.Drawing.Size(41, 19);
            this.check_jaz.TabIndex = 14;
            this.check_jaz.Text = "Jaz";
            this.check_jaz.UseVisualStyleBackColor = true;
            // 
            // check_rock
            // 
            this.check_rock.AutoSize = true;
            this.check_rock.Location = new System.Drawing.Point(103, 35);
            this.check_rock.Name = "check_rock";
            this.check_rock.Size = new System.Drawing.Size(52, 19);
            this.check_rock.TabIndex = 11;
            this.check_rock.Text = "Rock";
            this.check_rock.UseVisualStyleBackColor = true;
            // 
            // check_metal
            // 
            this.check_metal.AutoSize = true;
            this.check_metal.Location = new System.Drawing.Point(175, 35);
            this.check_metal.Name = "check_metal";
            this.check_metal.Size = new System.Drawing.Size(56, 19);
            this.check_metal.TabIndex = 12;
            this.check_metal.Text = "Metal";
            this.check_metal.UseVisualStyleBackColor = true;
            this.check_metal.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // check_pop
            // 
            this.check_pop.AutoSize = true;
            this.check_pop.Location = new System.Drawing.Point(254, 35);
            this.check_pop.Name = "check_pop";
            this.check_pop.Size = new System.Drawing.Size(47, 19);
            this.check_pop.TabIndex = 13;
            this.check_pop.Text = "Pop";
            this.check_pop.UseVisualStyleBackColor = true;
            this.check_pop.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // check_hiphop
            // 
            this.check_hiphop.AutoSize = true;
            this.check_hiphop.Location = new System.Drawing.Point(24, 35);
            this.check_hiphop.Name = "check_hiphop";
            this.check_hiphop.Size = new System.Drawing.Size(71, 19);
            this.check_hiphop.TabIndex = 10;
            this.check_hiphop.Text = "Hip Hop";
            this.check_hiphop.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(381, 450);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(132, 38);
            this.btn_clear.TabIndex = 16;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtbx_petName);
            this.groupBox1.Controls.Add(this.lbl_petName);
            this.groupBox1.Location = new System.Drawing.Point(357, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 100);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Security Question";
            // 
            // lbl_petName
            // 
            this.lbl_petName.AutoSize = true;
            this.lbl_petName.Location = new System.Drawing.Point(16, 47);
            this.lbl_petName.Name = "lbl_petName";
            this.lbl_petName.Size = new System.Drawing.Size(126, 15);
            this.lbl_petName.TabIndex = 0;
            this.lbl_petName.Text = "what\'s your pet name?";
            // 
            // txtbx_petName
            // 
            this.txtbx_petName.Location = new System.Drawing.Point(143, 43);
            this.txtbx_petName.Name = "txtbx_petName";
            this.txtbx_petName.Size = new System.Drawing.Size(132, 23);
            this.txtbx_petName.TabIndex = 1;
            // 
            // txtbx_age
            // 
            this.txtbx_age.Location = new System.Drawing.Point(139, 20);
            this.txtbx_age.Name = "txtbx_age";
            this.txtbx_age.Size = new System.Drawing.Size(132, 23);
            this.txtbx_age.TabIndex = 10;
            // 
            // Frm_regester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(739, 594);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbx_intrested);
            this.Controls.Add(this.g);
            this.Controls.Add(this.lbl_Log);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbl_havedAccount);
            this.Controls.Add(this.gbx_mainInformation);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_regester);
            this.Name = "Frm_regester";
            this.Text = "Regester";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gbx_mainInformation.ResumeLayout(false);
            this.gbx_mainInformation.PerformLayout();
            this.g.ResumeLayout(false);
            this.g.PerformLayout();
            this.gbx_intrested.ResumeLayout(false);
            this.gbx_intrested.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_regester;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label lbl_havedAccount;
        private System.Windows.Forms.LinkLabel lbl_Log;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox gbx_mainInformation;
        private System.Windows.Forms.GroupBox g;
        private System.Windows.Forms.RadioButton rdb_female;
        private System.Windows.Forms.RadioButton rdb_male;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.MaskedTextBox txt_email;
        private System.Windows.Forms.GroupBox gbx_intrested;
        private System.Windows.Forms.CheckBox check_rock;
        private System.Windows.Forms.CheckBox check_metal;
        private System.Windows.Forms.CheckBox check_hiphop;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox txt_confirmPass;
        private System.Windows.Forms.Label lbl_confirmPass;
        private System.Windows.Forms.CheckBox check_pop;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.CheckBox check_jaz;
        private System.Windows.Forms.TextBox txt_lastname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtbx_petName;
        private System.Windows.Forms.Label lbl_petName;
        private System.Windows.Forms.TextBox txtbx_age;
    }
}