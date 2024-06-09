
namespace az_payegahDadeh
{
    partial class FrmUpdatePass
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
            this.lbl_newPass = new System.Windows.Forms.Label();
            this.txtbx_newPass = new System.Windows.Forms.TextBox();
            this.lbl_cPass = new System.Windows.Forms.Label();
            this.txtbx_cpass = new System.Windows.Forms.TextBox();
            this.btn_updatePass = new System.Windows.Forms.Button();
            this.lbl_petName = new System.Windows.Forms.Label();
            this.txtbx_petName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_newPass
            // 
            this.lbl_newPass.AutoSize = true;
            this.lbl_newPass.Location = new System.Drawing.Point(72, 62);
            this.lbl_newPass.Name = "lbl_newPass";
            this.lbl_newPass.Size = new System.Drawing.Size(84, 15);
            this.lbl_newPass.TabIndex = 0;
            this.lbl_newPass.Text = "New Password";
            // 
            // txtbx_newPass
            // 
            this.txtbx_newPass.Location = new System.Drawing.Point(193, 59);
            this.txtbx_newPass.Name = "txtbx_newPass";
            this.txtbx_newPass.Size = new System.Drawing.Size(100, 23);
            this.txtbx_newPass.TabIndex = 1;
            // 
            // lbl_cPass
            // 
            this.lbl_cPass.AutoSize = true;
            this.lbl_cPass.Location = new System.Drawing.Point(72, 118);
            this.lbl_cPass.Name = "lbl_cPass";
            this.lbl_cPass.Size = new System.Drawing.Size(104, 15);
            this.lbl_cPass.TabIndex = 2;
            this.lbl_cPass.Text = "Confirm Password";
            // 
            // txtbx_cpass
            // 
            this.txtbx_cpass.Location = new System.Drawing.Point(193, 115);
            this.txtbx_cpass.Name = "txtbx_cpass";
            this.txtbx_cpass.Size = new System.Drawing.Size(100, 23);
            this.txtbx_cpass.TabIndex = 3;
            // 
            // btn_updatePass
            // 
            this.btn_updatePass.Location = new System.Drawing.Point(145, 229);
            this.btn_updatePass.Name = "btn_updatePass";
            this.btn_updatePass.Size = new System.Drawing.Size(85, 29);
            this.btn_updatePass.TabIndex = 4;
            this.btn_updatePass.Text = "Update Pass";
            this.btn_updatePass.UseVisualStyleBackColor = true;
            this.btn_updatePass.Click += new System.EventHandler(this.btn_updatePass_Click);
            // 
            // lbl_petName
            // 
            this.lbl_petName.AutoSize = true;
            this.lbl_petName.Location = new System.Drawing.Point(72, 174);
            this.lbl_petName.Name = "lbl_petName";
            this.lbl_petName.Size = new System.Drawing.Size(59, 15);
            this.lbl_petName.TabIndex = 5;
            this.lbl_petName.Text = "pet Name";
            // 
            // txtbx_petName
            // 
            this.txtbx_petName.Location = new System.Drawing.Point(193, 171);
            this.txtbx_petName.Name = "txtbx_petName";
            this.txtbx_petName.Size = new System.Drawing.Size(100, 23);
            this.txtbx_petName.TabIndex = 6;
            // 
            // FrmUpdatePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 450);
            this.Controls.Add(this.txtbx_petName);
            this.Controls.Add(this.lbl_petName);
            this.Controls.Add(this.btn_updatePass);
            this.Controls.Add(this.txtbx_cpass);
            this.Controls.Add(this.lbl_cPass);
            this.Controls.Add(this.txtbx_newPass);
            this.Controls.Add(this.lbl_newPass);
            this.Name = "FrmUpdatePass";
            this.Text = "FrmUpdatePass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_newPass;
        private System.Windows.Forms.TextBox txtbx_newPass;
        private System.Windows.Forms.Label lbl_cPass;
        private System.Windows.Forms.TextBox txtbx_cpass;
        private System.Windows.Forms.Button btn_updatePass;
        private System.Windows.Forms.Label lbl_petName;
        private System.Windows.Forms.TextBox txtbx_petName;
    }
}