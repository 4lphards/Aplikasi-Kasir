namespace Cashier.Pages
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            panel1 = new Panel();
            panel2 = new Panel();
            BtnUser = new Button();
            BtnStock = new Button();
            BtnLogout = new Button();
            BtnHome = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Location = new Point(70, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(634, 441);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(BtnUser);
            panel2.Controls.Add(BtnStock);
            panel2.Controls.Add(BtnLogout);
            panel2.Controls.Add(BtnHome);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(70, 441);
            panel2.TabIndex = 0;
            // 
            // BtnUser
            // 
            BtnUser.BackColor = Color.White;
            BtnUser.BackgroundImage = (Image)resources.GetObject("BtnUser.BackgroundImage");
            BtnUser.BackgroundImageLayout = ImageLayout.Zoom;
            BtnUser.Location = new Point(15, 67);
            BtnUser.Name = "BtnUser";
            BtnUser.Size = new Size(40, 40);
            BtnUser.TabIndex = 5;
            BtnUser.UseVisualStyleBackColor = false;
            BtnUser.Click += BtnUser_Click;
            // 
            // BtnStock
            // 
            BtnStock.BackColor = Color.White;
            BtnStock.BackgroundImage = (Image)resources.GetObject("BtnStock.BackgroundImage");
            BtnStock.BackgroundImageLayout = ImageLayout.Zoom;
            BtnStock.Location = new Point(15, 122);
            BtnStock.Name = "BtnStock";
            BtnStock.Size = new Size(40, 40);
            BtnStock.TabIndex = 3;
            BtnStock.UseVisualStyleBackColor = false;
            BtnStock.Click += BtnStock_Click;
            // 
            // BtnLogout
            // 
            BtnLogout.BackColor = Color.White;
            BtnLogout.BackgroundImage = (Image)resources.GetObject("BtnLogout.BackgroundImage");
            BtnLogout.BackgroundImageLayout = ImageLayout.Zoom;
            BtnLogout.Location = new Point(15, 389);
            BtnLogout.Name = "BtnLogout";
            BtnLogout.Size = new Size(40, 40);
            BtnLogout.TabIndex = 2;
            BtnLogout.UseVisualStyleBackColor = false;
            BtnLogout.Click += BtnLogout_Click;
            // 
            // BtnHome
            // 
            BtnHome.BackColor = Color.White;
            BtnHome.BackgroundImage = (Image)resources.GetObject("BtnHome.BackgroundImage");
            BtnHome.BackgroundImageLayout = ImageLayout.Zoom;
            BtnHome.Location = new Point(15, 12);
            BtnHome.Name = "BtnHome";
            BtnHome.Size = new Size(40, 40);
            BtnHome.TabIndex = 1;
            BtnHome.UseVisualStyleBackColor = false;
            BtnHome.Click += BtnHome_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 441);
            Controls.Add(panel1);
            Controls.Add(panel2);
            MaximizeBox = false;
            MaximumSize = new Size(720, 480);
            MinimumSize = new Size(720, 480);
            Name = "Main";
            Text = "Main";
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button BtnHome;
        private Button BtnUser;
        private Button BtnStock;
        private Button BtnLogout;
    }
}