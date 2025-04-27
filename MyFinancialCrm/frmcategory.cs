using MyFinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFinancialCrm
{
    public partial class frmcategory : Form
    {
        public frmcategory()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities1 db = new FinancialCrmDbEntities1();
        private void LoadCategories()
        {
            var categories =db.Categories.ToList() ;
            dataGridView1.DataSource = categories;
        }
        private void frmcategory_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            var newCategory = new Categories
            {
                CategoryName = txtCategoryName.Text,
            };
            db.Categories.Add(newCategory);
            db.SaveChanges();
            MessageBox.Show("Kategori Eklendi");
            LoadCategories();
            txtCategoryName.Clear();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string title = txtCategoryName.Text;
            int id = int.Parse(txtcategoryId.Text);

            var values=db.Categories.Find(id);
            values.CategoryName = title;
            db.SaveChanges();
            MessageBox.Show("Kategori Güncellendi");
            var values2 = db.Categories.ToList();
            dataGridView1.DataSource = values2;
            txtCategoryName.Clear();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtcategoryId.Text);
            var removeValue = db.Categories.Find(id);
            db.Categories.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Kategori Silindi");
            var values2 = db.Categories.ToList();
            dataGridView1.DataSource = values2;
        }

        private void btnlist_Click(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();

        }



        private void btndashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();

        }

        private void btncategory_Click(object sender, EventArgs e)
        {
            frmcategory frm = new frmcategory();
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

        private void btnsettings_Click(object sender, EventArgs e)
        {
            frmsettings frmsettings = new frmsettings();
            frmsettings.Show();
            this.Hide();

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
