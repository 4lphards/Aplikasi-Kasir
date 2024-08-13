using Cashier.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cashier.Pages.Actions.Product
{
    public partial class PAdd : Form
    {
        public List<Models.Product> Products = Program.db.Products.ToList();
        private Stock StockForm;
        public PAdd(Stock _StockForm)
        {
            InitializeComponent();
            StockForm = _StockForm;
        }

        public void BtnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TbName.Text) || string.IsNullOrEmpty(TbPrice.Text) || string.IsNullOrEmpty(TbStock.Text))
            {
                MessageBox.Show("Isi kolom yang kosong!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Anda yakin ingin menambah produk ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Models.Product product = new Models.Product
                {
                    Name = TbName.Text,
                    Price = Convert.ToDecimal(TbPrice.Text),
                    Stock = Convert.ToInt32(TbStock.Text)
                };

                Program.db.Products.Add(product);
                Program.db.SaveChanges();
                StockForm.RefreshDGV();
                this.Close();
            }
        }
    }
}
