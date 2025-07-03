using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientApp.Models;
using ClientApp.Services;
using System.Windows.Forms;

using System.Xml.Linq;

namespace ClientApp
{
    public partial class EditProductForm : Form
    {
        private readonly ApiClient _apiClient;
        private ProductDto _product;
        public EditProductForm(ProductDto product, ApiClient apiClient)
        {
            InitializeComponent();
            _apiClient = apiClient;
            _product = product;
            ProductCode_textBox.Text = product.Code;
            ProductCategory_Box.Text = product.CategoryName;
            ProductCategory_Box.SelectedValue = product.Category_Id;
            ProductDescription_Textbox.Text = product.Description;
            ProductPrice_box.Value = product.Price;
            ProductName_textBox.Text = product.Name;

        }

        private async void Edit_product(object sender, EventArgs e)
        {
            _product.Name = ProductName_textBox.Text.Trim();
            _product.Code = ProductCode_textBox.Text.Trim();
            _product.Price = ProductPrice_box.Value;
            _product.Description = ProductDescription_Textbox.Text.Trim();
            _product.Category_Id = (long)ProductCategory_Box.SelectedValue !=null ? (long)ProductCategory_Box.SelectedValue: _product.Category_Id;
            try
            {
                // Wywołanie API do aktualizacji produktu
                bool success = await _apiClient.UpdateProductAsync(_product);

                if (success)
                {
                    MessageBox.Show("The product has been updated.");
                    this.DialogResult = DialogResult.OK;  // sygnalizujemy sukces
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Product update failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show((string) ProductCategory_Box.SelectedValue);
               // MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
