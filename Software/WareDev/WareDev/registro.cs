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
using Common.cache;
using Domain; 



namespace WareDev
{
    public partial class registro : Form
    {
        CN_Clientes objetoCN = new CN_Clientes();
        UsersListcs obj = new UsersListcs();
        public registro()
        {
            InitializeComponent();
        }




       

       
        private void butrurn_Click(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {

        }

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void textKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        //AGREGAR FOTO 
        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Archivo JPG|*.jpg";
            if (file.ShowDialog() == DialogResult.OK)
                Fotouser.Image = Image.FromFile(file.FileName);

           
            
        }

        //CAMBIAR FOTO 
        private void button6_Click(object sender, EventArgs e)
        {

            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Archivo JPG|*.jpg";
            if (file.ShowDialog() == DialogResult.OK)
                Fotouser.Image = Image.FromFile(file.FileName);
        }

        private void registro_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            passconfirmtxt.Clear();
            passtxt.Clear();
            nametxt.Clear();
            usertxt.Clear();
            emailtxt.Clear();
            this.Close();
        }
        //guardar usuario
        private void button3_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    objetoCN.InsertarUsu(usertxt.Text, passtxt.Text, emailtxt.Text, nametxt.Text, lasttxt.Text);
            //    MessageBox.Show("Se ha agregado el usuario al sistema.");
            //    obj.MostrarUsuarios(); 
            //}catch(Exception ex)
            //{
            //    MessageBox.Show("No se pudo insertar los datos por: "+ex); 
            //}
        }

        private void User_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
