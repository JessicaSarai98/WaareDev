namespace WareDev
{
    partial class FacturaVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacturaVentas));
            this.contenedor = new System.Windows.Forms.Panel();
            this.tablaFacVentas = new System.Windows.Forms.TableLayoutPanel();
            this.comboIncoterm = new System.Windows.Forms.ComboBox();
            this.textClave = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.certificado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNoCliente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCertificado = new System.Windows.Forms.TextBox();
            this.comboMoneda = new System.Windows.Forms.ComboBox();
            this.txtSub = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.top = new System.Windows.Forms.Panel();
            this.txtVentas = new System.Windows.Forms.Label();
            this.btnPDF = new System.Windows.Forms.Button();
            this.btrRegreso = new System.Windows.Forms.Button();
            this.contenedor.SuspendLayout();
            this.tablaFacVentas.SuspendLayout();
            this.top.SuspendLayout();
            this.SuspendLayout();
            // 
            // contenedor
            // 
            this.contenedor.Controls.Add(this.tablaFacVentas);
            this.contenedor.Controls.Add(this.btnGuardar);
            this.contenedor.Controls.Add(this.top);
            this.contenedor.Controls.Add(this.btnPDF);
            this.contenedor.Controls.Add(this.btrRegreso);
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 0);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(800, 450);
            this.contenedor.TabIndex = 0;
            // 
            // tablaFacVentas
            // 
            this.tablaFacVentas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaFacVentas.ColumnCount = 6;
            this.tablaFacVentas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.875F));
            this.tablaFacVentas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.625F));
            this.tablaFacVentas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.125F));
            this.tablaFacVentas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.25F));
            this.tablaFacVentas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tablaFacVentas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.125F));
            this.tablaFacVentas.Controls.Add(this.comboIncoterm, 1, 1);
            this.tablaFacVentas.Controls.Add(this.textClave, 3, 2);
            this.tablaFacVentas.Controls.Add(this.label2, 2, 2);
            this.tablaFacVentas.Controls.Add(this.label1, 0, 2);
            this.tablaFacVentas.Controls.Add(this.certificado, 0, 0);
            this.tablaFacVentas.Controls.Add(this.label4, 0, 1);
            this.tablaFacVentas.Controls.Add(this.txtNoCliente, 3, 0);
            this.tablaFacVentas.Controls.Add(this.label9, 4, 0);
            this.tablaFacVentas.Controls.Add(this.txtCertificado, 1, 0);
            this.tablaFacVentas.Controls.Add(this.comboMoneda, 3, 1);
            this.tablaFacVentas.Controls.Add(this.txtSub, 1, 2);
            this.tablaFacVentas.Controls.Add(this.txtC, 5, 0);
            this.tablaFacVentas.Controls.Add(this.label5, 2, 1);
            this.tablaFacVentas.Controls.Add(this.label8, 2, 0);
            this.tablaFacVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.tablaFacVentas.Location = new System.Drawing.Point(3, 198);
            this.tablaFacVentas.Name = "tablaFacVentas";
            this.tablaFacVentas.RowCount = 3;
            this.tablaFacVentas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tablaFacVentas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tablaFacVentas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tablaFacVentas.Size = new System.Drawing.Size(788, 120);
            this.tablaFacVentas.TabIndex = 30;
            // 
            // comboIncoterm
            // 
            this.comboIncoterm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboIncoterm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboIncoterm.ForeColor = System.Drawing.Color.Black;
            this.comboIncoterm.Items.AddRange(new object[] {
            "Peso",
            "Dolar",
            "Euro"});
            this.comboIncoterm.Location = new System.Drawing.Point(143, 43);
            this.comboIncoterm.Name = "comboIncoterm";
            this.comboIncoterm.Size = new System.Drawing.Size(114, 28);
            this.comboIncoterm.TabIndex = 31;
            this.comboIncoterm.TabStop = false;
            // 
            // textClave
            // 
            this.textClave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textClave.BackColor = System.Drawing.Color.White;
            this.textClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.textClave.Location = new System.Drawing.Point(400, 83);
            this.textClave.Multiline = true;
            this.textClave.Name = "textClave";
            this.textClave.Size = new System.Drawing.Size(114, 34);
            this.textClave.TabIndex = 25;
            this.textClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(305, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Clave";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Subdivision";
            // 
            // certificado
            // 
            this.certificado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.certificado.AutoSize = true;
            this.certificado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.certificado.Location = new System.Drawing.Point(13, 2);
            this.certificado.Name = "certificado";
            this.certificado.Size = new System.Drawing.Size(113, 36);
            this.certificado.TabIndex = 7;
            this.certificado.Text = "Certificado de Origen ";
            this.certificado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Incoterm";
            // 
            // txtNoCliente
            // 
            this.txtNoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNoCliente.BackColor = System.Drawing.Color.White;
            this.txtNoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.txtNoCliente.Location = new System.Drawing.Point(400, 3);
            this.txtNoCliente.Multiline = true;
            this.txtNoCliente.Name = "txtNoCliente";
            this.txtNoCliente.Size = new System.Drawing.Size(114, 34);
            this.txtNoCliente.TabIndex = 16;
            this.txtNoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(527, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 36);
            this.label9.TabIndex = 15;
            this.label9.Text = "No de Exportacion";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCertificado
            // 
            this.txtCertificado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCertificado.BackColor = System.Drawing.Color.White;
            this.txtCertificado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCertificado.Location = new System.Drawing.Point(143, 3);
            this.txtCertificado.Multiline = true;
            this.txtCertificado.Name = "txtCertificado";
            this.txtCertificado.Size = new System.Drawing.Size(117, 34);
            this.txtCertificado.TabIndex = 13;
            this.txtCertificado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboMoneda
            // 
            this.comboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMoneda.ForeColor = System.Drawing.Color.Black;
            this.comboMoneda.Items.AddRange(new object[] {
            "Peso",
            "Dolar",
            "Euro"});
            this.comboMoneda.Location = new System.Drawing.Point(400, 43);
            this.comboMoneda.Name = "comboMoneda";
            this.comboMoneda.Size = new System.Drawing.Size(114, 28);
            this.comboMoneda.TabIndex = 20;
            this.comboMoneda.TabStop = false;
            // 
            // txtSub
            // 
            this.txtSub.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSub.BackColor = System.Drawing.Color.White;
            this.txtSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.txtSub.Location = new System.Drawing.Point(143, 83);
            this.txtSub.Multiline = true;
            this.txtSub.Name = "txtSub";
            this.txtSub.Size = new System.Drawing.Size(117, 34);
            this.txtSub.TabIndex = 18;
            this.txtSub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtC
            // 
            this.txtC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtC.BackColor = System.Drawing.Color.White;
            this.txtC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.txtC.Location = new System.Drawing.Point(638, 3);
            this.txtC.Multiline = true;
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(147, 34);
            this.txtC.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(275, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 37);
            this.label5.TabIndex = 11;
            this.label5.Text = "Moneda";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(285, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 36);
            this.label8.TabIndex = 14;
            this.label8.Text = "No de Certificado";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(213)))), ((int)(((byte)(227)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(574, 90);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(104, 65);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // top
            // 
            this.top.Controls.Add(this.txtVentas);
            this.top.Location = new System.Drawing.Point(0, 0);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(800, 84);
            this.top.TabIndex = 18;
            // 
            // txtVentas
            // 
            this.txtVentas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.69811F, System.Drawing.FontStyle.Bold);
            this.txtVentas.Location = new System.Drawing.Point(284, 22);
            this.txtVentas.Name = "txtVentas";
            this.txtVentas.Size = new System.Drawing.Size(342, 42);
            this.txtVentas.TabIndex = 2;
            this.txtVentas.Text = "Facturación ";
            // 
            // btnPDF
            // 
            this.btnPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPDF.BackColor = System.Drawing.Color.Silver;
            this.btnPDF.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF.ForeColor = System.Drawing.Color.Black;
            this.btnPDF.Image = ((System.Drawing.Image)(resources.GetObject("btnPDF.Image")));
            this.btnPDF.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPDF.Location = new System.Drawing.Point(464, 90);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(104, 65);
            this.btnPDF.TabIndex = 17;
            this.btnPDF.Text = "Exportar a PDF";
            this.btnPDF.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPDF.UseVisualStyleBackColor = false;
            // 
            // btrRegreso
            // 
            this.btrRegreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btrRegreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(208)))), ((int)(((byte)(98)))));
            this.btrRegreso.Cursor = System.Windows.Forms.Cursors.Default;
            this.btrRegreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btrRegreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btrRegreso.ForeColor = System.Drawing.Color.Black;
            this.btrRegreso.Image = ((System.Drawing.Image)(resources.GetObject("btrRegreso.Image")));
            this.btrRegreso.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btrRegreso.Location = new System.Drawing.Point(684, 90);
            this.btrRegreso.Name = "btrRegreso";
            this.btrRegreso.Size = new System.Drawing.Size(104, 65);
            this.btrRegreso.TabIndex = 13;
            this.btrRegreso.Text = "Regresar";
            this.btrRegreso.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btrRegreso.UseVisualStyleBackColor = false;
            this.btrRegreso.Click += new System.EventHandler(this.btrRegreso_Click);
            // 
            // FacturaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.contenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FacturaVentas";
            this.Text = "FacturaVentas";
            this.contenedor.ResumeLayout(false);
            this.tablaFacVentas.ResumeLayout(false);
            this.tablaFacVentas.PerformLayout();
            this.top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Button btrRegreso;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Panel top;
        private System.Windows.Forms.Label txtVentas;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TableLayoutPanel tablaFacVentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label certificado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNoCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCertificado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboMoneda;
        private System.Windows.Forms.TextBox txtSub;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox textClave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboIncoterm;
    }
}