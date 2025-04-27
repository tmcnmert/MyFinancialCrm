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
    public partial class frmsignup : Form
    {
        public frmsignup()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities1 db = new FinancialCrmDbEntities1();

        private void btnsignup_Click(object sender, EventArgs e)
        {
            if (db.Users.Any(x => x.Username == txtusername.Text))
            {
                MessageBox.Show("Bu kullanıcı adı zaten alınmış");
            }
            else
            {
                db.Users.Add(new Users
                {
                    Username = txtusername.Text,
                    Password = txtpassword.Text
                });
                db.SaveChanges();
                MessageBox.Show("Kayıt başarılı");

            }
        }
    }
}

