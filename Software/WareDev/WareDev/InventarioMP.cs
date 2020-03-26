using System;
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
    public partial class InventarioMP : Form
    {
        public InventarioMP(FormWindowState tam)
        {
            InitializeComponent();
            this.WindowState = tam;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.DoubleBuffered = true;
            if (this.WindowState == FormWindowState.Maximized)
            {
              
            }
            else
            {
                
            }
        }

        public InventarioMP()
        {
            InitializeComponent();
        }

        /*Libreria para general el efecto de movel con el mouse*/
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void btnexit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
        //restaurar
        private void btnrestaur_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnrestaur.Visible = false;
            btnmaximizar.Visible = true;
          
        }


        private void btnminimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnmaximizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnrestaur.Visible = true;
            btnmaximizar.Visible = false;
        }

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


       

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (menu.Width == 250) {
                menu.Width = 80;
                logo.Width = 70;
                panel1.Width = 1300;
               
            }
            else {
                menu.Width = 250;
                logo.Width = 250;
                panel1.Width = 1120;
                
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
            this.contenedor.Controls.Add(fh);
            this.contenedor.Tag = fh;
            fh.Show();

        }



        private void btnInicio_Click(object sender, EventArgs e)
        {

            
        }

        private void menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void top_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSupport_Click(object sender, EventArgs e)
        {

        }

        private void btnNombreUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new ModalUsuario());
            btnmaximizar.Visible = false;
            btnrestaur.Visible = false;
        }

        
        private void iconoMP_Click(object sender, EventArgs e)
        {

        }

       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        

       

        private void btnInven_Click(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings set = new Settings();
            set.ShowDialog();
        }

        

        private void btnuser_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new registro());
            btnmaximizar.Visible = false;
            btnrestaur.Visible = false;
            this.WindowState = FormWindowState.Normal;
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new InfoClient());
            btnmaximizar.Visible = true;
            btnrestaur.Visible = true;
        }
    }
}
