namespace MTCE
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
            txtProductName = new TextBox();
            txtQuantity = new TextBox();
            txtSellPrice = new TextBox();
            cbCategory = new ComboBox();
            dtPickerMfgDate = new DateTimePicker();
            dtPickerExpDate = new DateTimePicker();
            richTxtDescription = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnAddProduct = new Button();
            gritViewProductList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gritViewProductList).BeginInit();
            SuspendLayout();
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(174, 46);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(250, 27);
            txtProductName.TabIndex = 0;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(174, 179);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(250, 27);
            txtQuantity.TabIndex = 1;
            // 
            // txtSellPrice
            // 
            txtSellPrice.Location = new Point(174, 212);
            txtSellPrice.Name = "txtSellPrice";
            txtSellPrice.Size = new Size(250, 27);
            txtSellPrice.TabIndex = 2;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(174, 79);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(250, 28);
            cbCategory.TabIndex = 3;
            // 
            // dtPickerMfgDate
            // 
            dtPickerMfgDate.Location = new Point(174, 113);
            dtPickerMfgDate.Name = "dtPickerMfgDate";
            dtPickerMfgDate.Size = new Size(250, 27);
            dtPickerMfgDate.TabIndex = 4;
            dtPickerMfgDate.Value = new DateTime(2024, 11, 19, 22, 45, 28, 0);
            // 
            // dtPickerExpDate
            // 
            dtPickerExpDate.Location = new Point(174, 146);
            dtPickerExpDate.Name = "dtPickerExpDate";
            dtPickerExpDate.Size = new Size(250, 27);
            dtPickerExpDate.TabIndex = 5;
            // 
            // richTxtDescription
            // 
            richTxtDescription.Location = new Point(448, 79);
            richTxtDescription.Name = "richTxtDescription";
            richTxtDescription.Size = new Size(300, 160);
            richTxtDescription.TabIndex = 6;
            richTxtDescription.Text = "";
            richTxtDescription.TextChanged += richTxtDescription_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 53);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 7;
            label1.Text = "Product";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 79);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 8;
            label2.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 113);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 9;
            label3.Text = "Mfg.Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 146);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 10;
            label4.Text = "Exp.Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(70, 182);
            label5.Name = "label5";
            label5.Size = new Size(32, 20);
            label5.TabIndex = 11;
            label5.Text = "Qty";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(70, 219);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 12;
            label6.Text = "Sell Price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(448, 49);
            label7.Name = "label7";
            label7.Size = new Size(85, 20);
            label7.TabIndex = 13;
            label7.Text = "Description";
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(640, 245);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(108, 29);
            btnAddProduct.TabIndex = 14;
            btnAddProduct.Text = "Add product";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // gritViewProductList
            // 
            gritViewProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gritViewProductList.Location = new Point(12, 280);
            gritViewProductList.Name = "gritViewProductList";
            gritViewProductList.RowHeadersWidth = 51;
            gritViewProductList.Size = new Size(776, 158);
            gritViewProductList.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gritViewProductList);
            Controls.Add(btnAddProduct);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(richTxtDescription);
            Controls.Add(dtPickerExpDate);
            Controls.Add(dtPickerMfgDate);
            Controls.Add(cbCategory);
            Controls.Add(txtSellPrice);
            Controls.Add(txtQuantity);
            Controls.Add(txtProductName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)gritViewProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtProductName;
        private TextBox txtQuantity;
        private TextBox txtSellPrice;
        private ComboBox cbCategory;
        private DateTimePicker dtPickerMfgDate;
        private DateTimePicker dtPickerExpDate;
        private RichTextBox richTxtDescription;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnAddProduct;
        private DataGridView gritViewProductList;
    }
}
