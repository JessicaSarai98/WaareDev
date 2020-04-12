namespace WareDev
{
    partial class ModalUsuario
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
            this.CerrarSesion = new System.Windows.Forms.Button();
            this.perfil = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.usuario = new System.Windows.Forms.Panel();
            this.fotouser = new System.Windows.Forms.PictureBox();
            this.NombreUsuario = new System.Windows.Forms.Label();
            this.usuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotouser)).BeginInit();
            this.SuspendLayout();
            // 
            // CerrarSesion
            // 
            this.CerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CerrarSesion.BackColor = System.Drawing.Color.Silver;
            this.CerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CerrarSesion.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CerrarSesion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CerrarSesion.Location = new System.Drawing.Point(337, 277);
            this.CerrarSesion.Name = "CerrarSesion";
            this.CerrarSesion.Size = new System.Drawing.Size(145, 64);
            this.CerrarSesion.TabIndex = 0;
            this.CerrarSesion.Text = "Logout";
            this.CerrarSesion.UseVisualStyleBackColor = false;
            this.CerrarSesion.Click += new System.EventHandler(this.CerrarSesion_Click);
            // 
            // perfil
            // 
            this.perfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.perfil.BackColor = System.Drawing.Color.Silver;
            this.perfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.perfil.FlatAppearance.BorderSize = 0;
            this.perfil.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perfil.ForeColor = System.Drawing.SystemColors.ControlText;
            this.perfil.Location = new System.Drawing.Point(109, 277);
            this.perfil.Name = "perfil";
            this.perfil.Size = new System.Drawing.Size(144, 64);
            this.perfil.TabIndex = 0;
            this.perfil.Text = "Perfil";
            this.perfil.UseVisualStyleBackColor = false;
            this.perfil.Click += new System.EventHandler(this.perfil_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(132)))), ((int)(((byte)(58)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 33);
            this.panel1.TabIndex = 1;
            // 
            // usuario
            // 
            this.usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(176)))), ((int)(((byte)(77)))));
            this.usuario.Controls.Add(this.fotouser);
            this.usuario.Controls.Add(this.perfil);
            this.usuario.Controls.Add(this.CerrarSesion);
            this.usuario.Controls.Add(this.NombreUsuario);
            this.usuario.Controls.Add(this.panel1);
            this.usuario.Location = new System.Drawing.Point(3, 2);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(568, 382);
            this.usuario.TabIndex = 0;
            // 
            // fotouser
            // 
            this.fotouser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fotouser.Location = new System.Drawing.Point(192, 49);
            this.fotouser.Name = "fotouser";
            this.fotouser.Size = new System.Drawing.Size(166, 142);
            this.fotouser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.fotouser.TabIndex = 3;
            this.fotouser.TabStop = false;
            this.fotouser.Click += new System.EventHandler(this.fotouser_Click);
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NombreUsuario.Font = new System.Drawing.Font("Microsoft Tai Le", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreUsuario.Location = new System.Drawing.Point(148, 218);
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.Size = new System.Drawing.Size(288, 26);
            this.NombreUsuario.TabIndex = 2;
            this.NombreUsuario.Text = "Inserte nombre del usuario";
            this.NombreUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModalUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 387);
            this.Controls.Add(this.usuario);
            this.Name = "ModalUsuario";
            this.Text = "Perfil";
            this.usuario.ResumeLayout(false);
            this.usuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotouser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CerrarSesion;
        private System.Windows.Forms.Button perfil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel usuario;
        private System.Windows.Forms.Label NombreUsuario;
        private System.Windows.Forms.PictureBox fotouser;
    }
}