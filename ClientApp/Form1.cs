using ClientApp.Services; 
using ClientApp.Models;   
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class Form1 : Form
    {
        private readonly ApiClient _apiClient = new();

        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        private async void Form1_Load(object? sender, EventArgs e)
        {
            await Load_Products();
        }

        private async Task Load_Products()
        {
            try
            {
                var products = await _apiClient.GetProductsAsync();
                ProductsDataGrid.DataSource = products;
                

                if (ProductsDataGrid.Columns.Contains("Category_Id"))
                    ProductsDataGrid.Columns["Category_Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("B³¹d podczas ³adowania danych: " + ex.Message);
            }
        }

        private ProductDto? GetSelectedProduct()
        {
            if (ProductsDataGrid.SelectedRows.Count == 0)
                return null;

            var selectedRow = ProductsDataGrid.SelectedRows[0];

            return new ProductDto
            {
                Id = Convert.ToInt64(selectedRow.Cells["Id"].Value),
                Name = selectedRow.Cells["Name"].Value?.ToString() ?? "",
                Code = selectedRow.Cells["Code"].Value?.ToString() ?? "",
                Price = Convert.ToDecimal(selectedRow.Cells["Price"].Value),
                Description = selectedRow.Cells["Description"].Value?.ToString() ?? "",
                CategoryName = selectedRow.Cells["CategoryName"].Value?.ToString() ?? ""
            };
        }


        private void Add_Product(object sender, EventArgs e)
        {
            var form = new AddProductForm(); 
            form.ShowDialog();               

            
            _ = Load_Products();
        }

        private async void Edit_Product(object sender, EventArgs e)
        {
            var product = GetSelectedProduct();
            if (product == null)
            {
                MessageBox.Show("Wybierz produkt do edycji.");
                return;
            }

            var editForm = new EditProductForm(product, _apiClient);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                await Load_Products(); 
            }
        }

        private async void Delete_Product(object sender, EventArgs e)
        {
            var product = GetSelectedProduct();
            if (product == null)
            {
                MessageBox.Show("Choose product to delete");
                return;
            }

            var confirmed = MessageBox.Show($"Are you sure you want to remove the product: {product.Name}?",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmed == DialogResult.Yes)
            {
                bool success = await _apiClient.DeleteProductAsync(product.Id);
                if (success)
                {
                    MessageBox.Show("Product deleted");
                    await Load_Products(); 
                }
                else
                {
                    MessageBox.Show("Error while removing the product.");
                }
            }
        }

        private void Export_Products(object sender, EventArgs e)
        {

        }
    }
}
