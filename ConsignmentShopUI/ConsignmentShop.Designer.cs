namespace ConsignmentShopUI
{
    partial class ConsignmentShop
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
            this.lblHeaderText = new System.Windows.Forms.Label();
            this.listBoxItemList = new System.Windows.Forms.ListBox();
            this.lblItemListBox = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.lblShoppingCart = new System.Windows.Forms.Label();
            this.listBoxShoppingCart = new System.Windows.Forms.ListBox();
            this.btnMakePurchase = new System.Windows.Forms.Button();
            this.lblVandorListBox = new System.Windows.Forms.Label();
            this.listBoxVendor = new System.Windows.Forms.ListBox();
            this.lblStoreProfit = new System.Windows.Forms.Label();
            this.lblStoreProfitText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHeaderText
            // 
            this.lblHeaderText.AutoSize = true;
            this.lblHeaderText.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeaderText.Location = new System.Drawing.Point(37, 15);
            this.lblHeaderText.Name = "lblHeaderText";
            this.lblHeaderText.Size = new System.Drawing.Size(304, 45);
            this.lblHeaderText.TabIndex = 0;
            this.lblHeaderText.Text = "Consignment Shop";
            this.lblHeaderText.UseWaitCursor = true;
            // 
            // listBoxItemList
            // 
            this.listBoxItemList.FormattingEnabled = true;
            this.listBoxItemList.ItemHeight = 21;
            this.listBoxItemList.Location = new System.Drawing.Point(37, 120);
            this.listBoxItemList.Name = "listBoxItemList";
            this.listBoxItemList.Size = new System.Drawing.Size(451, 277);
            this.listBoxItemList.TabIndex = 1;
            this.listBoxItemList.UseWaitCursor = true;
            // 
            // lblItemListBox
            // 
            this.lblItemListBox.AutoSize = true;
            this.lblItemListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblItemListBox.Location = new System.Drawing.Point(37, 95);
            this.lblItemListBox.Name = "lblItemListBox";
            this.lblItemListBox.Size = new System.Drawing.Size(96, 21);
            this.lblItemListBox.TabIndex = 2;
            this.lblItemListBox.Text = "Store Items";
            this.lblItemListBox.UseWaitCursor = true;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(499, 239);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddToCart.Size = new System.Drawing.Size(118, 39);
            this.btnAddToCart.TabIndex = 3;
            this.btnAddToCart.Text = "Add To Cart >";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.UseWaitCursor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // lblShoppingCart
            // 
            this.lblShoppingCart.AutoSize = true;
            this.lblShoppingCart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblShoppingCart.Location = new System.Drawing.Point(623, 95);
            this.lblShoppingCart.Name = "lblShoppingCart";
            this.lblShoppingCart.Size = new System.Drawing.Size(96, 21);
            this.lblShoppingCart.TabIndex = 5;
            this.lblShoppingCart.Text = "Store Items";
            this.lblShoppingCart.UseWaitCursor = true;
            // 
            // listBoxShoppingCart
            // 
            this.listBoxShoppingCart.FormattingEnabled = true;
            this.listBoxShoppingCart.ItemHeight = 21;
            this.listBoxShoppingCart.Location = new System.Drawing.Point(623, 120);
            this.listBoxShoppingCart.Name = "listBoxShoppingCart";
            this.listBoxShoppingCart.Size = new System.Drawing.Size(451, 277);
            this.listBoxShoppingCart.TabIndex = 4;
            this.listBoxShoppingCart.UseWaitCursor = true;
            // 
            // btnMakePurchase
            // 
            this.btnMakePurchase.Location = new System.Drawing.Point(956, 414);
            this.btnMakePurchase.Name = "btnMakePurchase";
            this.btnMakePurchase.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMakePurchase.Size = new System.Drawing.Size(118, 39);
            this.btnMakePurchase.TabIndex = 6;
            this.btnMakePurchase.Text = "Purchase";
            this.btnMakePurchase.UseVisualStyleBackColor = true;
            this.btnMakePurchase.UseWaitCursor = true;
            this.btnMakePurchase.Click += new System.EventHandler(this.btnMakePurchase_Click);
            // 
            // lblVandorListBox
            // 
            this.lblVandorListBox.AutoSize = true;
            this.lblVandorListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVandorListBox.Location = new System.Drawing.Point(37, 439);
            this.lblVandorListBox.Name = "lblVandorListBox";
            this.lblVandorListBox.Size = new System.Drawing.Size(72, 21);
            this.lblVandorListBox.TabIndex = 8;
            this.lblVandorListBox.Text = "Vendors";
            this.lblVandorListBox.UseWaitCursor = true;
            // 
            // listBoxVendor
            // 
            this.listBoxVendor.FormattingEnabled = true;
            this.listBoxVendor.ItemHeight = 21;
            this.listBoxVendor.Location = new System.Drawing.Point(37, 464);
            this.listBoxVendor.Name = "listBoxVendor";
            this.listBoxVendor.Size = new System.Drawing.Size(451, 277);
            this.listBoxVendor.TabIndex = 7;
            this.listBoxVendor.UseWaitCursor = true;
            // 
            // lblStoreProfit
            // 
            this.lblStoreProfit.AutoSize = true;
            this.lblStoreProfit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStoreProfit.Location = new System.Drawing.Point(623, 464);
            this.lblStoreProfit.Name = "lblStoreProfit";
            this.lblStoreProfit.Size = new System.Drawing.Size(101, 21);
            this.lblStoreProfit.TabIndex = 9;
            this.lblStoreProfit.Text = "Store Profit:";
            this.lblStoreProfit.UseWaitCursor = true;
            // 
            // lblStoreProfitText
            // 
            this.lblStoreProfitText.AutoSize = true;
            this.lblStoreProfitText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStoreProfitText.Location = new System.Drawing.Point(755, 464);
            this.lblStoreProfitText.Name = "lblStoreProfitText";
            this.lblStoreProfitText.Size = new System.Drawing.Size(50, 21);
            this.lblStoreProfitText.TabIndex = 10;
            this.lblStoreProfitText.Text = "$0.00";
            this.lblStoreProfitText.UseWaitCursor = true;
            // 
            // ConsignmentShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 807);
            this.Controls.Add(this.lblStoreProfitText);
            this.Controls.Add(this.lblStoreProfit);
            this.Controls.Add(this.lblVandorListBox);
            this.Controls.Add(this.listBoxVendor);
            this.Controls.Add(this.btnMakePurchase);
            this.Controls.Add(this.lblShoppingCart);
            this.Controls.Add(this.listBoxShoppingCart);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.lblItemListBox);
            this.Controls.Add(this.listBoxItemList);
            this.Controls.Add(this.lblHeaderText);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConsignmentShop";
            this.Text = "Consignment Shop ";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeaderText;
        private System.Windows.Forms.ListBox listBoxItemList;
        private System.Windows.Forms.Label lblItemListBox;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Label lblShoppingCart;
        private System.Windows.Forms.ListBox listBoxShoppingCart;
        private System.Windows.Forms.Button btnMakePurchase;
        private System.Windows.Forms.Label lblVandorListBox;
        private System.Windows.Forms.ListBox listBoxVendor;
        private System.Windows.Forms.Label lblStoreProfit;
        private System.Windows.Forms.Label lblStoreProfitText;
    }
}
