namespace MyFinancialCrm
{
    partial class frmcategory
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnsettings = new System.Windows.Forms.Button();
            this.btndashboard = new System.Windows.Forms.Button();
            this.btnbanktransactions = new System.Windows.Forms.Button();
            this.btnBillForm = new System.Windows.Forms.Button();
            this.btnSpendingsForm = new System.Windows.Forms.Button();
            this.btnBanksForm = new System.Windows.Forms.Button();
            this.btncategory = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnlist = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.txtcategoryId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnexit);
            this.panel1.Controls.Add(this.btnsettings);
            this.panel1.Controls.Add(this.btndashboard);
            this.panel1.Controls.Add(this.btnbanktransactions);
            this.panel1.Controls.Add(this.btnBillForm);
            this.panel1.Controls.Add(this.btnSpendingsForm);
            this.panel1.Controls.Add(this.btnBanksForm);
            this.panel1.Controls.Add(this.btncategory);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 441);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(188, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.btnexit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Location = new System.Drawing.Point(20, 336);
            this.btnexit.Margin = new System.Windows.Forms.Padding(2);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(139, 35);
            this.btnexit.TabIndex = 7;
            this.btnexit.Text = "Çıkış Yap";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnsettings
            // 
            this.btnsettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.btnsettings.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsettings.ForeColor = System.Drawing.Color.White;
            this.btnsettings.Location = new System.Drawing.Point(20, 287);
            this.btnsettings.Margin = new System.Windows.Forms.Padding(2);
            this.btnsettings.Name = "btnsettings";
            this.btnsettings.Size = new System.Drawing.Size(139, 35);
            this.btnsettings.TabIndex = 6;
            this.btnsettings.Text = "Ayarlar";
            this.btnsettings.UseVisualStyleBackColor = false;
            this.btnsettings.Click += new System.EventHandler(this.btnsettings_Click);
            // 
            // btndashboard
            // 
            this.btndashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.btndashboard.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndashboard.ForeColor = System.Drawing.Color.White;
            this.btndashboard.Location = new System.Drawing.Point(20, 241);
            this.btndashboard.Margin = new System.Windows.Forms.Padding(2);
            this.btndashboard.Name = "btndashboard";
            this.btndashboard.Size = new System.Drawing.Size(139, 35);
            this.btndashboard.TabIndex = 5;
            this.btndashboard.Text = "Dashboard";
            this.btndashboard.UseVisualStyleBackColor = false;
            this.btndashboard.Click += new System.EventHandler(this.btndashboard_Click);
            // 
            // btnbanktransactions
            // 
            this.btnbanktransactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.btnbanktransactions.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbanktransactions.ForeColor = System.Drawing.Color.White;
            this.btnbanktransactions.Location = new System.Drawing.Point(20, 195);
            this.btnbanktransactions.Margin = new System.Windows.Forms.Padding(2);
            this.btnbanktransactions.Name = "btnbanktransactions";
            this.btnbanktransactions.Size = new System.Drawing.Size(139, 35);
            this.btnbanktransactions.TabIndex = 4;
            this.btnbanktransactions.Text = "Banka Hareketleri";
            this.btnbanktransactions.UseVisualStyleBackColor = false;
            this.btnbanktransactions.Click += new System.EventHandler(this.btnbanktransactions_Click);
            // 
            // btnBillForm
            // 
            this.btnBillForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.btnBillForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBillForm.ForeColor = System.Drawing.Color.White;
            this.btnBillForm.Location = new System.Drawing.Point(20, 149);
            this.btnBillForm.Margin = new System.Windows.Forms.Padding(2);
            this.btnBillForm.Name = "btnBillForm";
            this.btnBillForm.Size = new System.Drawing.Size(139, 35);
            this.btnBillForm.TabIndex = 3;
            this.btnBillForm.Text = "Faturalar";
            this.btnBillForm.UseVisualStyleBackColor = false;
            this.btnBillForm.Click += new System.EventHandler(this.btnBillForm_Click);
            // 
            // btnSpendingsForm
            // 
            this.btnSpendingsForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.btnSpendingsForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSpendingsForm.ForeColor = System.Drawing.Color.White;
            this.btnSpendingsForm.Location = new System.Drawing.Point(20, 103);
            this.btnSpendingsForm.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpendingsForm.Name = "btnSpendingsForm";
            this.btnSpendingsForm.Size = new System.Drawing.Size(139, 35);
            this.btnSpendingsForm.TabIndex = 2;
            this.btnSpendingsForm.Text = "Giderler";
            this.btnSpendingsForm.UseVisualStyleBackColor = false;
            this.btnSpendingsForm.Click += new System.EventHandler(this.btnSpendingsForm_Click);
            // 
            // btnBanksForm
            // 
            this.btnBanksForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.btnBanksForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBanksForm.ForeColor = System.Drawing.Color.White;
            this.btnBanksForm.Location = new System.Drawing.Point(20, 59);
            this.btnBanksForm.Margin = new System.Windows.Forms.Padding(2);
            this.btnBanksForm.Name = "btnBanksForm";
            this.btnBanksForm.Size = new System.Drawing.Size(139, 35);
            this.btnBanksForm.TabIndex = 1;
            this.btnBanksForm.Text = "Bankalar";
            this.btnBanksForm.UseVisualStyleBackColor = false;
            this.btnBanksForm.Click += new System.EventHandler(this.btnBanksForm_Click);
            // 
            // btncategory
            // 
            this.btncategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.btncategory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncategory.ForeColor = System.Drawing.Color.White;
            this.btncategory.Location = new System.Drawing.Point(20, 16);
            this.btncategory.Margin = new System.Windows.Forms.Padding(2);
            this.btncategory.Name = "btncategory";
            this.btncategory.Size = new System.Drawing.Size(139, 35);
            this.btncategory.TabIndex = 0;
            this.btncategory.Text = "Kategoriler";
            this.btncategory.UseVisualStyleBackColor = false;
            this.btncategory.Click += new System.EventHandler(this.btncategory_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(184, -11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 162);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bu sayfada kategorileri ekleyebilir,\r\nsilebilir, düzenleyebilir ve \r\ngüncelleyebi" +
    "lirsiniz.";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(509, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(534, 438);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kategoriler";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(490, 389);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox4.Controls.Add(this.btnupdate);
            this.groupBox4.Controls.Add(this.btndelete);
            this.groupBox4.Controls.Add(this.btnlist);
            this.groupBox4.Controls.Add(this.btnadd);
            this.groupBox4.Controls.Add(this.txtCategoryName);
            this.groupBox4.Controls.Add(this.txtcategoryId);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(188, 149);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(315, 292);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "İşlemler";
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(177, 203);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(103, 40);
            this.btnupdate.TabIndex = 7;
            this.btnupdate.Text = "Güncelle";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(14, 203);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(103, 40);
            this.btndelete.TabIndex = 6;
            this.btndelete.Text = "Sil";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnlist
            // 
            this.btnlist.Location = new System.Drawing.Point(177, 138);
            this.btnlist.Name = "btnlist";
            this.btnlist.Size = new System.Drawing.Size(103, 40);
            this.btnlist.TabIndex = 5;
            this.btnlist.Text = "Listele";
            this.btnlist.UseVisualStyleBackColor = true;
            this.btnlist.Click += new System.EventHandler(this.btnlist_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(14, 138);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(103, 40);
            this.btnadd.TabIndex = 4;
            this.btnadd.Text = "Ekle";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(136, 71);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(154, 29);
            this.txtCategoryName.TabIndex = 3;
            // 
            // txtcategoryId
            // 
            this.txtcategoryId.Location = new System.Drawing.Point(136, 36);
            this.txtcategoryId.Name = "txtcategoryId";
            this.txtcategoryId.Size = new System.Drawing.Size(154, 29);
            this.txtcategoryId.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kategori Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kategori Id:";
            // 
            // frmcategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 441);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmcategory";
            this.Text = "Kategoriler";
            this.Load += new System.EventHandler(this.frmcategory_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnsettings;
        private System.Windows.Forms.Button btndashboard;
        private System.Windows.Forms.Button btnbanktransactions;
        private System.Windows.Forms.Button btnBillForm;
        private System.Windows.Forms.Button btnSpendingsForm;
        private System.Windows.Forms.Button btnBanksForm;
        private System.Windows.Forms.Button btncategory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnlist;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.TextBox txtcategoryId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}