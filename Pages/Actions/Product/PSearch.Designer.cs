namespace Cashier.Pages.Actions.Product
{
    partial class PSearch
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
            TbQuantity = new TextBox();
            TbName = new TextBox();
            label1 = new Label();
            AddtoCart = new Button();
            SuspendLayout();
            // 
            // TbQuantity
            // 
            TbQuantity.Font = new Font("Consolas", 15F);
            TbQuantity.Location = new Point(12, 107);
            TbQuantity.Name = "TbQuantity";
            TbQuantity.PlaceholderText = " Banyak Produk";
            TbQuantity.Size = new Size(196, 31);
            TbQuantity.TabIndex = 2;
            // 
            // TbName
            // 
            TbName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            TbName.Font = new Font("Consolas", 15F);
            TbName.Location = new Point(12, 70);
            TbName.Name = "TbName";
            TbName.PlaceholderText = " Nama Produk";
            TbName.Size = new Size(196, 31);
            TbName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 15F);
            label1.Location = new Point(37, 24);
            label1.Name = "label1";
            label1.Size = new Size(153, 23);
            label1.TabIndex = 2;
            label1.Text = "Tambah produk";
            // 
            // AddtoCart
            // 
            AddtoCart.AutoSize = true;
            AddtoCart.Font = new Font("Consolas", 15F);
            AddtoCart.Location = new Point(111, 144);
            AddtoCart.Name = "AddtoCart";
            AddtoCart.Size = new Size(97, 33);
            AddtoCart.TabIndex = 3;
            AddtoCart.Text = "Tambah";
            AddtoCart.UseVisualStyleBackColor = true;
            AddtoCart.Click += AddtoCart_Click;
            // 
            // PSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(219, 219);
            Controls.Add(AddtoCart);
            Controls.Add(label1);
            Controls.Add(TbName);
            Controls.Add(TbQuantity);
            Font = new Font("Consolas", 10F);
            Name = "PSearch";
            Text = "PSearch";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TbQuantity;
        private TextBox TbName;
        private Label label1;
        private Button AddtoCart;
    }
}