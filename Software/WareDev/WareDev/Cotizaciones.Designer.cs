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
            this.button6 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txt1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.Customer = new System.Windows.Forms.TextBox();
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
            this.TablaDeVenta = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cajasPorContenido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.label1.Size = new System.Drawing.Size(156, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "Quotations";
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(968, 318);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(134, 56);
            this.button5.TabIndex = 47;
            this.button5.Text = "Cancel ";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.UseWaitCursor = true;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(968, 177);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(134, 56);
            this.button6.TabIndex = 44;
            this.button6.Text = "Generar ";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.UseWaitCursor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
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
            this.tableLayoutPanel1.Controls.Add(this.Customer, 5, 0);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(31, 94);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(908, 114);
            this.tableLayoutPanel1.TabIndex = 48;
            // 
            // txt1
            // 
            this.txt1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt1.AutoSize = true;
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.Location = new System.Drawing.Point(11, 1);
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
            this.txtTotal.Location = new System.Drawing.Point(554, 79);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(151, 32);
            this.txtTotal.TabIndex = 21;
            // 
            // Customer
            // 
            this.Customer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Customer.BackColor = System.Drawing.Color.White;
            this.Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.Customer.Location = new System.Drawing.Point(554, 3);
            this.Customer.Multiline = true;
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(351, 32);
            this.Customer.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 48);
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
            this.label8.Location = new System.Drawing.Point(214, 1);
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
            this.txtNoCliente.Location = new System.Drawing.Point(322, 3);
            this.txtNoCliente.Multiline = true;
            this.txtNoCliente.Name = "txtNoCliente";
            this.txtNoCliente.Size = new System.Drawing.Size(123, 32);
            this.txtNoCliente.TabIndex = 16;
            this.txtNoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(452, 1);
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
            this.dateTimePicker1.Location = new System.Drawing.Point(75, 41);
            this.dateTimePicker1.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(127, 26);
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
            this.txtFolio.Location = new System.Drawing.Point(75, 3);
            this.txtFolio.Multiline = true;
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(127, 32);
            this.txtFolio.TabIndex = 13;
            this.txtFolio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(451, 83);
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
            this.label5.Location = new System.Drawing.Point(214, 45);
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
            this.comboMoneda.Location = new System.Drawing.Point(322, 41);
            this.comboMoneda.Name = "comboMoneda";
            this.comboMoneda.Size = new System.Drawing.Size(123, 28);
            this.comboMoneda.TabIndex = 20;
            this.comboMoneda.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(451, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 24);
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
            this.txtSubtotal.Location = new System.Drawing.Point(554, 41);
            this.txtSubtotal.Multiline = true;
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(351, 32);
            this.txtSubtotal.TabIndex = 17;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 24);
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
            this.txtIva.Location = new System.Drawing.Point(75, 79);
            this.txtIva.Multiline = true;
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(127, 32);
            this.txtIva.TabIndex = 18;
            this.txtIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.TablaDeVenta.Location = new System.Drawing.Point(29, 267);
            this.TablaDeVenta.Name = "TablaDeVenta";
            this.TablaDeVenta.RowHeadersWidth = 45;
            this.TablaDeVenta.Size = new System.Drawing.Size(908, 277);
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
            this.medida.HeaderText = "Measure";
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
            // Numero
            // 
            this.Numero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero.Location = new System.Drawing.Point(34, 223);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(66, 24);
            this.Numero.TabIndex = 50;
            this.Numero.Text = "No.";
            this.Numero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.textBox1.Location = new System.Drawing.Point(106, 220);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 32);
            this.textBox1.TabIndex = 51;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Cotizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1114, 571);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Numero);
            this.Controls.Add(this.TablaDeVenta);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label1);
            this.Name = "Cotizaciones";
            this.Text = "Cotizaciones";
            this.Load += new System.EventHandler(this.Cotizaciones_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaDeVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label txt1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox Customer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNoCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtFolio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboMoneda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.DataGridView TablaDeVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn tam;
        private System.Windows.Forms.DataGridViewTextBoxColumn medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cajasPorContenido;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe;
        private System.Windows.Forms.Label Numero;
        private System.Windows.Forms.TextBox textBox1;
    }
}