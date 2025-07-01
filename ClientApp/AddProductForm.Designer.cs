namespace ClientApp
{
    partial class AddProductForm
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
            panel1 = new Panel();
            Name_TextBox = new TextBox();
            Name_label = new Label();
            textBox1 = new TextBox();
            Code_label = new Label();
            textBox2 = new TextBox();
            Price_label = new Label();
            Category_label = new Label();
            comboBox1 = new ComboBox();
            Description_Label = new Label();
            richTextBox1 = new RichTextBox();
            Add_product_button = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(Add_product_button);
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(Description_Label);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(Category_label);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(Price_label);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(Code_label);
            panel1.Controls.Add(Name_TextBox);
            panel1.Controls.Add(Name_label);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(568, 450);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // Name_TextBox
            // 
            Name_TextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Name_TextBox.Location = new Point(136, 24);
            Name_TextBox.Name = "Name_TextBox";
            Name_TextBox.Size = new Size(403, 23);
            Name_TextBox.TabIndex = 3;
            // 
            // Name_label
            // 
            Name_label.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Name_label.AutoSize = true;
            Name_label.Location = new Point(18, 27);
            Name_label.Name = "Name_label";
            Name_label.Size = new Size(80, 15);
            Name_label.TabIndex = 2;
            Name_label.Text = "Poduct Name";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(136, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(403, 23);
            textBox1.TabIndex = 5;
            // 
            // Code_label
            // 
            Code_label.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Code_label.AutoSize = true;
            Code_label.Location = new Point(18, 66);
            Code_label.Name = "Code_label";
            Code_label.Size = new Size(80, 15);
            Code_label.TabIndex = 4;
            Code_label.Text = "Product Code";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(136, 104);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(403, 23);
            textBox2.TabIndex = 7;
            // 
            // Price_label
            // 
            Price_label.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Price_label.AutoSize = true;
            Price_label.Location = new Point(18, 107);
            Price_label.Name = "Price_label";
            Price_label.Size = new Size(78, 15);
            Price_label.TabIndex = 6;
            Price_label.Text = "Product Price";
            // 
            // Category_label
            // 
            Category_label.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Category_label.AutoSize = true;
            Category_label.Location = new Point(18, 148);
            Category_label.Name = "Category_label";
            Category_label.Size = new Size(100, 15);
            Category_label.TabIndex = 8;
            Category_label.Text = "Product Category";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(136, 145);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(403, 23);
            comboBox1.TabIndex = 9;
            // 
            // Description_Label
            // 
            Description_Label.AutoSize = true;
            Description_Label.Location = new Point(18, 183);
            Description_Label.Name = "Description_Label";
            Description_Label.Size = new Size(112, 15);
            Description_Label.TabIndex = 10;
            Description_Label.Text = "Product Description";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(136, 180);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(403, 123);
            richTextBox1.TabIndex = 12;
            richTextBox1.Text = "";
            // 
            // Add_product_button
            // 
            Add_product_button.Location = new Point(136, 336);
            Add_product_button.Name = "Add_product_button";
            Add_product_button.Size = new Size(403, 41);
            Add_product_button.TabIndex = 13;
            Add_product_button.Text = "ADD Product";
            Add_product_button.UseVisualStyleBackColor = true;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 450);
            Controls.Add(panel1);
            Name = "AddProductForm";
            Text = "AddProductForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox Name_TextBox;
        private Label Name_label;
        private Label Category_label;
        private TextBox textBox2;
        private Label Price_label;
        private TextBox textBox1;
        private Label Code_label;
        private ComboBox comboBox1;
        private Button Add_product_button;
        private RichTextBox richTextBox1;
        private Label Description_Label;
    }
}