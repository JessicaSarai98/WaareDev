﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WareDev
{
    public partial class MenuInicio : Form
    {
        private Button currentButton;
        public MenuInicio(FormWindowState tam)
        {
            InitializeComponent();
            this.WindowState = tam;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%)
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }
        public MenuInicio()
        {
            InitializeComponent();
        }

       

        /*Libreria para general el efecto de movel con el mouse*/
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(109, 252, 51);
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Tai Le", 15.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in menu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(91, 210, 43);
                    previousBtn.ForeColor = SystemColors.ControlLightLight;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        //Funcion para crear Forms hijos 
        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.contenedor.Controls.Count > 0)
                this.contenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            fh.FormBorderStyle = FormBorderStyle.None;
            this.contenedor.Controls.Add(fh);
            this.contenedor.Tag = fh;
            fh.BringToFront();
            fh.Show();

        }

        private void btnuser_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            AbrirFormInPanel(new registro());
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            AbrirFormInPanel(new InfoClient());
            
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings set = new Settings();
            set.ShowDialog();
        }

        private void btnNombreUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new ModalUsuario());
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (menu.Width == 250)
            {
                menu.Width = 80;
                btnInicio.Text = " ";
                btnInven.Text = " ";
                btnCotizar.Text = " ";
                btnReportes.Text = " ";
                btnuser.Text = " ";
                btnClient.Text = " ";
                btnProve.Text = " ";
            }
            else
            {
                menu.Width = 250;
                btnInicio.Text = "Start";
                btnInven.Text = "Inventary";
                btnCotizar.Text = "Quotations";
                btnReportes.Text = "Reports";
                btnuser.Text = "Users";
                btnClient.Text = "Customers";
                btnProve.Text = "Suppliers";
            }
        }

        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.contenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(55, 61, 69));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }
        int LX;
        int LY;

        private void btnmaximizar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            LX = this.Location.X;
            LY = this.Location.Y;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnrestaur.Visible = true;
            btnmaximizar.Visible = false;
        }

        private void btnrestaur_Click_1(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            this.Size = new Size(1300,690);
            this.Location = new Point(LX,LY);
            btnrestaur.Visible = false;
            btnmaximizar.Visible = true;
            
        }

       

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnProve_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnInven_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void top_Paint_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        //METODO PARA HORA Y FECHA ACTUAL ----------------------------------------------------------
        private void timer1_Tick(object sender, EventArgs e)
        {
            hora.Text = DateTime.Now.ToString("hh:mm:ss ");
            fecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}