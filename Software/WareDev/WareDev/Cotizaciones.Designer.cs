using System;

namespace WareDev
{
    partial class Cotizaciones
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
            this.button5 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.IdClient = new System.Windows.Forms.ComboBox();
            this.ico = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.Expiration = new System.Windows.Forms.DateTimePicker();
            this.Customer = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pallet = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TablaDeVenta = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cajasPorContenido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.divisa = new System.Windows.Forms.ComboBox();
            this.agregar = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Condicion = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.Place = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.producto = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaDeVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.69811F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 33);
            this.label1.TabIndex = 14;
            this.label1.Text = "Quotations";
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(1000, 511);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 48);
            this.button5.TabIndex = 47;
            this.button5.Text = "Cancel ";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.UseWaitCursor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.028456F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.739F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.58956F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.60353F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.813542F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.92276F));
            this.tableLayoutPanel1.Controls.Add(this.IdClient, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.ico, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTotal, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.Expiration, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.Customer, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label10, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pallet, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Date, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtFolio, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtSubtotal, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 4, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(31, 67);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1036, 114);
            this.tableLayoutPanel1.TabIndex = 48;
            // 
            // IdClient
            // 
            this.IdClient.FormattingEnabled = true;
            this.IdClient.Items.AddRange(new object[] {
            "Peso",
            "Euro",
            "Dolar"});
            this.IdClient.Location = new System.Drawing.Point(369, 40);
            this.IdClient.Name = "IdClient";
            this.IdClient.Size = new System.Drawing.Size(150, 30);
            this.IdClient.TabIndex = 57;
            // 
            // ico
            // 
            this.ico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ico.BackColor = System.Drawing.Color.White;
            this.ico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.ico.Location = new System.Drawing.Point(369, 77);
            this.ico.Multiline = true;
            this.ico.Name = "ico";
            this.ico.Size = new System.Drawing.Size(156, 34);
            this.ico.TabIndex = 53;
            this.ico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 52;
            this.label2.Text = "Icoterm";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt1
            // 
            this.txt1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt1.AutoSize = true;
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.Location = new System.Drawing.Point(16, 8);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(50, 20);
            this.txt1.TabIndex = 7;
            this.txt1.Text = "Folio";
            this.txt1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.txtTotal.Location = new System.Drawing.Point(632, 77);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(195, 34);
            this.txtTotal.TabIndex = 21;
            // 
            // Expiration
            // 
            this.Expiration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Expiration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expiration.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Expiration.Location = new System.Drawing.Point(369, 3);
            this.Expiration.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.Expiration.Name = "Expiration";
            this.Expiration.Size = new System.Drawing.Size(156, 27);
            this.Expiration.TabIndex = 54;
            this.Expiration.Value = new System.DateTime(2020, 3, 31, 0, 0, 0, 0);
            // 
            // Customer
            // 
            this.Customer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Customer.BackColor = System.Drawing.Color.White;
            this.Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.Customer.Location = new System.Drawing.Point(632, 3);
            this.Customer.Multiline = true;
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(401, 31);
            this.Customer.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(247, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 30);
            this.label10.TabIndex = 52;
            this.label10.Text = "Expiration";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Date";
            // 
            // pallet
            // 
            this.pallet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pallet.BackColor = System.Drawing.Color.White;
            this.pallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.pallet.Location = new System.Drawing.Point(86, 77);
            this.pallet.Multiline = true;
            this.pallet.Name = "pallet";
            this.pallet.Size = new System.Drawing.Size(147, 34);
            this.pallet.TabIndex = 51;
            this.pallet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Date
            // 
            this.Date.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date.Location = new System.Drawing.Point(86, 40);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(147, 27);
            this.Date.TabIndex = 14;
            this.Date.Value = new System.DateTime(2020, 3, 31, 0, 0, 0, 0);
            // 
            // txtFolio
            // 
            this.txtFolio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFolio.BackColor = System.Drawing.Color.White;
            this.txtFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolio.Location = new System.Drawing.Point(86, 3);
            this.txtFolio.Multiline = true;
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(147, 31);
            this.txtFolio.TabIndex = 13;
            this.txtFolio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(531, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Total";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(253, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Id Client";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(536, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Subtotal";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubtotal.BackColor = System.Drawing.Color.White;
            this.txtSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.txtSubtotal.Location = new System.Drawing.Point(632, 40);
            this.txtSubtotal.Multiline = true;
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(401, 31);
            this.txtSubtotal.TabIndex = 17;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Pallet";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(531, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 37);
            this.label9.TabIndex = 15;
            this.label9.Text = "Customer\'s name";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TablaDeVenta
            // 
            this.TablaDeVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TablaDeVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablaDeVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaDeVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.tam,
            this.medida,
            this.descripcion,
            this.precio,
            this.cajasPorContenido,
            this.importe});
            this.TablaDeVenta.Location = new System.Drawing.Point(29, 280);
            this.TablaDeVenta.Name = "TablaDeVenta";
            this.TablaDeVenta.RowHeadersWidth = 45;
            this.TablaDeVenta.Size = new System.Drawing.Size(924, 291);
            this.TablaDeVenta.TabIndex = 49;
            // 
            // nombre
            // 
            this.nombre.FillWeight = 120F;
            this.nombre.HeaderText = "Product\'s name";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            // 
            // tam
            // 
            this.tam.FillWeight = 38.49408F;
            this.tam.HeaderText = "Size";
            this.tam.MinimumWidth = 6;
            this.tam.Name = "tam";
            // 
            // medida
            // 
            this.medida.FillWeight = 38.49408F;
            this.medida.HeaderText = "Grs/Size";
            this.medida.MinimumWidth = 6;
            this.medida.Name = "medida";
            // 
            // descripcion
            // 
            this.descripcion.FillWeight = 38.49408F;
            this.descripcion.HeaderText = "Description";
            this.descripcion.MinimumWidth = 6;
            this.descripcion.Name = "descripcion";
            // 
            // precio
            // 
            this.precio.FillWeight = 38.49408F;
            this.precio.HeaderText = "Price";
            this.precio.MinimumWidth = 6;
            this.precio.Name = "precio";
            // 
            // cajasPorContenido
            // 
            this.cajasPorContenido.FillWeight = 38.49408F;
            this.cajasPorContenido.HeaderText = "Boxes per content";
            this.cajasPorContenido.MinimumWidth = 6;
            this.cajasPorContenido.Name = "cajasPorContenido";
            // 
            // importe
            // 
            this.importe.FillWeight = 38.49408F;
            this.importe.HeaderText = "Amount";
            this.importe.MinimumWidth = 6;
            this.importe.Name = "importe";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(562, 193);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 24);
            this.label11.TabIndex = 55;
            this.label11.Text = "Currency";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divisa
            // 
            this.divisa.FormattingEnabled = true;
            this.divisa.Items.AddRange(new object[] {
            "Peso",
            "Euro",
            "Dolar"});
            this.divisa.Location = new System.Drawing.Point(657, 195);
            this.divisa.Name = "divisa";
            this.divisa.Size = new System.Drawing.Size(150, 21);
            this.divisa.TabIndex = 56;
            // 
            // agregar
            // 
            this.agregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.agregar.BackColor = System.Drawing.Color.Black;
            this.agregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.agregar.Location = new System.Drawing.Point(1000, 354);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(119, 48);
            this.agregar.TabIndex = 57;
            this.agregar.Text = "Add";
            this.agregar.UseVisualStyleBackColor = false;
            this.agregar.UseWaitCursor = true;
            // 
            // Delete
            // 
            this.Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Delete.BackColor = System.Drawing.Color.Black;
            this.Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Delete.Location = new System.Drawing.Point(1000, 431);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(119, 48);
            this.Delete.TabIndex = 58;
            this.Delete.Text = "Delate";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 59;
            this.label8.Text = "Place";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Condicion
            // 
            this.Condicion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Condicion.BackColor = System.Drawing.Color.White;
            this.Condicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.Condicion.Location = new System.Drawing.Point(126, 231);
            this.Condicion.Multiline = true;
            this.Condicion.Name = "Condicion";
            this.Condicion.Size = new System.Drawing.Size(411, 31);
            this.Condicion.TabIndex = 60;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(1000, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 48);
            this.button1.TabIndex = 61;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.UseWaitCursor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(1000, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 48);
            this.button2.TabIndex = 62;
            this.button2.Text = "Generate";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.UseWaitCursor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(25, 235);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 20);
            this.label12.TabIndex = 63;
            this.label12.Text = "Condicion";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Place
            // 
            this.Place.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Place.BackColor = System.Drawing.Color.White;
            this.Place.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.Place.Location = new System.Drawing.Point(127, 191);
            this.Place.Multiline = true;
            this.Place.Name = "Place";
            this.Place.Size = new System.Drawing.Size(170, 30);
            this.Place.TabIndex = 64;
            this.Place.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(571, 230);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 20);
            this.label13.TabIndex = 65;
            this.label13.Text = "Product";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // producto
            // 
            this.producto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.producto.BackColor = System.Drawing.Color.White;
            this.producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.producto.Location = new System.Drawing.Point(653, 230);
            this.producto.Multiline = true;
            this.producto.Name = "producto";
            this.producto.Size = new System.Drawing.Size(170, 29);
            this.producto.TabIndex = 66;
            this.producto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Cotizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1131, 585);
            this.Controls.Add(this.producto);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Place);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Condicion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.divisa);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TablaDeVenta);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Name = "Cotizaciones";
            this.Text = "Cotizaciones";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaDeVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Cotizaciones_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label txt1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox Customer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.TextBox txtFolio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView TablaDeVenta;
        private System.Windows.Forms.TextBox pallet;
        private System.Windows.Forms.TextBox ico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker Expiration;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox divisa;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn tam;
        private System.Windows.Forms.DataGridViewTextBoxColumn medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cajasPorContenido;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Condicion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox IdClient;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Place;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox producto;
    }
}