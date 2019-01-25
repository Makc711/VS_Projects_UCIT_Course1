namespace Lab2_2
{
    partial class ProductsStatistic
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.systemTextBox = new System.Windows.Forms.TextBox();
            this.NameOfProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfProducts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeOfProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Markup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellProduct = new System.Windows.Forms.DataGridViewButtonColumn();
            this.QuantityPurchaseOrSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyProduct = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Продукты отдела";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(190, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "\"Название отдела\"";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameOfProduct,
            this.NumberOfProducts,
            this.SizeOfProduct,
            this.Markup,
            this.Cost,
            this.SellProduct,
            this.QuantityPurchaseOrSale,
            this.BuyProduct,
            this.PurchasePrice});
            this.dataGridView1.Location = new System.Drawing.Point(13, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 363);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // systemTextBox
            // 
            this.systemTextBox.Location = new System.Drawing.Point(12, 418);
            this.systemTextBox.Name = "systemTextBox";
            this.systemTextBox.ReadOnly = true;
            this.systemTextBox.Size = new System.Drawing.Size(776, 20);
            this.systemTextBox.TabIndex = 3;
            // 
            // NameOfProduct
            // 
            this.NameOfProduct.HeaderText = "Название";
            this.NameOfProduct.Name = "NameOfProduct";
            // 
            // NumberOfProducts
            // 
            this.NumberOfProducts.HeaderText = "Количество";
            this.NumberOfProducts.Name = "NumberOfProducts";
            this.NumberOfProducts.ReadOnly = true;
            this.NumberOfProducts.Width = 70;
            // 
            // SizeOfProduct
            // 
            this.SizeOfProduct.HeaderText = "Размер, см2";
            this.SizeOfProduct.Name = "SizeOfProduct";
            this.SizeOfProduct.Width = 70;
            // 
            // Markup
            // 
            this.Markup.HeaderText = "Наценка, %";
            this.Markup.Name = "Markup";
            this.Markup.ReadOnly = true;
            this.Markup.Width = 70;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Стоимость, руб";
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            this.Cost.Width = 70;
            // 
            // SellProduct
            // 
            this.SellProduct.HeaderText = "Продать";
            this.SellProduct.Name = "SellProduct";
            this.SellProduct.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SellProduct.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SellProduct.Width = 70;
            // 
            // QuantityPurchaseOrSale
            // 
            this.QuantityPurchaseOrSale.HeaderText = "Количество продаваемого/ покупаемого продукта";
            this.QuantityPurchaseOrSale.Name = "QuantityPurchaseOrSale";
            // 
            // BuyProduct
            // 
            this.BuyProduct.HeaderText = "Купить";
            this.BuyProduct.Name = "BuyProduct";
            this.BuyProduct.Width = 70;
            // 
            // PurchasePrice
            // 
            this.PurchasePrice.HeaderText = "Цена закупа, руб";
            this.PurchasePrice.Name = "PurchasePrice";
            // 
            // ProductsStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.systemTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProductsStatistic";
            this.Text = "Товары";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox systemTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOfProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeOfProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Markup;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewButtonColumn SellProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityPurchaseOrSale;
        private System.Windows.Forms.DataGridViewButtonColumn BuyProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasePrice;
    }
}