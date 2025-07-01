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
                if (ProductsDataGrid.Columns.Contains("Id"))
                    ProductsDataGrid.Columns["Id"].Visible = false;

                if (ProductsDataGrid.Columns.Contains("Category_Id"))
                    ProductsDataGrid.Columns["Category_Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("B³¹d podczas ³adowania danych: " + ex.Message);
            }
        }


        private void Add_Product(object sender, EventArgs e)
        {
            var form = new AddProductForm(); 
            form.ShowDialog();               

            
            _ = Load_Products();
        }

        private void Edit_Product(object sender, EventArgs e)
        {

        }

        private void Delete_Product(object sender, EventArgs e)
        {

        }

        private void Export_Products(object sender, EventArgs e)
        {

        }
    }
}
