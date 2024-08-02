using Cashier.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
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
        public DataGridViewRow SelectedRow;
        public int RowIndex;
        public AdminStockPage()
        {
            InitializeComponent();
            RefreshDGV();
        }
        private void RefreshDGV()
        {
            productBindingSource.DataSource = Program.db.Products.ToList();

            TBName.Text = string.Empty;
            TBPrice.Text = string.Empty;
            TbStock.Text = string.Empty;

            BtnAdd.Enabled = true;
            BtnEdit.Enabled = false;
            BtnRemove.Enabled = false;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TBName.Text) || string.IsNullOrEmpty(TBPrice.Text) || string.IsNullOrEmpty(TbStock.Text))
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Product product = new Product
            {
                Name = TBName.Text,
                Price = Convert.ToDecimal(TBPrice.Text),
                Stock = Convert.ToInt32(TbStock.Text)
            };

            DialogResult result = MessageBox.Show("Are you sure you want to add this product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

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

            RowIndex = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                SelectedRow = DGVProduct.Rows[e.RowIndex];
            }
        }

        private void TbSearch_TextChanged(object sender, EventArgs e)
        {
            productBindingSource.DataSource = Program.db.Products.Where(x => x.Name.Contains(TbSearch.Text)).ToList();
            RefreshDGV();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (RowIndex < 0)
            {
                MessageBox.Show("Please select a product to remove", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RefreshDGV();
                return;
            }

            var id = Convert.ToInt32(SelectedRow.Cells[0].Value);
            var Products = Program.db.Products.Find(id);

            DialogResult result = MessageBox.Show("Are you sure you want to remove this product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Program.db.Products.Remove(Products);
                Program.db.SaveChanges();
                RefreshDGV();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (RowIndex < 0)
            {
                MessageBox.Show("Please select a product to edit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RefreshDGV();
                return;
            }

            var id = Convert.ToInt32(SelectedRow.Cells[0].Value);
            var Products = Program.db.Products.Find(id);

            DialogResult result = MessageBox.Show("Are you sure you want to edit this product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Products.Name = TBName.Text;
                Products.Price = Convert.ToDecimal(TBPrice.Text);
                Products.Stock = Convert.ToInt32(TbStock.Text);

                Program.db.SaveChanges();
                RefreshDGV();
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            RefreshDGV();
        }
    }
}
