namespace Cashier.Pages.Actions.Product
{
    partial class PEdit
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
            TbStock = new TextBox();
            TbPrice = new TextBox();
            TbName = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // BtnAdd
            // 
            BtnAdd.AutoSize = true;
            BtnAdd.BackColor = Color.WhiteSmoke;
            BtnAdd.Location = new Point(184, 221);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(73, 33);
            BtnAdd.TabIndex = 10;
            BtnAdd.Text = "Edit";
            BtnAdd.UseVisualStyleBackColor = false;
            BtnAdd.Click += BtnEdit_Click;
            // 
            // TbStock
            // 
            TbStock.BackColor = Color.WhiteSmoke;
            TbStock.Location = new Point(12, 164);
            TbStock.Name = "TbStock";
            TbStock.PlaceholderText = " Stok";
            TbStock.Size = new Size(245, 31);
            TbStock.TabIndex = 9;
            // 
            // TbPrice
            // 
            TbPrice.BackColor = Color.WhiteSmoke;
            TbPrice.Location = new Point(12, 113);
            TbPrice.Name = "TbPrice";
            TbPrice.PlaceholderText = " Harga";
            TbPrice.Size = new Size(245, 31);
            TbPrice.TabIndex = 8;
            // 
            // TbName
            // 
            TbName.BackColor = Color.WhiteSmoke;
            TbName.Location = new Point(12, 64);
            TbName.Name = "TbName";
            TbName.PlaceholderText = " Nama";
            TbName.Size = new Size(245, 31);
            TbName.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 21);
            label2.Name = "label2";
            label2.Size = new Size(131, 23);
            label2.TabIndex = 6;
            label2.Text = "Edit Produk";
            // 
            // PEdit
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(269, 272);
            Controls.Add(BtnAdd);
            Controls.Add(TbStock);
            Controls.Add(TbPrice);
            Controls.Add(TbName);
            Controls.Add(label2);
            Font = new Font("Consolas", 15F);
            Margin = new Padding(5);
            Name = "PEdit";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "EditProduct";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAdd;
        private TextBox TbStock;
        private TextBox TbPrice;
        private TextBox TbName;
        private Label label2;
    }
}