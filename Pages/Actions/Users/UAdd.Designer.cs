namespace Cashier.Pages.Actions.Users
{
    partial class UAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnAdd = new Button();
            TbAddress = new TextBox();
            TbName = new TextBox();
            label2 = new Label();
            CbUserType = new ComboBox();
            TbPhone = new TextBox();
            TbUsername = new TextBox();
            TbPassword = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // BtnAdd
            // 
            BtnAdd.AutoSize = true;
            BtnAdd.BackColor = Color.WhiteSmoke;
            BtnAdd.Location = new Point(171, 340);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(86, 33);
            BtnAdd.TabIndex = 7;
            BtnAdd.Text = "Tambah";
            BtnAdd.UseVisualStyleBackColor = false;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // TbAddress
            // 
            TbAddress.BackColor = Color.WhiteSmoke;
            TbAddress.Location = new Point(12, 142);
            TbAddress.Multiline = true;
            TbAddress.Name = "TbAddress";
            TbAddress.PlaceholderText = " Alamat";
            TbAddress.Size = new Size(245, 67);
            TbAddress.TabIndex = 3;
            // 
            // TbName
            // 
            TbName.BackColor = Color.WhiteSmoke;
            TbName.Location = new Point(12, 68);
            TbName.Name = "TbName";
            TbName.PlaceholderText = " Nama";
            TbName.Size = new Size(245, 31);
            TbName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 22);
            label2.Name = "label2";
            label2.Size = new Size(175, 23);
            label2.TabIndex = 11;
            label2.Text = "Tambah Pengguna";
            // 
            // CbUserType
            // 
            CbUserType.BackColor = Color.WhiteSmoke;
            CbUserType.DropDownStyle = ComboBoxStyle.DropDownList;
            CbUserType.FormattingEnabled = true;
            CbUserType.Items.AddRange(new object[] { "Admin", "Kasir" });
            CbUserType.Location = new Point(64, 105);
            CbUserType.Name = "CbUserType";
            CbUserType.Size = new Size(193, 31);
            CbUserType.TabIndex = 2;
            // 
            // TbPhone
            // 
            TbPhone.BackColor = Color.WhiteSmoke;
            TbPhone.Location = new Point(12, 215);
            TbPhone.Name = "TbPhone";
            TbPhone.PlaceholderText = " No Telepon";
            TbPhone.Size = new Size(245, 31);
            TbPhone.TabIndex = 4;
            // 
            // TbUsername
            // 
            TbUsername.BackColor = Color.WhiteSmoke;
            TbUsername.Location = new Point(12, 252);
            TbUsername.Name = "TbUsername";
            TbUsername.PlaceholderText = " Username";
            TbUsername.Size = new Size(245, 31);
            TbUsername.TabIndex = 5;
            // 
            // TbPassword
            // 
            TbPassword.BackColor = Color.WhiteSmoke;
            TbPassword.Location = new Point(12, 289);
            TbPassword.Name = "TbPassword";
            TbPassword.PlaceholderText = " Password";
            TbPassword.Size = new Size(245, 31);
            TbPassword.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 108);
            label1.Name = "label1";
            label1.Size = new Size(54, 23);
            label1.TabIndex = 20;
            label1.Text = "Tipe";
            // 
            // UAdd
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(269, 385);
            Controls.Add(CbUserType);
            Controls.Add(label1);
            Controls.Add(TbPassword);
            Controls.Add(TbUsername);
            Controls.Add(TbPhone);
            Controls.Add(BtnAdd);
            Controls.Add(TbAddress);
            Controls.Add(TbName);
            Controls.Add(label2);
            Font = new Font("Consolas", 15F);
            Margin = new Padding(5);
            Name = "UAdd";
            Text = "AddUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAdd;
        private TextBox TbAddress;
        private TextBox TbName;
        private Label label2;
        private ComboBox CbUserType;
        private TextBox TbPhone;
        private TextBox TbUsername;
        private TextBox TbPassword;
        private Label label1;
    }
}