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
    public partial class ModalUsuario : Form
    {
        public ModalUsuario()
        {
            InitializeComponent();
           
        }
        
        /*Libreria para general el efecto de movel con el mouse*/
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void perfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuInicio inv = new MenuInicio();
            inv.Hide();
            registro re = new registro();
            re.Show();
        }

        private void CerrarSesion_Click(object sender, EventArgs e)
        {
            var tam = this.WindowState;
            MenuInicio inv = new MenuInicio(tam);
            inv.Visible = false;
            inv.Hide();
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void fotouser_Click(object sender, EventArgs e)
        {

        }
    }
}
