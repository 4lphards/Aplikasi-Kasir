using Cashier.Models;
using Cashier.Pages.Actions;
using Cashier.Pages.Actions.Users;
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
    public partial class User : Form
    {
        public List<Models.User> Users { get; set; } = Program.db.Users.ToList();
        public DataGridViewRow SelectedRow;
        public int RowIndex;

        public User()
        {
            InitializeComponent();
            RefreshDGV();
        }

        public void RefreshDGV()
        {
            userBindingSource.DataSource = Program.db.Users.ToList();

            BtnAdd.Enabled = true;
            BtnEdit.Enabled = false;
            BtnRemove.Enabled = false;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            UAdd addUser = new UAdd(this);
            addUser.ShowDialog();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (RowIndex < 0)
            {
                MessageBox.Show("Tolong pilih pengguna terlebih dahulu", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var id = Convert.ToInt32(SelectedRow.Cells[0].Value);

            UEdit uEdit = new UEdit(id, this);
            uEdit.ShowDialog();
        }

        private void DGVUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnEdit.Enabled = true;
            BtnRemove.Enabled = true;

            if (e.RowIndex >= 0)
            {
                RowIndex = e.RowIndex;

                SelectedRow = DGVUser.Rows[e.RowIndex];
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (RowIndex < 0)
            {
                MessageBox.Show("Tolong pilih pengguna terlebih dahulu", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Anda yakin ingin menghapus pengguna ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes) {
                var id = Convert.ToInt32(SelectedRow.Cells[0].Value);
                var user = Program.db.Users.Find(id);

                Program.db.Users.Remove(user);
                Program.db.SaveChanges();
                RefreshDGV();
            }
        }
    }
}
