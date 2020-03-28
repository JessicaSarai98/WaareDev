namespace WareDev
{
    partial class MenuInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuInicio));
            this.menu = new System.Windows.Forms.Panel();
            this.top = new System.Windows.Forms.Panel();
            this.contenedor = new System.Windows.Forms.Panel();
            this.btnmaximizar = new System.Windows.Forms.PictureBox();
            this.btnrestaur = new System.Windows.Forms.PictureBox();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.btnNombreUsuario = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.btnSettings = new System.Windows.Forms.PictureBox();
            this.btnexit = new System.Windows.Forms.PictureBox();
            this.btnCotizar = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnInven = new System.Windows.Forms.Button();
            this.btnProve = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnuser = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menu.SuspendLayout();
            this.top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrestaur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnexit)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(210)))), ((int)(((byte)(43)))));
            this.menu.Controls.Add(this.btnCotizar);
            this.menu.Controls.Add(this.btnReportes);
            this.menu.Controls.Add(this.btnInven);
            this.menu.Controls.Add(this.btnProve);
            this.menu.Controls.Add(this.btnClient);
            this.menu.Controls.Add(this.btnuser);
            this.menu.Controls.Add(this.btnInicio);
            this.menu.Controls.Add(this.panel2);
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(250, 649);
            this.menu.TabIndex = 1;
            // 
            // top
            // 
            this.top.AutoScroll = true;
            this.top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(210)))), ((int)(((byte)(43)))));
            this.top.Controls.Add(this.btnmaximizar);
            this.top.Controls.Add(this.btnrestaur);
            this.top.Controls.Add(this.btnminimizar);
            this.top.Controls.Add(this.btnNombreUsuario);
            this.top.Controls.Add(this.btnMenu);
            this.top.Controls.Add(this.btnSettings);
            this.top.Controls.Add(this.btnexit);
            this.top.Dock = System.Windows.Forms.DockStyle.Top;
            this.top.Location = new System.Drawing.Point(250, 0);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(1034, 57);
            this.top.TabIndex = 4;
            this.top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.top_Paint_MouseDown);
            // 
            // contenedor
            // 
            this.contenedor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(250, 57);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1034, 592);
            this.contenedor.TabIndex = 5;
            // 
            // btnmaximizar
            // 
            this.btnmaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnmaximizar.Image")));
            this.btnmaximizar.Location = new System.Drawing.Point(952, 12);
            this.btnmaximizar.Name = "btnmaximizar";
            this.btnmaximizar.Size = new System.Drawing.Size(32, 32);
            this.btnmaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnmaximizar.TabIndex = 13;
            this.btnmaximizar.TabStop = false;
            this.btnmaximizar.Click += new System.EventHandler(this.btnmaximizar_Click);
            // 
            // btnrestaur
            // 
            this.btnrestaur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrestaur.Image = ((System.Drawing.Image)(resources.GetObject("btnrestaur.Image")));
            this.btnrestaur.Location = new System.Drawing.Point(952, 12);
            this.btnrestaur.Name = "btnrestaur";
            this.btnrestaur.Size = new System.Drawing.Size(32, 32);
            this.btnrestaur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnrestaur.TabIndex = 10;
            this.btnrestaur.TabStop = false;
            this.btnrestaur.Visible = false;
            this.btnrestaur.Click += new System.EventHandler(this.btnrestaur_Click_1);
            // 
            // btnminimizar
            // 
            this.btnminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnminimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnminimizar.Image")));
            this.btnminimizar.Location = new System.Drawing.Point(914, 12);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(32, 32);
            this.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnminimizar.TabIndex = 9;
            this.btnminimizar.TabStop = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // btnNombreUsuario
            // 
            this.btnNombreUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNombreUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnNombreUsuario.FlatAppearance.BorderSize = 0;
            this.btnNombreUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNombreUsuario.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNombreUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNombreUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnNombreUsuario.Image")));
            this.btnNombreUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNombreUsuario.Location = new System.Drawing.Point(524, 3);
            this.btnNombreUsuario.Name = "btnNombreUsuario";
            this.btnNombreUsuario.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNombreUsuario.Size = new System.Drawing.Size(250, 44);
            this.btnNombreUsuario.TabIndex = 12;
            this.btnNombreUsuario.Text = "Nombre del usuario";
            this.btnNombreUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNombreUsuario.UseVisualStyleBackColor = false;
            this.btnNombreUsuario.Click += new System.EventHandler(this.btnNombreUsuario_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(42, 57);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 12;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.Image = global::WareDev.Properties.Resources.settings;
            this.btnSettings.Location = new System.Drawing.Point(826, 4);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(47, 47);
            this.btnSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSettings.TabIndex = 6;
            this.btnSettings.TabStop = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnexit
            // 
            this.btnexit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnexit.Image = ((System.Drawing.Image)(resources.GetObject("btnexit.Image")));
            this.btnexit.InitialImage = null;
            this.btnexit.Location = new System.Drawing.Point(990, 12);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(32, 32);
            this.btnexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnexit.TabIndex = 7;
            this.btnexit.TabStop = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnCotizar
            // 
            this.btnCotizar.BackColor = System.Drawing.Color.Transparent;
            this.btnCotizar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCotizar.FlatAppearance.BorderSize = 0;
            this.btnCotizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCotizar.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCotizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCotizar.Image = ((System.Drawing.Image)(resources.GetObject("btnCotizar.Image")));
            this.btnCotizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCotizar.Location = new System.Drawing.Point(0, 556);
            this.btnCotizar.Name = "btnCotizar";
            this.btnCotizar.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnCotizar.Size = new System.Drawing.Size(250, 60);
            this.btnCotizar.TabIndex = 19;
            this.btnCotizar.Text = "Quotations";
            this.btnCotizar.UseVisualStyleBackColor = false;
            this.btnCotizar.Click += new System.EventHandler(this.btnCotizar_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.Transparent;
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnReportes.Image")));
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(0, 496);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnReportes.Size = new System.Drawing.Size(250, 60);
            this.btnReportes.TabIndex = 18;
            this.btnReportes.Text = "Reports";
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnInven
            // 
            this.btnInven.BackColor = System.Drawing.Color.Transparent;
            this.btnInven.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInven.FlatAppearance.BorderSize = 0;
            this.btnInven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInven.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInven.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInven.Image = ((System.Drawing.Image)(resources.GetObject("btnInven.Image")));
            this.btnInven.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInven.Location = new System.Drawing.Point(0, 436);
            this.btnInven.Name = "btnInven";
            this.btnInven.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnInven.Size = new System.Drawing.Size(250, 60);
            this.btnInven.TabIndex = 17;
            this.btnInven.Text = "Inventory";
            this.btnInven.UseVisualStyleBackColor = false;
            this.btnInven.Click += new System.EventHandler(this.btnInven_Click);
            // 
            // btnProve
            // 
            this.btnProve.BackColor = System.Drawing.Color.Transparent;
            this.btnProve.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProve.FlatAppearance.BorderSize = 0;
            this.btnProve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProve.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProve.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProve.Image = ((System.Drawing.Image)(resources.GetObject("btnProve.Image")));
            this.btnProve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProve.Location = new System.Drawing.Point(0, 376);
            this.btnProve.Name = "btnProve";
            this.btnProve.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnProve.Size = new System.Drawing.Size(250, 60);
            this.btnProve.TabIndex = 16;
            this.btnProve.Text = "Suppliers";
            this.btnProve.UseVisualStyleBackColor = false;
            this.btnProve.Click += new System.EventHandler(this.btnProve_Click);
            // 
            // btnClient
            // 
            this.btnClient.BackColor = System.Drawing.Color.Transparent;
            this.btnClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClient.FlatAppearance.BorderSize = 0;
            this.btnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClient.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClient.Image = ((System.Drawing.Image)(resources.GetObject("btnClient.Image")));
            this.btnClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClient.Location = new System.Drawing.Point(0, 316);
            this.btnClient.Name = "btnClient";
            this.btnClient.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnClient.Size = new System.Drawing.Size(250, 60);
            this.btnClient.TabIndex = 15;
            this.btnClient.Text = "Customers";
            this.btnClient.UseVisualStyleBackColor = false;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnuser
            // 
            this.btnuser.BackColor = System.Drawing.Color.Transparent;
            this.btnuser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnuser.FlatAppearance.BorderSize = 0;
            this.btnuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnuser.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnuser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnuser.Image = ((System.Drawing.Image)(resources.GetObject("btnuser.Image")));
            this.btnuser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnuser.Location = new System.Drawing.Point(0, 256);
            this.btnuser.Name = "btnuser";
            this.btnuser.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnuser.Size = new System.Drawing.Size(250, 60);
            this.btnuser.TabIndex = 14;
            this.btnuser.Text = "Users";
            this.btnuser.UseVisualStyleBackColor = false;
            this.btnuser.Click += new System.EventHandler(this.btnuser_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(0, 196);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnInicio.Size = new System.Drawing.Size(250, 60);
            this.btnInicio.TabIndex = 13;
            this.btnInicio.Text = "Start";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::WareDev.Properties.Resources.Logo2;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 196);
            this.panel2.TabIndex = 12;
            // 
            // MenuInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 649);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.top);
            this.Controls.Add(this.menu);
            this.MinimumSize = new System.Drawing.Size(850, 500);
            this.Name = "MenuInicio";
            this.Text = "WareDev";
            this.menu.ResumeLayout(false);
            this.top.ResumeLayout(false);
            this.top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrestaur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnexit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Button btnCotizar;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnInven;
        private System.Windows.Forms.Button btnProve;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnuser;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel top;
        private System.Windows.Forms.PictureBox btnmaximizar;
        private System.Windows.Forms.PictureBox btnrestaur;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.Button btnNombreUsuario;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.PictureBox btnSettings;
        private System.Windows.Forms.PictureBox btnexit;
        private System.Windows.Forms.Panel contenedor;
    }
}