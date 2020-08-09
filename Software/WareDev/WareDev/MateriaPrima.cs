using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace WareDev
{
    public partial class MateriaPrima : Form
    {
        public MateriaPrima()
        {
            InitializeComponent();
        }
        //SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-SDO1671B;Initial Catalog=users;Integrated Security=True;Pooling=False");
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jessica\Documents\fruteria.mdf;Integrated Security=True;Connect Timeout=30");
        //karina
       //SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = C:\Users\William carmona\Documents\users.mdf;Integrated Security = True");
        string imgLocation = "";
        SqlCommand cmd; 

        public byte[] ImageToByteArray(System.Drawing.Image imagen)
        {
            MemoryStream ms = new MemoryStream();
            imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray(); 
        }

       
        private void btrRegreso_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog file = new OpenFileDialog();
                file.Filter = "Archivo JPG|*.jpg";
                if (file.ShowDialog() == DialogResult.OK)
                {
                    imgLocation = file.FileName.ToString(); 
                    FotoProduc.Image = Image.FromFile(file.FileName);
                }
                FotoProduc.Visible = true;
            } catch (Exception ex)
            {
                MessageBox.Show("No se puede por: "+ ex); 
            }
        }
        //Guardar materia prima
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if ((this.txtNombre.Text.Length>=1) && (this.txtUniMedAduana.Text.Length>=1)&& (this.txtUniMedida.Text.Length>= 1) && (this.txtDescripcion.Text.Length>= 1) && (this.txtSat.Text.Length>= 1) && (this.txtFraccion.Text.Length>= 1) && 
                (this.txtEstado.Text.Length>= 1)  && (this.txtCantiAdquirida.Text.Length>= 1) && (this.txtCanAduana.Text.Length>= 1) && (this.txtPrecio.Text.Length>= 1))
            {
                if (this.FotoProduc.Image != null)
                {
                    byte[] images = null;
                    FileStream Streem = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(Streem); 
                    images = brs.ReadBytes((int)Streem.Length);

                    connection.Open();
                    string sqlQuery = "insert into rawMaterials(name, date,customsUnitOfMeasure,unitOfMeasure,description,arrancel, SAT,status,amountPurchased,customsAmount,price,photo,mat) " +
                        "values('"+txtNombre.Text+ "',@fecha,'"+txtUniMedAduana.SelectedItem+ "','"+txtUniMedida.SelectedItem+ "','"+txtDescripcion.Text+ "','"+txtFraccion.Text+"','"+txtSat.Text+ "','"+txtEstado.Text+"','"+txtCantiAdquirida.Text+ 
                        "','"+txtCanAduana.Text+ "','"+txtPrecio.Text+"',@images, '"+mat.Text+"')";
                    cmd = new SqlCommand(sqlQuery, connection);
                    cmd.Parameters.Add(new SqlParameter("@images",images));
                    cmd.Parameters.AddWithValue("@fecha", dateTimePicker1.Value.Date);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Se ha agregado la materia prima");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Agregue una imagen."); 
                }

            }
            else
            {
                MessageBox.Show("Ingrese todos los campos."); 
            }
        }

        private void SaveEdit_Click(object sender, EventArgs e)
        {
            if ((this.txtNombre.Text.Length >= 1) && (this.txtUniMedAduana.Text.Length >= 1) && (this.txtUniMedida.Text.Length >= 1) && (this.txtDescripcion.Text.Length >= 1) && (this.txtSat.Text.Length >= 1) && (this.txtFraccion.Text.Length >= 1) &&
                (this.txtEstado.Text.Length >= 1) && (this.txtCantiAdquirida.Text.Length >= 1) && (this.txtCanAduana.Text.Length >= 1) && (this.txtPrecio.Text.Length >= 1))
            {

                byte[] byteArrayImagen = ImageToByteArray(FotoProduc.Image);
                connection.Open();
                string sqlQuery = "update rawMaterials set name='" + txtNombre.Text + "',date=@fecha,customsUnitOfMeasure='" + txtUniMedAduana.Text + "',unitOfMeasure='" + txtUniMedida.Text + "',description='" + txtDescripcion.Text +  "',arrancel= '"+txtFraccion.Text+"',SAT='" + txtSat.Text + "',status='" + txtEstado.Text + "',amountPurchased='" + txtCantiAdquirida.Text + "',customsAmount='" + txtCanAduana.Text + "',price='" + txtPrecio.Text + "',photo=@imagen where Id='" + ID.Text + "'";

                cmd = new SqlCommand(sqlQuery, connection);
                cmd.Parameters.AddWithValue("@fecha", dateTimePicker1.Value.Date);
                cmd.Parameters.Add("@imagen", byteArrayImagen);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Se ha editado correctamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ingrese todos los campos.");
            }
        }

        private void MateriaPrima_Load(object sender, EventArgs e)
        {
            //dateTimePicker1.Value = DateTime.Today;
        }
        //float
        Regex rx = new Regex(@"^[0-9]+\.[0-9]{2}?", RegexOptions.Compiled | RegexOptions.IgnoreCase);
       
        private void txtSat_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.SoloNumeros(e);
        }

        private void txtFraccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.SoloNumeros(e);
        }

        private void txtPorcentaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.NumerosDecimales(e);
        }

        private void txtCantiAdquirida_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.SoloNumeros(e);
        }

        private void txtCanAduana_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.SoloNumeros(e);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.NumerosDecimales(e);
        }

        private void tablaFacVentas_Paint(object sender, PaintEventArgs e)
        {

        }
        int posX;
        int posY;
        private void top_MouseMove(object sender, MouseEventArgs e)
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
