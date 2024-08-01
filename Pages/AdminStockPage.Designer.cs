namespace Cashier.Pages
{
    partial class AdminStockPage
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
            TBName = new TextBox();
            DGVProduct = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stockDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productBindingSource = new BindingSource(components);
            TBPrice = new TextBox();
            TbStock = new TextBox();
            BtnAdd = new Button();
            BtnEdit = new Button();
            BtnRemove = new Button();
            TbSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DGVProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            SuspendLayout();
            // 
            // TBName
            // 
            TBName.BackColor = Color.WhiteSmoke;
            TBName.Font = new Font("Consolas", 15F);
            TBName.Location = new Point(77, 238);
            TBName.Multiline = true;
            TBName.Name = "TBName";
            TBName.PlaceholderText = " Name";
            TBName.Size = new Size(298, 70);
            TBName.TabIndex = 0;
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
            DGVProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVProduct.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, stockDataGridViewTextBoxColumn });
            DGVProduct.DataSource = productBindingSource;
            DGVProduct.Location = new Point(12, 41);
            DGVProduct.MultiSelect = false;
            DGVProduct.Name = "DGVProduct";
            DGVProduct.ReadOnly = true;
            DGVProduct.RowHeadersVisible = false;
            DGVProduct.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DGVProduct.ShowCellErrors = false;
            DGVProduct.Size = new Size(594, 150);
            DGVProduct.TabIndex = 1;
            DGVProduct.CellClick += DGVProduct_ContentCellClick;
            DGVProduct.CellContentClick += DGVProduct_ContentCellClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.FillWeight = 20.3045673F;
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.FillWeight = 126.565132F;
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.FillWeight = 126.565132F;
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            stockDataGridViewTextBoxColumn.FillWeight = 126.565132F;
            stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            stockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Models.Product);
            // 
            // TBPrice
            // 
            TBPrice.BackColor = Color.WhiteSmoke;
            TBPrice.Font = new Font("Consolas", 15F);
            TBPrice.Location = new Point(77, 314);
            TBPrice.Name = "TBPrice";
            TBPrice.PlaceholderText = " Price";
            TBPrice.Size = new Size(140, 31);
            TBPrice.TabIndex = 2;
            // 
            // TbStock
            // 
            TbStock.BackColor = Color.WhiteSmoke;
            TbStock.Font = new Font("Consolas", 15F);
            TbStock.Location = new Point(235, 314);
            TbStock.Name = "TbStock";
            TbStock.PlaceholderText = " Stock";
            TbStock.Size = new Size(140, 31);
            TbStock.TabIndex = 3;
            // 
            // BtnAdd
            // 
            BtnAdd.BackColor = Color.Lime;
            BtnAdd.BackgroundImage = Properties.Resources.add;
            BtnAdd.BackgroundImageLayout = ImageLayout.Zoom;
            BtnAdd.FlatStyle = FlatStyle.Flat;
            BtnAdd.Location = new Point(407, 238);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(50, 50);
            BtnAdd.TabIndex = 4;
            BtnAdd.UseVisualStyleBackColor = false;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.BackColor = Color.Yellow;
            BtnEdit.BackgroundImage = Properties.Resources.edit;
            BtnEdit.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEdit.Enabled = false;
            BtnEdit.FlatStyle = FlatStyle.Flat;
            BtnEdit.Location = new Point(463, 238);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(50, 50);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = false;
            // 
            // BtnRemove
            // 
            BtnRemove.BackColor = Color.Red;
            BtnRemove.BackgroundImage = Properties.Resources.trash;
            BtnRemove.BackgroundImageLayout = ImageLayout.Zoom;
            BtnRemove.Enabled = false;
            BtnRemove.FlatStyle = FlatStyle.Flat;
            BtnRemove.Location = new Point(435, 295);
            BtnRemove.Name = "BtnRemove";
            BtnRemove.Size = new Size(50, 50);
            BtnRemove.TabIndex = 6;
            BtnRemove.UseVisualStyleBackColor = false;
            // 
            // TbSearch
            // 
            TbSearch.BackColor = Color.WhiteSmoke;
            TbSearch.Font = new Font("Consolas", 10F);
            TbSearch.Location = new Point(435, 12);
            TbSearch.Name = "TbSearch";
            TbSearch.PlaceholderText = " Search";
            TbSearch.Size = new Size(171, 23);
            TbSearch.TabIndex = 7;
            // 
            // AdminStockPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(618, 402);
            Controls.Add(TbSearch);
            Controls.Add(BtnRemove);
            Controls.Add(BtnEdit);
            Controls.Add(BtnAdd);
            Controls.Add(TbStock);
            Controls.Add(TBPrice);
            Controls.Add(DGVProduct);
            Controls.Add(TBName);
            Name = "AdminStockPage";
            Text = "AdminStockPage";
            ((System.ComponentModel.ISupportInitialize)DGVProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TBName;
        private DataGridView DGVProduct;
        private TextBox TBPrice;
        private TextBox TbStock;
        private Button BtnAdd;
        private Button BtnEdit;
        private Button BtnRemove;
        private BindingSource productBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private TextBox TbSearch;
    }
}