﻿namespace WareDev
{
    partial class ProductoTerminado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductoTerminado));
            this.contenedor = new System.Windows.Forms.Panel();
            this.exis = new System.Windows.Forms.Button();
            this.existencia = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.SaveEdit = new System.Windows.Forms.Button();
            this.FotoProduc = new System.Windows.Forms.PictureBox();
            this.TablaProdTermi = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombreMateria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecioInsumo = new System.Windows.Forms.TextBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreInsumo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtUniMedInsu = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCajasContenido = new System.Windows.Forms.TextBox();
            this.txtNameInputs = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPallet = new System.Windows.Forms.TextBox();
            this.txtCantiMatPrima = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidadInsumo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCantiAdquirida = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.top = new System.Windows.Forms.Panel();
            this.txtVentas = new System.Windows.Forms.Label();
            this.btrRegreso = new System.Windows.Forms.Button();
            this.existenciaI = new System.Windows.Forms.Button();
            this.exisI = new System.Windows.Forms.TextBox();
            this.contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoProduc)).BeginInit();
            this.TablaProdTermi.SuspendLayout();
            this.top.SuspendLayout();
            this.SuspendLayout();
            // 
            // contenedor
            // 
            this.contenedor.Controls.Add(this.exisI);
            this.contenedor.Controls.Add(this.existenciaI);
            this.contenedor.Controls.Add(this.exis);
            this.contenedor.Controls.Add(this.existencia);
            this.contenedor.Controls.Add(this.ID);
            this.contenedor.Controls.Add(this.SaveEdit);
            this.contenedor.Controls.Add(this.FotoProduc);
            this.contenedor.Controls.Add(this.TablaProdTermi);
            this.contenedor.Controls.Add(this.btnGuardar);
            this.contenedor.Controls.Add(this.top);
            this.contenedor.Controls.Add(this.btrRegreso);
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 0);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1100, 500);
            this.contenedor.TabIndex = 0;
            // 
            // exis
            // 
            this.exis.Location = new System.Drawing.Point(592, 434);
            this.exis.Name = "exis";
            this.exis.Size = new System.Drawing.Size(125, 23);
            this.exis.TabIndex = 35;
            this.exis.Text = "Ver existencia - Raw";
            this.exis.UseVisualStyleBackColor = true;
            this.exis.Click += new System.EventHandler(this.exis_Click);
            // 
            // existencia
            // 
            this.existencia.Location = new System.Drawing.Point(743, 434);
            this.existencia.Name = "existencia";
            this.existencia.Size = new System.Drawing.Size(100, 20);
            this.existencia.TabIndex = 34;
            this.existencia.TextChanged += new System.EventHandler(this.existencia_TextChanged);
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(379, 126);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(100, 20);
            this.ID.TabIndex = 33;
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
            this.SaveEdit.Location = new System.Drawing.Point(769, 90);
            this.SaveEdit.Name = "SaveEdit";
            this.SaveEdit.Size = new System.Drawing.Size(88, 57);
            this.SaveEdit.TabIndex = 32;
            this.SaveEdit.Text = "Save";
            this.SaveEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SaveEdit.UseVisualStyleBackColor = false;
            this.SaveEdit.Click += new System.EventHandler(this.SaveEdit_Click);
            // 
            // FotoProduc
            // 
            this.FotoProduc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FotoProduc.BackColor = System.Drawing.Color.Silver;
            this.FotoProduc.Location = new System.Drawing.Point(874, 349);
            this.FotoProduc.Name = "FotoProduc";
            this.FotoProduc.Size = new System.Drawing.Size(214, 148);
            this.FotoProduc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FotoProduc.TabIndex = 31;
            this.FotoProduc.TabStop = false;
            this.FotoProduc.Visible = false;
            // 
            // TablaProdTermi
            // 
            this.TablaProdTermi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TablaProdTermi.ColumnCount = 4;
            this.TablaProdTermi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TablaProdTermi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.07936F));
            this.TablaProdTermi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.86773F));
            this.TablaProdTermi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TablaProdTermi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TablaProdTermi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TablaProdTermi.Controls.Add(this.label9, 0, 5);
            this.TablaProdTermi.Controls.Add(this.label8, 2, 4);
            this.TablaProdTermi.Controls.Add(this.txtNombreMateria, 3, 3);
            this.TablaProdTermi.Controls.Add(this.label1, 2, 3);
            this.TablaProdTermi.Controls.Add(this.txtPrecioInsumo, 3, 1);
            this.TablaProdTermi.Controls.Add(this.btnFoto, 2, 6);
            this.TablaProdTermi.Controls.Add(this.label5, 2, 5);
            this.TablaProdTermi.Controls.Add(this.txtNombreInsumo, 3, 0);
            this.TablaProdTermi.Controls.Add(this.label2, 0, 0);
            this.TablaProdTermi.Controls.Add(this.label6, 2, 0);
            this.TablaProdTermi.Controls.Add(this.label12, 2, 1);
            this.TablaProdTermi.Controls.Add(this.dateTimePicker1, 1, 0);
            this.TablaProdTermi.Controls.Add(this.txtUniMedInsu, 1, 1);
            this.TablaProdTermi.Controls.Add(this.label10, 0, 1);
            this.TablaProdTermi.Controls.Add(this.label11, 0, 3);
            this.TablaProdTermi.Controls.Add(this.txtCajasContenido, 1, 3);
            this.TablaProdTermi.Controls.Add(this.txtNameInputs, 1, 4);
            this.TablaProdTermi.Controls.Add(this.label7, 2, 2);
            this.TablaProdTermi.Controls.Add(this.txtDescripcion, 3, 2);
            this.TablaProdTermi.Controls.Add(this.label4, 0, 2);
            this.TablaProdTermi.Controls.Add(this.txtPallet, 1, 2);
            this.TablaProdTermi.Controls.Add(this.txtCantiMatPrima, 3, 4);
            this.TablaProdTermi.Controls.Add(this.label3, 0, 4);
            this.TablaProdTermi.Controls.Add(this.txtCantidadInsumo, 1, 5);
            this.TablaProdTermi.Controls.Add(this.label13, 0, 6);
            this.TablaProdTermi.Controls.Add(this.txtCantiAdquirida, 1, 6);
            this.TablaProdTermi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.TablaProdTermi.Location = new System.Drawing.Point(75, 161);
            this.TablaProdTermi.Name = "TablaProdTermi";
            this.TablaProdTermi.RowCount = 7;
            this.TablaProdTermi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TablaProdTermi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TablaProdTermi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TablaProdTermi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TablaProdTermi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TablaProdTermi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.TablaProdTermi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.TablaProdTermi.Size = new System.Drawing.Size(945, 242);
            this.TablaProdTermi.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(52, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Quantity used (I)";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(513, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Quantity used (RM)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNombreMateria
            // 
            this.txtNombreMateria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreMateria.BackColor = System.Drawing.Color.White;
            this.txtNombreMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.txtNombreMateria.Location = new System.Drawing.Point(711, 108);
            this.txtNombreMateria.Multiline = true;
            this.txtNombreMateria.Name = "txtNombreMateria";
            this.txtNombreMateria.Size = new System.Drawing.Size(231, 29);
            this.txtNombreMateria.TabIndex = 9;
            this.txtNombreMateria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(514, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Raw material name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPrecioInsumo
            // 
            this.txtPrecioInsumo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecioInsumo.BackColor = System.Drawing.Color.White;
            this.txtPrecioInsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.txtPrecioInsumo.Location = new System.Drawing.Point(711, 38);
            this.txtPrecioInsumo.Multiline = true;
            this.txtPrecioInsumo.Name = "txtPrecioInsumo";
            this.txtPrecioInsumo.Size = new System.Drawing.Size(231, 29);
            this.txtPrecioInsumo.TabIndex = 5;
            this.txtPrecioInsumo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnFoto
            // 
            this.btnFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFoto.BackColor = System.Drawing.Color.Silver;
            this.btnFoto.FlatAppearance.BorderSize = 0;
            this.btnFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnFoto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFoto.Location = new System.Drawing.Point(476, 213);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnFoto.Size = new System.Drawing.Size(229, 26);
            this.btnFoto.TabIndex = 14;
            this.btnFoto.Text = "ADD PICTURE";
            this.btnFoto.UseVisualStyleBackColor = false;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(564, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Photo";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNombreInsumo
            // 
            this.txtNombreInsumo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreInsumo.BackColor = System.Drawing.Color.White;
            this.txtNombreInsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.txtNombreInsumo.Location = new System.Drawing.Point(711, 3);
            this.txtNombreInsumo.Multiline = true;
            this.txtNombreInsumo.Name = "txtNombreInsumo";
            this.txtNombreInsumo.Size = new System.Drawing.Size(231, 29);
            this.txtNombreInsumo.TabIndex = 3;
            this.txtNombreInsumo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 8);
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
            this.label6.Location = new System.Drawing.Point(564, 8);
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
            this.label12.Location = new System.Drawing.Point(550, 43);
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
            this.dateTimePicker1.Location = new System.Drawing.Point(239, 3);
            this.dateTimePicker1.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(231, 26);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.Value = new System.DateTime(2020, 5, 13, 0, 0, 0, 0);
            // 
            // txtUniMedInsu
            // 
            this.txtUniMedInsu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUniMedInsu.BackColor = System.Drawing.Color.White;
            this.txtUniMedInsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.txtUniMedInsu.Location = new System.Drawing.Point(239, 38);
            this.txtUniMedInsu.Multiline = true;
            this.txtUniMedInsu.Name = "txtUniMedInsu";
            this.txtUniMedInsu.Size = new System.Drawing.Size(231, 29);
            this.txtUniMedInsu.TabIndex = 4;
            this.txtUniMedInsu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(54, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "Unit of measure";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(49, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "Boxes by content";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCajasContenido
            // 
            this.txtCajasContenido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCajasContenido.BackColor = System.Drawing.Color.White;
            this.txtCajasContenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.txtCajasContenido.Location = new System.Drawing.Point(239, 108);
            this.txtCajasContenido.Multiline = true;
            this.txtCajasContenido.Name = "txtCajasContenido";
            this.txtCajasContenido.Size = new System.Drawing.Size(231, 29);
            this.txtCajasContenido.TabIndex = 8;
            this.txtCajasContenido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNameInputs
            // 
            this.txtNameInputs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameInputs.BackColor = System.Drawing.Color.White;
            this.txtNameInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.txtNameInputs.Location = new System.Drawing.Point(239, 143);
            this.txtNameInputs.Multiline = true;
            this.txtNameInputs.Name = "txtNameInputs";
            this.txtNameInputs.Size = new System.Drawing.Size(231, 29);
            this.txtNameInputs.TabIndex = 10;
            this.txtNameInputs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(543, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Description";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.txtDescripcion.Location = new System.Drawing.Point(711, 73);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(231, 29);
            this.txtDescripcion.TabIndex = 7;
            this.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Pallet by content";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPallet
            // 
            this.txtPallet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPallet.BackColor = System.Drawing.Color.White;
            this.txtPallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.txtPallet.Location = new System.Drawing.Point(239, 73);
            this.txtPallet.Multiline = true;
            this.txtPallet.Name = "txtPallet";
            this.txtPallet.Size = new System.Drawing.Size(231, 29);
            this.txtPallet.TabIndex = 6;
            this.txtPallet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCantiMatPrima
            // 
            this.txtCantiMatPrima.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCantiMatPrima.BackColor = System.Drawing.Color.White;
            this.txtCantiMatPrima.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.txtCantiMatPrima.Location = new System.Drawing.Point(711, 143);
            this.txtCantiMatPrima.Multiline = true;
            this.txtCantiMatPrima.Name = "txtCantiMatPrima";
            this.txtCantiMatPrima.Size = new System.Drawing.Size(231, 29);
            this.txtCantiMatPrima.TabIndex = 11;
            this.txtCantiMatPrima.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Inputs name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCantidadInsumo
            // 
            this.txtCantidadInsumo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCantidadInsumo.BackColor = System.Drawing.Color.White;
            this.txtCantidadInsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.txtCantidadInsumo.Location = new System.Drawing.Point(239, 178);
            this.txtCantidadInsumo.Multiline = true;
            this.txtCantidadInsumo.Name = "txtCantidadInsumo";
            this.txtCantidadInsumo.Size = new System.Drawing.Size(231, 29);
            this.txtCantidadInsumo.TabIndex = 12;
            this.txtCantidadInsumo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(44, 217);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(148, 18);
            this.label13.TabIndex = 0;
            this.label13.Text = "Amount purchased";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCantiAdquirida
            // 
            this.txtCantiAdquirida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCantiAdquirida.BackColor = System.Drawing.Color.White;
            this.txtCantiAdquirida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.txtCantiAdquirida.Location = new System.Drawing.Point(239, 213);
            this.txtCantiAdquirida.Multiline = true;
            this.txtCantiAdquirida.Name = "txtCantiAdquirida";
            this.txtCantiAdquirida.Size = new System.Drawing.Size(231, 26);
            this.txtCantiAdquirida.TabIndex = 13;
            this.txtCantiAdquirida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btnGuardar.Location = new System.Drawing.Point(874, 90);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(88, 57);
            this.btnGuardar.TabIndex = 15;
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
            this.top.Size = new System.Drawing.Size(1100, 84);
            this.top.TabIndex = 18;
            // 
            // txtVentas
            // 
            this.txtVentas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.69811F, System.Drawing.FontStyle.Bold);
            this.txtVentas.Location = new System.Drawing.Point(434, 22);
            this.txtVentas.Name = "txtVentas";
            this.txtVentas.Size = new System.Drawing.Size(337, 42);
            this.txtVentas.TabIndex = 0;
            this.txtVentas.Text = "Add Finished Products";
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
            this.btrRegreso.Location = new System.Drawing.Point(984, 90);
            this.btrRegreso.Name = "btrRegreso";
            this.btrRegreso.Size = new System.Drawing.Size(88, 57);
            this.btrRegreso.TabIndex = 16;
            this.btrRegreso.Text = "Return";
            this.btrRegreso.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btrRegreso.UseVisualStyleBackColor = false;
            this.btrRegreso.Click += new System.EventHandler(this.btrRegreso_Click);
            // 
            // existenciaI
            // 
            this.existenciaI.Location = new System.Drawing.Point(189, 431);
            this.existenciaI.Name = "existenciaI";
            this.existenciaI.Size = new System.Drawing.Size(125, 23);
            this.existenciaI.TabIndex = 36;
            this.existenciaI.Text = "Ver existencia - Input";
            this.existenciaI.UseVisualStyleBackColor = true;
            this.existenciaI.Click += new System.EventHandler(this.existenciaI_Click);
            // 
            // exisI
            // 
            this.exisI.Location = new System.Drawing.Point(367, 431);
            this.exisI.Name = "exisI";
            this.exisI.Size = new System.Drawing.Size(100, 20);
            this.exisI.TabIndex = 37;
            // 
            // ProductoTerminado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 500);
            this.Controls.Add(this.contenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductoTerminado";
            this.Text = "ProductoTerminado";
            this.Load += new System.EventHandler(this.ProductoTerminado_Load);
            this.contenedor.ResumeLayout(false);
            this.contenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoProduc)).EndInit();
            this.TablaProdTermi.ResumeLayout(false);
            this.TablaProdTermi.PerformLayout();
            this.top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.TableLayoutPanel TablaProdTermi;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel top;
        private System.Windows.Forms.Label txtVentas;
        private System.Windows.Forms.Button btrRegreso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox txtCantiAdquirida;
        public System.Windows.Forms.Button SaveEdit;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.PictureBox FotoProduc;
        public System.Windows.Forms.TextBox txtDescripcion;
        public System.Windows.Forms.TextBox txtPrecioInsumo;
        public System.Windows.Forms.TextBox txtNombreInsumo;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.TextBox txtCajasContenido;
        public System.Windows.Forms.TextBox txtUniMedInsu;
        public System.Windows.Forms.TextBox txtPallet;
        public System.Windows.Forms.TextBox txtNombreMateria;
        public System.Windows.Forms.TextBox txtNameInputs;
        public System.Windows.Forms.TextBox txtCantiMatPrima;
        public System.Windows.Forms.TextBox txtCantidadInsumo;
        public System.Windows.Forms.TextBox ID;
        public System.Windows.Forms.TextBox existencia;
        public System.Windows.Forms.Button exis;
        public System.Windows.Forms.TextBox exisI;
        public System.Windows.Forms.Button existenciaI;
    }
}