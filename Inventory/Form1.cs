using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Inventory
{
    public partial class Form1 : Form
    {
        private readonly List<Product> _catalog = new();

        public Form1()
        {
            InitializeComponent();
            ValidateInputs();
            RefreshInventory();
        }

        private void RefreshInventory(List<Product> source = null)
        {
            dataGridView1.Rows.Clear();
            var listToShow = source ?? _catalog;

            foreach (var p in listToShow)
            {
                dataGridView1.Rows.Add(p.SKU, p.Name, p.Category, p.Quantity);
            }

            int total = listToShow.Sum(p => p.Quantity);
            TotalQuantity.Text = $"Total Quantity: {total}";
        }

        private void ValidateInputs()
        {
            AddBtn.Enabled =
                !string.IsNullOrEmpty(SKUTextBox.Text.Trim()) &&
                !string.IsNullOrEmpty(ProductTextBox.Text.Trim()) &&
                CategoryBox.SelectedIndex >= 0 &&
                QuantityBox.Value >= 0;

            UpdateBtn.Enabled = !string.IsNullOrEmpty(SKUTextBox.Text.Trim());
        }


        private void AddBtn_Click(object sender, EventArgs e)
        {
            string sku = SKUTextBox.Text.Trim();
            string name = ProductTextBox.Text.Trim();
            string category = CategoryBox.SelectedItem?.ToString();
            int quantity = (int)QuantityBox.Value;

            if (string.IsNullOrEmpty(sku) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(category))
            {
                Status.Text = "Please fill all fields.";
                return;
            }

            if (_catalog.Any(p => p.SKU == sku))
            {
                Status.Text = $"Duplicate SKU {sku} not allowed.";
                MessageBox.Show("SKU already exists. Use Update Stock instead.", "Duplicate SKU",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var product = new Product { SKU = sku, Name = name, Category = category, Quantity = quantity };
            _catalog.Add(product);

            SKUTextBox.Clear();
            ProductTextBox.Clear();
            CategoryBox.SelectedIndex = -1;
            QuantityBox.Value = 0;

            RefreshInventory();
            Status.Text = $"Added {product.SKU} | {product.Name}";
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string sku = SKUTextBox.Text.Trim();
            var product = _catalog.FirstOrDefault(p => p.SKU == sku);

            if (product == null)
            {
                Status.Text = $"Product {sku} not found.";
                MessageBox.Show("Product not found. Check SKU.", "Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            product.Quantity = (int)QuantityBox.Value;
            RefreshInventory();
            Status.Text = $"Updated {product.SKU} | Qty: {product.Quantity}";
        }


        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                Status.Text = "No item selected.";
                return;
            }

            if (chkConfirmDelete.Checked)
            {
                var confirm = MessageBox.Show("Remove selected product(s)?", "Confirm Deletion",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm != DialogResult.Yes)
                {
                    Status.Text = "Deletion cancelled.";
                    return;
                }
            }

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string sku = row.Cells["SKU"].Value.ToString();
                var product = _catalog.FirstOrDefault(p => p.SKU == sku);
                if (product != null) _catalog.Remove(product);
            }

            RefreshInventory();
            Status.Text = "Selected items removed.";
        }

  
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            if (_catalog.Count == 0)
            {
                Status.Text = "No items to clear.";
                return;
            }

            var confirm = MessageBox.Show("Clear all items?", "Confirm Clear",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.No)
            {
                Status.Text = "Clear cancelled.";
                return;
            }

            _catalog.Clear();
            RefreshInventory();
            Status.Text = "All items cleared.";
        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            string category = Filter.SelectedItem?.ToString();
            string search = Search.Text.Trim().ToLower();

            var filtered = _catalog.Where(p =>
                (category == "All" || p.Category == category) &&
                (string.IsNullOrEmpty(search) ||
                 p.SKU.ToLower().Contains(search) ||
                 p.Name.ToLower().Contains(search))
            ).ToList();

            RefreshInventory(filtered);
            Status.Text = "Filter applied.";
        }

       
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Filter.SelectedIndex = 0;
            Search.Clear();
            RefreshInventory();
            Status.Text = "Filter reset.";
        }

        
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                Status.Text = $"{row.Cells["SKU"].Value} | {row.Cells["Name"].Value} | {row.Cells["Category"].Value} | Qty: {row.Cells["Quantity"].Value}";
            }
        }

     
        private void ProductTextBox_TextChanged(object sender, EventArgs e) => ValidateInputs();
        private void SKUTextBox_TextChanged(object sender, EventArgs e) => ValidateInputs();
        private void CategoryBox_SelectedIndexChanged(object sender, EventArgs e) => ValidateInputs();
        private void QuantityBox_ValueChanged(object sender, EventArgs e) => ValidateInputs();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            
        }

    }
}
