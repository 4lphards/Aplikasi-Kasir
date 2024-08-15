using Cashier.Pages.Admin;
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
    public partial class PSearch : Form
    {
        private Home home;
        public PSearch(Home _Home)
        {
            InitializeComponent();
            InitializeAutoComplete();
            home = _Home;
        }

        private void InitializeAutoComplete()
        {
            var productNames = Program.db.Products.Select(p => p.Name).ToList();

            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            autoCompleteCollection.AddRange(productNames.ToArray());

            TbName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            TbName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            TbName.AutoCompleteCustomSource = autoCompleteCollection;
        }

        private void AddtoCart_Click(object sender, EventArgs e)
        {
            var ProductName = TbName.Text;
            var ProductQuantity = TbQuantity.Text;

            if (string.IsNullOrEmpty(ProductName) || string.IsNullOrEmpty(ProductQuantity))
            {
                MessageBox.Show("Isi kolom yang tersedia!");
                return;
            }

            var product = Program.db.Products.FirstOrDefault(p => p.Name.ToLower() == ProductName.ToLower());

            if (product == null)
            {
                MessageBox.Show("Produk tidak ditemukan!");
                return;
            }

            if (product.Stock < int.Parse(ProductQuantity))
            {
                MessageBox.Show("Stok tidak mencukupi!");
                return;
            }

            // check if there are the same product, then adds the quantity, if the quantity exceed the stock then show a message box
            foreach (DataGridViewRow row in home.dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == product.Name)
                {
                    var totalQuantity = int.Parse(row.Cells[1].Value.ToString()) + int.Parse(ProductQuantity);
                    if (totalQuantity > product.Stock)
                    {
                        MessageBox.Show("Stok tidak mencukupi!");
                        return;
                    }

                    row.Cells[1].Value = totalQuantity;
                    row.Cells[2].Value = product.Price * totalQuantity;
                    this.Close();
                    return;
                }
            }

            home.dataGridView1.Rows.Add(product.Name, int.Parse(ProductQuantity), product.Price * int.Parse(ProductQuantity));

            home.UpdateTotalPrice();

            this.Close();
        }

    }
}
