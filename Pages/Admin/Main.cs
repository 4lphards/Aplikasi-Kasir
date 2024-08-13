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

namespace Cashier.Pages
{
    public partial class Main : Form
    {
        private Login Login;
        private Models.User User;
        public Main(Login _login, Models.User _user)
        {
            InitializeComponent();
            ShowHomePage();
            Login = _login;
            User = _user;
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Login.Show();
            this.Close();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            ShowHomePage();
        }

        private void BtnStock_Click(object sender, EventArgs e)
        {
            Stock adminStockPage = new Stock();
            adminStockPage.TopLevel = false;
            adminStockPage.Dock = DockStyle.Fill;
            adminStockPage.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Clear();
            panel1.Controls.Add(adminStockPage);
            adminStockPage.Show();
        }

        private void BtnUser_Click(object sender, EventArgs e)
        {
            User adminUserPage = new User();
            adminUserPage.TopLevel = false;
            adminUserPage.Dock = DockStyle.Fill;
            adminUserPage.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Clear();
            panel1.Controls.Add(adminUserPage);
            adminUserPage.Show();
        }

        private void ShowHomePage()
        {
            Home adminHomePage = new Home(User);
            adminHomePage.TopLevel = false;
            adminHomePage.Dock = DockStyle.Fill;
            adminHomePage.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Clear();
            panel1.Controls.Add(adminHomePage);
            adminHomePage.Show();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login.Show();
        }
    }
}
