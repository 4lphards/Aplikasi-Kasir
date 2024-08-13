using Cashier.Models;
using Cashier.Pages.Actions.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cashier.Pages.Admin
{
    public partial class Home : Form
    {
        private List<Sale> CurentSale = Program.db.Sales.ToList();
        private List<SaleDetail> salesDetails = Program.db.SaleDetails.ToList();
        private Models.User User;
        public Home(Models.User user)
        {
            InitializeComponent();
            User = user;
        }

        private void SearchProduct_Click(object sender, EventArgs e)
        {
            PSearch pSearch = new PSearch(this);
            pSearch.ShowDialog();
        }

        public void UpdateTotalPrice()
        {
            double totalPrice = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                totalPrice += double.Parse(row.Cells[2].Value.ToString());
            }

            label2.Text = totalPrice.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (label2.Text == "0")
            {
                return;
            }

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                label5.Text = "0";
                return;
            }

            var kembalian = int.Parse(textBox1.Text) - int.Parse(label2.Text);

            if (kembalian < 0)
            {
                label5.Text = "0";
            }
            else
            {
                label5.Text = kembalian.ToString();
            }
        }

        private void PrintStruk_Click(object sender, EventArgs e)
        {
            Sale sale = new Sale
            {
                SaleDate = DateTime.Now,
                TotalPrice = int.Parse(label2.Text),
                User = User,
            };

            Program.db.Sales.Add(sale);

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var product = Program.db.Products.FirstOrDefault(p => p.Name.ToLower() == row.Cells[0].Value.ToString().ToLower());
                SaleDetail saleDetail = new SaleDetail
                {
                    Sale = sale,
                    Product = product,
                    Quantity = int.Parse(row.Cells[1].Value.ToString()),
                    SubTotalPrice = decimal.Parse(row.Cells[2].Value.ToString()),
                };

                Program.db.SaleDetails.Add(saleDetail);
                Program.db.SaveChanges();
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var product = Program.db.Products.FirstOrDefault(p => p.Name.ToLower() == row.Cells[0].Value.ToString().ToLower());
                product.Stock -= int.Parse(row.Cells[1].Value.ToString());
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("================================");
            sb.AppendLine("             Kasir App");
            sb.AppendLine("================================");
            sb.AppendLine("Nama Barang\tQty\tHarga");
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                sb.AppendLine($"{row.Cells[0].Value}\t{row.Cells[1].Value}\t{row.Cells[2].Value}");
            }
            sb.AppendLine("================================");
            sb.AppendLine($"Total\t{label2.Text}");
            sb.AppendLine($"Bayar\t{textBox1.Text}");
            sb.AppendLine($"Kembalian\t{label5.Text}");
            sb.AppendLine("================================");
            sb.AppendLine($"Tanggal\t{DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}");
            sb.AppendLine("================================");
            sb.AppendLine("Terima kasih telah berbelanja di Kasir App");
            sb.AppendLine("================================");

            MessageBox.Show(sb.ToString());

            dataGridView1.Rows.Clear();
            label2.Text = "0";
            textBox1.Text = string.Empty;
            label5.Text = "0";
            UpdateTotalPrice();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // check if the button column are clicked
            if (e.ColumnIndex == 3)
            {
                dataGridView1.Rows.RemoveAt(e.RowIndex);
                UpdateTotalPrice();
            }
        }
    }
}
