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
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
            ShowHomePage();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Login loginform = new Login();
            loginform.Show();
            this.Close();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            ShowHomePage();
        }

        private void BtnStock_Click(object sender, EventArgs e)
        {
            AdminStockPage adminStockPage = new AdminStockPage();
            adminStockPage.TopLevel = false;
            adminStockPage.Dock = DockStyle.Fill;
            adminStockPage.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Clear();
            panel1.Controls.Add(adminStockPage);
            adminStockPage.Show();
        }

        private void BtnUser_Click(object sender, EventArgs e)
        {
            AdminUserPage adminUserPage = new AdminUserPage();
            adminUserPage.TopLevel = false;
            adminUserPage.Dock = DockStyle.Fill;
            adminUserPage.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Clear();
            panel1.Controls.Add(adminUserPage);
            adminUserPage.Show();
        }

        private void ShowHomePage()
        {
            AdminHomePage adminHomePage = new AdminHomePage();
            adminHomePage.TopLevel = false;
            adminHomePage.Dock = DockStyle.Fill;
            adminHomePage.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Clear();
            panel1.Controls.Add(adminHomePage);
            adminHomePage.Show();
        }
    }
}
