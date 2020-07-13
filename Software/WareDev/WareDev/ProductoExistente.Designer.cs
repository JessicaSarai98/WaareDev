namespace WareDev
{
    partial class ProductoExistente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductoExistente));
            this.contenedor = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mat = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.SaveEdit = new System.Windows.Forms.Button();
            this.z = new System.Windows.Forms.TableLayoutPanel();
            this.txtFraccion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUniMedida = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.nombre = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtSAT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCanAduana = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUniMedAduana = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnFoto = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCantiAdquirida = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.top = new System.Windows.Forms.Panel();
            this.txtVentas = new System.Windows.Forms.Label();
            this.btrRegreso = new System.Windows.Forms.Button();
            this.FotoProduc = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.contenedor.SuspendLayout();
            this.panel1.SuspendLayout();
            this.z.SuspendLayout();
            this.top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoProduc)).BeginInit();
            this.SuspendLayout();
            // 
            // contenedor
            // 
            this.contenedor.Controls.Add(this.panel1);
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 0);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(847, 648);
            this.contenedor.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FotoProduc);
            this.panel1.Controls.Add(this.mat);
            this.panel1.Controls.Add(this.ID);
            this.panel1.Controls.Add(this.SaveEdit);
            this.panel1.Controls.Add(this.z);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.top);
            this.panel1.Controls.Add(this.btrRegreso);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 648);
            this.panel1.TabIndex = 1;
            // 
            // mat
            // 
            this.mat.Location = new System.Drawing.Point(368, 98);
            this.mat.Name = "mat";
            this.mat.Size = new System.Drawing.Size(100, 20);
            this.mat.TabIndex = 32;
            this.mat.Text = "Materia prima";
            this.mat.Visible = false;
            // 
            // ID
            // 
            this.ID.Enabled = false;
            this.ID.Location = new System.Drawing.Point(461, 124);
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Size = new System.Drawing.Size(100, 20);
            this.ID.TabIndex = 3;
            this.ID.Visible = false;
            // 
            // SaveEdit
            // 
            this.SaveEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(213)))), ((int)(((byte)(227)))));
            this.SaveEdit.Cursor = System.Windows.Forms.Cursors.Default;
            this.SaveEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveEdit.ForeColor = System.Drawing.Color.Black;
            this.SaveEdit.Image = ((System.Drawing.Image)(resources.GetObject("SaveEdit.Image")));
            this.SaveEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SaveEdit.Location = new System.Drawing.Point(621, 90);
            this.SaveEdit.Name = "SaveEdit";
            this.SaveEdit.Size = new System.Drawing.Size(104, 65);
            this.SaveEdit.TabIndex = 13;
            this.SaveEdit.Text = "Guardar";
            this.SaveEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SaveEdit.UseVisualStyleBackColor = false;
            this.SaveEdit.Click += new System.EventHandler(this.SaveEdit_Click);
            // 
            // z
            // 
            this.z.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.z.ColumnCount = 4;
            this.z.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.14447F));
            this.z.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.11159F));
            this.z.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.84557F));
            this.z.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.63899F));
            this.z.Controls.Add(this.textBox1, 3, 3);
            this.z.Controls.Add(this.textBox2, 3, 4);
            this.z.Controls.Add(this.label12, 2, 3);
            this.z.Controls.Add(this.label15, 2, 4);
            this.z.Controls.Add(this.txtFraccion, 1, 4);
            this.z.Controls.Add(this.label7, 0, 4);
            this.z.Controls.Add(this.txtUniMedida, 1, 3);
            this.z.Controls.Add(this.label10, 0, 3);
            this.z.Controls.Add(this.txtCodigo, 1, 0);
            this.z.Controls.Add(this.label5, 0, 0);
            this.z.Controls.Add(this.txtEstado, 1, 7);
            this.z.Controls.Add(this.label2, 0, 7);
            this.z.Controls.Add(this.dateTimePicker1, 1, 8);
            this.z.Controls.Add(this.nombre, 0, 1);
            this.z.Controls.Add(this.label4, 0, 8);
            this.z.Controls.Add(this.txtNombre, 1, 1);
            this.z.Controls.Add(this.txtSAT, 1, 2);
            this.z.Controls.Add(this.label8, 0, 2);
            this.z.Controls.Add(this.label3, 0, 5);
            this.z.Controls.Add(this.txtCanAduana, 1, 5);
            this.z.Controls.Add(this.label1, 0, 6);
            this.z.Controls.Add(this.txtUniMedAduana, 1, 6);
            this.z.Controls.Add(this.label13, 0, 9);
            this.z.Controls.Add(this.txtDescripcion, 1, 9);
            this.z.Controls.Add(this.label9, 2, 2);
            this.z.Controls.Add(this.txtIVA, 3, 2);
            this.z.Controls.Add(this.label11, 2, 1);
            this.z.Controls.Add(this.txtCantiAdquirida, 3, 1);
            this.z.Controls.Add(this.txtPrecio, 3, 0);
            this.z.Controls.Add(this.label6, 2, 0);
            this.z.Controls.Add(this.label14, 2, 5);
            this.z.Controls.Add(this.btnFoto, 3, 5);
            this.z.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.z.Location = new System.Drawing.Point(9, 178);
            this.z.Name = "z";
            this.z.RowCount = 10;
            this.z.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.z.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.z.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.z.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.z.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.z.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.z.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.z.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.z.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.z.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.z.Size = new System.Drawing.Size(725, 458);
            this.z.TabIndex = 0;
            // 
            // txtFraccion
            // 
            this.txtFraccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFraccion.BackColor = System.Drawing.Color.White;
            this.txtFraccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.txtFraccion.Location = new System.Drawing.Point(158, 189);
            this.txtFraccion.Name = "txtFraccion";
            this.txtFraccion.Size = new System.Drawing.Size(241, 26);
            this.txtFraccion.TabIndex = 33;
            this.txtFraccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 36);
            this.label7.TabIndex = 33;
            this.label7.Text = "Fracción arancelaria";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUniMedida
            // 
            this.txtUniMedida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUniMedida.AutoCompleteCustomSource.AddRange(new string[] {
            "-- Seleccione una medida --",
            "A76 - Galón",
            "A9 - Tarifa",
            "ACT - Actividad",
            "C62 - Uno",
            "CCT - Capacidad de carga en toneladas métricas",
            "CMK - Centimetro cuadrado",
            "E48 - Unidad de servicio",
            "E53 - Prueba",
            "EA - Elemento",
            "FOT - Pie ",
            "FTK - Pie cuadrado",
            "GRM - Gramo",
            "H87 - Pieza",
            "HAR - Hectarea",
            "HEA - Cabeza",
            "HL - Cien pies (lineal)",
            "INH - Pulgada",
            "KGM - Kilogramo",
            "LBR - Libra",
            "LC - Centímetro lineal",
            "LM - Metro lineal",
            "LTR - Litro",
            "MIL - Millares",
            "MTK - Metro cuadrado",
            "MTQ - Metro cúbico",
            "MTR - Metro",
            "NMP - Número de paquetes",
            "PR - Par",
            "SMI - Milla",
            "TNE - Tonelada métrica",
            " TT - Mil metros lineales",
            "WSD - Estándar",
            "X4G - Caja de carton",
            "X4H - Caja de plástico",
            "XBJ - Cubeta",
            "XBX - Caja",
            "XCX - Lata cilíndrica",
            "XKI - Kit",
            "XLT - Lote",
            "XNA - No disponible",
            "XOK - Bloque",
            "XRO - Rollo",
            "XSA - Saco",
            "YRD - Yarda",
            "ZZ - Mutuamente definido"});
            this.txtUniMedida.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtUniMedida.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtUniMedida.FormattingEnabled = true;
            this.txtUniMedida.Items.AddRange(new object[] {
            "-- Seleccione una medida --",
            "A76 - Galón",
            "A9 - Tarifa",
            "ACT - Actividad",
            "C62 - Uno",
            "CCT - Capacidad de carga en toneladas métricas",
            "CMK - Centimetro cuadrado",
            "E48 - Unidad de servicio",
            "E53 - Prueba",
            "EA - Elemento",
            "FOT - Pie ",
            "FTK - Pie cuadrado",
            "GRM - Gramo",
            "H87 - Pieza",
            "HAR - Hectarea",
            "HEA - Cabeza",
            "HL - Cien pies (lineal)",
            "INH - Pulgada",
            "KGM - Kilogramo",
            "LBR - Libra",
            "LC - Centímetro lineal",
            "LM - Metro lineal",
            "LTR - Litro",
            "MIL - Millares",
            "MTK - Metro cuadrado",
            "MTQ - Metro cúbico",
            "MTR - Metro",
            "NMP - Número de paquetes",
            "PR - Par",
            "SMI - Milla",
            "TNE - Tonelada métrica",
            " TT - Mil metros lineales",
            "WSD - Estándar",
            "X4G - Caja de carton",
            "X4H - Caja de plástico",
            "XBJ - Cubeta",
            "XBX - Caja",
            "XCX - Lata cilíndrica",
            "XKI - Kit",
            "XLT - Lote",
            "XNA - No disponible",
            "XOK - Bloque",
            "XRO - Rollo",
            "XSA - Saco",
            "YRD - Yarda",
            "ZZ - Mutuamente definido"});
            this.txtUniMedida.Location = new System.Drawing.Point(158, 143);
            this.txtUniMedida.Name = "txtUniMedida";
            this.txtUniMedida.Size = new System.Drawing.Size(241, 28);
            this.txtUniMedida.TabIndex = 9;
            this.txtUniMedida.Text = "-- Seleccione una medida --";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "Unidad de Medida";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCodigo.BackColor = System.Drawing.Color.White;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.txtCodigo.Location = new System.Drawing.Point(158, 9);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(139, 26);
            this.txtCodigo.TabIndex = 33;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 33;
            this.label5.Text = "Código";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEstado
            // 
            this.txtEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtEstado.FormattingEnabled = true;
            this.txtEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.txtEstado.Location = new System.Drawing.Point(158, 323);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(241, 28);
            this.txtEstado.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Estado";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(158, 369);
            this.dateTimePicker1.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(241, 26);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.Value = new System.DateTime(2020, 5, 13, 0, 0, 0, 0);
            // 
            // nombre
            // 
            this.nombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nombre.AutoSize = true;
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(43, 58);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(68, 18);
            this.nombre.TabIndex = 0;
            this.nombre.Text = "Nombre";
            this.nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fecha";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(158, 54);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(241, 26);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSAT
            // 
            this.txtSAT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSAT.BackColor = System.Drawing.Color.White;
            this.txtSAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.txtSAT.Location = new System.Drawing.Point(158, 99);
            this.txtSAT.Name = "txtSAT";
            this.txtSAT.Size = new System.Drawing.Size(241, 26);
            this.txtSAT.TabIndex = 8;
            this.txtSAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSAT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSAT_KeyPress);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Clave de SAT ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cantidad de Aduana";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCanAduana
            // 
            this.txtCanAduana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCanAduana.BackColor = System.Drawing.Color.White;
            this.txtCanAduana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.txtCanAduana.Location = new System.Drawing.Point(158, 234);
            this.txtCanAduana.Name = "txtCanAduana";
            this.txtCanAduana.Size = new System.Drawing.Size(241, 26);
            this.txtCanAduana.TabIndex = 3;
            this.txtCanAduana.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unidad de Medida de Aduana";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUniMedAduana
            // 
            this.txtUniMedAduana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUniMedAduana.AutoCompleteCustomSource.AddRange(new string[] {
            "-- Seleccione una opción --",
            "01 - Kilo",
            "02 - Gramo",
            "03 - Metro lineal",
            "04 - Metro cuadrado",
            "05 - Metro cubico",
            "06 - Pieza",
            "07 - Cabeza",
            "08 - Litro",
            "09 - Par",
            "10 - Kilowatt",
            "11 - Millar",
            "12 - Juego",
            "13 - Kilowatt/Hora",
            "14 - Tonelada",
            "15 - Barril",
            "16 - Gramo neto",
            "17 - Decena",
            "18 - Cientos",
            "19 - Docena",
            "20 - Caja",
            "21 - Botella",
            "22 - Servicios"});
            this.txtUniMedAduana.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtUniMedAduana.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtUniMedAduana.FormattingEnabled = true;
            this.txtUniMedAduana.Items.AddRange(new object[] {
            "-- Seleccione una opción --",
            "01 - Kilo",
            "02 - Gramo",
            "03 - Metro lineal",
            "04 - Metro cuadrado",
            "05 - Metro cubico",
            "06 - Pieza",
            "07 - Cabeza",
            "08 - Litro",
            "09 - Par",
            "10 - Kilowatt",
            "11 - Millar",
            "12 - Juego",
            "13 - Kilowatt/Hora",
            "14 - Tonelada",
            "15 - Barril",
            "16 - Gramo neto",
            "17 - Decena",
            "18 - Cientos",
            "19 - Docena",
            "20 - Caja",
            "21 - Botella",
            "22 - Servicios"});
            this.txtUniMedAduana.Location = new System.Drawing.Point(158, 278);
            this.txtUniMedAduana.Name = "txtUniMedAduana";
            this.txtUniMedAduana.Size = new System.Drawing.Size(241, 28);
            this.txtUniMedAduana.TabIndex = 7;
            this.txtUniMedAduana.Text = "-- Seleccione una opción --";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(28, 422);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 18);
            this.label13.TabIndex = 0;
            this.label13.Text = "Descripción";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.txtDescripcion.Location = new System.Drawing.Point(158, 418);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(241, 26);
            this.txtDescripcion.TabIndex = 11;
            this.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(456, 238);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 18);
            this.label14.TabIndex = 43;
            this.label14.Text = "Foto";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFoto
            // 
            this.btnFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFoto.BackColor = System.Drawing.Color.Silver;
            this.btnFoto.FlatAppearance.BorderSize = 0;
            this.btnFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnFoto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFoto.Location = new System.Drawing.Point(557, 228);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnFoto.Size = new System.Drawing.Size(165, 39);
            this.btnFoto.TabIndex = 12;
            this.btnFoto.Text = "Agregar imagen";
            this.btnFoto.UseVisualStyleBackColor = false;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(462, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 18);
            this.label9.TabIndex = 33;
            this.label9.Text = "IVA";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIVA
            // 
            this.txtIVA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIVA.BackColor = System.Drawing.Color.White;
            this.txtIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.txtIVA.Location = new System.Drawing.Point(557, 99);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(165, 26);
            this.txtIVA.TabIndex = 33;
            this.txtIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIVA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIVA_KeyPress);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(435, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 36);
            this.label11.TabIndex = 0;
            this.label11.Text = "Cantidad Comprada";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCantiAdquirida
            // 
            this.txtCantiAdquirida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCantiAdquirida.BackColor = System.Drawing.Color.White;
            this.txtCantiAdquirida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.txtCantiAdquirida.Location = new System.Drawing.Point(557, 54);
            this.txtCantiAdquirida.Name = "txtCantiAdquirida";
            this.txtCantiAdquirida.Size = new System.Drawing.Size(165, 26);
            this.txtCantiAdquirida.TabIndex = 10;
            this.txtCantiAdquirida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCantiAdquirida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantiAdquirida_KeyPress);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecio.BackColor = System.Drawing.Color.White;
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.txtPrecio.Location = new System.Drawing.Point(557, 9);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(165, 26);
            this.txtPrecio.TabIndex = 6;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(419, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Precio unitario";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnGuardar.Location = new System.Drawing.Point(621, 90);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(104, 65);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // top
            // 
            this.top.Controls.Add(this.txtVentas);
            this.top.Dock = System.Windows.Forms.DockStyle.Top;
            this.top.Location = new System.Drawing.Point(0, 0);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(847, 84);
            this.top.TabIndex = 0;
            this.top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.top_MouseMove);
            // 
            // txtVentas
            // 
            this.txtVentas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.69811F, System.Drawing.FontStyle.Bold);
            this.txtVentas.Location = new System.Drawing.Point(307, 22);
            this.txtVentas.Name = "txtVentas";
            this.txtVentas.Size = new System.Drawing.Size(342, 42);
            this.txtVentas.TabIndex = 0;
            this.txtVentas.Text = "Producto final";
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
            this.btrRegreso.Location = new System.Drawing.Point(731, 90);
            this.btrRegreso.Name = "btrRegreso";
            this.btrRegreso.Size = new System.Drawing.Size(104, 65);
            this.btrRegreso.TabIndex = 14;
            this.btrRegreso.Text = "Regresar";
            this.btrRegreso.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btrRegreso.UseVisualStyleBackColor = false;
            this.btrRegreso.Click += new System.EventHandler(this.btrRegreso_Click);
            // 
            // FotoProduc
            // 
            this.FotoProduc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FotoProduc.BackColor = System.Drawing.Color.Silver;
            this.FotoProduc.Location = new System.Drawing.Point(498, 467);
            this.FotoProduc.Name = "FotoProduc";
            this.FotoProduc.Size = new System.Drawing.Size(309, 177);
            this.FotoProduc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FotoProduc.TabIndex = 33;
            this.FotoProduc.TabStop = false;
            this.FotoProduc.Visible = false;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(443, 148);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 18);
            this.label12.TabIndex = 34;
            this.label12.Text = "Tamaño";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(447, 193);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 18);
            this.label15.TabIndex = 35;
            this.label15.Text = "Medida";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.textBox1.Location = new System.Drawing.Point(557, 144);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 26);
            this.textBox1.TabIndex = 34;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.textBox2.Location = new System.Drawing.Point(557, 189);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(165, 26);
            this.textBox2.TabIndex = 35;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ProductoExistente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 648);
            this.Controls.Add(this.contenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductoExistente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Producto final";
            this.Load += new System.EventHandler(this.ProductoExistente_Load);
            this.contenedor.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.z.ResumeLayout(false);
            this.z.PerformLayout();
            this.top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FotoProduc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox mat;
        public System.Windows.Forms.TextBox ID;
        public System.Windows.Forms.Button SaveEdit;
        private System.Windows.Forms.TableLayoutPanel z;
        public System.Windows.Forms.ComboBox txtUniMedida;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nombre;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtCanAduana;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtCantiAdquirida;
        public System.Windows.Forms.ComboBox txtUniMedAduana;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox txtEstado;
        public System.Windows.Forms.TextBox txtSAT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel top;
        private System.Windows.Forms.Label txtVentas;
        private System.Windows.Forms.Button btrRegreso;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtFraccion;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtIVA;
        public System.Windows.Forms.PictureBox FotoProduc;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
    }
}