using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;


namespace WareDev
{
    public partial class ProductoExistente : Form
    {
        string imgLocation = "";
        public ProductoExistente()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jessica\Documents\fruteria.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;


        private void btrRegreso_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public byte[] ImageToByteArray(System.Drawing.Image imagen)
        {
            MemoryStream ms = new MemoryStream();
            imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        private void ProductoExistente_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today;

            string query = "select max(Id) from FinishedProducts";
            SqlCommand cmd1 = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                string pcount = Convert.ToString(cmd1.ExecuteScalar());
                if(pcount.Length == 0)
                {
                    txtCodigo.Text = "1";
                }
                else
                {
                    int pcount1 = Convert.ToInt32(pcount);
                    int pcountAdd = pcount1 + 1;
                    txtCodigo.Text = pcountAdd.ToString(); 
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Mensaje",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally {
                connection.Close(); 
            }
        }

        private void SaveEdit_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    byte[] images = null;
            //    FileStream Streem = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            //    BinaryReader brs = new BinaryReader(Streem);
            //    images = brs.ReadBytes((int)Streem.Length);

            //    connection.Open();
            //    string sqlQuery = "insert into FinishedProducts(Id, date, unitOfMeasure, input, quantityUsedI, amountPurchased, name, unitPrice, description, rawMaterial, quantityUsedR, photo, size, measure, fin, cantAduana, IVA, status, SAT, fraccion, medidaAduana) values('" + txtCodigo.Text + "',@fecha, '" + txtUniMedida.Text + "','"+textBox3.Text+"','"+textBox3.Text+"','" + txtCantiAdquirida.Text + "','" + txtNombre.Text + "','" + txtPrecio.Text + "','" + txtDescripcion.Text + "','"+textBox3.Text+"','"+textBox3.Text+"',@images,'" + textBox1.Text + "','" + textBox2.Text + "','" + mat.Text + "','" + txtCanAduana.Text + "','" + txtIVA.Text + "','" + txtEstado.Text + "','" + txtSAT.Text + "','" + txtFraccion.Text + "','" + txtUniMedAduana.Text + "')";
            //    cmd = new SqlCommand(sqlQuery, connection);

            //    cmd.Parameters.Add(new SqlParameter("@images", images));
            //    cmd.Parameters.AddWithValue("@fecha", dateTimePicker1.Value.Date);
            //    cmd.ExecuteNonQuery();
            //    connection.Close();
            //    MessageBox.Show("Se ha agregado el producto");
            //    this.Close();
            //}catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Archivo JPG|*.jpg";
            if (file.ShowDialog() == DialogResult.OK)
            {
                imgLocation = file.FileName.ToString();
                FotoProduc.Image = Image.FromFile(file.FileName);
            }
            FotoProduc.Visible = true;
        }
        int posY = 0;
        int posX = 0;
        private void top_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button != MouseButtons.Left)
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

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.NumerosDecimales(e);
        }

        private void txtCantiAdquirida_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.SoloNumeros(e);
        }

        private void txtIVA_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.NumerosDecimales(e);
        }

        private void txtSAT_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.SoloNumeros(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.SoloNumeros(e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if ((this.txtCodigo.Text.Length >= 1) && (this.txtNombre.Text.Length >= 1) && (this.txtSAT.Text.Length >= 1) && (this.txtUniMedida.Text.Length >= 1) && (this.txtFraccion.Text.Length >= 1) && (this.txtCanAduana.Text.Length >= 1) && (this.txtUniMedAduana.Text.Length >= 1) && (this.txtEstado.Text.Length >= 1) && (this.txtPrecio.Text.Length >= 1) && (this.txtCantiAdquirida.Text.Length >= 1) && (this.txtIVA.Text.Length >= 1) && (this.textBox1.Text.Length >= 1) && (this.textBox2.Text.Length >= 1)) {
                if (this.FotoProduc.Image != null)
                {
                    byte[] images = null;
                    FileStream Streem = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(Streem);
                    images = brs.ReadBytes((int)Streem.Length);

                    connection.Open();
                    string sqlQuery = "insert into FinishedProducts(Id, date, unitOfMeasure, input, quantityUsedI, amountPurchased, name, unitPrice, description, rawMaterial, quantityUsedR, photo, size, measure, fin, cantAduana, IVA, status, SAT, fraccion, medidaAduana) values('" + txtCodigo.Text + "',@fecha, '" + txtUniMedida.Text + "','" + textBox3.Text + "','" + textBox3.Text + "','" + txtCantiAdquirida.Text + "','" + txtNombre.Text + "','" + txtPrecio.Text + "','" + txtDescripcion.Text + "','" + textBox3.Text + "','" + textBox3.Text + "',@images,'" + textBox1.Text + "','" + textBox2.Text + "','" + mat.Text + "','" + txtCanAduana.Text + "','" + txtIVA.Text + "','" + txtEstado.Text + "','" + txtSAT.Text + "','" + txtFraccion.Text + "','" + txtUniMedAduana.Text + "')";
                    cmd = new SqlCommand(sqlQuery, connection);

                    cmd.Parameters.Add(new SqlParameter("@images", images));
                    cmd.Parameters.AddWithValue("@fecha", dateTimePicker1.Value.Date);

                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Se ha agregado el producto");
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
    }
}
