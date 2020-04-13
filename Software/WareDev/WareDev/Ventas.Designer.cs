namespace WareDev
{
    partial class ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventas));
            this.contenedor = new System.Windows.Forms.Panel();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.imgVentas = new System.Windows.Forms.PictureBox();
            this.txtVentas = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnFactura = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.contenedor.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgVentas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contenedor
            // 
            this.contenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(208)))), ((int)(((byte)(98)))));
            this.contenedor.Controls.Add(this.panel1);
            this.contenedor.Controls.Add(this.panelTitulo);
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 0);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1018, 476);
            this.contenedor.TabIndex = 0;
            // 
            // panelTitulo
            // 
            this.panelTitulo.Controls.Add(this.txtVentas);
            this.panelTitulo.Controls.Add(this.imgVentas);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1018, 84);
            this.panelTitulo.TabIndex = 0;
            // 
            // imgVentas
            // 
            this.imgVentas.Image = ((System.Drawing.Image)(resources.GetObject("imgVentas.Image")));
            this.imgVentas.Location = new System.Drawing.Point(138, 0);
            this.imgVentas.Name = "imgVentas";
            this.imgVentas.Size = new System.Drawing.Size(107, 83);
            this.imgVentas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgVentas.TabIndex = 0;
            this.imgVentas.TabStop = false;
            // 
            // txtVentas
            // 
            this.txtVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtVentas.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVentas.Location = new System.Drawing.Point(338, 21);
            this.txtVentas.Name = "txtVentas";
            this.txtVentas.Size = new System.Drawing.Size(342, 42);
            this.txtVentas.TabIndex = 2;
            this.txtVentas.Text = "Start   >>>   Sales";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.btnFactura);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 76);
            this.panel1.TabIndex = 6;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(213)))), ((int)(((byte)(227)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCerrar.Location = new System.Drawing.Point(913, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(93, 76);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Return";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // btnFactura
            // 
            this.btnFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(213)))), ((int)(((byte)(227)))));
            this.btnFactura.FlatAppearance.BorderSize = 0;
            this.btnFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFactura.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactura.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFactura.Image = ((System.Drawing.Image)(resources.GetObject("btnFactura.Image")));
            this.btnFactura.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFactura.Location = new System.Drawing.Point(674, 0);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(93, 76);
            this.btnFactura.TabIndex = 2;
            this.btnFactura.Text = "Generate invoice";
            this.btnFactura.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFactura.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(213)))), ((int)(((byte)(227)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(796, 0);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(93, 76);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Save";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 476);
            this.Controls.Add(this.contenedor);
            this.Name = "ventas";
            this.Text = "ventas";
            this.contenedor.ResumeLayout(false);
            this.panelTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgVentas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnFactura;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label txtVentas;
        private System.Windows.Forms.PictureBox imgVentas;
    }
}