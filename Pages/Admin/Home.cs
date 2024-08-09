using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cashier.Pages.Admin
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            RefreshDGV();
        }

        public void RefreshDGV()
        {
            productBindingSource.DataSource = Program.db.Products.ToList();
            saleDetailBindingSource.DataSource = Program.db.SaleDetails.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                // Perform your action here
                MessageBox.Show("Button clicked in row " + e.RowIndex.ToString());

            }
        }
    }
}
