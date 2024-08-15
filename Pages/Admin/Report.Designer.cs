namespace Cashier.Pages.Admin
{
    partial class Report
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
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            saleDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            saleBindingSource = new BindingSource(components);
            chart = new ScottPlot.FormsPlot();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            BtnFilter = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)saleBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, saleDateDataGridViewTextBoxColumn, totalPriceDataGridViewTextBoxColumn, userDataGridViewTextBoxColumn });
            dataGridView1.DataSource = saleBindingSource;
            dataGridView1.Location = new Point(0, 220);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(619, 182);
            dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.FillWeight = 22.3350258F;
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saleDateDataGridViewTextBoxColumn
            // 
            saleDateDataGridViewTextBoxColumn.DataPropertyName = "SaleDate";
            saleDateDataGridViewTextBoxColumn.FillWeight = 125.888321F;
            saleDateDataGridViewTextBoxColumn.HeaderText = "SaleDate";
            saleDateDataGridViewTextBoxColumn.Name = "saleDateDataGridViewTextBoxColumn";
            saleDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            totalPriceDataGridViewTextBoxColumn.FillWeight = 125.888321F;
            totalPriceDataGridViewTextBoxColumn.HeaderText = "TotalPrice";
            totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userDataGridViewTextBoxColumn
            // 
            userDataGridViewTextBoxColumn.DataPropertyName = "User";
            userDataGridViewTextBoxColumn.FillWeight = 125.888321F;
            userDataGridViewTextBoxColumn.HeaderText = "User";
            userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            userDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saleBindingSource
            // 
            saleBindingSource.DataSource = typeof(Models.Sale);
            // 
            // chart
            // 
            chart.Location = new Point(13, 12);
            chart.Margin = new Padding(4, 3, 4, 3);
            chart.Name = "chart";
            chart.Size = new Size(368, 182);
            chart.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "";
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(514, 65);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(92, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "";
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(514, 114);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(92, 23);
            dateTimePicker2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(468, 71);
            label1.Name = "label1";
            label1.Size = new Size(40, 17);
            label1.TabIndex = 4;
            label1.Text = "Dari";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(452, 120);
            label2.Name = "label2";
            label2.Size = new Size(56, 17);
            label2.TabIndex = 5;
            label2.Text = "Sampai";
            // 
            // BtnFilter
            // 
            BtnFilter.Location = new Point(531, 171);
            BtnFilter.Name = "BtnFilter";
            BtnFilter.Size = new Size(75, 23);
            BtnFilter.TabIndex = 6;
            BtnFilter.Text = "Filter";
            BtnFilter.UseVisualStyleBackColor = true;
            BtnFilter.Click += BtnFilter_Click;
            // 
            // Report
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(618, 402);
            Controls.Add(BtnFilter);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(chart);
            Controls.Add(dataGridView1);
            Font = new Font("Consolas", 10F);
            Name = "Report";
            Text = "Report";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)saleBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn saleDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private BindingSource saleBindingSource;
        private ScottPlot.FormsPlot chart;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private Label label2;
        private Button BtnFilter;
    }
}