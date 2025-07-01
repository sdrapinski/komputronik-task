namespace ClientApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            ProductsDataGrid = new DataGridView();
            Add_Product_Button = new Button();
            Edit_Product_Button = new Button();
            Delete_Product_Button = new Button();
            Export_button = new Button();
            ((System.ComponentModel.ISupportInitialize)ProductsDataGrid).BeginInit();
            SuspendLayout();
            // 
            // ProductsDataGrid
            // 
            ProductsDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ProductsDataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            ProductsDataGrid.Location = new Point(12, 12);
            ProductsDataGrid.MaximumSize = new Size(796, 542);
            ProductsDataGrid.Name = "ProductsDataGrid";
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ProductsDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            ProductsDataGrid.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            ProductsDataGrid.RowTemplate.Height = 30;
            ProductsDataGrid.RowTemplate.Resizable = DataGridViewTriState.True;
            ProductsDataGrid.ScrollBars = ScrollBars.Horizontal;
            ProductsDataGrid.Size = new Size(796, 542);
            ProductsDataGrid.TabIndex = 0;
            // 
            // Add_Product_Button
            // 
            Add_Product_Button.Location = new Point(827, 13);
            Add_Product_Button.Name = "Add_Product_Button";
            Add_Product_Button.Size = new Size(117, 29);
            Add_Product_Button.TabIndex = 1;
            Add_Product_Button.Text = "Add Product";
            Add_Product_Button.UseVisualStyleBackColor = true;
            Add_Product_Button.Click += Add_Product;
            // 
            // Edit_Product_Button
            // 
            Edit_Product_Button.Location = new Point(827, 48);
            Edit_Product_Button.Name = "Edit_Product_Button";
            Edit_Product_Button.Size = new Size(117, 29);
            Edit_Product_Button.TabIndex = 2;
            Edit_Product_Button.Text = "Edit Product";
            Edit_Product_Button.UseVisualStyleBackColor = true;
            Edit_Product_Button.Click += Edit_Product;
            // 
            // Delete_Product_Button
            // 
            Delete_Product_Button.Location = new Point(827, 83);
            Delete_Product_Button.Name = "Delete_Product_Button";
            Delete_Product_Button.Size = new Size(117, 29);
            Delete_Product_Button.TabIndex = 3;
            Delete_Product_Button.Text = "Delete Product";
            Delete_Product_Button.UseVisualStyleBackColor = true;
            Delete_Product_Button.Click += Delete_Product;
            // 
            // Export_button
            // 
            Export_button.Location = new Point(827, 525);
            Export_button.Name = "Export_button";
            Export_button.Size = new Size(117, 29);
            Export_button.TabIndex = 4;
            Export_button.Text = "Export to CSV";
            Export_button.UseVisualStyleBackColor = true;
            Export_button.Click += Export_Products;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 571);
            Controls.Add(Export_button);
            Controls.Add(Delete_Product_Button);
            Controls.Add(Edit_Product_Button);
            Controls.Add(Add_Product_Button);
            Controls.Add(ProductsDataGrid);
            Name = "Form1";
            Text = "Warehouse App";
            ((System.ComponentModel.ISupportInitialize)ProductsDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ProductsDataGrid;
        private Button Add_Product_Button;
        private Button Edit_Product_Button;
        private Button Delete_Product_Button;
        private Button Export_button;
    }
}
