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
    public partial class frmspendings : Form
    {
        public frmspendings()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities1 db = new FinancialCrmDbEntities1();

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void frmspendings_Load(object sender, EventArgs e)
        {
            // Bu ayın başından bugüne varsayılan tarih aralığı
            dtpStartDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpEndDate.Value = DateTime.Now;

            // Verileri yükle
            LoadData();
        }

        private void LoadData()
        {
            // Seçilen tarih aralığı
            var startDate = dtpStartDate.Value.Date;
            var endDate = dtpEndDate.Value.Date.AddDays(1);

            // Verileri sorgula
            var data = db.Spendings
                .Where(s => s.SpendingDate >= startDate && s.SpendingDate < endDate)
                .OrderByDescending(s => s.SpendingDate)
                .Select(s => new {
                    s.SpendingDate,
                    s.SpendingTitle,
                    s.SpendingAmount
                })
                .ToList();

            // DataGridView'e bağla
            dataGridView1.DataSource = data;

            // Sütun başlıklarını düzenle
            dataGridView1.Columns["SpendingDate"].HeaderText = "Tarih";
            dataGridView1.Columns["SpendingTitle"].HeaderText = "Açıklama";
            dataGridView1.Columns["SpendingAmount"].HeaderText = "Tutar";

            // Tutar formatı
            dataGridView1.Columns["SpendingAmount"].DefaultCellStyle.Format = "N2";
        }

        private void btncategory_Click(object sender, EventArgs e)
        {
            frmcategory frm = new frmcategory();
            frm.Show();
            this.Hide();

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

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
