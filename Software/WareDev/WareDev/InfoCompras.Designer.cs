namespace WareDev
{
    partial class InfoCompras
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtProvider = new System.Windows.Forms.TextBox();
            this.txtAmountPurchased = new System.Windows.Forms.TextBox();
            this.txtNumberP = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(34, 13);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 0;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(34, 70);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 1;
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(34, 128);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(100, 20);
            this.txtProduct.TabIndex = 2;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(34, 199);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 3;
            // 
            // txtProvider
            // 
            this.txtProvider.Location = new System.Drawing.Point(34, 271);
            this.txtProvider.Name = "txtProvider";
            this.txtProvider.Size = new System.Drawing.Size(100, 20);
            this.txtProvider.TabIndex = 4;
            // 
            // txtAmountPurchased
            // 
            this.txtAmountPurchased.Location = new System.Drawing.Point(34, 403);
            this.txtAmountPurchased.Name = "txtAmountPurchased";
            this.txtAmountPurchased.Size = new System.Drawing.Size(100, 20);
            this.txtAmountPurchased.TabIndex = 5;
            // 
            // txtNumberP
            // 
            this.txtNumberP.Location = new System.Drawing.Point(34, 336);
            this.txtNumberP.Name = "txtNumberP";
            this.txtNumberP.Size = new System.Drawing.Size(100, 20);
            this.txtNumberP.TabIndex = 6;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(295, 128);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 7;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(295, 217);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 20);
            this.txtDescription.TabIndex = 8;
            // 
            // InfoCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtNumberP);
            this.Controls.Add(this.txtAmountPurchased);
            this.Controls.Add(this.txtProvider);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtId);
            this.Name = "InfoCompras";
            this.Text = "InfoCompras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtId;
        public System.Windows.Forms.TextBox txtFecha;
        public System.Windows.Forms.TextBox txtProduct;
        public System.Windows.Forms.TextBox txtPrice;
        public System.Windows.Forms.TextBox txtProvider;
        public System.Windows.Forms.TextBox txtAmountPurchased;
        public System.Windows.Forms.TextBox txtNumberP;
        public System.Windows.Forms.TextBox txtTotal;
        public System.Windows.Forms.TextBox txtDescription;
    }
}