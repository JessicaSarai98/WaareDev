namespace WareDev
{
    partial class Insumos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Insumos));
            this.contenedor = new System.Windows.Forms.Panel();
            this.ins = new System.Windows.Forms.TextBox();
            this.mult = new System.Windows.Forms.Button();
            this.SaveEditinputs = new System.Windows.Forms.Button();
            this.IDinputs = new System.Windows.Forms.TextBox();
            this.FotoProduc = new System.Windows.Forms.PictureBox();
            this.tablaFacVentas = new System.Windows.Forms.TableLayoutPanel();
            this.txtDesInsumo = new System.Windows.Forms.TextBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.txtPrecioInsumo = new System.Windows.Forms.TextBox();
            this.txtNombreInsumo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtCanAdqInsumos = new System.Windows.Forms.TextBox();
            this.txtUniMedInsu = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCostoTotalInsumo = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.top = new System.Windows.Forms.Panel();
            this.txtVentas = new System.Windows.Forms.Label();
            this.btrRegreso = new System.Windows.Forms.Button();
            this.contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoProduc)).BeginInit();
            this.tablaFacVentas.SuspendLayout();
            this.top.SuspendLayout();
            this.SuspendLayout();
            // 
            // contenedor
            // 
            this.contenedor.Controls.Add(this.ins);
            this.contenedor.Controls.Add(this.mult);
            this.contenedor.Controls.Add(this.SaveEditinputs);
            this.contenedor.Controls.Add(this.IDinputs);
            this.contenedor.Controls.Add(this.FotoProduc);
            this.contenedor.Controls.Add(this.tablaFacVentas);
            this.contenedor.Controls.Add(this.btnGuardar);
            this.contenedor.Controls.Add(this.top);
            this.contenedor.Controls.Add(this.btrRegreso);
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 0);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1018, 476);
            this.contenedor.TabIndex = 0;
            // 
            // ins
            // 
            this.ins.Enabled = false;
            this.ins.Location = new System.Drawing.Point(155, 420);
            this.ins.Name = "ins";
            this.ins.Size = new System.Drawing.Size(100, 20);
            this.ins.TabIndex = 32;
            this.ins.Text = "Insumos";
            // 
            // mult
            // 
            this.mult.BackColor = System.Drawing.Color.Silver;
            this.mult.FlatAppearance.BorderSize = 0;
            this.mult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.mult.Location = new System.Drawing.Point(535, 329);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(208, 35);
            this.mult.TabIndex = 8;
            this.mult.Text = "Calculate the Total Cost";
            this.mult.UseVisualStyleBackColor = false;
            this.mult.Click += new System.EventHandler(this.mult_Click);
            // 
            // SaveEditinputs
            // 
            this.SaveEditinputs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveEditinputs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(213)))), ((int)(((byte)(227)))));
            this.SaveEditinputs.Cursor = System.Windows.Forms.Cursors.Default;
            this.SaveEditinputs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveEditinputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveEditinputs.ForeColor = System.Drawing.Color.Black;
            this.SaveEditinputs.Image = ((System.Drawing.Image)(resources.GetObject("SaveEditinputs.Image")));
            this.SaveEditinputs.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SaveEditinputs.Location = new System.Drawing.Point(682, 90);
            this.SaveEditinputs.Name = "SaveEditinputs";
            this.SaveEditinputs.Size = new System.Drawing.Size(104, 65);
            this.SaveEditinputs.TabIndex = 12;
            this.SaveEditinputs.Text = "Save";
            this.SaveEditinputs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SaveEditinputs.UseVisualStyleBackColor = false;
            this.SaveEditinputs.Click += new System.EventHandler(this.SaveEditinputs_Click);
            // 
            // IDinputs
            // 
            this.IDinputs.Location = new System.Drawing.Point(316, 126);
            this.IDinputs.Name = "IDinputs";
            this.IDinputs.Size = new System.Drawing.Size(52, 20);
            this.IDinputs.TabIndex = 2;
            this.IDinputs.Visible = false;
            // 
            // FotoProduc
            // 
            this.FotoProduc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FotoProduc.BackColor = System.Drawing.Color.Silver;
            this.FotoProduc.Location = new System.Drawing.Point(777, 329);
            this.FotoProduc.Name = "FotoProduc";
            this.FotoProduc.Size = new System.Drawing.Size(164, 144);
            this.FotoProduc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FotoProduc.TabIndex = 31;
            this.FotoProduc.TabStop = false;
            this.FotoProduc.Visible = false;
            // 
            // tablaFacVentas
            // 
            this.tablaFacVentas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaFacVentas.ColumnCount = 4;
            this.tablaFacVentas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablaFacVentas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablaFacVentas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablaFacVentas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablaFacVentas.Controls.Add(this.txtDesInsumo, 1, 3);
            this.tablaFacVentas.Controls.Add(this.btnFoto, 3, 3);
            this.tablaFacVentas.Controls.Add(this.txtPrecioInsumo, 3, 1);
            this.tablaFacVentas.Controls.Add(this.txtNombreInsumo, 3, 0);
            this.tablaFacVentas.Controls.Add(this.label2, 0, 0);
            this.tablaFacVentas.Controls.Add(this.label6, 2, 0);
            this.tablaFacVentas.Controls.Add(this.label12, 2, 1);
            this.tablaFacVentas.Controls.Add(this.dateTimePicker1, 1, 0);
            this.tablaFacVentas.Controls.Add(this.txtCanAdqInsumos, 1, 2);
            this.tablaFacVentas.Controls.Add(this.txtUniMedInsu, 1, 1);
            this.tablaFacVentas.Controls.Add(this.label11, 0, 2);
            this.tablaFacVentas.Controls.Add(this.label10, 0, 1);
            this.tablaFacVentas.Controls.Add(this.label4, 2, 2);
            this.tablaFacVentas.Controls.Add(this.label5, 2, 3);
            this.tablaFacVentas.Controls.Add(this.label7, 0, 3);
            this.tablaFacVentas.Controls.Add(this.txtCostoTotalInsumo, 3, 2);
            this.tablaFacVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.tablaFacVentas.Location = new System.Drawing.Point(9, 161);
            this.tablaFacVentas.Name = "tablaFacVentas";
            this.tablaFacVentas.RowCount = 4;
            this.tablaFacVentas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablaFacVentas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablaFacVentas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablaFacVentas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablaFacVentas.Size = new System.Drawing.Size(1006, 162);
            this.tablaFacVentas.TabIndex = 30;
            // 
            // txtDesInsumo
            // 
            this.txtDesInsumo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDesInsumo.BackColor = System.Drawing.Color.White;
            this.txtDesInsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.txtDesInsumo.Location = new System.Drawing.Point(254, 123);
            this.txtDesInsumo.Multiline = true;
            this.txtDesInsumo.Name = "txtDesInsumo";
            this.txtDesInsumo.Size = new System.Drawing.Size(245, 36);
            this.txtDesInsumo.TabIndex = 9;
            this.txtDesInsumo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btnFoto.Location = new System.Drawing.Point(756, 123);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnFoto.Size = new System.Drawing.Size(247, 36);
            this.btnFoto.TabIndex = 10;
            this.btnFoto.Text = "ADD PICTURE";
            this.btnFoto.UseVisualStyleBackColor = false;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // txtPrecioInsumo
            // 
            this.txtPrecioInsumo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecioInsumo.BackColor = System.Drawing.Color.White;
            this.txtPrecioInsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.txtPrecioInsumo.Location = new System.Drawing.Point(756, 43);
            this.txtPrecioInsumo.Multiline = true;
            this.txtPrecioInsumo.Name = "txtPrecioInsumo";
            this.txtPrecioInsumo.Size = new System.Drawing.Size(247, 34);
            this.txtPrecioInsumo.TabIndex = 6;
            this.txtPrecioInsumo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombreInsumo
            // 
            this.txtNombreInsumo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreInsumo.BackColor = System.Drawing.Color.White;
            this.txtNombreInsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.txtNombreInsumo.Location = new System.Drawing.Point(756, 3);
            this.txtNombreInsumo.Multiline = true;
            this.txtNombreInsumo.Name = "txtNombreInsumo";
            this.txtNombreInsumo.Size = new System.Drawing.Size(247, 34);
            this.txtNombreInsumo.TabIndex = 4;
            this.txtNombreInsumo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(601, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Name";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(587, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 18);
            this.label12.TabIndex = 0;
            this.label12.Text = "Unit price";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(254, 3);
            this.dateTimePicker1.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(245, 26);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Value = new System.DateTime(2020, 5, 13, 0, 0, 0, 0);
            // 
            // txtCanAdqInsumos
            // 
            this.txtCanAdqInsumos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCanAdqInsumos.BackColor = System.Drawing.Color.White;
            this.txtCanAdqInsumos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.txtCanAdqInsumos.Location = new System.Drawing.Point(254, 83);
            this.txtCanAdqInsumos.Multiline = true;
            this.txtCanAdqInsumos.Name = "txtCanAdqInsumos";
            this.txtCanAdqInsumos.Size = new System.Drawing.Size(245, 34);
            this.txtCanAdqInsumos.TabIndex = 7;
            this.txtCanAdqInsumos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUniMedInsu
            // 
            this.txtUniMedInsu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUniMedInsu.BackColor = System.Drawing.Color.White;
            this.txtUniMedInsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.txtUniMedInsu.Location = new System.Drawing.Point(254, 43);
            this.txtUniMedInsu.Multiline = true;
            this.txtUniMedInsu.Name = "txtUniMedInsu";
            this.txtUniMedInsu.Size = new System.Drawing.Size(245, 34);
            this.txtUniMedInsu.TabIndex = 5;
            this.txtUniMedInsu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(51, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "Amount purchased";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(61, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "Unit of measure";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(585, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total cost";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(601, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Photo";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(78, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Description";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCostoTotalInsumo
            // 
            this.txtCostoTotalInsumo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCostoTotalInsumo.BackColor = System.Drawing.Color.White;
            this.txtCostoTotalInsumo.Enabled = false;
            this.txtCostoTotalInsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.txtCostoTotalInsumo.Location = new System.Drawing.Point(756, 83);
            this.txtCostoTotalInsumo.Multiline = true;
            this.txtCostoTotalInsumo.Name = "txtCostoTotalInsumo";
            this.txtCostoTotalInsumo.ReadOnly = true;
            this.txtCostoTotalInsumo.Size = new System.Drawing.Size(247, 34);
            this.txtCostoTotalInsumo.TabIndex = 0;
            this.txtCostoTotalInsumo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCostoTotalInsumo.TextChanged += new System.EventHandler(this.txtCostoTotalInsumo_TextChanged);
            this.txtCostoTotalInsumo.Leave += new System.EventHandler(this.txtCostoTotalInsumo_Leave);
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
            this.btnGuardar.Location = new System.Drawing.Point(792, 90);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(104, 65);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Save";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // top
            // 
            this.top.Controls.Add(this.txtVentas);
            this.top.Dock = System.Windows.Forms.DockStyle.Top;
            this.top.Location = new System.Drawing.Point(0, 0);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(1018, 84);
            this.top.TabIndex = 0;
            // 
            // txtVentas
            // 
            this.txtVentas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.69811F, System.Drawing.FontStyle.Bold);
            this.txtVentas.Location = new System.Drawing.Point(393, 22);
            this.txtVentas.Name = "txtVentas";
            this.txtVentas.Size = new System.Drawing.Size(212, 42);
            this.txtVentas.TabIndex = 0;
            this.txtVentas.Text = "Add inputs";
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
            this.btrRegreso.Location = new System.Drawing.Point(902, 90);
            this.btrRegreso.Name = "btrRegreso";
            this.btrRegreso.Size = new System.Drawing.Size(104, 65);
            this.btrRegreso.TabIndex = 14;
            this.btrRegreso.Text = "Return";
            this.btrRegreso.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btrRegreso.UseVisualStyleBackColor = false;
            this.btrRegreso.Click += new System.EventHandler(this.btrRegreso_Click);
            // 
            // Insumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 476);
            this.Controls.Add(this.contenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Insumos";
            this.Text = "Insumos";
            this.Load += new System.EventHandler(this.Insumos_Load);
            this.contenedor.ResumeLayout(false);
            this.contenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoProduc)).EndInit();
            this.tablaFacVentas.ResumeLayout(false);
            this.tablaFacVentas.PerformLayout();
            this.top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.TableLayoutPanel tablaFacVentas;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel top;
        private System.Windows.Forms.Label txtVentas;
        private System.Windows.Forms.Button btrRegreso;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox IDinputs;
        public System.Windows.Forms.PictureBox FotoProduc;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.TextBox txtCanAdqInsumos;
        public System.Windows.Forms.TextBox txtUniMedInsu;
        public System.Windows.Forms.TextBox txtNombreInsumo;
        public System.Windows.Forms.TextBox txtPrecioInsumo;
        public System.Windows.Forms.TextBox txtCostoTotalInsumo;
        public System.Windows.Forms.TextBox txtDesInsumo;
        public System.Windows.Forms.Button SaveEditinputs;
        public System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button mult;
        public System.Windows.Forms.TextBox ins;
    }
}