namespace Cashier.Pages.Actions.Users
{
    partial class UEdit
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
            CbUserType = new ComboBox();
            label1 = new Label();
            TbPassword = new TextBox();
            TbUsername = new TextBox();
            TbPhone = new TextBox();
            BtnAdd = new Button();
            TbAddress = new TextBox();
            TbName = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // CbUserType
            // 
            CbUserType.BackColor = Color.WhiteSmoke;
            CbUserType.DropDownStyle = ComboBoxStyle.DropDownList;
            CbUserType.FormattingEnabled = true;
            CbUserType.Items.AddRange(new object[] { "Admin", "Kasir" });
            CbUserType.Location = new Point(64, 100);
            CbUserType.Name = "CbUserType";
            CbUserType.Size = new Size(193, 31);
            CbUserType.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 103);
            label1.Name = "label1";
            label1.Size = new Size(54, 23);
            label1.TabIndex = 29;
            label1.Text = "Tipe";
            // 
            // TbPassword
            // 
            TbPassword.BackColor = Color.WhiteSmoke;
            TbPassword.Location = new Point(12, 284);
            TbPassword.Name = "TbPassword";
            TbPassword.PlaceholderText = " Password";
            TbPassword.Size = new Size(245, 31);
            TbPassword.TabIndex = 26;
            // 
            // TbUsername
            // 
            TbUsername.BackColor = Color.WhiteSmoke;
            TbUsername.Location = new Point(12, 247);
            TbUsername.Name = "TbUsername";
            TbUsername.PlaceholderText = " Username";
            TbUsername.Size = new Size(245, 31);
            TbUsername.TabIndex = 25;
            // 
            // TbPhone
            // 
            TbPhone.BackColor = Color.WhiteSmoke;
            TbPhone.Location = new Point(12, 210);
            TbPhone.Name = "TbPhone";
            TbPhone.PlaceholderText = " No Telepon";
            TbPhone.Size = new Size(245, 31);
            TbPhone.TabIndex = 24;
            // 
            // BtnAdd
            // 
            BtnAdd.AutoSize = true;
            BtnAdd.BackColor = Color.WhiteSmoke;
            BtnAdd.Location = new Point(184, 335);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(73, 33);
            BtnAdd.TabIndex = 27;
            BtnAdd.Text = "Edit";
            BtnAdd.UseVisualStyleBackColor = false;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // TbAddress
            // 
            TbAddress.BackColor = Color.WhiteSmoke;
            TbAddress.Location = new Point(12, 137);
            TbAddress.Multiline = true;
            TbAddress.Name = "TbAddress";
            TbAddress.PlaceholderText = " Alamat";
            TbAddress.Size = new Size(245, 67);
            TbAddress.TabIndex = 23;
            // 
            // TbName
            // 
            TbName.BackColor = Color.WhiteSmoke;
            TbName.Location = new Point(12, 63);
            TbName.Name = "TbName";
            TbName.PlaceholderText = " Nama";
            TbName.Size = new Size(245, 31);
            TbName.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 21);
            label2.Name = "label2";
            label2.Size = new Size(153, 23);
            label2.TabIndex = 28;
            label2.Text = "Edit Pengguna";
            // 
            // UEdit
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
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            Name = "UEdit";
            Text = "UEdit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CbUserType;
        private Label label1;
        private TextBox TbPassword;
        private TextBox TbUsername;
        private TextBox TbPhone;
        private Button BtnAdd;
        private TextBox TbAddress;
        private TextBox TbName;
        private Label label2;
    }
}