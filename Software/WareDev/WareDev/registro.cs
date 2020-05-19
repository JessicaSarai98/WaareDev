using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Common.cache;
using Domain;
using System.Data.SqlClient;


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
        SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-SDO1671B;Initial Catalog=users;Integrated Security=True;Pooling=False");
        string imgLocation = "";
        SqlCommand cmd; 
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
            //OpenFileDialog fo = new OpenFileDialog();
            //DialogResult fs = fo.ShowDialog();
            //if (fs == DialogResult.OK)
            //{
            //    pictureBox1.Image = Image.FromFile(fo.FileName);
            //}
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Archivo JPG|*.jpg";
            if (file.ShowDialog() == DialogResult.OK)
            {
                imgLocation = file.FileName.ToString(); 
                Fotouser.Image = Image.FromFile(file.FileName);
            }


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
        //guardar usuario (Nuevo)
        private void button3_Click(object sender, EventArgs e)
        {
            if (this.passtxt.Text.Equals(this.passconfirmtxt.Text))
            {
                if (this.passtxt.Text.Equals(0) || this.usertxt.Text.Equals(0) || this.nametxt.Text.Equals(0) || this.lasttxt.Text.Equals(0) || pictureBox1.Equals(0))
                {


                    byte[] images = null;
                    FileStream Streem = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(Streem);
                    images = brs.ReadBytes((int)Streem.Length);

                    connection.Open();
                    string sqlQuery = "insert into data(username, password, email, firstName, lastName, imagen)values('" + usertxt.Text + "', '" + passtxt.Text + "', '" + emailtxt.Text + "', '" + nametxt.Text + "', '" + lasttxt.Text + "',@images)";
                    cmd = new SqlCommand(sqlQuery, connection);
                    cmd.Parameters.Add(new SqlParameter("@images", images));
                    int N = cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show(N.ToString() + "Se ha agregado el usuario al sistema.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Complete todos los campos.");
                }

            }
            else
            {
                MessageBox.Show("Las contraseñas no son iguales, vuelva a intentar.");
            }
        }

        private void User_Paint(object sender, PaintEventArgs e)
        {

        }

        //editar usuario
        private void saveEdit_Click(object sender, EventArgs e)
        {
            if (this.passtxt.Text.Equals(this.passconfirmtxt.Text))
            {
                


                //byte[] images = null;
                //FileStream Streem = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                //BinaryReader brs = new BinaryReader(Streem);
                //images = brs.ReadBytes((int)Streem.Length);


                connection.Open();
                string sqlQuery = "update data set username='" + usertxt.Text + "', password='" + passtxt.Text + "',email='" + emailtxt.Text + "',firstName='" + nametxt.Text + "',lastName='" + lasttxt.Text + "',imagen="+pictureBox1.Image+ " where Id = '"+ID.Text+ "'"; 
                    
                cmd = new SqlCommand(sqlQuery, connection);
                cmd.Parameters.Add("@imagen", SqlDbType.Image);
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                cmd.Parameters["@imagen"].Value = ms.GetBuffer(); 
                int N = cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show(N.ToString() + "Se ha editado correctamente.");
                this.Close();

                //"update data set username='" + username + "', password='" + pass + "',email='" + email + "',firstName='" + firstname + "'," +
                //"lastName='" + lastname + "',imagen=@imagen where Id='" + id + "'";
                //comando.CommandText = "insert into data values('" + username + "', '" + pass + "', '" + email + "', '" + firstname + "', '" + lastname + "','" + @foto + "')";

                //MemoryStream ms = new MemoryStream();
                //Fotouser.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                //try
                //{
                //    objetoCN.EditarUsu(usertxt.Text, passtxt.Text, emailtxt.Text, nametxt.Text, lasttxt.Text,ms.GetBuffer(), ID.Text);
                //    MessageBox.Show("Se ha editado correctamente.");
                //    this.Close(); 
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("No se pudo insertar los datos por: " + ex);
                //}
            }
            else
            {
                MessageBox.Show("Las contraseñas no son iguales, vuelva a intentar.");
            }
        }
    }
}
