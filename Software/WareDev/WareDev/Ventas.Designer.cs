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
            this.TablaDeVenta = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cajasPorContenido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txt1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNoCliente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboMoneda = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btrRegreso = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnFactura = new System.Windows.Forms.Button();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.txtVentas = new System.Windows.Forms.Label();
            this.imgVentas = new System.Windows.Forms.PictureBox();
            this.contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaDeVenta)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // contenedor
            // 
            this.contenedor.BackColor = System.Drawing.Color.White;
            this.contenedor.Controls.Add(this.TablaDeVenta);
            this.contenedor.Controls.Add(this.tableLayoutPanel1);
            this.contenedor.Controls.Add(this.panel1);
            this.contenedor.Controls.Add(this.panelTitulo);
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 0);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1018, 476);
            this.contenedor.TabIndex = 0;
            // 
            // TablaDeVenta
            // 
            this.TablaDeVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TablaDeVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaDeVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.foto,
            this.tam,
            this.medida,
            this.descripcion,
            this.precio,
            this.cajasPorContenido,
            this.importe});
            this.TablaDeVenta.Location = new System.Drawing.Point(12, 332);
            this.TablaDeVenta.Name = "TablaDeVenta";
            this.TablaDeVenta.RowHeadersWidth = 45;
            this.TablaDeVenta.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TablaDeVenta.Size = new System.Drawing.Size(965, 132);
            this.TablaDeVenta.StandardTab = true;
            this.TablaDeVenta.TabIndex = 30;
            this.TablaDeVenta.TabStop = false;
            // 
            // nombre
            // 
            this.nombre.FillWeight = 120F;
            this.nombre.HeaderText = "Product\'s name";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.Width = 244;
            // 
            // foto
            // 
            this.foto.HeaderText = "Photo";
            this.foto.Name = "foto";
            this.foto.Width = 204;
            // 
            // tam
            // 
            this.tam.FillWeight = 38.49408F;
            this.tam.HeaderText = "Size";
            this.tam.MinimumWidth = 6;
            this.tam.Name = "tam";
            this.tam.Width = 78;
            // 
            // medida
            // 
            this.medida.FillWeight = 38.49408F;
            this.medida.HeaderText = "Measure";
            this.medida.MinimumWidth = 6;
            this.medida.Name = "medida";
            this.medida.Width = 79;
            // 
            // descripcion
            // 
            this.descripcion.FillWeight = 38.49408F;
            this.descripcion.HeaderText = "Description";
            this.descripcion.MinimumWidth = 6;
            this.descripcion.Name = "descripcion";
            this.descripcion.Width = 78;
            // 
            // precio
            // 
            this.precio.FillWeight = 38.49408F;
            this.precio.HeaderText = "Price";
            this.precio.MinimumWidth = 6;
            this.precio.Name = "precio";
            this.precio.Width = 78;
            // 
            // cajasPorContenido
            // 
            this.cajasPorContenido.FillWeight = 38.49408F;
            this.cajasPorContenido.HeaderText = "Boxes per content";
            this.cajasPorContenido.MinimumWidth = 6;
            this.cajasPorContenido.Name = "cajasPorContenido";
            this.cajasPorContenido.Width = 79;
            // 
            // importe
            // 
            this.importe.FillWeight = 38.49408F;
            this.importe.HeaderText = "Amount";
            this.importe.MinimumWidth = 6;
            this.importe.Name = "importe";
            this.importe.Width = 78;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.028456F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.739F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.58956F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.22723F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.38211F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.92276F));
            this.tableLayoutPanel1.Controls.Add(this.txt1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTotal, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtCliente, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNoCliente, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtFolio, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboMoneda, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtSubtotal, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtIva, 1, 2);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 166);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(977, 114);
            this.tableLayoutPanel1.TabIndex = 29;
            // 
            // txt1
            // 
            this.txt1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt1.AutoSize = true;
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.Location = new System.Drawing.Point(14, 1);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(50, 36);
            this.txt1.TabIndex = 7;
            this.txt1.Text = "Sales folio";
            this.txt1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.txtTotal.Location = new System.Drawing.Point(598, 79);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(151, 32);
            this.txtTotal.TabIndex = 21;
            this.txtTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotal_KeyPress);
            // 
            // txtCliente
            // 
            this.txtCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCliente.BackColor = System.Drawing.Color.White;
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.txtCliente.Location = new System.Drawing.Point(598, 3);
            this.txtCliente.Multiline = true;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(376, 32);
            this.txtCliente.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Date";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(236, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 36);
            this.label8.TabIndex = 14;
            this.label8.Text = "Customer\'s number";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNoCliente
            // 
            this.txtNoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNoCliente.BackColor = System.Drawing.Color.White;
            this.txtNoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.txtNoCliente.Location = new System.Drawing.Point(348, 3);
            this.txtNoCliente.Multiline = true;
            this.txtNoCliente.Name = "txtNoCliente";
            this.txtNoCliente.Size = new System.Drawing.Size(133, 32);
            this.txtNoCliente.TabIndex = 16;
            this.txtNoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFolio_KeyPress);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(492, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 36);
            this.label9.TabIndex = 15;
            this.label9.Text = "Customer\'s name";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(81, 41);
            this.dateTimePicker1.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(138, 26);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.Value = new System.DateTime(2020, 3, 31, 0, 0, 0, 0);
            // 
            // txtFolio
            // 
            this.txtFolio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFolio.BackColor = System.Drawing.Color.White;
            this.txtFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolio.Location = new System.Drawing.Point(81, 3);
            this.txtFolio.Multiline = true;
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(138, 32);
            this.txtFolio.TabIndex = 13;
            this.txtFolio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFolio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFolio_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(491, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Total";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(235, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Currency";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboMoneda
            // 
            this.comboMoneda.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMoneda.ForeColor = System.Drawing.Color.Black;
            this.comboMoneda.Items.AddRange(new object[] {
            "Peso",
            "Dolar",
            "Euro"});
            this.comboMoneda.Location = new System.Drawing.Point(348, 41);
            this.comboMoneda.Name = "comboMoneda";
            this.comboMoneda.Size = new System.Drawing.Size(133, 28);
            this.comboMoneda.TabIndex = 20;
            this.comboMoneda.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(487, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 24);
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
            this.txtSubtotal.Location = new System.Drawing.Point(598, 41);
            this.txtSubtotal.Multiline = true;
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(376, 32);
            this.txtSubtotal.TabIndex = 17;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSubtotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSubtotal_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "IVA (%)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIva
            // 
            this.txtIva.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIva.BackColor = System.Drawing.Color.White;
            this.txtIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.txtIva.Location = new System.Drawing.Point(81, 79);
            this.txtIva.Multiline = true;
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(138, 32);
            this.txtIva.TabIndex = 18;
            this.txtIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIva_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 76);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.69811F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(54, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "NEW SALE";
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
            this.btrRegreso.Location = new System.Drawing.Point(911, 7);
            this.btrRegreso.Name = "btrRegreso";
            this.btrRegreso.Size = new System.Drawing.Size(104, 74);
            this.btrRegreso.TabIndex = 12;
            this.btrRegreso.Text = "Return";
            this.btrRegreso.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btrRegreso.UseVisualStyleBackColor = false;
            this.btrRegreso.Click += new System.EventHandler(this.btrRegreso_Click);
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
            this.btnGuardar.Location = new System.Drawing.Point(784, 7);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(104, 74);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Save";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnFactura
            // 
            this.btnFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(176)))), ((int)(((byte)(106)))));
            this.btnFactura.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactura.ForeColor = System.Drawing.Color.Black;
            this.btnFactura.Image = ((System.Drawing.Image)(resources.GetObject("btnFactura.Image")));
            this.btnFactura.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFactura.Location = new System.Drawing.Point(648, 7);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(104, 74);
            this.btnFactura.TabIndex = 10;
            this.btnFactura.Text = "Generate invoice";
            this.btnFactura.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFactura.UseVisualStyleBackColor = false;
            this.btnFactura.Click += new System.EventHandler(this.btnFactura_Click);
            // 
            // panelTitulo
            // 
            this.panelTitulo.Controls.Add(this.txtVentas);
            this.panelTitulo.Controls.Add(this.btnFactura);
            this.panelTitulo.Controls.Add(this.btnGuardar);
            this.panelTitulo.Controls.Add(this.btrRegreso);
            this.panelTitulo.Controls.Add(this.imgVentas);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1018, 84);
            this.panelTitulo.TabIndex = 0;
            // 
            // txtVentas
            // 
            this.txtVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.69811F, System.Drawing.FontStyle.Bold);
            this.txtVentas.Location = new System.Drawing.Point(338, 21);
            this.txtVentas.Name = "txtVentas";
            this.txtVentas.Size = new System.Drawing.Size(287, 42);
            this.txtVentas.TabIndex = 2;
            this.txtVentas.Text = "Start   >>>   Sales";
            // 
            // imgVentas
            // 
            this.imgVentas.Image = ((System.Drawing.Image)(resources.GetObject("imgVentas.Image")));
            this.imgVentas.Location = new System.Drawing.Point(219, -6);
            this.imgVentas.Name = "imgVentas";
            this.imgVentas.Size = new System.Drawing.Size(96, 96);
            this.imgVentas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgVentas.TabIndex = 0;
            this.imgVentas.TabStop = false;
            // 
            // ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 476);
            this.Controls.Add(this.contenedor);
            this.Name = "ventas";
            this.Text = "ventas";
            this.Load += new System.EventHandler(this.ventas_Load);
            this.contenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TablaDeVenta)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtVentas;
        private System.Windows.Forms.PictureBox imgVentas;
        private System.Windows.Forms.Button btrRegreso;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txt1;
        private System.Windows.Forms.ComboBox comboMoneda;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtFolio;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtNoCliente;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView TablaDeVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn palletContenido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn foto;
        private System.Windows.Forms.DataGridViewTextBoxColumn tam;
        private System.Windows.Forms.DataGridViewTextBoxColumn medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cajasPorContenido;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe;
    }
}