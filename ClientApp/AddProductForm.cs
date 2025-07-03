using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using ClientApp.Models;
using ClientApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ClientApp
{
    public partial class AddProductForm : Form
    {
        private readonly ApiClient _apiClient = new();
        public AddProductForm()
        {
            InitializeComponent();
            this.Load += AddProductForm_Load;
        }

        private async void AddProductForm_Load(object sender, EventArgs e)
        {
            try
            {
                var categories = await _apiClient.GetCategoriesAsync();
                ProductCategory_Box.DataSource = categories;
                ProductCategory_Box.DisplayMember = "Name";
                ProductCategory_Box.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fetching categories failed: " + ex.Message);
            }
        }


        private async  void Add_product(object sender, EventArgs e)
        {
            try
            {
                var product = new ProductDto
                {
                    Name = ProductName_textBox.Text,
                    Price = ProductPrice_box.Value,
                    Description = ProductDescription_Textbox.Text,
                    Code = ProductCode_textBox.Text,
                    Category_Id = (long)ProductCategory_Box.SelectedValue
                };

                var success = await _apiClient.AddProductAsync(product);
                if (success)
                {
                    MessageBox.Show("Product added");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to add product");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
    
}
