using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cashier.Pages.Actions.Users
{
    public partial class UAdd : Form
    {
        private User UserPages;
        public UAdd(User _UserPages)
        {
            InitializeComponent();
            UserPages = _UserPages;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TbUsername.Text) || string.IsNullOrEmpty(TbPassword.Text) || string.IsNullOrEmpty(CbUserType.Text) || string.IsNullOrEmpty(TbAddress.Text) || string.IsNullOrEmpty(TbPhone.Text) || string.IsNullOrEmpty(TbUsername.Text) || string.IsNullOrEmpty(TbPassword.Text))
            {
                MessageBox.Show("Isi kolom yang kosong!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Anda yakin ingin menambah pengguna ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Models.User user = new Models.User
                {
                    Username = TbUsername.Text,
                    Password = TbPassword.Text,
                    User_Type = CbUserType.Text,
                    Name = TbName.Text,
                    Address = TbAddress.Text,
                    PhoneNumber = TbPhone.Text
                };

                Program.db.Users.Add(user);
                Program.db.SaveChanges();
                UserPages.RefreshDGV();
                this.Close();
            }

        }
    }
}
