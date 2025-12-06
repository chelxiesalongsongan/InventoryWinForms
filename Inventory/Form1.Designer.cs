namespace Inventory
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.CheckBox chkConfirmDelete;


        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ProductTextBox = new TextBox();
            SKUTextBox = new TextBox();
            QuantityBox = new NumericUpDown();
            CategoryBox = new ComboBox();
            AddBtn = new Button();
            UpdateBtn = new Button();
            Filter = new ComboBox();
            Search = new TextBox();
            RemoveBtn = new Button();
            ClearBtn = new Button();
            ApplyBtn = new Button();
            ResetBtn = new Button();
            dataGridView1 = new DataGridView();
            SKUColumn = new DataGridViewTextBoxColumn();
            NameColumn = new DataGridViewTextBoxColumn();
            CategoryColumn = new DataGridViewTextBoxColumn();
            QuantityColumn = new DataGridViewTextBoxColumn();
            TotalQuantity = new Label();
            Status = new Label();
            chkConfirmDelete = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)QuantityBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ProductTextBox
            // 
            ProductTextBox.AccessibleName = "ProductTextBox";
            ProductTextBox.Location = new Point(254, 56);
            ProductTextBox.Name = "ProductTextBox";
            ProductTextBox.Size = new Size(313, 23);
            ProductTextBox.TabIndex = 0;
            ProductTextBox.Text = "Product Name";
            ProductTextBox.TextChanged += ProductTextBox_TextChanged;
            // 
            // SKUTextBox
            // 
            SKUTextBox.AccessibleName = "SKUTextBox";
            SKUTextBox.Location = new Point(254, 85);
            SKUTextBox.Name = "SKUTextBox";
            SKUTextBox.Size = new Size(313, 23);
            SKUTextBox.TabIndex = 1;
            SKUTextBox.Text = "SKU-code";
            SKUTextBox.TextChanged += SKUTextBox_TextChanged;
            // 
            // QuantityBox
            // 
            QuantityBox.AccessibleName = "QuantityBox";
            QuantityBox.Location = new Point(410, 116);
            QuantityBox.Name = "QuantityBox";
            QuantityBox.Size = new Size(120, 23);
            QuantityBox.TabIndex = 2;
            QuantityBox.ValueChanged += QuantityBox_ValueChanged;
            // 
            // CategoryBox
            // 
            CategoryBox.AccessibleName = "CategoryBox";
            CategoryBox.FormattingEnabled = true;
            CategoryBox.Location = new Point(283, 116);
            CategoryBox.Name = "CategoryBox";
            CategoryBox.Size = new Size(121, 23);
            CategoryBox.TabIndex = 0;
            CategoryBox.Text = "Category";
            CategoryBox.SelectedIndexChanged += CategoryBox_SelectedIndexChanged;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(329, 149);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(75, 23);
            AddBtn.TabIndex = 4;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.AccessibleName = "UpdateBtn";
            UpdateBtn.Location = new Point(410, 149);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(75, 23);
            UpdateBtn.TabIndex = 5;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // Filter
            // 
            Filter.AccessibleName = "Filter";
            Filter.FormattingEnabled = true;
            Filter.Location = new Point(12, 238);
            Filter.Name = "Filter";
            Filter.Size = new Size(121, 23);
            Filter.TabIndex = 6;
            Filter.Text = "Filter";
            // 
            // Search
            // 
            Search.AccessibleName = "Search";
            Search.Location = new Point(139, 238);
            Search.Name = "Search";
            Search.Size = new Size(128, 23);
            Search.TabIndex = 7;
            Search.Text = "Search";
            // 
            // RemoveBtn
            // 
            RemoveBtn.AccessibleName = "RemoveBtn";
            RemoveBtn.Location = new Point(632, 238);
            RemoveBtn.Name = "RemoveBtn";
            RemoveBtn.Size = new Size(75, 23);
            RemoveBtn.TabIndex = 8;
            RemoveBtn.Text = "Remove";
            RemoveBtn.UseVisualStyleBackColor = true;
            RemoveBtn.Click += RemoveBtn_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.AccessibleName = "ClearBtn";
            ClearBtn.Location = new Point(713, 238);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(75, 23);
            ClearBtn.TabIndex = 9;
            ClearBtn.Text = "Clear All";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // ApplyBtn
            // 
            ApplyBtn.AccessibleName = "ApplyBtn";
            ApplyBtn.Location = new Point(273, 238);
            ApplyBtn.Name = "ApplyBtn";
            ApplyBtn.Size = new Size(75, 23);
            ApplyBtn.TabIndex = 10;
            ApplyBtn.Text = "Apply";
            ApplyBtn.UseVisualStyleBackColor = true;
            ApplyBtn.Click += ApplyBtn_Click;
            // 
            // ResetBtn
            // 
            ResetBtn.AccessibleName = "ResetBtn";
            ResetBtn.Location = new Point(354, 237);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(75, 23);
            ResetBtn.TabIndex = 11;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = true;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { SKUColumn, NameColumn, CategoryColumn, QuantityColumn });
            dataGridView1.Location = new Point(12, 278);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(776, 150);
            dataGridView1.TabIndex = 12;
            // 
            // SKUColumn
            // 
            SKUColumn.HeaderText = "SKU";
            SKUColumn.Name = "SKUColumn";
            SKUColumn.ReadOnly = true;
            // 
            // NameColumn
            // 
            NameColumn.HeaderText = "Name";
            NameColumn.Name = "NameColumn";
            NameColumn.ReadOnly = true;
            // 
            // CategoryColumn
            // 
            CategoryColumn.HeaderText = "Category";
            CategoryColumn.Name = "CategoryColumn";
            CategoryColumn.ReadOnly = true;
            // 
            // QuantityColumn
            // 
            QuantityColumn.HeaderText = "Quantity";
            QuantityColumn.Name = "QuantityColumn";
            QuantityColumn.ReadOnly = true;
            // 
            // TotalQuantity
            // 
            TotalQuantity.AccessibleName = "TotalQuantity";
            TotalQuantity.Location = new Point(12, 179);
            TotalQuantity.Name = "TotalQuantity";
            TotalQuantity.Size = new Size(100, 23);
            TotalQuantity.TabIndex = 1;
            TotalQuantity.Text = "Total Quantity";
            // 
            // Status
            // 
            Status.AccessibleName = "Status";
            Status.Location = new Point(12, 202);
            Status.Name = "Status";
            Status.Size = new Size(241, 23);
            Status.TabIndex = 0;
            Status.Text = "Status";
            // 
            // chkConfirmDelete
            // 
            chkConfirmDelete.AutoSize = true;
            chkConfirmDelete.Location = new Point(632, 213);
            chkConfirmDelete.Name = "chkConfirmDelete";
            chkConfirmDelete.Size = new Size(153, 19);
            chkConfirmDelete.TabIndex = 0;
            chkConfirmDelete.Text = "Confirm before deletion";
            chkConfirmDelete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chkConfirmDelete);
            Controls.Add(Status);
            Controls.Add(TotalQuantity);
            Controls.Add(dataGridView1);
            Controls.Add(ResetBtn);
            Controls.Add(ApplyBtn);
            Controls.Add(ClearBtn);
            Controls.Add(RemoveBtn);
            Controls.Add(Search);
            Controls.Add(Filter);
            Controls.Add(UpdateBtn);
            Controls.Add(AddBtn);
            Controls.Add(CategoryBox);
            Controls.Add(QuantityBox);
            Controls.Add(SKUTextBox);
            Controls.Add(ProductTextBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)QuantityBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ProductTextBox;
        private TextBox SKUTextBox;
        private NumericUpDown QuantityBox;
        private ComboBox CategoryBox;
        private Button AddBtn;
        private Button UpdateBtn;
        private ComboBox Filter;
        private TextBox Search;
        private Button RemoveBtn;
        private Button ClearBtn;
        private Button ApplyBtn;
        private Button ResetBtn;
        private DataGridView dataGridView1;
        private Label TotalQuantity;
        private Label Status;
        private DataGridViewTextBoxColumn SKUColumn;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn CategoryColumn;
        private DataGridViewTextBoxColumn QuantityColumn;
    }
}
