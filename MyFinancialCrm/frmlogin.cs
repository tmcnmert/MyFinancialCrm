using MyFinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFinancialCrm
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities1 db = new FinancialCrmDbEntities1();
        private void btnlogin_Click(object sender, EventArgs e)
        {
            var username = txtusername.Text;
            var password = txtpassword.Text;
            var user = db.Users.FirstOrDefault(x => x.Username == username && x.Password == password);
            if (user != null)
            {
                // Kullanıcı adı ve şifre doğruysa
                MessageBox.Show("Giriş Başarılı");
                FrmBanks frm = new FrmBanks();
                frm.Show();
                this.Hide();
            }
            else
            {
                // Kullanıcı adı veya şifre yanlışsa
                MessageBox.Show("Kullanıcı adı veya şifre yanlış");
            }
        }

        private void lnksignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmsignup frm = new frmsignup();
            frm.Show();

        }
    }
}
