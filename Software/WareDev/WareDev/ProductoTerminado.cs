using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace WareDev
{
    public partial class ProductoTerminado : Form
    {
        public ProductoTerminado()
        {
            InitializeComponent();
        }

        //JESS
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jessica\Documents\fruteria.mdf;Integrated Security=True;Connect Timeout=30");
        //karina
        //SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = C:\Users\William carmona\Documents\users.mdf;Integrated Security = True");
        string imgLocation = "";
        SqlCommand cmd;
        SqlCommand cmd2;
        SqlCommand cmd3;
        private int posX;
        private int posY;

        public byte[] ImageToByteArray(System.Drawing.Image imagen)
        {
            MemoryStream ms = new MemoryStream();
            imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
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

        private void btrRegreso_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductoTerminado_Load(object sender, EventArgs e)
        {
            //dateTimePicker1.Value = DateTime.Today;

            SqlCommand cm = new SqlCommand("select name from rawMaterials", connection);
            connection.Open();
            SqlDataReader registro = cm.ExecuteReader();
            while (registro.Read())
            {
                comboBox1.Items.Add(registro["name"].ToString());
            }
            connection.Close();

            SqlCommand c = new SqlCommand("select name from inputs",connection);
            connection.Open();
            SqlDataReader regi = c.ExecuteReader();
            while (regi.Read())
            {
                comboBox2.Items.Add(regi["name"].ToString());
            }
            connection.Close();

            txtCantidadInsumo.Enabled = false;

            txtCantiMatPrima.Enabled = false;
            string query = "select max(Id) from FinishedProducts";
            SqlCommand cmd1 = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                string pcount = Convert.ToString(cmd1.ExecuteScalar());
                if (pcount.Length == 0)
                {
                    txtCodigo.Text = "1";
                }
                else
                {
                    int pcount1 = Convert.ToInt32(pcount);
                    int pcountAdd = pcount1 + 1;
                    txtCodigo.Text = pcountAdd.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if ((this.txtFaccion.Text.Length >= 1) && (this.dateTimePicker1 != null) && 
                (this.txtSat.Text.Length >= 1) && (this.txtCajasContenido.Text.Length >= 1) &&
                (this.comboBox2.Text.Length >= 1) && (this.txtCantidadInsumo.Text.Length >= 1) && (this.txtCantiAdquirida.Text.Length >= 1) &&
                (this.txtNombreInsumo.Text.Length >= 1) && (this.txtPrecioInsumo.Text.Length >= 1) && (this.txtDescripcion.Text.Length >= 1) && (this.comboBox1.Text.Length >= 1) && (this.txtCantiMatPrima.Text.Length >= 1) &&(this.txtEstado.Text.Length >=1) &&(this.txtMeasure.Text.Length>=1))
            { 
                if (this.FotoProduc.Image != null)
                {

                        
                        byte[] images = null;
                        FileStream Streem = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                        BinaryReader brs = new BinaryReader(Streem);
                        images = brs.ReadBytes((int)Streem.Length);

                    

                        connection.Open();
                        string sqlQuery = "insert into FinishedProducts(Id,date,unitOfMeasure,input,quantityUsedI,amountPurchased,name,unitPrice,description,rawMaterial,quantityUsedR,photo,size,measure, fin, cantAduana, IVA, status, SAT, fraccion, medidaAduana ) values('"+txtCodigo.Text+"',@fecha,'" + txtMeasure.Text + "','" + comboBox2.Text + "','" + txtCantidadInsumo.Text + 
                        "','" + txtCantiAdquirida.Text + "','"+txtNombreInsumo.Text+"', '"+txtPrecioInsumo.Text+ "','"+txtDescripcion.Text+ "','"+comboBox1.Text+ "','"+txtCantiMatPrima.Text+ "',@images,'"+textBox1.Text+ "','"+textBox2.Text+ "','"+fin.Text+ "','"+txtCajasContenido.Text+ "','"+txtIva.Text+ "','"+txtEstado.Text+ "','"+txtSat.Text+"','"+txtFaccion.Text+ "','"+txtUniMedAduana.Text+"')";
                        string sqlQuery2 = "update rawMaterials set amountPurchased= amountPurchased - @cant where name='" + comboBox1.Text + "'";
                        string sqlQuery3 = "update inputs set amountPurchased= amountPurchased - @canti where name= '" + comboBox2.Text + "'";

                        cmd = new SqlCommand(sqlQuery, connection);
                        cmd2 = new SqlCommand(sqlQuery2, connection);
                        cmd3 = new SqlCommand(sqlQuery3, connection);

                        cmd2.Parameters.AddWithValue("@cant", txtCantiMatPrima.Text);
                        cmd.Parameters.Add(new SqlParameter("@images", images));
                        cmd.Parameters.AddWithValue("@fecha", dateTimePicker1.Value.Date);
                        cmd3.Parameters.AddWithValue("@canti", txtCantidadInsumo.Text);

                        cmd.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();
                        cmd3.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Se ha agregado el producto terminado");
                        this.Close();
                    
                    
                }
                else
                {
                    MessageBox.Show("Agregue una imagen");
                }
            }
            else
            {
                MessageBox.Show("Complete todos los campos");
            }
            
            
        }

        private void SaveEdit_Click(object sender, EventArgs e)
        {
            if ((this.txtFaccion.Text.Length >= 1) && (this.dateTimePicker1 != null) && (this.txtSat.Text.Length >= 1) && (this.txtCajasContenido.Text.Length >= 1) && 
                (this.comboBox2.Text.Length >= 1) && (this.txtCantidadInsumo.Text.Length >= 1) && (this.txtCantiAdquirida.Text.Length >= 1) && (this.txtNombreInsumo.Text.Length >= 1) && 
                (this.txtPrecioInsumo.Text.Length >= 1) && (this.txtDescripcion.Text.Length >= 1) && (this.comboBox1.Text.Length >= 1) && (this.txtCantiMatPrima.Text.Length >= 1) &&(this.txtEstado.Text.Length >= 1) &&(this.txtMeasure.Text.Length>=1))
            {

                byte[] byteArrayImagen = ImageToByteArray(FotoProduc.Image);
                connection.Open();

                //int n1, n2, r;
                //n1 = Convert.ToInt32(txtCantiMatPrima.Text);
                //n2 = Convert.ToInt32(existencia.Text);
                //r = n2 - n1;

                string sqlQuery = "update FinishedProducts set date=@fecha,unitOfMeasure='" + txtFaccion.Text + "',pallet='" + txtSat.Text + "',boxes='" + txtCajasContenido.Text + "',input='" 
                    + comboBox2.Text + "',quantityUsedI='" + txtCantidadInsumo.Text + "',amountPurchased='" + txtCantiAdquirida.Text + "',name='" + txtNombreInsumo.Text + "',unitPrice='" + txtPrecioInsumo.Text + 
                    "',description='" + txtDescripcion.Text + "',rawMaterial='" + comboBox1.Text + "',quantityUsedR='" + txtCantiMatPrima.Text + "', size = '"+txtEstado.Text+"', measure = '"+txtMeasure.Text+"',photo=@imagen where Id='" + ID.Text + "'";
               // string sqlQuery2 = "update rawMaterials set amountPurchased='"+r+ "' where Id='"+txtNombreMateria.Text+"'";
                cmd = new SqlCommand(sqlQuery, connection);
                //cmd2 = new SqlCommand(sqlQuery2, connection);

                cmd.Parameters.AddWithValue("@fecha", dateTimePicker1.Value.Date);
                cmd.Parameters.Add("@imagen", byteArrayImagen);

                //cmd2.ExecuteNonQuery(); 
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

        private void existencia_TextChanged(object sender, EventArgs e)
        {
            //if(existencia.Text != "" && txtCantiMatPrima.Text!="")
            //{
            //    if (Convert.ToDecimal(existencia.Text) < Convert.ToDecimal(txtCantiMatPrima.Text))
            //    {
            //        MessageBox.Show("Cantidad insuficiente.");
            //        txtCantiMatPrima.Text = string.Empty;
            //    }
            //}
        }

        //private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    SqlCommand d = new SqlCommand("select amountPurchased from inputs where name= '" + comboBox2.Text + "'", connection);
        //    //connection.Open();
        //    SqlDataReader r = d.ExecuteReader();
        //    while (r.Read())
        //    {
        //        exisI.Text = r["amountPurchased"].ToString();
        //    }
        //    //connection.Close();
        //    txtCantidadInsumo.Enabled = true;
        //}

        private void txtPallet_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.SoloNumeros(e);
        }

        private void txtCajasContenido_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.SoloNumeros(e);
        }

        private void txtCantidadInsumo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.SoloNumeros(e);
        }

        private void txtCantiAdquirida_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.SoloNumeros(e);
        }

        private void txtPrecioInsumo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.NumerosDecimales(e);
        }

        private void txtCantiMatPrima_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.SoloNumeros(e);
        }

        private void txtSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.NumerosDecimales(e);
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCantidadInsumo.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlCommand b = new SqlCommand("select amountPurchased from rawMaterials where name= '" + comboBox1.Text + "'", connection);
            connection.Open();
            SqlDataReader z = b.ExecuteReader();
            while (z.Read())
            {
                existencia.Text = z["amountPurchased"].ToString();
            }
            connection.Close();
            txtCantiMatPrima.Enabled = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand d = new SqlCommand("select amountPurchased from inputs where name= '" + comboBox2.Text + "'", connection);
            connection.Open();
            SqlDataReader r = d.ExecuteReader();
            while (r.Read())
            {
                exisI.Text = r["amountPurchased"].ToString();
            }
            connection.Close();
            txtCantidadInsumo.Enabled = true;
        }
        private void txtCantidadInsumo_TextChanged(object sender, EventArgs e)
        {


            if ((exisI.Text != "") && (txtCantidadInsumo.Text != ""))
            {
                if (Convert.ToDecimal(exisI.Text) < Convert.ToDecimal(txtCantidadInsumo.Text))
                {
                    MessageBox.Show("No hay cantidad suficiente");
                    txtCantidadInsumo.Text = string.Empty;
                }
            }
            //if (txtCantidadInsumo.Text != "")
            //{

            //        if (Convert.ToDecimal(exisI.Text) < Convert.ToDecimal(txtCantidadInsumo.Text))
            //        {
            //            MessageBox.Show("No hay cantidad suficiente");
            //            txtCantidadInsumo.Text = string.Empty;
            //        }


            //}


        }

        private void txtCantiMatPrima_TextChanged(object sender, EventArgs e)
        {
            if ((existencia.Text != "") && (txtCantiMatPrima.Text != ""))
            {
                if (Convert.ToDecimal(existencia.Text) < Convert.ToDecimal(txtCantiMatPrima.Text))
                {
                    MessageBox.Show("Cantidad insuficiente.");
                    txtCantiMatPrima.Text = string.Empty;
                }
            }
            //if (txtCantiMatPrima.Text!="") {
            //        if (Convert.ToDecimal(existencia.Text) < Convert.ToDecimal(txtCantiMatPrima.Text))
            //        {
            //            MessageBox.Show("Cantidad insuficiente.");
            //            txtCantiMatPrima.Text = string.Empty;
            //        }

            //}

        }

        private void exisI_TextChanged(object sender, EventArgs e)
        {
            //if (exisI.Text != "" && txtCantiMatPrima.Text!="")
            //{
            //    if (Convert.ToDecimal(exisI.Text) < Convert.ToDecimal(txtCantidadInsumo.Text))
            //    {
            //        MessageBox.Show("No hay cantidad suficiente");
            //        txtCantidadInsumo.Text = string.Empty;
            //    }
            //}
        }

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

        private void txtIva_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.NumerosDecimales(e);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
