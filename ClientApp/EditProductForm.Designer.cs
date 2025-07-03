namespace ClientApp
{
    partial class EditProductForm
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
            ProductPrice_box = new NumericUpDown();
            Edit_product_button = new Button();
            ProductDescription_Textbox = new RichTextBox();
            Description_Label = new Label();
            ProductCategory_Box = new ComboBox();
            Category_label = new Label();
            Price_label = new Label();
            ProductCode_textBox = new TextBox();
            Code_label = new Label();
            ProductName_textBox = new TextBox();
            Name_label = new Label();
            ((System.ComponentModel.ISupportInitialize)ProductPrice_box).BeginInit();
            SuspendLayout();
            // 
            // ProductPrice_box
            // 
            ProductPrice_box.DecimalPlaces = 2;
            ProductPrice_box.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            ProductPrice_box.Location = new Point(132, 106);
            ProductPrice_box.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            ProductPrice_box.Name = "ProductPrice_box";
            ProductPrice_box.Size = new Size(403, 23);
            ProductPrice_box.TabIndex = 25;
            // 
            // Edit_product_button
            // 
            Edit_product_button.Location = new Point(132, 337);
            Edit_product_button.Name = "Edit_product_button";
            Edit_product_button.Size = new Size(403, 41);
            Edit_product_button.TabIndex = 24;
            Edit_product_button.Text = "Edit Product";
            Edit_product_button.UseVisualStyleBackColor = true;
            Edit_product_button.Click += Edit_product;
            // 
            // ProductDescription_Textbox
            // 
            ProductDescription_Textbox.Location = new Point(132, 184);
            ProductDescription_Textbox.Name = "ProductDescription_Textbox";
            ProductDescription_Textbox.Size = new Size(403, 123);
            ProductDescription_Textbox.TabIndex = 23;
            ProductDescription_Textbox.Text = "";
            // 
            // Description_Label
            // 
            Description_Label.AutoSize = true;
            Description_Label.Location = new Point(14, 184);
            Description_Label.Name = "Description_Label";
            Description_Label.Size = new Size(112, 15);
            Description_Label.TabIndex = 22;
            Description_Label.Text = "Product Description";
            // 
            // ProductCategory_Box
            // 
            ProductCategory_Box.FormattingEnabled = true;
            ProductCategory_Box.Location = new Point(132, 146);
            ProductCategory_Box.Name = "ProductCategory_Box";
            ProductCategory_Box.Size = new Size(403, 23);
            ProductCategory_Box.TabIndex = 21;
            // 
            // Category_label
            // 
            Category_label.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Category_label.AutoSize = true;
            Category_label.Location = new Point(14, 149);
            Category_label.Name = "Category_label";
            Category_label.Size = new Size(100, 15);
            Category_label.TabIndex = 20;
            Category_label.Text = "Product Category";
            // 
            // Price_label
            // 
            Price_label.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Price_label.AutoSize = true;
            Price_label.Location = new Point(14, 108);
            Price_label.Name = "Price_label";
            Price_label.Size = new Size(78, 15);
            Price_label.TabIndex = 19;
            Price_label.Text = "Product Price";
            // 
            // ProductCode_textBox
            // 
            ProductCode_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ProductCode_textBox.Location = new Point(132, 64);
            ProductCode_textBox.Name = "ProductCode_textBox";
            ProductCode_textBox.Size = new Size(403, 23);
            ProductCode_textBox.TabIndex = 18;
            // 
            // Code_label
            // 
            Code_label.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Code_label.AutoSize = true;
            Code_label.Location = new Point(14, 67);
            Code_label.Name = "Code_label";
            Code_label.Size = new Size(80, 15);
            Code_label.TabIndex = 17;
            Code_label.Text = "Product Code";
            // 
            // ProductName_textBox
            // 
            ProductName_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ProductName_textBox.Location = new Point(132, 25);
            ProductName_textBox.Name = "ProductName_textBox";
            ProductName_textBox.Size = new Size(403, 23);
            ProductName_textBox.TabIndex = 16;
            // 
            // Name_label
            // 
            Name_label.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Name_label.AutoSize = true;
            Name_label.Location = new Point(14, 28);
            Name_label.Name = "Name_label";
            Name_label.Size = new Size(80, 15);
            Name_label.TabIndex = 15;
            Name_label.Text = "Poduct Name";
            // 
            // EditProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 450);
            Controls.Add(ProductPrice_box);
            Controls.Add(Edit_product_button);
            Controls.Add(ProductDescription_Textbox);
            Controls.Add(Description_Label);
            Controls.Add(ProductCategory_Box);
            Controls.Add(Category_label);
            Controls.Add(Price_label);
            Controls.Add(ProductCode_textBox);
            Controls.Add(Code_label);
            Controls.Add(ProductName_textBox);
            Controls.Add(Name_label);
            Name = "EditProductForm";
            Text = "EditProductForm";
            ((System.ComponentModel.ISupportInitialize)ProductPrice_box).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown ProductPrice_box;
        private Button Edit_product_button;
        private RichTextBox ProductDescription_Textbox;
        private Label Description_Label;
        private ComboBox ProductCategory_Box;
        private Label Category_label;
        private Label Price_label;
        private TextBox ProductCode_textBox;
        private Label Code_label;
        private TextBox ProductName_textBox;
        private Label Name_label;
    }
}