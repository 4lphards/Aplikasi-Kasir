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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DGVProduct = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stockDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productBindingSource = new BindingSource(components);
            TbSearch = new TextBox();
            BtnAdd = new Button();
            BtnEdit = new Button();
            BtnRemove = new Button();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Consolas", 10F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGVProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGVProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVProduct.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, stockDataGridViewTextBoxColumn });
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
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.FillWeight = 24.3654823F;
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.FillWeight = 125.21151F;
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.FillWeight = 125.21151F;
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            stockDataGridViewTextBoxColumn.FillWeight = 125.21151F;
            stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            stockDataGridViewTextBoxColumn.ReadOnly = true;
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
            TbSearch.PlaceholderText = " Search Name";
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
            // Stock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(618, 402);
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
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private Button BtnAdd;
        private Button BtnEdit;
        private Button BtnRemove;
    }
}