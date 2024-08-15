using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cashier.Pages.Admin
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
            RefreshDGV();
        }

        private void RefreshDGV()
        {
            // make the User Column on the datagridview, shows the username instead of the user Data
            dataGridView1.DataSource = Program.db.SaleDetails.Select(x => new
            {
                Id = x.Sale.Id,
                User = x.User.Name,
                TotalPrice = x.Sale.TotalPrice,
                SaleDate = x.Sale.SaleDate
            }).ToList();
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            var From = dateTimePicker1.Value;
            var To = dateTimePicker2.Value;
            var Transaksis = Program.db.SaleDetails.Where(x => x.Sale.SaleDate >= From && x.Sale.SaleDate <= To).Select(x => new
            {
                Id = x.Sale.Id,
                User = x.User.Name,
                TotalPrice = x.Sale.TotalPrice,
                SaleDate = x.Sale.SaleDate
            }).ToList();;

            dataGridView1.DataSource = Transaksis;

            var query = Transaksis.GroupBy(t => t.SaleDate).Select(g => new
            {
                Date = g.Key,
                Omset = g.Sum(x => x.TotalPrice)
            }).ToList();

            var dateArray = query.Select(i => i.Date).ToArray();
            var omsetArray = query.Select(i => (double)i.Omset).ToArray();

            if (omsetArray.Length > 0)
            {
                chart.Plot.AddBar(omsetArray);
                chart.Plot.YLabel("Omset");

                var labelArray = dateArray.Select(d => d.ToString("yyyy-MM-dd")).ToArray();

                chart.Plot.XTicks(labelArray);

                chart.Plot.AxisAuto(0);
                chart.Plot.Render();
                chart.Refresh();
            } else
            {
                // reset the chart
                chart.Plot.Clear();
            }
        }
    }
}
