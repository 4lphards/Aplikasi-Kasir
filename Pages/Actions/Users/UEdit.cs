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
    public partial class UEdit : Form
    {
        private User UserPage;
        private int Index;
        private List<Models.User> Users = Program.db.Users.ToList();

        public UEdit(int _Index, User _UserPage)
        {
            InitializeComponent();
            Index = _Index;
            UserPage = _UserPage;

            var user = Users.FirstOrDefault(u => u.Id == Index);

            TbAddress.Text = user.Address;
            TbName.Text = user.Name;
            TbPhone.Text = user.PhoneNumber;
            TbUsername.Text = user.Username;
            TbPassword.Text = user.Password;
            CbUserType.Text = user.User_Type;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to edit this user?", "Edit User", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                var user = Users.FirstOrDefault(u => u.Id == Index);

                user.Address = TbAddress.Text;
                user.Name = TbName.Text;
                user.PhoneNumber = TbPhone.Text;
                user.Username = TbUsername.Text;
                user.Password = TbPassword.Text;
                user.User_Type = CbUserType.Text;

                Program.db.SaveChanges();
                UserPage.RefreshDGV();
                this.Close();
            }
        }
    }
}
