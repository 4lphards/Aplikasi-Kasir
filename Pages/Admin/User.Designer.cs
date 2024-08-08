namespace Cashier.Pages
{
    partial class User
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
            BtnRemove = new Button();
            BtnEdit = new Button();
            BtnAdd = new Button();
            TbSearch = new TextBox();
            DGVUser = new DataGridView();
            userBindingSource = new BindingSource(components);
            Id = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            usernameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DGVUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            SuspendLayout();
            // 
            // BtnRemove
            // 
            BtnRemove.BackgroundImage = Properties.Resources.trash;
            BtnRemove.BackgroundImageLayout = ImageLayout.Zoom;
            BtnRemove.Font = new Font("Consolas", 10F);
            BtnRemove.Location = new Point(399, 17);
            BtnRemove.Name = "BtnRemove";
            BtnRemove.Size = new Size(30, 30);
            BtnRemove.TabIndex = 18;
            BtnRemove.UseVisualStyleBackColor = true;
            BtnRemove.Click += BtnRemove_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.BackgroundImage = Properties.Resources.edit;
            BtnEdit.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEdit.Font = new Font("Consolas", 10F);
            BtnEdit.Location = new Point(363, 17);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(30, 30);
            BtnEdit.TabIndex = 17;
            BtnEdit.UseVisualStyleBackColor = true;
            BtnEdit.Click += BtnEdit_Click;
            // 
            // BtnAdd
            // 
            BtnAdd.BackgroundImage = Properties.Resources.add;
            BtnAdd.BackgroundImageLayout = ImageLayout.Zoom;
            BtnAdd.Font = new Font("Consolas", 10F);
            BtnAdd.Location = new Point(327, 17);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(30, 30);
            BtnAdd.TabIndex = 16;
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // TbSearch
            // 
            TbSearch.BackColor = Color.WhiteSmoke;
            TbSearch.Font = new Font("Consolas", 12F);
            TbSearch.Location = new Point(435, 21);
            TbSearch.Name = "TbSearch";
            TbSearch.PlaceholderText = " Search Name";
            TbSearch.Size = new Size(171, 26);
            TbSearch.TabIndex = 15;
            // 
            // DGVUser
            // 
            DGVUser.AllowUserToAddRows = false;
            DGVUser.AllowUserToDeleteRows = false;
            DGVUser.AllowUserToResizeColumns = false;
            DGVUser.AllowUserToResizeRows = false;
            DGVUser.AutoGenerateColumns = false;
            DGVUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVUser.BackgroundColor = Color.WhiteSmoke;
            DGVUser.BorderStyle = BorderStyle.Fixed3D;
            DGVUser.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Consolas", 10F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGVUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGVUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVUser.Columns.AddRange(new DataGridViewColumn[] { Id, nameDataGridViewTextBoxColumn, userTypeDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, phoneNumberDataGridViewTextBoxColumn, usernameDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn });
            DGVUser.DataSource = userBindingSource;
            DGVUser.Location = new Point(12, 53);
            DGVUser.MultiSelect = false;
            DGVUser.Name = "DGVUser";
            DGVUser.ReadOnly = true;
            DGVUser.RowHeadersVisible = false;
            DGVUser.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DGVUser.ShowCellErrors = false;
            DGVUser.Size = new Size(594, 332);
            DGVUser.TabIndex = 14;
            DGVUser.CellClick += DGVUser_CellClick;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(Models.User);
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.FillWeight = 38.62506F;
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.FillWeight = 120.381424F;
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userTypeDataGridViewTextBoxColumn
            // 
            userTypeDataGridViewTextBoxColumn.DataPropertyName = "User_Type";
            userTypeDataGridViewTextBoxColumn.FillWeight = 120.381424F;
            userTypeDataGridViewTextBoxColumn.HeaderText = "UserType";
            userTypeDataGridViewTextBoxColumn.Name = "userTypeDataGridViewTextBoxColumn";
            userTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.FillWeight = 120.381424F;
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.FillWeight = 120.381424F;
            phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            usernameDataGridViewTextBoxColumn.FillWeight = 120.381424F;
            usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            passwordDataGridViewTextBoxColumn.FillWeight = 120.381424F;
            passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(618, 402);
            Controls.Add(BtnRemove);
            Controls.Add(BtnEdit);
            Controls.Add(BtnAdd);
            Controls.Add(TbSearch);
            Controls.Add(DGVUser);
            Name = "User";
            Text = "User";
            ((System.ComponentModel.ISupportInitialize)DGVUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnRemove;
        private Button BtnEdit;
        private Button BtnAdd;
        private TextBox TbSearch;
        private DataGridView DGVUser;
        private BindingSource userBindingSource;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
    }
}