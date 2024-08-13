namespace Cashier.Pages.Admin
{
    partial class Home
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            Product_Name = new DataGridViewTextBoxColumn();
            Product_Quantity = new DataGridViewTextBoxColumn();
            TotalPrice = new DataGridViewTextBoxColumn();
            remove = new DataGridViewButtonColumn();
            productBindingSource = new BindingSource(components);
            saleDetailBindingSource = new BindingSource(components);
            panel1 = new Panel();
            PrintStruk = new Button();
            panel4 = new Panel();
            label5 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            textBox1 = new TextBox();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            TambahProduct = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)saleDetailBindingSource).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new Font("Consolas", 10F);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Product_Name, Product_Quantity, TotalPrice, remove });
            dataGridView1.Location = new Point(0, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(419, 382);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Product_Name
            // 
            Product_Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Product_Name.FillWeight = 126.56514F;
            Product_Name.Frozen = true;
            Product_Name.HeaderText = "Nama ";
            Product_Name.Name = "Product_Name";
            Product_Name.ReadOnly = true;
            Product_Name.Width = 132;
            // 
            // Product_Quantity
            // 
            Product_Quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Product_Quantity.FillWeight = 126.56514F;
            Product_Quantity.Frozen = true;
            Product_Quantity.HeaderText = "Banyak";
            Product_Quantity.Name = "Product_Quantity";
            Product_Quantity.ReadOnly = true;
            Product_Quantity.Width = 131;
            // 
            // TotalPrice
            // 
            TotalPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            TotalPrice.FillWeight = 126.56514F;
            TotalPrice.Frozen = true;
            TotalPrice.HeaderText = "Harga";
            TotalPrice.Name = "TotalPrice";
            TotalPrice.ReadOnly = true;
            TotalPrice.Width = 132;
            // 
            // remove
            // 
            remove.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            remove.FillWeight = 20.30457F;
            remove.Frozen = true;
            remove.HeaderText = "";
            remove.Name = "remove";
            remove.ReadOnly = true;
            remove.Resizable = DataGridViewTriState.True;
            remove.SortMode = DataGridViewColumnSortMode.Automatic;
            remove.Text = "-";
            remove.UseColumnTextForButtonValue = true;
            remove.Width = 21;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Models.Product);
            // 
            // saleDetailBindingSource
            // 
            saleDetailBindingSource.DataSource = typeof(Models.SaleDetail);
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(PrintStruk);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(418, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(211, 438);
            panel1.TabIndex = 3;
            // 
            // PrintStruk
            // 
            PrintStruk.Location = new Point(23, 358);
            PrintStruk.Name = "PrintStruk";
            PrintStruk.Size = new Size(170, 44);
            PrintStruk.TabIndex = 10;
            PrintStruk.Text = "Cetak Struk";
            PrintStruk.UseVisualStyleBackColor = true;
            PrintStruk.Click += PrintStruk_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.WhiteSmoke;
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(23, 234);
            panel4.Name = "panel4";
            panel4.Size = new Size(170, 88);
            panel4.TabIndex = 9;
            // 
            // label5
            // 
            label5.Location = new Point(3, 41);
            label5.Name = "label5";
            label5.Size = new Size(164, 37);
            label5.TabIndex = 8;
            label5.Text = "Rp. 0";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.WhiteSmoke;
            label3.Font = new Font("Consolas", 10F);
            label3.Location = new Point(42, 15);
            label3.Name = "label3";
            label3.Size = new Size(80, 17);
            label3.TabIndex = 6;
            label3.Text = "Kembalian";
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(textBox1);
            panel3.Location = new Point(23, 122);
            panel3.Name = "panel3";
            panel3.Size = new Size(170, 90);
            panel3.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.WhiteSmoke;
            label4.Font = new Font("Consolas", 10F);
            label4.Location = new Point(42, 20);
            label4.Name = "label4";
            label4.Size = new Size(88, 17);
            label4.TabIndex = 6;
            label4.Text = "Uang Masuk";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.WhiteSmoke;
            textBox1.Location = new Point(23, 49);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = " Nominal";
            textBox1.Size = new Size(127, 23);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(23, 21);
            panel2.Name = "panel2";
            panel2.Size = new Size(170, 81);
            panel2.TabIndex = 7;
            // 
            // label2
            // 
            label2.Location = new Point(3, 35);
            label2.Name = "label2";
            label2.Size = new Size(164, 37);
            label2.TabIndex = 7;
            label2.Text = "0";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.WhiteSmoke;
            label1.Font = new Font("Consolas", 10F);
            label1.Location = new Point(34, 9);
            label1.Name = "label1";
            label1.Size = new Size(96, 17);
            label1.TabIndex = 6;
            label1.Text = "Total Harga";
            // 
            // TambahProduct
            // 
            TambahProduct.Font = new Font("Consolas", 10F);
            TambahProduct.Location = new Point(12, 12);
            TambahProduct.Name = "TambahProduct";
            TambahProduct.Size = new Size(112, 35);
            TambahProduct.TabIndex = 4;
            TambahProduct.Text = "Cari Produk";
            TambahProduct.UseVisualStyleBackColor = true;
            TambahProduct.Click += SearchProduct_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(629, 438);
            Controls.Add(dataGridView1);
            Controls.Add(TambahProduct);
            Controls.Add(panel1);
            Font = new Font("Consolas", 10F);
            Name = "Home";
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)saleDetailBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView dataGridView1;
        private BindingSource productBindingSource;
        private BindingSource saleDetailBindingSource;
        private Panel panel1;
        private Button TambahProduct;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private Label label4;
        private TextBox textBox1;
        private Panel panel4;
        private Label label3;
        private Label label5;
        private Button PrintStruk;
        private DataGridViewTextBoxColumn Product_Name;
        private DataGridViewTextBoxColumn Product_Quantity;
        private DataGridViewTextBoxColumn TotalPrice;
        private DataGridViewButtonColumn remove;
    }
}