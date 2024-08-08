namespace Cashier.Pages.Actions.Product
{
    partial class PAdd
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
            label2 = new Label();
            TbName = new TextBox();
            TbPrice = new TextBox();
            TbStock = new TextBox();
            BtnAdd = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 24);
            label2.Name = "label2";
            label2.Size = new Size(131, 23);
            label2.TabIndex = 1;
            label2.Text = "Add Product";
            // 
            // TbName
            // 
            TbName.BackColor = Color.WhiteSmoke;
            TbName.Location = new Point(12, 70);
            TbName.Name = "TbName";
            TbName.PlaceholderText = " Name";
            TbName.Size = new Size(245, 31);
            TbName.TabIndex = 2;
            // 
            // TbPrice
            // 
            TbPrice.BackColor = Color.WhiteSmoke;
            TbPrice.Location = new Point(12, 119);
            TbPrice.Name = "TbPrice";
            TbPrice.PlaceholderText = " Price";
            TbPrice.Size = new Size(245, 31);
            TbPrice.TabIndex = 3;
            // 
            // TbStock
            // 
            TbStock.BackColor = Color.WhiteSmoke;
            TbStock.Location = new Point(12, 170);
            TbStock.Name = "TbStock";
            TbStock.PlaceholderText = " Stock";
            TbStock.Size = new Size(245, 31);
            TbStock.TabIndex = 4;
            // 
            // BtnAdd
            // 
            BtnAdd.AutoSize = true;
            BtnAdd.BackColor = Color.WhiteSmoke;
            BtnAdd.Location = new Point(184, 227);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(73, 33);
            BtnAdd.TabIndex = 5;
            BtnAdd.Text = "Add";
            BtnAdd.UseVisualStyleBackColor = false;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // AddProduct
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
            Name = "AddProduct";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddProduct";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox TbName;
        private TextBox TbPrice;
        private TextBox TbStock;
        private Button BtnAdd;
    }
}