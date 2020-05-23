namespace WareDev
{
    partial class inventarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inventarios));
            this.contenedor = new System.Windows.Forms.Panel();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.TablaMatPrima = new System.Windows.Forms.DataGridView();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claveSAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUnidadB = new System.Windows.Forms.TextBox();
            this.txtNombreB = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAgregarIns = new System.Windows.Forms.Button();
            this.btnAgreInsum = new System.Windows.Forms.Button();
            this.btnBorrarInsu = new System.Windows.Forms.Button();
            this.btnEditInsu = new System.Windows.Forms.Button();
            this.tablaInsumo = new System.Windows.Forms.DataGridView();
            this.IDInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreInsu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadMedidaInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadDispoInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameInsumo = new System.Windows.Forms.TextBox();
            this.btnBuscarInsumo = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnAddProductos = new System.Windows.Forms.Button();
            this.btnAddCantiProducto = new System.Windows.Forms.Button();
            this.btnElimProdTerm = new System.Windows.Forms.Button();
            this.btnEditProdTer = new System.Windows.Forms.Button();
            this.TablaProducTermi = new System.Windows.Forms.DataGridView();
            this.IDProdTerm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameProduTer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadProdTermi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioProdTermi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantDisponibleProduTermi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBusProdTermi = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomProdTerm = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.btnInsumos = new System.Windows.Forms.RadioButton();
            this.txtVentas = new System.Windows.Forms.Label();
            this.imgVentas = new System.Windows.Forms.PictureBox();
            this.btnPTerminado = new System.Windows.Forms.RadioButton();
            this.btnMPrima = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contenedor.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.TabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaMatPrima)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaInsumo)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaProducTermi)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // contenedor
            // 
            this.contenedor.BackColor = System.Drawing.Color.Khaki;
            this.contenedor.Controls.Add(this.TabControl);
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 0);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1018, 476);
            this.contenedor.TabIndex = 0;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TabPage1);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Controls.Add(this.tabPage3);
            this.TabControl.Controls.Add(this.tabPage4);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1018, 476);
            this.TabControl.TabIndex = 3;
            // 
            // TabPage1
            // 
            this.TabPage1.AutoScroll = true;
            this.TabPage1.BackColor = System.Drawing.Color.Khaki;
            this.TabPage1.Controls.Add(this.dataGridView1);
            this.TabPage1.Controls.Add(this.btnAgregarProducto);
            this.TabPage1.Controls.Add(this.BtnAgregar);
            this.TabPage1.Controls.Add(this.BtnEliminar);
            this.TabPage1.Controls.Add(this.btnEditar);
            this.TabPage1.Controls.Add(this.TablaMatPrima);
            this.TabPage1.Controls.Add(this.btnBuscar);
            this.TabPage1.Controls.Add(this.tableLayoutPanel1);
            this.TabPage1.Location = new System.Drawing.Point(4, 29);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(1010, 443);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Raw material";
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarProducto.BackColor = System.Drawing.Color.Silver;
            this.btnAgregarProducto.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarProducto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarProducto.Location = new System.Drawing.Point(876, 98);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(104, 60);
            this.btnAgregarProducto.TabIndex = 36;
            this.btnAgregarProducto.Text = "Add raw material";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.BtnPDF_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.AccessibleName = "";
            this.BtnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAgregar.BackColor = System.Drawing.SystemColors.Desktop;
            this.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.BtnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.Silver;
            this.BtnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregar.Location = new System.Drawing.Point(876, 391);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(104, 41);
            this.BtnAgregar.TabIndex = 35;
            this.BtnAgregar.Text = "Add";
            this.BtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.AccessibleName = "";
            this.BtnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEliminar.BackColor = System.Drawing.SystemColors.Desktop;
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.BtnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.Silver;
            this.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminar.Location = new System.Drawing.Point(876, 295);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(104, 41);
            this.BtnEliminar.TabIndex = 34;
            this.BtnEliminar.Text = "Delete";
            this.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.AccessibleName = "";
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Silver;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(876, 202);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(104, 41);
            this.btnEditar.TabIndex = 33;
            this.btnEditar.Text = "Edit";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // TablaMatPrima
            // 
            this.TablaMatPrima.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TablaMatPrima.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablaMatPrima.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.TablaMatPrima.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.TablaMatPrima.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaMatPrima.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaMatPrima.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.nombre,
            this.claveSAT,
            this.UnidadMedida,
            this.precio,
            this.importe});
            this.TablaMatPrima.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.TablaMatPrima.Location = new System.Drawing.Point(8, 143);
            this.TablaMatPrima.Name = "TablaMatPrima";
            this.TablaMatPrima.RowHeadersWidth = 45;
            this.TablaMatPrima.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TablaMatPrima.Size = new System.Drawing.Size(798, 292);
            this.TablaMatPrima.StandardTab = true;
            this.TablaMatPrima.TabIndex = 32;
            this.TablaMatPrima.TabStop = false;
            this.TablaMatPrima.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaMatPrima_CellContentClick);
            // 
            // numero
            // 
            this.numero.FillWeight = 38.49408F;
            this.numero.HeaderText = "ID";
            this.numero.MinimumWidth = 6;
            this.numero.Name = "numero";
            // 
            // nombre
            // 
            this.nombre.FillWeight = 38.49408F;
            this.nombre.HeaderText = "Name";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            // 
            // claveSAT
            // 
            this.claveSAT.FillWeight = 38.49408F;
            this.claveSAT.HeaderText = "SAT key";
            this.claveSAT.MinimumWidth = 6;
            this.claveSAT.Name = "claveSAT";
            // 
            // UnidadMedida
            // 
            this.UnidadMedida.FillWeight = 38.49408F;
            this.UnidadMedida.HeaderText = "Unit of measure";
            this.UnidadMedida.MinimumWidth = 6;
            this.UnidadMedida.Name = "UnidadMedida";
            // 
            // precio
            // 
            this.precio.FillWeight = 38.49408F;
            this.precio.HeaderText = "Price";
            this.precio.MinimumWidth = 6;
            this.precio.Name = "precio";
            // 
            // importe
            // 
            this.importe.FillWeight = 38.49408F;
            this.importe.HeaderText = "Available quantity";
            this.importe.MinimumWidth = 6;
            this.importe.Name = "importe";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(210)))), ((int)(((byte)(43)))));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(752, 63);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(79, 47);
            this.btnBuscar.TabIndex = 31;
            this.btnBuscar.Text = "Find";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtUnidadB, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNombreB, 1, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 71);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(722, 39);
            this.tableLayoutPanel1.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(374, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 35);
            this.label1.TabIndex = 22;
            this.label1.Text = "Unit of measure";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUnidadB
            // 
            this.txtUnidadB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtUnidadB.BackColor = System.Drawing.Color.White;
            this.txtUnidadB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.txtUnidadB.Location = new System.Drawing.Point(543, 3);
            this.txtUnidadB.Multiline = true;
            this.txtUnidadB.Name = "txtUnidadB";
            this.txtUnidadB.Size = new System.Drawing.Size(174, 33);
            this.txtUnidadB.TabIndex = 23;
            // 
            // txtNombreB
            // 
            this.txtNombreB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNombreB.BackColor = System.Drawing.Color.White;
            this.txtNombreB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.txtNombreB.Location = new System.Drawing.Point(183, 3);
            this.txtNombreB.Multiline = true;
            this.txtNombreB.Name = "txtNombreB";
            this.txtNombreB.Size = new System.Drawing.Size(174, 33);
            this.txtNombreB.TabIndex = 21;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Khaki;
            this.tabPage2.Controls.Add(this.btnAgregarIns);
            this.tabPage2.Controls.Add(this.btnAgreInsum);
            this.tabPage2.Controls.Add(this.btnBorrarInsu);
            this.tabPage2.Controls.Add(this.btnEditInsu);
            this.tabPage2.Controls.Add(this.tablaInsumo);
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Controls.Add(this.btnBuscarInsumo);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1010, 443);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Supplies";
            // 
            // btnAgregarIns
            // 
            this.btnAgregarIns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarIns.BackColor = System.Drawing.Color.Silver;
            this.btnAgregarIns.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAgregarIns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarIns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarIns.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarIns.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarIns.Location = new System.Drawing.Point(881, 100);
            this.btnAgregarIns.Name = "btnAgregarIns";
            this.btnAgregarIns.Size = new System.Drawing.Size(104, 60);
            this.btnAgregarIns.TabIndex = 43;
            this.btnAgregarIns.Text = "Add inputs";
            this.btnAgregarIns.UseVisualStyleBackColor = false;
            this.btnAgregarIns.Click += new System.EventHandler(this.btnAgregarIns_Click);
            // 
            // btnAgreInsum
            // 
            this.btnAgreInsum.AccessibleName = "";
            this.btnAgreInsum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgreInsum.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnAgreInsum.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAgreInsum.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAgreInsum.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnAgreInsum.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnAgreInsum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgreInsum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgreInsum.ForeColor = System.Drawing.Color.Silver;
            this.btnAgreInsum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgreInsum.Location = new System.Drawing.Point(881, 393);
            this.btnAgreInsum.Name = "btnAgreInsum";
            this.btnAgreInsum.Size = new System.Drawing.Size(104, 41);
            this.btnAgreInsum.TabIndex = 42;
            this.btnAgreInsum.Text = "Add";
            this.btnAgreInsum.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgreInsum.UseVisualStyleBackColor = false;
            this.btnAgreInsum.Click += new System.EventHandler(this.btnAgreInsum_Click);
            // 
            // btnBorrarInsu
            // 
            this.btnBorrarInsu.AccessibleName = "";
            this.btnBorrarInsu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrarInsu.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnBorrarInsu.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBorrarInsu.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnBorrarInsu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnBorrarInsu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnBorrarInsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarInsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarInsu.ForeColor = System.Drawing.Color.Silver;
            this.btnBorrarInsu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrarInsu.Location = new System.Drawing.Point(881, 297);
            this.btnBorrarInsu.Name = "btnBorrarInsu";
            this.btnBorrarInsu.Size = new System.Drawing.Size(104, 41);
            this.btnBorrarInsu.TabIndex = 41;
            this.btnBorrarInsu.Text = "Delete";
            this.btnBorrarInsu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBorrarInsu.UseVisualStyleBackColor = false;
            // 
            // btnEditInsu
            // 
            this.btnEditInsu.AccessibleName = "";
            this.btnEditInsu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditInsu.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnEditInsu.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEditInsu.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnEditInsu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnEditInsu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnEditInsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditInsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditInsu.ForeColor = System.Drawing.Color.Silver;
            this.btnEditInsu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditInsu.Location = new System.Drawing.Point(881, 204);
            this.btnEditInsu.Name = "btnEditInsu";
            this.btnEditInsu.Size = new System.Drawing.Size(104, 41);
            this.btnEditInsu.TabIndex = 40;
            this.btnEditInsu.Text = "Edit";
            this.btnEditInsu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditInsu.UseVisualStyleBackColor = false;
            // 
            // tablaInsumo
            // 
            this.tablaInsumo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaInsumo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaInsumo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.tablaInsumo.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.tablaInsumo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaInsumo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaInsumo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDInsumo,
            this.NombreInsu,
            this.UnidadMedidaInsumo,
            this.PrecioInsumo,
            this.CantidadDispoInsumo});
            this.tablaInsumo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tablaInsumo.Location = new System.Drawing.Point(19, 143);
            this.tablaInsumo.Name = "tablaInsumo";
            this.tablaInsumo.RowHeadersWidth = 45;
            this.tablaInsumo.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tablaInsumo.Size = new System.Drawing.Size(798, 292);
            this.tablaInsumo.StandardTab = true;
            this.tablaInsumo.TabIndex = 39;
            this.tablaInsumo.TabStop = false;
            // 
            // IDInsumo
            // 
            this.IDInsumo.FillWeight = 38.49408F;
            this.IDInsumo.HeaderText = "ID";
            this.IDInsumo.MinimumWidth = 6;
            this.IDInsumo.Name = "IDInsumo";
            // 
            // NombreInsu
            // 
            this.NombreInsu.FillWeight = 38.49408F;
            this.NombreInsu.HeaderText = "Name";
            this.NombreInsu.MinimumWidth = 6;
            this.NombreInsu.Name = "NombreInsu";
            // 
            // UnidadMedidaInsumo
            // 
            this.UnidadMedidaInsumo.FillWeight = 38.49408F;
            this.UnidadMedidaInsumo.HeaderText = "Unit of measure";
            this.UnidadMedidaInsumo.MinimumWidth = 6;
            this.UnidadMedidaInsumo.Name = "UnidadMedidaInsumo";
            // 
            // PrecioInsumo
            // 
            this.PrecioInsumo.FillWeight = 38.49408F;
            this.PrecioInsumo.HeaderText = "Price";
            this.PrecioInsumo.MinimumWidth = 6;
            this.PrecioInsumo.Name = "PrecioInsumo";
            // 
            // CantidadDispoInsumo
            // 
            this.CantidadDispoInsumo.FillWeight = 38.49408F;
            this.CantidadDispoInsumo.HeaderText = "Available quantity";
            this.CantidadDispoInsumo.MinimumWidth = 6;
            this.CantidadDispoInsumo.Name = "CantidadDispoInsumo";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtNameInsumo, 1, 0);
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(20, 82);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(422, 39);
            this.tableLayoutPanel2.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNameInsumo
            // 
            this.txtNameInsumo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameInsumo.BackColor = System.Drawing.Color.White;
            this.txtNameInsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.txtNameInsumo.Location = new System.Drawing.Point(214, 3);
            this.txtNameInsumo.Multiline = true;
            this.txtNameInsumo.Name = "txtNameInsumo";
            this.txtNameInsumo.Size = new System.Drawing.Size(205, 33);
            this.txtNameInsumo.TabIndex = 21;
            // 
            // btnBuscarInsumo
            // 
            this.btnBuscarInsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(210)))), ((int)(((byte)(43)))));
            this.btnBuscarInsumo.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBuscarInsumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarInsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarInsumo.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarInsumo.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarInsumo.Image")));
            this.btnBuscarInsumo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarInsumo.Location = new System.Drawing.Point(522, 78);
            this.btnBuscarInsumo.Name = "btnBuscarInsumo";
            this.btnBuscarInsumo.Size = new System.Drawing.Size(79, 47);
            this.btnBuscarInsumo.TabIndex = 38;
            this.btnBuscarInsumo.Text = "Find";
            this.btnBuscarInsumo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarInsumo.UseVisualStyleBackColor = false;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Khaki;
            this.tabPage3.Controls.Add(this.btnAddProductos);
            this.tabPage3.Controls.Add(this.btnAddCantiProducto);
            this.tabPage3.Controls.Add(this.btnElimProdTerm);
            this.tabPage3.Controls.Add(this.btnEditProdTer);
            this.tabPage3.Controls.Add(this.TablaProducTermi);
            this.tabPage3.Controls.Add(this.btnBusProdTermi);
            this.tabPage3.Controls.Add(this.tableLayoutPanel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1010, 443);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Finished products";
            // 
            // btnAddProductos
            // 
            this.btnAddProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddProductos.BackColor = System.Drawing.Color.Silver;
            this.btnAddProductos.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAddProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProductos.ForeColor = System.Drawing.Color.Black;
            this.btnAddProductos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddProductos.Location = new System.Drawing.Point(895, 100);
            this.btnAddProductos.Name = "btnAddProductos";
            this.btnAddProductos.Size = new System.Drawing.Size(104, 60);
            this.btnAddProductos.TabIndex = 50;
            this.btnAddProductos.Text = "Add finished Products";
            this.btnAddProductos.UseVisualStyleBackColor = false;
            this.btnAddProductos.Click += new System.EventHandler(this.btnAddProductos_Click);
            // 
            // btnAddCantiProducto
            // 
            this.btnAddCantiProducto.AccessibleName = "";
            this.btnAddCantiProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCantiProducto.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnAddCantiProducto.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAddCantiProducto.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAddCantiProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnAddCantiProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnAddCantiProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCantiProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCantiProducto.ForeColor = System.Drawing.Color.Silver;
            this.btnAddCantiProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCantiProducto.Location = new System.Drawing.Point(895, 393);
            this.btnAddCantiProducto.Name = "btnAddCantiProducto";
            this.btnAddCantiProducto.Size = new System.Drawing.Size(104, 41);
            this.btnAddCantiProducto.TabIndex = 49;
            this.btnAddCantiProducto.Text = "Add";
            this.btnAddCantiProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddCantiProducto.UseVisualStyleBackColor = false;
            this.btnAddCantiProducto.Click += new System.EventHandler(this.btnAddCantiProducto_Click);
            // 
            // btnElimProdTerm
            // 
            this.btnElimProdTerm.AccessibleName = "";
            this.btnElimProdTerm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnElimProdTerm.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnElimProdTerm.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnElimProdTerm.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnElimProdTerm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnElimProdTerm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnElimProdTerm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElimProdTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimProdTerm.ForeColor = System.Drawing.Color.Silver;
            this.btnElimProdTerm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnElimProdTerm.Location = new System.Drawing.Point(895, 297);
            this.btnElimProdTerm.Name = "btnElimProdTerm";
            this.btnElimProdTerm.Size = new System.Drawing.Size(104, 41);
            this.btnElimProdTerm.TabIndex = 48;
            this.btnElimProdTerm.Text = "Delete";
            this.btnElimProdTerm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnElimProdTerm.UseVisualStyleBackColor = false;
            // 
            // btnEditProdTer
            // 
            this.btnEditProdTer.AccessibleName = "";
            this.btnEditProdTer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditProdTer.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnEditProdTer.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEditProdTer.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnEditProdTer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnEditProdTer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnEditProdTer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProdTer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProdTer.ForeColor = System.Drawing.Color.Silver;
            this.btnEditProdTer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditProdTer.Location = new System.Drawing.Point(895, 204);
            this.btnEditProdTer.Name = "btnEditProdTer";
            this.btnEditProdTer.Size = new System.Drawing.Size(104, 41);
            this.btnEditProdTer.TabIndex = 47;
            this.btnEditProdTer.Text = "Edit";
            this.btnEditProdTer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditProdTer.UseVisualStyleBackColor = false;
            // 
            // TablaProducTermi
            // 
            this.TablaProducTermi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TablaProducTermi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablaProducTermi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.TablaProducTermi.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.TablaProducTermi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaProducTermi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaProducTermi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDProdTerm,
            this.nameProduTer,
            this.UnidadProdTermi,
            this.precioProdTermi,
            this.CantDisponibleProduTermi});
            this.TablaProducTermi.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.TablaProducTermi.Location = new System.Drawing.Point(33, 143);
            this.TablaProducTermi.Name = "TablaProducTermi";
            this.TablaProducTermi.RowHeadersWidth = 45;
            this.TablaProducTermi.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TablaProducTermi.Size = new System.Drawing.Size(798, 292);
            this.TablaProducTermi.StandardTab = true;
            this.TablaProducTermi.TabIndex = 46;
            this.TablaProducTermi.TabStop = false;
            // 
            // IDProdTerm
            // 
            this.IDProdTerm.FillWeight = 38.49408F;
            this.IDProdTerm.HeaderText = "ID";
            this.IDProdTerm.MinimumWidth = 6;
            this.IDProdTerm.Name = "IDProdTerm";
            // 
            // nameProduTer
            // 
            this.nameProduTer.FillWeight = 38.49408F;
            this.nameProduTer.HeaderText = "Name";
            this.nameProduTer.MinimumWidth = 6;
            this.nameProduTer.Name = "nameProduTer";
            // 
            // UnidadProdTermi
            // 
            this.UnidadProdTermi.FillWeight = 38.49408F;
            this.UnidadProdTermi.HeaderText = "Unit of measure";
            this.UnidadProdTermi.MinimumWidth = 6;
            this.UnidadProdTermi.Name = "UnidadProdTermi";
            // 
            // precioProdTermi
            // 
            this.precioProdTermi.FillWeight = 38.49408F;
            this.precioProdTermi.HeaderText = "Price";
            this.precioProdTermi.MinimumWidth = 6;
            this.precioProdTermi.Name = "precioProdTermi";
            // 
            // CantDisponibleProduTermi
            // 
            this.CantDisponibleProduTermi.FillWeight = 38.49408F;
            this.CantDisponibleProduTermi.HeaderText = "Available quantity";
            this.CantDisponibleProduTermi.MinimumWidth = 6;
            this.CantDisponibleProduTermi.Name = "CantDisponibleProduTermi";
            // 
            // btnBusProdTermi
            // 
            this.btnBusProdTermi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(210)))), ((int)(((byte)(43)))));
            this.btnBusProdTermi.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBusProdTermi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusProdTermi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusProdTermi.ForeColor = System.Drawing.Color.Black;
            this.btnBusProdTermi.Image = ((System.Drawing.Image)(resources.GetObject("btnBusProdTermi.Image")));
            this.btnBusProdTermi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBusProdTermi.Location = new System.Drawing.Point(536, 78);
            this.btnBusProdTermi.Name = "btnBusProdTermi";
            this.btnBusProdTermi.Size = new System.Drawing.Size(79, 47);
            this.btnBusProdTermi.TabIndex = 45;
            this.btnBusProdTermi.Text = "Find";
            this.btnBusProdTermi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBusProdTermi.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtNomProdTerm, 1, 0);
            this.tableLayoutPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(34, 82);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(422, 39);
            this.tableLayoutPanel3.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNomProdTerm
            // 
            this.txtNomProdTerm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomProdTerm.BackColor = System.Drawing.Color.White;
            this.txtNomProdTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.txtNomProdTerm.Location = new System.Drawing.Point(214, 3);
            this.txtNomProdTerm.Multiline = true;
            this.txtNomProdTerm.Name = "txtNomProdTerm";
            this.txtNomProdTerm.Size = new System.Drawing.Size(205, 33);
            this.txtNomProdTerm.TabIndex = 21;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Khaki;
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1010, 443);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.Khaki;
            this.panelTitulo.Controls.Add(this.btnInsumos);
            this.panelTitulo.Controls.Add(this.txtVentas);
            this.panelTitulo.Controls.Add(this.imgVentas);
            this.panelTitulo.Controls.Add(this.btnPTerminado);
            this.panelTitulo.Controls.Add(this.btnMPrima);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1018, 84);
            this.panelTitulo.TabIndex = 3;
            // 
            // btnInsumos
            // 
            this.btnInsumos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsumos.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnInsumos.FlatAppearance.BorderSize = 0;
            this.btnInsumos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsumos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsumos.Location = new System.Drawing.Point(797, 32);
            this.btnInsumos.Name = "btnInsumos";
            this.btnInsumos.Size = new System.Drawing.Size(132, 46);
            this.btnInsumos.TabIndex = 5;
            this.btnInsumos.TabStop = true;
            this.btnInsumos.Text = "Finished products";
            this.btnInsumos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInsumos.UseVisualStyleBackColor = true;
            this.btnInsumos.CheckedChanged += new System.EventHandler(this.btnInsumos_CheckedChanged);
            // 
            // txtVentas
            // 
            this.txtVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVentas.AutoSize = true;
            this.txtVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.69811F, System.Drawing.FontStyle.Bold);
            this.txtVentas.Location = new System.Drawing.Point(187, 19);
            this.txtVentas.Name = "txtVentas";
            this.txtVentas.Size = new System.Drawing.Size(136, 31);
            this.txtVentas.TabIndex = 2;
            this.txtVentas.Text = "Inventory";
            // 
            // imgVentas
            // 
            this.imgVentas.Image = ((System.Drawing.Image)(resources.GetObject("imgVentas.Image")));
            this.imgVentas.Location = new System.Drawing.Point(75, 3);
            this.imgVentas.Name = "imgVentas";
            this.imgVentas.Size = new System.Drawing.Size(83, 75);
            this.imgVentas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgVentas.TabIndex = 0;
            this.imgVentas.TabStop = false;
            // 
            // btnPTerminado
            // 
            this.btnPTerminado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPTerminado.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnPTerminado.FlatAppearance.BorderSize = 0;
            this.btnPTerminado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPTerminado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPTerminado.Location = new System.Drawing.Point(629, 32);
            this.btnPTerminado.Name = "btnPTerminado";
            this.btnPTerminado.Size = new System.Drawing.Size(132, 46);
            this.btnPTerminado.TabIndex = 4;
            this.btnPTerminado.TabStop = true;
            this.btnPTerminado.Text = "Inputs";
            this.btnPTerminado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPTerminado.UseVisualStyleBackColor = true;
            this.btnPTerminado.CheckedChanged += new System.EventHandler(this.btnPTerminado_CheckedChanged);
            // 
            // btnMPrima
            // 
            this.btnMPrima.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMPrima.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnMPrima.Checked = true;
            this.btnMPrima.FlatAppearance.BorderSize = 0;
            this.btnMPrima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMPrima.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMPrima.Location = new System.Drawing.Point(461, 32);
            this.btnMPrima.Name = "btnMPrima";
            this.btnMPrima.Size = new System.Drawing.Size(132, 46);
            this.btnMPrima.TabIndex = 3;
            this.btnMPrima.TabStop = true;
            this.btnMPrima.Text = "Raw material";
            this.btnMPrima.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMPrima.UseVisualStyleBackColor = true;
            this.btnMPrima.CheckedChanged += new System.EventHandler(this.btnMPrima_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(798, 207);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // inventarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 476);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.contenedor);
            this.Name = "inventarios";
            this.Text = "inventarios";
            this.Load += new System.EventHandler(this.inventarios_Load);
            this.contenedor.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TablaMatPrima)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaInsumo)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TablaProducTermi)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage TabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label txtVentas;
        private System.Windows.Forms.PictureBox imgVentas;
        private System.Windows.Forms.RadioButton btnInsumos;
        private System.Windows.Forms.RadioButton btnPTerminado;
        private System.Windows.Forms.RadioButton btnMPrima;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUnidadB;
        private System.Windows.Forms.TextBox txtNombreB;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView TablaMatPrima;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn claveSAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnAgregarIns;
        private System.Windows.Forms.Button btnAgreInsum;
        private System.Windows.Forms.Button btnBorrarInsu;
        private System.Windows.Forms.Button btnEditInsu;
        private System.Windows.Forms.DataGridView tablaInsumo;
        private System.Windows.Forms.Button btnBuscarInsumo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameInsumo;
        private System.Windows.Forms.Button btnAddProductos;
        private System.Windows.Forms.Button btnAddCantiProducto;
        private System.Windows.Forms.Button btnElimProdTerm;
        private System.Windows.Forms.Button btnEditProdTer;
        private System.Windows.Forms.DataGridView TablaProducTermi;
        private System.Windows.Forms.Button btnBusProdTermi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomProdTerm;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProdTerm;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameProduTer;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadProdTermi;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioProdTermi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantDisponibleProduTermi;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreInsu;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadMedidaInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadDispoInsumo;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}