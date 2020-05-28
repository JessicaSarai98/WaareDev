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
using System.Data.SqlClient;
using Domain;
using Common.cache;

namespace WareDev
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }

        /*Libreria para general el efecto de movel con el mouse*/
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            registro reg = new registro();
            this.Hide();
            reg.Show();

        }

        private void btnmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }

        private void btnrestaur_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;

        }
        //olvido contraseña
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            olvidoContra contra = new olvidoContra();
            contra.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //NO MUEVAN NADA DE AQUI PLOX o los mato :)


            //if (textUser.Text != "username" && textUser.TextLength > 0)
            //{
            //    if (textKey.Text != "password")
            //    {
            //        UserModel user = new UserModel();
            //        var validLogin = user.LoginUser(textUser.Text, textKey.Text);
            //        if (validLogin == true)
            //        {
            //            //MessageBox.Show("Bienvenido" + UserCache.firstName + "," + UserCache.lastName);

            //            var tam = this.WindowState;
            //            MenuInicio ini = new MenuInicio(tam);
            //            ini.name.Text = ""+UserCache.firstName; 
            //            ini.Show();
            //            this.Hide();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Invalid username or password");
            //            //textKey.Text = "Password";
            //            textKey.UseSystemPasswordChar = false;
            //            textUser.Focus();

            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Please enter password");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Please enter the username");
            //}





            ////cuando no este en comentarios lo anterior, comentar las siguientes lineas.
            this.Hide();
            var tam = this.WindowState;
            MenuInicio ini = new MenuInicio(tam);
            //MessageBox.Show("Bienvenido: " + textUser.Text + ".");
            ini.Show();
        }


    


            private void titulo2_MouseDown(object sender, MouseEventArgs e)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }

            private void titulo_MouseDown(object sender, MouseEventArgs e)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }

            private void btnexit_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }

            private void btnminimizar_Click(object sender, EventArgs e)
            {
                this.WindowState = FormWindowState.Minimized;
            }
    }
    
}


