namespace Cashier.Pages
{
    partial class Stock
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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DGVProduct = new DataGridView();
            productBindingSource = new BindingSource(components);
            TbSearch = new TextBox();
            BtnAdd = new Button();
            BtnEdit = new Button();
            BtnRemove = new Button();
            Id = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stockDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DGVProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            SuspendLayout();
            // 
            // DGVProduct
            // 
            DGVProduct.AllowUserToAddRows = false;
            DGVProduct.AllowUserToDeleteRows = false;
            DGVProduct.AllowUserToResizeColumns = false;
            DGVProduct.AllowUserToResizeRows = false;
            DGVProduct.AutoGenerateColumns = false;
            DGVProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVProduct.BackgroundColor = Color.WhiteSmoke;
            DGVProduct.BorderStyle = BorderStyle.Fixed3D;
            DGVProduct.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Consolas", 10F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            DGVProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            DGVProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVProduct.Columns.AddRange(new DataGridViewColumn[] { Id, nameDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, stockDataGridViewTextBoxColumn });
            DGVProduct.DataSource = productBindingSource;
            DGVProduct.Location = new Point(12, 58);
            DGVProduct.MultiSelect = false;
            DGVProduct.Name = "DGVProduct";
            DGVProduct.ReadOnly = true;
            DGVProduct.RowHeadersVisible = false;
            DGVProduct.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DGVProduct.ShowCellErrors = false;
            DGVProduct.Size = new Size(594, 332);
            DGVProduct.TabIndex = 1;
            DGVProduct.CellClick += DGVProduct_ContentCellClick;
            DGVProduct.CellContentClick += DGVProduct_ContentCellClick;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Models.Product);
            // 
            // TbSearch
            // 
            TbSearch.BackColor = Color.WhiteSmoke;
            TbSearch.Font = new Font("Consolas", 12F);
            TbSearch.Location = new Point(435, 26);
            TbSearch.Name = "TbSearch";
            TbSearch.PlaceholderText = " Cari Nama Produk";
            TbSearch.Size = new Size(171, 26);
            TbSearch.TabIndex = 7;
            TbSearch.TextChanged += TbSearch_TextChanged;
            // 
            // BtnAdd
            // 
            BtnAdd.BackgroundImage = Properties.Resources.add;
            BtnAdd.BackgroundImageLayout = ImageLayout.Zoom;
            BtnAdd.Font = new Font("Consolas", 10F);
            BtnAdd.Location = new Point(327, 22);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(30, 30);
            BtnAdd.TabIndex = 11;
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.BackgroundImage = Properties.Resources.edit;
            BtnEdit.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEdit.Font = new Font("Consolas", 10F);
            BtnEdit.Location = new Point(363, 22);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(30, 30);
            BtnEdit.TabIndex = 12;
            BtnEdit.UseVisualStyleBackColor = true;
            BtnEdit.Click += BtnEdit_Click;
            // 
            // BtnRemove
            // 
            BtnRemove.BackgroundImage = Properties.Resources.trash;
            BtnRemove.BackgroundImageLayout = ImageLayout.Zoom;
            BtnRemove.Font = new Font("Consolas", 10F);
            BtnRemove.Location = new Point(399, 22);
            BtnRemove.Name = "BtnRemove";
            BtnRemove.Size = new Size(30, 30);
            BtnRemove.TabIndex = 13;
            BtnRemove.UseVisualStyleBackColor = true;
            BtnRemove.Click += BtnRemove_Click;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.FillWeight = 24.1438866F;
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.FillWeight = 150.496887F;
            nameDataGridViewTextBoxColumn.HeaderText = "Nama";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            dataGridViewCellStyle10.Format = "Rp\".\" .";
            dataGridViewCellStyle10.NullValue = null;
            priceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            priceDataGridViewTextBoxColumn.FillWeight = 150.496887F;
            priceDataGridViewTextBoxColumn.HeaderText = "Harga";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            stockDataGridViewTextBoxColumn.FillWeight = 150.496887F;
            stockDataGridViewTextBoxColumn.HeaderText = "Stok";
            stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            stockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Consolas", 9F);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(266, 14);
            label1.TabIndex = 14;
            label1.Text = "*Klik produk untuk mengedit/menghapus";
            // 
            // Stock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(618, 402);
            Controls.Add(label1);
            Controls.Add(BtnRemove);
            Controls.Add(BtnEdit);
            Controls.Add(BtnAdd);
            Controls.Add(TbSearch);
            Controls.Add(DGVProduct);
            Name = "Stock";
            Text = "Stock";
            ((System.ComponentModel.ISupportInitialize)DGVProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView DGVProduct;
        private BindingSource productBindingSource;
        private TextBox TbSearch;
        private Button BtnAdd;
        private Button BtnEdit;
        private Button BtnRemove;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private Label label1;
    }
}