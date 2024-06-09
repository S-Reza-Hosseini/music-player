namespace az_payegahDadeh
{
    partial class FrmDeletAccount
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
            btn_submit = new System.Windows.Forms.Button();
            lbl_user = new System.Windows.Forms.Label();
            txtbx_user = new System.Windows.Forms.TextBox();
            lbl_pass = new System.Windows.Forms.Label();
            txtbx_pass = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // btn_submit
            // 
            btn_submit.Location = new System.Drawing.Point(122, 191);
            btn_submit.Name = "btn_submit";
            btn_submit.Size = new System.Drawing.Size(86, 26);
            btn_submit.TabIndex = 0;
            btn_submit.Text = "Submit";
            btn_submit.UseVisualStyleBackColor = true;
            btn_submit.Click += btn_submit_Click;
            // 
            // lbl_user
            // 
            lbl_user.AutoSize = true;
            lbl_user.Location = new System.Drawing.Point(49, 72);
            lbl_user.Name = "lbl_user";
            lbl_user.Size = new System.Drawing.Size(60, 15);
            lbl_user.TabIndex = 1;
            lbl_user.Text = "Username";
            // 
            // txtbx_user
            // 
            txtbx_user.Location = new System.Drawing.Point(158, 69);
            txtbx_user.Name = "txtbx_user";
            txtbx_user.Size = new System.Drawing.Size(119, 23);
            txtbx_user.TabIndex = 2;
            // 
            // lbl_pass
            // 
            lbl_pass.AutoSize = true;
            lbl_pass.Location = new System.Drawing.Point(52, 130);
            lbl_pass.Name = "lbl_pass";
            lbl_pass.Size = new System.Drawing.Size(57, 15);
            lbl_pass.TabIndex = 1;
            lbl_pass.Text = "Password";
            // 
            // txtbx_pass
            // 
            txtbx_pass.Location = new System.Drawing.Point(158, 122);
            txtbx_pass.Name = "txtbx_pass";
            txtbx_pass.Size = new System.Drawing.Size(119, 23);
            txtbx_pass.TabIndex = 2;
            txtbx_pass.TextChanged += textBox2_TextChanged;
            // 
            // FrmDeletAccount
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Gainsboro;
            ClientSize = new System.Drawing.Size(349, 450);
            Controls.Add(txtbx_pass);
            Controls.Add(lbl_pass);
            Controls.Add(txtbx_user);
            Controls.Add(lbl_user);
            Controls.Add(btn_submit);
            Name = "FrmDeletAccount";
            Text = "FrmDeletAccount";
            Load += FrmDeletAccount_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.TextBox txtbx_user;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.TextBox txtbx_pass;
    }
}