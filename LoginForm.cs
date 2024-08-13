using Cashier.Models;
using Cashier.Pages;

namespace Cashier
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            LoginAction();
        }

        private void ClearText()
        {
            TbUsername.Text = "";
            TbPassword.Text = "";
        }

        private void LoginAction()
        {
            Models.User? user = Program.db.Users.FirstOrDefault(u => u.Username == TbUsername.Text && u.Password == TbPassword.Text);

            if (TbUsername.Text.Length == 0 || TbPassword.Text.Length == 0)
            {
                MessageBox.Show("Username dan Password harus diisi!");
                return;
            }

            if (user == null)
            {
                MessageBox.Show("Username atau Password salah");
                return;
            }
            Main adminMainPage = new Main(this, user);
            adminMainPage.Show();
            ClearText();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
