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
            productBindingSource = new BindingSource(components);
            TBPrice = new TextBox();
            TbStock = new TextBox();
            BtnAdd = new Button();
            BtnEdit = new Button();
            BtnRemove = new Button();
            TbSearch = new TextBox();
            ClearBtn = new Button();
            label1 = new Label();
            Id = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stockDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
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
            TBName.Size = new Size(222, 70);
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
            DGVProduct.Columns.AddRange(new DataGridViewColumn[] { Id, nameDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, stockDataGridViewTextBoxColumn });
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
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Models.Product);
            // 
            // TBPrice
            // 
            TBPrice.BackColor = Color.WhiteSmoke;
            TBPrice.Font = new Font("Consolas", 15F);
            TBPrice.Location = new Point(112, 315);
            TBPrice.Name = "TBPrice";
            TBPrice.PlaceholderText = " Price";
            TBPrice.Size = new Size(115, 31);
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
            BtnEdit.Location = new Point(463, 238);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(50, 50);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = false;
            BtnEdit.Click += BtnEdit_Click;
            // 
            // BtnRemove
            // 
            BtnRemove.BackColor = Color.Red;
            BtnRemove.BackgroundImage = Properties.Resources.trash;
            BtnRemove.BackgroundImageLayout = ImageLayout.Zoom;
            BtnRemove.Enabled = false;
            BtnRemove.Location = new Point(435, 295);
            BtnRemove.Name = "BtnRemove";
            BtnRemove.Size = new Size(50, 50);
            BtnRemove.TabIndex = 6;
            BtnRemove.UseVisualStyleBackColor = false;
            BtnRemove.Click += BtnRemove_Click;
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
            TbSearch.TextChanged += TbSearch_TextChanged;
            // 
            // ClearBtn
            // 
            ClearBtn.BackColor = Color.Transparent;
            ClearBtn.BackgroundImage = Properties.Resources.broom;
            ClearBtn.BackgroundImageLayout = ImageLayout.Stretch;
            ClearBtn.Location = new Point(305, 238);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(70, 70);
            ClearBtn.TabIndex = 8;
            ClearBtn.UseVisualStyleBackColor = false;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 15F);
            label1.Location = new Point(75, 320);
            label1.Name = "label1";
            label1.Size = new Size(43, 23);
            label1.TabIndex = 9;
            label1.Text = "Rp.";
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.FillWeight = 21.91502F;
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.FillWeight = 152.59346F;
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.FillWeight = 152.59346F;
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            stockDataGridViewTextBoxColumn.FillWeight = 152.59346F;
            stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            stockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AdminStockPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(618, 402);
            Controls.Add(ClearBtn);
            Controls.Add(TbSearch);
            Controls.Add(BtnRemove);
            Controls.Add(BtnEdit);
            Controls.Add(BtnAdd);
            Controls.Add(TbStock);
            Controls.Add(TBPrice);
            Controls.Add(DGVProduct);
            Controls.Add(TBName);
            Controls.Add(label1);
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
        private TextBox TbSearch;
        private Button ClearBtn;
        private Label label1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
    }
}