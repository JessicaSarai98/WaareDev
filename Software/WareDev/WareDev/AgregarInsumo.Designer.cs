﻿namespace WareDev
{
    partial class Agregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar));
            this.contenedor = new System.Windows.Forms.Panel();
            this.input = new System.Windows.Forms.TextBox();
            this.raw = new System.Windows.Forms.TextBox();
            this.addF = new System.Windows.Forms.Button();
            this.addI = new System.Windows.Forms.Button();
            this.addR = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.titulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rawN = new System.Windows.Forms.TextBox();
            this.inputN = new System.Windows.Forms.TextBox();
            this.rawC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputC = new System.Windows.Forms.TextBox();
            this.btrRegreso = new System.Windows.Forms.Button();
            this.contenedor.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contenedor
            // 
            this.contenedor.BackColor = System.Drawing.SystemColors.Control;
            this.contenedor.Controls.Add(this.input);
            this.contenedor.Controls.Add(this.raw);
            this.contenedor.Controls.Add(this.addF);
            this.contenedor.Controls.Add(this.addI);
            this.contenedor.Controls.Add(this.addR);
            this.contenedor.Controls.Add(this.textBox1);
            this.contenedor.Controls.Add(this.txtCantidad);
            this.contenedor.Controls.Add(this.titulo);
            this.contenedor.Controls.Add(this.panel1);
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 0);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(358, 252);
            this.contenedor.TabIndex = 0;
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(23, 192);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(32, 20);
            this.input.TabIndex = 52;
            this.input.Visible = false;
            // 
            // raw
            // 
            this.raw.Location = new System.Drawing.Point(61, 192);
            this.raw.Name = "raw";
            this.raw.Size = new System.Drawing.Size(33, 20);
            this.raw.TabIndex = 51;
            this.raw.Visible = false;
            // 
            // addF
            // 
            this.addF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addF.Location = new System.Drawing.Point(168, 202);
            this.addF.Name = "addF";
            this.addF.Size = new System.Drawing.Size(128, 23);
            this.addF.TabIndex = 50;
            this.addF.Text = "Guardar";
            this.addF.UseVisualStyleBackColor = true;
            this.addF.Click += new System.EventHandler(this.addF_Click);
            // 
            // addI
            // 
            this.addI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addI.Location = new System.Drawing.Point(168, 202);
            this.addI.Name = "addI";
            this.addI.Size = new System.Drawing.Size(125, 23);
            this.addI.TabIndex = 49;
            this.addI.Text = "Guardar";
            this.addI.UseVisualStyleBackColor = true;
            this.addI.Click += new System.EventHandler(this.addI_Click);
            // 
            // addR
            // 
            this.addR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addR.Location = new System.Drawing.Point(168, 202);
            this.addR.Name = "addR";
            this.addR.Size = new System.Drawing.Size(125, 23);
            this.addR.TabIndex = 48;
            this.addR.Text = "Guardar";
            this.addR.UseVisualStyleBackColor = true;
            this.addR.Click += new System.EventHandler(this.addR_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(302, 205);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(33, 20);
            this.textBox1.TabIndex = 47;
            this.textBox1.Visible = false;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCantidad.BackColor = System.Drawing.Color.White;
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F);
            this.txtCantidad.Location = new System.Drawing.Point(51, 152);
            this.txtCantidad.Multiline = true;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(261, 50);
            this.txtCantidad.TabIndex = 46;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress_1);
            // 
            // titulo
            // 
            this.titulo.BackColor = System.Drawing.SystemColors.Control;
            this.titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.titulo.Location = new System.Drawing.Point(0, 80);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(358, 40);
            this.titulo.TabIndex = 1;
            this.titulo.Text = "titulo";
            this.titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titulo.Click += new System.EventHandler(this.titulo_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rawN);
            this.panel1.Controls.Add(this.inputN);
            this.panel1.Controls.Add(this.rawC);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.inputC);
            this.panel1.Controls.Add(this.btrRegreso);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 80);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // rawN
            // 
            this.rawN.Location = new System.Drawing.Point(39, 48);
            this.rawN.Name = "rawN";
            this.rawN.Size = new System.Drawing.Size(30, 20);
            this.rawN.TabIndex = 58;
            this.rawN.Visible = false;
            // 
            // inputN
            // 
            this.inputN.Location = new System.Drawing.Point(39, 17);
            this.inputN.Name = "inputN";
            this.inputN.Size = new System.Drawing.Size(30, 20);
            this.inputN.TabIndex = 57;
            this.inputN.Visible = false;
            // 
            // rawC
            // 
            this.rawC.Location = new System.Drawing.Point(3, 48);
            this.rawC.Name = "rawC";
            this.rawC.Size = new System.Drawing.Size(30, 20);
            this.rawC.TabIndex = 56;
            this.rawC.Text = "0";
            this.rawC.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(88, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Añadir producto";
            // 
            // inputC
            // 
            this.inputC.Location = new System.Drawing.Point(3, 17);
            this.inputC.Name = "inputC";
            this.inputC.Size = new System.Drawing.Size(30, 20);
            this.inputC.TabIndex = 55;
            this.inputC.Text = "0";
            this.inputC.Visible = false;
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
            this.btrRegreso.Location = new System.Drawing.Point(251, 3);
            this.btrRegreso.Name = "btrRegreso";
            this.btrRegreso.Size = new System.Drawing.Size(104, 65);
            this.btrRegreso.TabIndex = 14;
            this.btrRegreso.Text = "Regresar";
            this.btrRegreso.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btrRegreso.UseVisualStyleBackColor = false;
            this.btrRegreso.Click += new System.EventHandler(this.btrRegreso_Click);
            // 
            // Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(358, 252);
            this.Controls.Add(this.contenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Agregar";
            this.Text = "AgregarInsumo";
            this.Load += new System.EventHandler(this.AgregarInsumo_Load);
            this.contenedor.ResumeLayout(false);
            this.contenedor.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Button btrRegreso;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label titulo;
        private System.Windows.Forms.TextBox txtCantidad;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button addF;
        public System.Windows.Forms.Button addI;
        public System.Windows.Forms.Button addR;
        public System.Windows.Forms.TextBox input;
        public System.Windows.Forms.TextBox raw;
        public System.Windows.Forms.TextBox rawC;
        public System.Windows.Forms.TextBox inputC;
        public System.Windows.Forms.TextBox rawN;
        public System.Windows.Forms.TextBox inputN;
    }
}