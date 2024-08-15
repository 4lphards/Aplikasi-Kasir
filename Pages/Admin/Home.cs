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
        private Customer? CurrentMember = null;
        private Models.User User;
        private int Kembalian = 0;
        private double Discount;

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
            double price = 0;

            if (CurrentMember != null)
            {
                switch (CurrentMember.MemberType)
                {
                    case "Regular":
                        Discount = 0.05;
                        break;
                    case "Silver":
                        Discount = 0.1;
                        break;
                    case "Gold":
                        Discount = 0.15;
                        break;
                    case "Platinum":
                        Discount = 0.2;
                        break;
                }
            }
            else
            {
                Discount = 0;
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[2].Value != null)
                {
                    price += double.Parse(row.Cells[2].Value.ToString());

                    if (CurrentMember != null)
                    {
                        totalPrice -= price * Discount;
                    }
                }
            }

            label2.Text = totalPrice.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }

            if (label2.Text == "0")
            {
                return;
            }

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                Kembalian = 0;
                return;
            }

            var kembalian = int.Parse(textBox1.Text) - int.Parse(label2.Text);

            if (kembalian < 0)
            {
                Kembalian = 0;
            }
            else
            {
                Kembalian = kembalian;
            }
        }

        private void PrintStruk_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Tidak ada barang yang dibeli", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Sale sale = new Sale
            {
                SaleDate = DateTime.Now,
                TotalPrice = int.Parse(label2.Text),
                Customer = CurrentMember
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
                    User = User,
                };

                Program.db.SaleDetails.Add(saleDetail);
                Program.db.SaveChanges();
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var product = Program.db.Products.FirstOrDefault(p => p.Name.ToLower() == row.Cells[0].Value.ToString().ToLower());
                product.Stock -= int.Parse(row.Cells[1].Value.ToString());

                Program.db.Products.Update(product);
                Program.db.SaveChanges();
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("============================");
            sb.AppendLine("             \tKasir App");
            sb.AppendLine("============================");
            sb.AppendLine($"User: {User.Name}");
            sb.AppendLine("============================");
            sb.AppendLine("Barang");
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                sb.AppendLine($"{row.Cells[0].Value}\t{row.Cells[1].Value}\t{row.Cells[2].Value}");
            }
            sb.AppendLine("============================");
            sb.AppendLine($"Total\t{label2.Text}");
            sb.AppendLine($"Bayar\t{textBox1.Text}");
            sb.AppendLine($"Kembalian\t{Kembalian}");
            sb.AppendLine("============================");
            sb.AppendLine($"Tanggal\t{DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}");
            sb.AppendLine("============================");
            sb.AppendLine("Terima kasih telah berbelanja di Kasir App");
            sb.AppendLine("============================");

            MessageBox.Show(sb.ToString());

            dataGridView1.Rows.Clear();
            label2.Text = "0";
            textBox1.Text = string.Empty;
            Kembalian = 0;
            UpdateTotalPrice();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                dataGridView1.Rows.RemoveAt(e.RowIndex);
                UpdateTotalPrice();
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            UpdateTotalPrice();
        }

        private void MemberNoHp_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(MemberNoHp.Text, "[^0-9]"))
            {
                MemberNoHp.Text = MemberNoHp.Text.Remove(MemberNoHp.Text.Length - 1);
            }

            CurrentMember = Program.db.Customers.FirstOrDefault(c => c.PhoneNumber == MemberNoHp.Text);

            if (CurrentMember != null)
            {
                LabelNamaMember.Text = CurrentMember.Name;
            }
            else
            {
                LabelNamaMember.Text = "-";
            }

            UpdateTotalPrice();
        }
    }
}
