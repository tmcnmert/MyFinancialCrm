namespace MyFinancialCrm
{
    partial class frmlogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.lnksignup = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 23);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre:";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(167, 39);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(149, 29);
            this.txtusername.TabIndex = 3;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(167, 77);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(149, 29);
            this.txtpassword.TabIndex = 4;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(143, 125);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(112, 36);
            this.btnlogin.TabIndex = 5;
            this.btnlogin.Text = "Giriş Yap";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // lnksignup
            // 
            this.lnksignup.AutoSize = true;
            this.lnksignup.Location = new System.Drawing.Point(270, 132);
            this.lnksignup.Name = "lnksignup";
            this.lnksignup.Size = new System.Drawing.Size(79, 23);
            this.lnksignup.TabIndex = 6;
            this.lnksignup.TabStop = true;
            this.lnksignup.Text = "Kayıt Ol";
            this.lnksignup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnksignup_LinkClicked);
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(405, 220);
            this.Controls.Add(this.lnksignup);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmlogin";
            this.Text = "frmlogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.LinkLabel lnksignup;
    }
}