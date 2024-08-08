namespace Cashier
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            TbUsername = new TextBox();
            TbPassword = new TextBox();
            BtnLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 20F);
            label1.Location = new Point(96, 30);
            label1.Name = "label1";
            label1.Size = new Size(89, 32);
            label1.TabIndex = 0;
            label1.Text = "Login";
            label1.Click += label1_Click;
            // 
            // TbUsername
            // 
            TbUsername.BackColor = Color.WhiteSmoke;
            TbUsername.Font = new Font("Consolas", 15F);
            TbUsername.Location = new Point(23, 82);
            TbUsername.Name = "TbUsername";
            TbUsername.PlaceholderText = " Username";
            TbUsername.Size = new Size(237, 31);
            TbUsername.TabIndex = 1;
            // 
            // TbPassword
            // 
            TbPassword.BackColor = Color.WhiteSmoke;
            TbPassword.Font = new Font("Consolas", 15F);
            TbPassword.Location = new Point(23, 131);
            TbPassword.Name = "TbPassword";
            TbPassword.PasswordChar = '*';
            TbPassword.PlaceholderText = " Password";
            TbPassword.Size = new Size(237, 31);
            TbPassword.TabIndex = 2;
            // 
            // BtnLogin
            // 
            BtnLogin.AutoSize = true;
            BtnLogin.BackColor = Color.WhiteSmoke;
            BtnLogin.FlatAppearance.BorderColor = Color.Black;
            BtnLogin.FlatAppearance.BorderSize = 3;
            BtnLogin.FlatStyle = FlatStyle.System;
            BtnLogin.Font = new Font("Consolas", 15F);
            BtnLogin.Location = new Point(159, 179);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(101, 32);
            BtnLogin.TabIndex = 3;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // Login
            // 
            AcceptButton = BtnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(284, 261);
            Controls.Add(BtnLogin);
            Controls.Add(TbPassword);
            Controls.Add(TbUsername);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F);
            MaximizeBox = false;
            MaximumSize = new Size(300, 300);
            MinimumSize = new Size(300, 300);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TbUsername;
        private TextBox TbPassword;
        private Button BtnLogin;
    }
}
