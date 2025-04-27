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
    public partial class frmsettings : Form
    {
        public frmsettings()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities1 db = new FinancialCrmDbEntities1();
        private void btnupdate_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;
            var user = db.Users.FirstOrDefault(u => u.Username == username);
            if (user != null)
            {
                user.Password = txtpassword.Text;
                db.SaveChanges();
                MessageBox.Show("Kullanıcı bilgileri güncellendi.");
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı.");

            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();

        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }



        private void btncategory_Click(object sender, EventArgs e)
        {
            frmcategory frm = new frmcategory();
            frm.Show();
            this.Hide();
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            frmsettings frm = new frmsettings();
            frm.Show();
            this.Hide();

        }

        private void btnbanktransactions_Click(object sender, EventArgs e)
        {
            frmbanktransactions frm = new frmbanktransactions();
            frm.Show();
            this.Hide();
        }

        private void btnBillForm_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
            this.Hide();
        }

        private void btnSpendingsForm_Click(object sender, EventArgs e)
        {
            frmspendings frm = new frmspendings();
            frm.Show();
            this.Hide();
        }
    }
}
