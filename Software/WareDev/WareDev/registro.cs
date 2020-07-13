using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
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
        //SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-SDO1671B;Initial Catalog=users;Integrated Security=True;Pooling=False");
        //SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jessica\Documents\fruteria.mdf;Integrated Security=True;Connect Timeout=30");
        // karina
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = C:\Users\William carmona\Documents\users.mdf;Integrated Security = True");
        string imgLocation = "";
        SqlCommand cmd;
        public byte[] ImageToByteArray(System.Drawing.Image imagen)
        {
            MemoryStream ms = new MemoryStream();

            imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
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
            try
            {
                OpenFileDialog file = new OpenFileDialog();
                file.Filter = "Archivo JPG|*.jpg";
                if (file.ShowDialog() == DialogResult.OK)
                {
                    imgLocation = file.FileName.ToString();
                    Fotouser.Image = Image.FromFile(file.FileName);
                }
            } catch (Exception ex)
            {
                MessageBox.Show("No se puede por:" + ex);
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
                if ((this.usertxt.Text.Length >= 1) && (this.passtxt.Text.Length >= 1) && (this.nametxt.Text.Length >= 1) && (this.emailtxt.Text.Length >= 1) && (this.lasttxt.Text.Length >= 1))
                {
                    if (this.Fotouser.Image != null)
                    {
                        byte[] images = null;
                        FileStream Streem = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                        BinaryReader brs = new BinaryReader(Streem);
                        images = brs.ReadBytes((int)Streem.Length);

                        connection.Open();
                        string sqlQuery = "insert into data(username, password, email, firstName, lastName, imagen)values('" + usertxt.Text + "', '" + passtxt.Text + "', '" + emailtxt.Text + "', '" + nametxt.Text + "', '" + lasttxt.Text + "',@images)";
                        cmd = new SqlCommand(sqlQuery, connection);
                        //cmd.Parameters.Add("@imagen", byteArrayImagen);
                        cmd.Parameters.Add(new SqlParameter("@images", images));
                        int N = cmd.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Se ha agregado el usuario al sistema.");
                        this.Close();
                    } else
                    {
                        MessageBox.Show("Agregue una imagen.");
                    }
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
        //editar usuario
        private void saveEdit_Click(object sender, EventArgs e)
        {
            if (this.passtxt.Text.Equals(this.passconfirmtxt.Text))
            {
                if ((this.usertxt.Text.Length >= 1) && (this.passtxt.Text.Length >= 1) && (this.nametxt.Text.Length >= 1) && (this.emailtxt.Text.Length >= 1) && (this.lasttxt.Text.Length >= 1))
                {
                    if (this.Fotouser.Image != null)
                    {


                        byte[] byteArrayImagen = ImageToByteArray(Fotouser.Image);

                        connection.Open();
                        string sqlQuery = "update data set username='" + usertxt.Text + "', password='" + passtxt.Text + "',email='" + emailtxt.Text + "',firstName='" + nametxt.Text + "',lastName='" + lasttxt.Text + "',imagen=@imagen where Id = '" + ID.Text + "'";

                        cmd = new SqlCommand(sqlQuery, connection);
                        cmd.Parameters.Add("@imagen", byteArrayImagen);
                       
                        int N = cmd.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show(N.ToString() + "Se ha editado correctamente.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Agregue una imagen.");
                    }
                }
                else
                {
                    MessageBox.Show("Complete todos los campos.");
                }
            }
            else{
                    MessageBox.Show("Las contraseñas no son iguales, vuelva a intentar.");
            }
        }
        int posX;
        int posY;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }
    }
} 

