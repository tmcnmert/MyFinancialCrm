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
    public partial class frmbanktransactions : Form
    {
        public frmbanktransactions()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities1 db = new FinancialCrmDbEntities1();
        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnziraatlist_Click(object sender, EventArgs e)
        {
            ShowBankTransactions(1);
        }

        private void frmbanktransactions_Load(object sender, EventArgs e)
        {
            
        }

        private void btnvakıflsit_Click(object sender, EventArgs e)
        {
            ShowBankTransactions(2);
        }

        private void btnislist_Click(object sender, EventArgs e)
        {
            ShowBankTransactions(3);
        }
        private void ShowBankTransactions(int bankId)
        {
            var transactions = db.BankProcesses
                 .Where(t => t.BankId == bankId)
                 .OrderByDescending(t => t.ProcessDate)
                 .Select(t => new {
                     Tarih = t.ProcessDate,
                     Açıklama = t.Description,
                     Tür = t.ProcessType,
                     Tutar = t.Amount
                 })
                 .ToList();

            dataGridView1.DataSource = transactions;
            dataGridView1.Columns["Tutar"].DefaultCellStyle.Format = "N2";
        }



        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }



        private void btnSpendingsForm_Click(object sender, EventArgs e)
        {
            frmspendings frm = new frmspendings();
            frm.Show();
            this.Hide();
        }

        private void btncategory_Click(object sender, EventArgs e)
        {
            frmcategory frm = new frmcategory();
            frm.Show();
            this.Hide();

        }

        private void btnBillForm_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
            this.Hide();
        }

        private void btnbanktransactions_Click(object sender, EventArgs e)
        {
            frmbanktransactions frm = new frmbanktransactions();
            frm.Show();
            this.Hide();

        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            frmsettings frm = new frmsettings();
            frm.Show();
            this.Hide();

        }
    }
}
