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
using System.Data.SqlClient;
using System.IO;

namespace WareDev
{
    public partial class Insumos : Form
    {
        public Insumos()
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

        private void Insumos_Load(object sender, EventArgs e)
        {
            //dateTimePicker1.Value = DateTime.Today;
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
            }catch(Exception ex)
            {
                MessageBox.Show("No se puede por "+ex);
            }
        }

        //guardar insumo
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if((this.txtUniMedInsu.Text.Length>=1)&&(this.txtCanAdqInsumos.Text.Length>=1) && (this.txtDesInsumo.Text.Length >= 1) && (this.txtNombreInsumo.Text.Length >= 1) && (this.txtPrecioInsumo.Text.Length >= 1) && (this.txtCostoTotalInsumo.Text.Length >= 1))
            {
                if (this.FotoProduc.Image != null)
                {
                    byte[] images = null;
                    FileStream Streem = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(Streem);
                    images = brs.ReadBytes((int)Streem.Length);

                    connection.Open();
                    string sqlQuery = "insert into inputs(date,unitOfMeasure,amountPurchased,description,name,unitPrice,total,photo) values(@fecha,'" +txtUniMedInsu.Text+ "','" +txtCanAdqInsumos.Text+ "','" + txtDesInsumo.Text + "','" + txtNombreInsumo.Text + "','" +txtPrecioInsumo.Text + "','" + txtCostoTotalInsumo.Text+ "',@images)";
                    cmd = new SqlCommand(sqlQuery, connection);
                    cmd.Parameters.Add(new SqlParameter("@images", images));
                    cmd.Parameters.AddWithValue("@fecha", dateTimePicker1.Value.Date);
                    int N = cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show(N.ToString() + "Se ha agregado la materia prima");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Agregue una imagen");
                }
            }
            else
            {
                MessageBox.Show("Ingrese todos los campos.");
            }
        }
        //guardar (editar inputs)
        private void SaveEditinputs_Click(object sender, EventArgs e)
        {
            if ((this.txtUniMedInsu.Text.Length >= 1) && (this.txtCanAdqInsumos.Text.Length >= 1) && (this.txtDesInsumo.Text.Length >= 1) && (this.txtNombreInsumo.Text.Length >= 1) && (this.txtPrecioInsumo.Text.Length >= 1) && (this.txtCostoTotalInsumo.Text.Length >= 1))
            {
                if (this.FotoProduc.Image != null)
                {
                    byte[] byteArrayImagen = ImageToByteArray(FotoProduc.Image);
                    connection.Open();
                    string sqlQuery = "update inputs set date=@fecha,unitOfMeasure='" + txtUniMedInsu.Text + "',amountPurchased='" + txtCanAdqInsumos.Text + "',description='" + txtDesInsumo.Text + "',name='" + txtNombreInsumo.Text + "',unitPrice='" + txtPrecioInsumo.Text + "',total='" + txtCostoTotalInsumo.Text + "',photo=@imagen where Id='" + IDinputs.Text + "'";

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
                    MessageBox.Show("Agregue una imagen"); 
                }
            }
            else
            {
                MessageBox.Show("Ingrese todos los campos.");
            }
        }

        private void txtCostoTotalInsumo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCostoTotalInsumo_Leave(object sender, EventArgs e)
        {
            int n1, n2, r;
            n1 = Convert.ToInt32(txtCanAdqInsumos.Text);
            n2 = Convert.ToInt32(txtPrecioInsumo.Text);
            r = n1 * n2;
            txtCostoTotalInsumo.Text = r.ToString(); 
        }

        private void mult_Click(object sender, EventArgs e)
        {
            int n1, n2, r;
            n1 = Convert.ToInt32(txtCanAdqInsumos.Text);
            n2 = Convert.ToInt32(txtPrecioInsumo.Text);
            r = n1 * n2;
            txtCostoTotalInsumo.Text = r.ToString();
        }

        private void txtPrecioInsumo_Enter(object sender, EventArgs e)
        {
            int n1, n2, r;
                n1 = Convert.ToInt32(txtCanAdqInsumos.Text);
            n2 = Convert.ToInt32(txtPrecioInsumo.Text);
            r = n1 * n2;
            txtCostoTotalInsumo.Text = r.ToString();
        }
    }
    
}
