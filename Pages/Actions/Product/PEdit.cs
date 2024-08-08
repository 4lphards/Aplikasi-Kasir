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
    public partial class PEdit : Form
    {
        private int productId;
        private Stock stock;
        private List<Models.Product> products = Program.db.Products.ToList();
        public PEdit(int _product, Stock _stock)
        {
            InitializeComponent();
            productId = _product;
            stock = _stock;

            var product = products.FirstOrDefault(p => p.Id == productId);

            TbName.Text = product.Name;
            TbPrice.Text = product.Price.ToString();
            TbStock.Text = product.Stock.ToString();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to edit this product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                var product = products.FirstOrDefault(p => p.Id == productId);

                product.Name = TbName.Text;
                product.Price = Convert.ToDecimal(TbPrice.Text);
                product.Stock = Convert.ToInt32(TbStock.Text);

                Program.db.SaveChanges();
                stock.RefreshDGV();
                this.Close();
            }
        }
    }
}
