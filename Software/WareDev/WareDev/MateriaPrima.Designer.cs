namespace WareDev
{
    partial class MateriaPrima
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MateriaPrima));
            this.contenedor = new System.Windows.Forms.Panel();
            this.mat = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.SaveEdit = new System.Windows.Forms.Button();
            this.FotoProduc = new System.Windows.Forms.PictureBox();
            this.tablaFacVentas = new System.Windows.Forms.TableLayoutPanel();
            this.txtCantiAdquirida = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSat = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtFraccion = new System.Windows.Forms.TextBox();
            this.txtUniMedAduana = new System.Windows.Forms.TextBox();
            this.txtCanAduana = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPorcentaje = new System.Windows.Forms.TextBox();
            this.txtUniMedida = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFoto = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
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
            this.contenedor.Controls.Add(this.mat);
            this.contenedor.Controls.Add(this.ID);
            this.contenedor.Controls.Add(this.SaveEdit);
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
            // mat
            // 
            this.mat.Location = new System.Drawing.Point(584, 443);
            this.mat.Name = "mat";
            this.mat.Size = new System.Drawing.Size(100, 20);
            this.mat.TabIndex = 32;
            this.mat.Text = "Materia prima";
            // 
            // ID
            // 
            this.ID.Enabled = false;
            this.ID.Location = new System.Drawing.Point(538, 122);
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Size = new System.Drawing.Size(100, 20);
            this.ID.TabIndex = 3;
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
            this.SaveEdit.Location = new System.Drawing.Point(792, 90);
            this.SaveEdit.Name = "SaveEdit";
            this.SaveEdit.Size = new System.Drawing.Size(104, 65);
            this.SaveEdit.TabIndex = 16;
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
            this.FotoProduc.Location = new System.Drawing.Point(792, 350);
            this.FotoProduc.Name = "FotoProduc";
            this.FotoProduc.Size = new System.Drawing.Size(161, 114);
            this.FotoProduc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FotoProduc.TabIndex = 31;
            this.FotoProduc.TabStop = false;
            this.FotoProduc.Visible = false;
            // 
            // tablaFacVentas
            // 
            this.tablaFacVentas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaFacVentas.ColumnCount = 6;
            this.tablaFacVentas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tablaFacVentas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tablaFacVentas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tablaFacVentas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tablaFacVentas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tablaFacVentas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tablaFacVentas.Controls.Add(this.txtCantiAdquirida, 3, 4);
            this.tablaFacVentas.Controls.Add(this.label11, 2, 4);
            this.tablaFacVentas.Controls.Add(this.label13, 0, 4);
            this.tablaFacVentas.Controls.Add(this.txtEstado, 3, 2);
            this.tablaFacVentas.Controls.Add(this.label2, 2, 2);
            this.tablaFacVentas.Controls.Add(this.label1, 0, 2);
            this.tablaFacVentas.Controls.Add(this.nombre, 0, 0);
            this.tablaFacVentas.Controls.Add(this.label4, 0, 1);
            this.tablaFacVentas.Controls.Add(this.label8, 2, 0);
            this.tablaFacVentas.Controls.Add(this.txtSat, 3, 0);
            this.tablaFacVentas.Controls.Add(this.txtNombre, 1, 0);
            this.tablaFacVentas.Controls.Add(this.label5, 2, 1);
            this.tablaFacVentas.Controls.Add(this.dateTimePicker1, 1, 1);
            this.tablaFacVentas.Controls.Add(this.txtFraccion, 3, 1);
            this.tablaFacVentas.Controls.Add(this.txtUniMedAduana, 1, 2);
            this.tablaFacVentas.Controls.Add(this.txtCanAduana, 5, 1);
            this.tablaFacVentas.Controls.Add(this.txtPrecio, 5, 2);
            this.tablaFacVentas.Controls.Add(this.label3, 4, 1);
            this.tablaFacVentas.Controls.Add(this.label6, 4, 2);
            this.tablaFacVentas.Controls.Add(this.txtPorcentaje, 3, 3);
            this.tablaFacVentas.Controls.Add(this.txtUniMedida, 1, 3);
            this.tablaFacVentas.Controls.Add(this.txtDescripcion, 1, 4);
            this.tablaFacVentas.Controls.Add(this.label10, 0, 3);
            this.tablaFacVentas.Controls.Add(this.label7, 2, 3);
            this.tablaFacVentas.Controls.Add(this.btnFoto, 5, 3);
            this.tablaFacVentas.Controls.Add(this.label14, 4, 3);
            this.tablaFacVentas.Controls.Add(this.txtIva, 5, 0);
            this.tablaFacVentas.Controls.Add(this.label12, 4, 0);
            this.tablaFacVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.tablaFacVentas.Location = new System.Drawing.Point(9, 161);
            this.tablaFacVentas.Name = "tablaFacVentas";
            this.tablaFacVentas.RowCount = 6;
            this.tablaFacVentas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablaFacVentas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablaFacVentas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.54545F));
            this.tablaFacVentas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.45455F));
            this.tablaFacVentas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tablaFacVentas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tablaFacVentas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablaFacVentas.Size = new System.Drawing.Size(1006, 261);
            this.tablaFacVentas.TabIndex = 0;
            // 
            // txtCantiAdquirida
            // 
            this.txtCantiAdquirida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCantiAdquirida.BackColor = System.Drawing.Color.White;
            this.txtCantiAdquirida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.txtCantiAdquirida.Location = new System.Drawing.Point(504, 179);
            this.txtCantiAdquirida.Multiline = true;
            this.txtCantiAdquirida.Name = "txtCantiAdquirida";
            this.txtCantiAdquirida.Size = new System.Drawing.Size(161, 38);
            this.txtCantiAdquirida.TabIndex = 13;
            this.txtCantiAdquirida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCantiAdquirida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantiAdquirida_KeyPress);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(339, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "Cantidad Comprada";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(34, 189);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 18);
            this.label13.TabIndex = 0;
            this.label13.Text = "Descripción";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEstado
            // 
            this.txtEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEstado.BackColor = System.Drawing.Color.White;
            this.txtEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.txtEstado.Location = new System.Drawing.Point(504, 91);
            this.txtEstado.Multiline = true;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(161, 37);
            this.txtEstado.TabIndex = 8;
            this.txtEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(389, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Status";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unidad de Medida de Aduana";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nombre
            // 
            this.nombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nombre.AutoSize = true;
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(49, 13);
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
            this.label4.Location = new System.Drawing.Point(56, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fecha";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(360, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Clave de SAT ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSat
            // 
            this.txtSat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSat.BackColor = System.Drawing.Color.White;
            this.txtSat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.txtSat.Location = new System.Drawing.Point(504, 3);
            this.txtSat.Multiline = true;
            this.txtSat.Name = "txtSat";
            this.txtSat.Size = new System.Drawing.Size(161, 38);
            this.txtSat.TabIndex = 2;
            this.txtSat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSat_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(170, 3);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(161, 38);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(363, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 40);
            this.label5.TabIndex = 0;
            this.label5.Text = "Arancel ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(170, 47);
            this.dateTimePicker1.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(161, 26);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(2020, 5, 13, 0, 0, 0, 0);
            // 
            // txtFraccion
            // 
            this.txtFraccion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFraccion.BackColor = System.Drawing.Color.White;
            this.txtFraccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.txtFraccion.Location = new System.Drawing.Point(504, 47);
            this.txtFraccion.Multiline = true;
            this.txtFraccion.Name = "txtFraccion";
            this.txtFraccion.Size = new System.Drawing.Size(161, 38);
            this.txtFraccion.TabIndex = 5;
            this.txtFraccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFraccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFraccion_KeyPress);
            // 
            // txtUniMedAduana
            // 
            this.txtUniMedAduana.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUniMedAduana.BackColor = System.Drawing.Color.White;
            this.txtUniMedAduana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.txtUniMedAduana.Location = new System.Drawing.Point(170, 91);
            this.txtUniMedAduana.Multiline = true;
            this.txtUniMedAduana.Name = "txtUniMedAduana";
            this.txtUniMedAduana.Size = new System.Drawing.Size(161, 37);
            this.txtUniMedAduana.TabIndex = 7;
            this.txtUniMedAduana.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCanAduana
            // 
            this.txtCanAduana.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCanAduana.BackColor = System.Drawing.Color.White;
            this.txtCanAduana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.txtCanAduana.Location = new System.Drawing.Point(838, 47);
            this.txtCanAduana.Multiline = true;
            this.txtCanAduana.Name = "txtCanAduana";
            this.txtCanAduana.Size = new System.Drawing.Size(165, 38);
            this.txtCanAduana.TabIndex = 6;
            this.txtCanAduana.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCanAduana.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCanAduana_KeyPress);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecio.BackColor = System.Drawing.Color.White;
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.txtPrecio.Location = new System.Drawing.Point(838, 91);
            this.txtPrecio.Multiline = true;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(165, 37);
            this.txtPrecio.TabIndex = 9;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(673, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cantidad de Aduana";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(723, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Precio";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPorcentaje.BackColor = System.Drawing.Color.White;
            this.txtPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.txtPorcentaje.Location = new System.Drawing.Point(504, 134);
            this.txtPorcentaje.Multiline = true;
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.Size = new System.Drawing.Size(161, 39);
            this.txtPorcentaje.TabIndex = 11;
            this.txtPorcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPorcentaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorcentaje_KeyPress);
            // 
            // txtUniMedida
            // 
            this.txtUniMedida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUniMedida.BackColor = System.Drawing.Color.White;
            this.txtUniMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.txtUniMedida.Location = new System.Drawing.Point(170, 134);
            this.txtUniMedida.Multiline = true;
            this.txtUniMedida.Name = "txtUniMedida";
            this.txtUniMedida.Size = new System.Drawing.Size(161, 39);
            this.txtUniMedida.TabIndex = 10;
            this.txtUniMedida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.txtDescripcion.Location = new System.Drawing.Point(170, 179);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(161, 38);
            this.txtDescripcion.TabIndex = 12;
            this.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "Unidad de Medida";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(351, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Monto Agregado";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnFoto.Location = new System.Drawing.Point(838, 134);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnFoto.Size = new System.Drawing.Size(165, 39);
            this.btnFoto.TabIndex = 15;
            this.btnFoto.Text = "ADD PICTURE";
            this.btnFoto.UseVisualStyleBackColor = false;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(730, 144);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 18);
            this.label14.TabIndex = 43;
            this.label14.Text = "Foto";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIva
            // 
            this.txtIva.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIva.BackColor = System.Drawing.Color.White;
            this.txtIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.txtIva.Location = new System.Drawing.Point(838, 3);
            this.txtIva.Multiline = true;
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(165, 38);
            this.txtIva.TabIndex = 14;
            this.txtIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIva_KeyPress);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(735, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 18);
            this.label12.TabIndex = 0;
            this.label12.Text = "IVA";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnGuardar.TabIndex = 16;
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
            this.txtVentas.Size = new System.Drawing.Size(342, 42);
            this.txtVentas.TabIndex = 0;
            this.txtVentas.Text = "Agregar Materia Prima";
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
            this.btrRegreso.TabIndex = 17;
            this.btrRegreso.Text = "Return";
            this.btrRegreso.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btrRegreso.UseVisualStyleBackColor = false;
            this.btrRegreso.Click += new System.EventHandler(this.btrRegreso_Click);
            // 
            // MateriaPrima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1018, 476);
            this.Controls.Add(this.contenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MateriaPrima";
            this.Text = "2";
            this.Load += new System.EventHandler(this.MateriaPrima_Load);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel top;
        private System.Windows.Forms.Label txtVentas;
        private System.Windows.Forms.Button btrRegreso;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Button SaveEdit;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.TextBox ID;
        public System.Windows.Forms.TextBox txtEstado;
        public System.Windows.Forms.TextBox txtSat;
        public System.Windows.Forms.TextBox txtFraccion;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.TextBox txtUniMedAduana;
        public System.Windows.Forms.TextBox txtCanAduana;
        public System.Windows.Forms.TextBox txtPrecio;
        public System.Windows.Forms.TextBox txtIva;
        public System.Windows.Forms.TextBox txtPorcentaje;
        public System.Windows.Forms.TextBox txtUniMedida;
        public System.Windows.Forms.TextBox txtDescripcion;
        public System.Windows.Forms.TextBox txtCantiAdquirida;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.PictureBox FotoProduc;
        public System.Windows.Forms.TextBox mat;
    }
}