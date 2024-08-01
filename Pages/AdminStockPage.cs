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

namespace Cashier.Pages
{
    public partial class AdminStockPage : Form
    {
        public List<Product> Products = Program.db.Products.ToList();
        public AdminStockPage()
        {
            InitializeComponent();
            RefreshDGV();
        }
        private void RefreshDGV()
        {
            productBindingSource.DataSource = Program.db.Products.ToList();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                Name = TBName.Text,
                Price = Convert.ToDecimal(TBPrice.Text),
                Stock = Convert.ToInt32(TbStock.Text)
            };

            DialogResult result = MessageBox.Show("Apakah anda yakin ingin menambahkan produk ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Program.db.Products.Add(product);
                Program.db.SaveChanges();
                RefreshDGV();
            }

        }

        private void DGVProduct_ContentCellClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnAdd.Enabled = false;
            BtnEdit.Enabled = true;
            BtnRemove.Enabled = true;

            if (DGVProduct.SelectedRows.Count > 0)
            {
                var selectedRow = DGVProduct.SelectedRows[0];
                var firstColumnValue = selectedRow.Cells[0].Value.ToString();

                var CurrentProduct = Program.db.Products.FirstOrDefault(Products => Products.Id == Convert.ToInt32(firstColumnValue)); 

                TBName.Text = CurrentProduct.Name;
                TBPrice.Text = CurrentProduct.Price.ToString();
                TbStock.Text = CurrentProduct.Stock.ToString();
            }
        }
    }
}
