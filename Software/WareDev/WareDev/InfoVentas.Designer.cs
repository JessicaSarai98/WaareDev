namespace WareDev
{
    partial class InfoVentas
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
            this.txtIva = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCurrency = new System.Windows.Forms.TextBox();
            this.txtCond = new System.Windows.Forms.TextBox();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(47, 29);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 0;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(47, 79);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 20);
            this.txtDate.TabIndex = 1;
            // 
            // txtIva
            // 
            this.txtIva.Location = new System.Drawing.Point(47, 128);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(100, 20);
            this.txtIva.TabIndex = 2;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(47, 180);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 20);
            this.txtNum.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(47, 224);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtCurrency
            // 
            this.txtCurrency.Location = new System.Drawing.Point(47, 271);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Size = new System.Drawing.Size(100, 20);
            this.txtCurrency.TabIndex = 5;
            // 
            // txtCond
            // 
            this.txtCond.Location = new System.Drawing.Point(47, 328);
            this.txtCond.Name = "txtCond";
            this.txtCond.Size = new System.Drawing.Size(100, 20);
            this.txtCond.TabIndex = 6;
            this.txtCond.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(300, 79);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(100, 20);
            this.txtLugar.TabIndex = 7;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(300, 143);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 8;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(300, 206);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 9;
            // 
            // InfoVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.txtLugar);
            this.Controls.Add(this.txtCond);
            this.Controls.Add(this.txtCurrency);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.txtIva);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtId);
            this.Name = "InfoVentas";
            this.Text = "InfoVentas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txtId;
        public System.Windows.Forms.TextBox txtDate;
        public System.Windows.Forms.TextBox txtIva;
        public System.Windows.Forms.TextBox txtNum;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtCurrency;
        public System.Windows.Forms.TextBox txtCond;
        public System.Windows.Forms.TextBox txtLugar;
        public System.Windows.Forms.TextBox txtSubtotal;
        public System.Windows.Forms.TextBox txtTotal;
    }
}