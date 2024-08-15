using Cashier.Models;
using Cashier.Pages.Actions;
using Cashier.Pages.Actions.Product;
using Microsoft.EntityFrameworkCore.Update.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cashier.Pages
{
    public partial class Stock : Form
    {
        public Models.User User;
        public List<Product> Products { get; set; } = Program.db.Products.ToList();
        public DataGridViewRow SelectedRow;
        public int RowIndex = 0;
        public Stock(Models.User _user)
        {
            InitializeComponent();
            RefreshDGV();
            User = _user;
        }

        private void CheckUser()
        {
            if (User.User_Type == "Kasir")
            {
                BtnAdd.Enabled = false;
                BtnRemove.Enabled = false;
                BtnEdit.Enabled = false;
            } else
            {
                BtnAdd.Enabled = true;
                BtnRemove.Enabled = true;
                BtnEdit.Enabled = true;
            }
        }
        public void RefreshDGV()
        {
            productBindingSource.DataSource = Program.db.Products.ToList();

            BtnAdd.Enabled = true;
            BtnEdit.Enabled = false;
            BtnRemove.Enabled = false;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            PAdd add = new PAdd(this);
            add.ShowDialog();
        }

        private void DGVProduct_ContentCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            BtnEdit.Enabled = true;
            BtnRemove.Enabled = true;

            RowIndex = e.RowIndex;
            
            SelectedRow = DGVProduct.Rows[e.RowIndex];
        }

        private void TbSearch_TextChanged(object sender, EventArgs e)
        {
            var Search = TbSearch.Text.ToLower();
            productBindingSource.DataSource = Program.db.Products.Where(x => x.Name.ToLower().Contains(Search)).ToList();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (RowIndex < 0)
            {
                MessageBox.Show("Tolong pilih pengguna terlebih dahulu", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RefreshDGV();
                return;
            }

            DialogResult result = MessageBox.Show("Anda yakin ingin menghapus produk ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                var id = Convert.ToInt32(SelectedRow.Cells[0].Value);
                var Products = Program.db.Products.Find(id);

                Program.db.Products.Remove(Products);
                Program.db.SaveChanges();
                RefreshDGV();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (RowIndex < 0)
            {
                MessageBox.Show("Tolong pilih produk untuk di edit", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RefreshDGV();
                return;
            }

            var Id = Convert.ToInt32(SelectedRow.Cells[0].Value);

            PEdit EditProduct = new PEdit(Id, this);
            EditProduct.ShowDialog();
        }
    }
}
