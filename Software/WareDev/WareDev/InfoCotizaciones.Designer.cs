namespace WareDev
{
    partial class InfoCotizaciones
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
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtPallet = new System.Windows.Forms.TextBox();
            this.txtExpiration = new System.Windows.Forms.TextBox();
            this.txtIcoterm = new System.Windows.Forms.TextBox();
            this.txtIdClient = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtCurrency = new System.Windows.Forms.TextBox();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.txtCond = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtFlete = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(38, 30);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 0;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(38, 85);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 20);
            this.txtDate.TabIndex = 1;
            // 
            // txtPallet
            // 
            this.txtPallet.Location = new System.Drawing.Point(38, 141);
            this.txtPallet.Name = "txtPallet";
            this.txtPallet.Size = new System.Drawing.Size(100, 20);
            this.txtPallet.TabIndex = 2;
            // 
            // txtExpiration
            // 
            this.txtExpiration.Location = new System.Drawing.Point(38, 205);
            this.txtExpiration.Name = "txtExpiration";
            this.txtExpiration.Size = new System.Drawing.Size(100, 20);
            this.txtExpiration.TabIndex = 3;
            // 
            // txtIcoterm
            // 
            this.txtIcoterm.Location = new System.Drawing.Point(38, 341);
            this.txtIcoterm.Name = "txtIcoterm";
            this.txtIcoterm.Size = new System.Drawing.Size(100, 20);
            this.txtIcoterm.TabIndex = 4;
            // 
            // txtIdClient
            // 
            this.txtIdClient.Location = new System.Drawing.Point(38, 279);
            this.txtIdClient.Name = "txtIdClient";
            this.txtIdClient.Size = new System.Drawing.Size(100, 20);
            this.txtIdClient.TabIndex = 5;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(38, 394);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerName.TabIndex = 6;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(187, 21);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 7;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(187, 85);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 8;
            // 
            // txtCurrency
            // 
            this.txtCurrency.Location = new System.Drawing.Point(187, 141);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Size = new System.Drawing.Size(100, 20);
            this.txtCurrency.TabIndex = 9;
            // 
            // txtIva
            // 
            this.txtIva.Location = new System.Drawing.Point(187, 205);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(100, 20);
            this.txtIva.TabIndex = 10;
            // 
            // txtPlace
            // 
            this.txtPlace.Location = new System.Drawing.Point(187, 279);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(100, 20);
            this.txtPlace.TabIndex = 11;
            // 
            // txtCond
            // 
            this.txtCond.Location = new System.Drawing.Point(187, 341);
            this.txtCond.Name = "txtCond";
            this.txtCond.Size = new System.Drawing.Size(100, 20);
            this.txtCond.TabIndex = 12;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(187, 394);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(100, 20);
            this.txtProducto.TabIndex = 13;
            // 
            // txtFlete
            // 
            this.txtFlete.Location = new System.Drawing.Point(331, 177);
            this.txtFlete.Name = "txtFlete";
            this.txtFlete.Size = new System.Drawing.Size(100, 20);
            this.txtFlete.TabIndex = 14;
            this.txtFlete.TextChanged += new System.EventHandler(this.textBox15_TextChanged);
            // 
            // InfoCotizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFlete);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.txtCond);
            this.Controls.Add(this.txtPlace);
            this.Controls.Add(this.txtIva);
            this.Controls.Add(this.txtCurrency);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtIdClient);
            this.Controls.Add(this.txtIcoterm);
            this.Controls.Add(this.txtExpiration);
            this.Controls.Add(this.txtPallet);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtId);
            this.Name = "InfoCotizaciones";
            this.Text = "InfoCotizaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtId;
        public System.Windows.Forms.TextBox txtDate;
        public System.Windows.Forms.TextBox txtPallet;
        public System.Windows.Forms.TextBox txtExpiration;
        public System.Windows.Forms.TextBox txtIcoterm;
        public System.Windows.Forms.TextBox txtIdClient;
        public System.Windows.Forms.TextBox txtCustomerName;
        public System.Windows.Forms.TextBox txtSubtotal;
        public System.Windows.Forms.TextBox txtTotal;
        public System.Windows.Forms.TextBox txtCurrency;
        public System.Windows.Forms.TextBox txtIva;
        public System.Windows.Forms.TextBox txtPlace;
        public System.Windows.Forms.TextBox txtCond;
        public System.Windows.Forms.TextBox txtProducto;
        public System.Windows.Forms.TextBox txtFlete;
    }
}