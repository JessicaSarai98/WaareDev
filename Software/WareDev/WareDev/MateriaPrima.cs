using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Data.SqlClient; 

namespace WareDev
{
    public partial class MateriaPrima : Form
    {
        public MateriaPrima()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-SDO1671B;Initial Catalog=users;Integrated Security=True;Pooling=False");
        string imgLocation = "";
        SqlCommand cmd; 

        public byte[] ImageToByteArray(System.Drawing.Image imagen)
        {
            MemoryStream ms = new MemoryStream();
            imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray(); 
        }

        /*Libreria para general el efecto de movel con el mouse*/
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

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

        private void MateriaPrima_Load_1(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today;
            
        }

        //Guardar materia prima
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if ((this.txtNombre.Text.Length>=1) && (this.txtUniMedAduana.Text.Length>=1)&& (this.txtUniMedida.Text.Length>= 1) && (this.txtDescripcion.Text.Length>= 1) && (this.txtIva.Text.Length>= 1) && (this.txtSat.Text.Length>= 1) && (this.txtFraccion.Text.Length>= 1) && 
                (this.txtEstado.Text.Length>= 1) && (this.txtPorcentaje.Text.Length>= 1) && (this.txtCantiAdquirida.Text.Length>= 1) && (this.txtCanAduana.Text.Length>= 1) && (this.txtPrecio.Text.Length>= 1))
            {
                if (this.FotoProduc.Image != null)
                {
                    byte[] images = null;
                    FileStream Streem = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(Streem); 
                    images = brs.ReadBytes((int)Streem.Length);

                    connection.Open();
                    string sqlQuery = "insert into rawMaterials(name, date,customsUnitOfMeasure,unitOfMeasure,description,IVA,SAT,tariffFraction,status, percentage,amountPurchased,customsAmount,price,photo) values('"+txtNombre.Text+ "',@fecha,'"+txtUniMedAduana.Text+ "','"+txtUniMedida.Text+ "','"+txtDescripcion.Text+ "','"+txtIva.Text+ "','"+txtSat.Text+ "','"+txtFraccion.Text+ "','"+txtEstado.Text+ "','"+txtPorcentaje.Text+ "','"+txtCantiAdquirida.Text+ "','"+txtCanAduana.Text+ "','"+txtPrecio.Text+"',@images)";
                    cmd = new SqlCommand(sqlQuery, connection);
                    cmd.Parameters.Add(new SqlParameter("@images",images));
                    cmd.Parameters.AddWithValue("@fecha", dateTimePicker1.Value.Date);
                    int N = cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show(N.ToString()+"Se ha agregado la materia prima");
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
    }
}
