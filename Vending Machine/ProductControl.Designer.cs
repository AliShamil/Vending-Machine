namespace Vending_Machine
{
    partial class ProductControl
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_Product = new System.Windows.Forms.Panel();
            this.txt_product_price = new System.Windows.Forms.TextBox();
            this.lbl_product_name = new System.Windows.Forms.Label();
            this.panel_Product.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Product
            // 
            this.panel_Product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Product.Controls.Add(this.txt_product_price);
            this.panel_Product.Controls.Add(this.lbl_product_name);
            this.panel_Product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Product.Location = new System.Drawing.Point(0, 0);
            this.panel_Product.Name = "panel_Product";
            this.panel_Product.Size = new System.Drawing.Size(111, 97);
            this.panel_Product.TabIndex = 16;
            this.panel_Product.Tag = "Cola";
            // 
            // txt_product_price
            // 
            this.txt_product_price.Location = new System.Drawing.Point(18, 46);
            this.txt_product_price.Name = "txt_product_price";
            this.txt_product_price.ReadOnly = true;
            this.txt_product_price.Size = new System.Drawing.Size(72, 23);
            this.txt_product_price.TabIndex = 1;
            this.txt_product_price.Text = "0.00 AZN";
            // 
            // lbl_product_name
            // 
            this.lbl_product_name.AutoSize = true;
            this.lbl_product_name.Location = new System.Drawing.Point(18, 13);
            this.lbl_product_name.Name = "lbl_product_name";
            this.lbl_product_name.Size = new System.Drawing.Size(84, 15);
            this.lbl_product_name.TabIndex = 0;
            this.lbl_product_name.Text = "Product Name";
            // 
            // ProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_Product);
            this.Name = "ProductControl";
            this.Size = new System.Drawing.Size(111, 97);
            this.panel_Product.ResumeLayout(false);
            this.panel_Product.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel_Product;
        public TextBox txt_product_price;
        public Label lbl_product_name;
    }
}
