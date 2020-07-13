using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Data.SqlClient;

namespace WareDev
{
    public partial class Cotizaciones : Form
    {
        public Cotizaciones()
        {
            InitializeComponent();

        }
        // JESS
         //SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jessica\Documents\fruteria.mdf;Integrated Security=True;Connect Timeout=30");
        // karina 
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = C:\Users\William carmona\Documents\users.mdf;Integrated Security = True");

        SqlCommand cmd;
        private void cotizaciones_Load(object sender, EventArgs e)
        {
            Date.Value = DateTime.Today;
            Expiration.Value = DateTime.Today;
            txtCantidad.Enabled = false;
            SqlCommand cm = new SqlCommand("select Id from clientes", connection);

           

            //leyendp clientes - nombre
            SqlCommand d = new SqlCommand("select name from clientes", connection);
            SqlCommand a = new SqlCommand("Select Id from clientes where name='" + Customer.Text + "'", connection);

            connection.Open();
            SqlDataReader r = d.ExecuteReader(); 
            
            while (r.Read())
            {
                Customer.Items.Add(r["name"].ToString());

            }
            connection.Close();

            //leyendo name de finished products
            SqlCommand c = new SqlCommand("Select name from FinishedProducts", connection);
            connection.Open();
            SqlDataReader reg = c.ExecuteReader();
            while (reg.Read())
            {
                comboBox1.Items.Add(reg["name"].ToString());
            }
            connection.Close();

            string query = "select max(Id) from quotations";
            SqlCommand cmd = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                string pcount = Convert.ToString(cmd.ExecuteScalar());
                if (pcount.Length == 0)
                {
                    txtFolio.Text = "1";
                }
                else
                {
                    int pcount1 = Convert.ToInt32(pcount);
                    int pcountAdd = pcount1 + 1;
                    txtFolio.Text = pcountAdd.ToString();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                connection.Close();
            }

            //IdClient_SelectedIndexChanged(null, null);
            Customer_SelectedIndexChanged(null, null);



        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("If you want to modify the same PDF, you must close the document before", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                Document doc = new Document(PageSize.A4);

                // Indicamos donde vamos a guardar el documento

                string pdfName = @"C:\Users\Jessica\Desktop\" + "Cotizacion"+ Customer.Text + ".pdf";


                //SaveFileDialog save = new SaveFileDialog();
                //save.Filter = "Archivo de pdf |*.pdf";
                //save.InitialDirectory = @"C:\Users\AdriFdez18\Desktop\";
                //save.FileName ="Cliente:"+ Nametxt.Text + ".pdf";

                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(pdfName, FileMode.OpenOrCreate));



                //Margenes del documento 
                doc.SetMargins(30, 30, 10, 10);


                // Le colocamos el título y el autor
                // Esto no será visible en el documento
                doc.AddTitle("Cotizacion");


                //Se estipula de fuente de escritura 
                iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                //fuente de escritura del titulo 
                var fuentetitulo = FontFactory.GetFont("Arial", 10, BaseColor.BLACK);

                // Abrimos el archivo
                doc.Open();



                //Espacio entre parrafos
                var spacer = new Paragraph("")
                {
                    SpacingBefore = 10f,
                    SpacingAfter = 10f,
                };


                //Agregar imagen al pdf se debe poner la ruta de la imagen de infromacion esta en la carpta de imagenes del proyecto
                var imagenpath = @"C:\Users\Jessica\Desktop\WareDev\WaareDev\Imagenes\Informacion.jpeg";

                using (FileStream im = new FileStream(imagenpath, FileMode.Open))
                {
                    var jpg = iTextSharp.text.Image.GetInstance(System.Drawing.Image.FromStream(im), System.Drawing.Imaging.ImageFormat.Png);
                    //(x,y)
                    jpg.SetAbsolutePosition(450, 0);
                    jpg.ScalePercent(25, 25);
                    doc.Add(jpg);

                }

                //Agregar imagen al pdf se debe poner la ruta de la imagen de infromacion esta en la carpta de imagenes del proyecto
                var Logopath = @"C:\Users\Jessica\Desktop\WareDev\WaareDev\Imagenes\Logo.jpeg";

                using (FileStream im = new FileStream(Logopath, FileMode.Open))
                {
                    var png = iTextSharp.text.Image.GetInstance(System.Drawing.Image.FromStream(im), System.Drawing.Imaging.ImageFormat.Png);
                    //(x,y)
                    png.SetAbsolutePosition(250, 770);
                    png.ScalePercent(15, 15);
                    doc.Add(png);

                }



                // Escribimos el encabezamiento en el documento
                var titulo = new Paragraph("PROMOTORA Y COMERCIALIZADORA COSTA MAYA S.A DE C.V.", fuentetitulo);


                titulo.SpacingBefore = 0;
                titulo.Alignment = 2;
                doc.Add(titulo);
                doc.Add(Chunk.NEWLINE);
                doc.Add(spacer);

                // Creamos la tabla con con la infromacion de cliente y vendedor 

                var headertable = new PdfPTable(new[] { .75f, 2f })
                {
                    HorizontalAlignment = Left,
                    WidthPercentage = 75,
                    DefaultCell = { MinimumHeight = 22f }

                };
                doc.Add(spacer);

                //Creacion de Tabla de datos de comprador 
                headertable.AddCell("FECHA");
                headertable.AddCell(DateTime.Now.ToString());
                headertable.AddCell("VALIDO HASTA");
                headertable.AddCell(Expiration.Text);
                headertable.AddCell("COTIZACION");
                headertable.AddCell(txtFolio.Text);
                headertable.AddCell("LUGAR DE EXPEDICION");
                headertable.AddCell(place.Text);
                headertable.AddCell("CLAVE DE CLIENTE");
                headertable.AddCell(Customer.Text);
                headertable.AddCell("CONDICION COMERCIAL");
                headertable.AddCell(Condicion.Text);
                //headertable.AddCell("PRODUCTO");
                //headertable.AddCell(producto.Text);
                headertable.AddCell("PALLET");
                headertable.AddCell(pallet.Text);
                headertable.AddCell("ICOTERM");
                headertable.AddCell(ico.Text);
                headertable.AddCell("Currency");
                headertable.AddCell(divisa.Text);
                headertable.AddCell("Total Final");
                headertable.AddCell(txtTotal.Text);

                doc.Add(headertable);
                doc.Add(spacer);


                //Creacion de Tabla de Cotizacion

                var columCount = TablaDeVenta.ColumnCount;
                var columAncho = new[] { 1f, 2f, 2f, 3f, 1f, 2f, 2f, 2f, 2f };


                var table = new PdfPTable(columAncho)
                {
                    HorizontalAlignment = Left,
                    WidthPercentage = 100,
                    DefaultCell = { MinimumHeight = 22f }

                };

                var cell = new PdfPCell(new Phrase("Product Quote"))
                {

                    Colspan = columCount,
                    HorizontalAlignment = 1,
                    MinimumHeight = 30f

                };

                table.AddCell(cell);

                //Encabezados del DataGridview
                TablaDeVenta.Columns
                    .OfType<DataGridViewColumn>()
                    .ToList()
                    .ForEach(c => table.AddCell(c.Name));

                //Columnas
                TablaDeVenta.Rows
                    .OfType<DataGridViewRow>()
                    .ToList()
                    .ForEach(r =>
                    {
                        var cells = r.Cells.OfType<DataGridViewCell>().ToList();
                        cells.ForEach(c => table.AddCell(c.Value.ToString()));

                    });

                doc.Add(table);
                doc.Close();
            }

            else
            {
                MessageBox.Show("Cierre el pdf para poder modificarlo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            pallet.Text = string.Empty;
            place.Text= string.Empty;
            Condicion.Text = string.Empty;
            Customer.Text = string.Empty;
            txtSubtotal.Text = string.Empty;
            txtTotal.Text = string.Empty;
            divisa.Text = string.Empty;

            txtProducto.Text = string.Empty;
            txtCantidad.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtPallet.Text = string.Empty;
            txtMedida.Text = string.Empty;
            txtTam.Text = string.Empty;
            txtPrecio.Text = string.Empty;

            IdClient.Text = string.Empty;
            ico.Text = string.Empty;
            //TablaDeVenta.Rows.Clear(); 

        }

        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable(); 
        

        private void Delete_Click(object sender, EventArgs e)
        {
            if (TablaDeVenta.SelectedRows.Count > 0)
            {
                TablaDeVenta.Rows.Remove(TablaDeVenta.CurrentRow);
            }
            else
            {
                MessageBox.Show("Seleccione una fila.","Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if ((this.Date != null) && (this.pallet.Text.Length >= 1) && (this.place.Text.Length >= 1) 
                && (this.Condicion.Text.Length >= 1) && (this.Expiration != null) && 
                (this.IdClient.Text.Length >= 1) && (this.ico.Text.Length >= 1) && 
                (this.Customer.Text.Length >= 1) && (this.txtSubtotal.Text.Length >= 1) && (this.txtTotal.Text.Length >= 1) && (this.divisa.Text.Length >= 1))
            {
                connection.Open();

                foreach (DataGridViewRow row in TablaDeVenta.Rows)
                {
                    SqlCommand ad = new SqlCommand("insert into detalleQuo values(@folio,@subtotal," +
                        "@producto,@cantidad,@desc,@pallet,@medida,@tam,@precio)", connection);

                    ad.Parameters.Clear();
                    ad.Parameters.AddWithValue("@folio", Convert.ToInt32(row.Cells["Column1"].Value));
                    ad.Parameters.AddWithValue("@subtotal", Convert.ToString(row.Cells["Column9"].Value));
                    ad.Parameters.AddWithValue("@producto", Convert.ToString(row.Cells["Column2"].Value));
                    ad.Parameters.AddWithValue("@cantidad", Convert.ToString(row.Cells["Column3"].Value));
                    ad.Parameters.AddWithValue("@desc", Convert.ToString(row.Cells["Column4"].Value));
                    ad.Parameters.AddWithValue("@pallet", Convert.ToString(row.Cells["Column5"].Value));

                    ad.Parameters.AddWithValue("@medida", Convert.ToString(row.Cells["Column6"].Value));
                    ad.Parameters.AddWithValue("@tam", Convert.ToString(row.Cells["Column7"].Value));
                    ad.Parameters.AddWithValue("@precio", Convert.ToString(row.Cells["Column8"].Value));
                    
                    ad.ExecuteNonQuery();

                }

            string sqlQuery = "insert into quotations(Id, date, pallet, expiration, idCliente, " +
                    "icoterm, customerName,subtotal,total,currency, IVA,place,cond) " +
                    "values('" + txtFolio.Text + "',@date,'" + pallet.Text + "', @expiration, '" +
                    IdClient.Text + "','" + ico.Text + "','" + Customer.Text + "','" + txtSubtotal.Text +
                    "','" + txtTotal.Text + "','" + divisa.Text + "','" + txtIva.Text + "','" + place.Text +
                    "','" + Condicion.Text + "')";
            cmd = new SqlCommand(sqlQuery, connection);
            cmd.Parameters.AddWithValue("@date", Date.Value);
            cmd.Parameters.AddWithValue("@expiration", Expiration.Value);
            cmd.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Se ha agregado la venta", "Mensaje", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                this.Close();

            }
            else
            {
                MessageBox.Show("Complete todos los campos", "Mensaje", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoadComboBox2()
        {
            //DataRow dr;
            connection.Open();
            SqlCommand a = new SqlCommand("select name from clientes where Id=@ID",connection);
            SqlDataAdapter sda = new SqlDataAdapter(a);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            Customer.ValueMember = "ID";
            Customer.DisplayMember = "name";

            Customer.DataSource = dt;
            connection.Close(); 
        }
        private void Customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand d = new SqlCommand("Select Id from clientes where name = '"+Customer.Text+"'", connection);
            connection.Open();
            SqlDataReader r = d.ExecuteReader();
            while (r.Read())
            {
                IdClient.Text = r["Id"].ToString(); 
            }
            connection.Close();
        }
        Productos materia;
        private void btnArticulo_Click(object sender, EventArgs e)
        {
            materia = new Productos();
            materia.Show();
            txtCantidad.Enabled = true;
        }
        private void btnAgregarProd_Click(object sender, EventArgs e)
        {
            if (txtProducto.Text !="")
            {
                if(txtCantidad.Text!= "")
                {
                    if(txtMedida.Text != "")
                    {
                        TablaDeVenta.Rows.Add(txtFolio.Text,txtProducto.Text,txtCantidad.Text,txtDescripcion.Text,txtPallet.Text, txtMedida.Text,txtTam.Text, txtPrecio.Text,txtPrecioTotal.Text);
                        txtProducto.Text = string.Empty;
                        txtCantidad.Text = string.Empty;
                        txtDescripcion.Text = string.Empty;
                        txtPallet.Text = string.Empty;
                        txtMedida.Text = string.Empty;
                        txtTam.Text = string.Empty;
                        txtPrecio.Text = string.Empty;
                        txtCan.Text = string.Empty;
                        txtPrecioTotal.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Ingrese la medida", "Mensaje", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese la cantidad a utilizar", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto para agregarlo a la tabla", "Mensaje", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if(txtIva.Text!= "")
            {
                txtProducto.Text = string.Empty;
                txtCantidad.Text = string.Empty;
                txtDescripcion.Text = string.Empty;
                txtPallet.Text = string.Empty;
                txtMedida.Text = string.Empty;
                txtTam.Text = string.Empty;
                txtPrecio.Text = string.Empty;

                decimal total = 0; 
                foreach(DataGridViewRow row in TablaDeVenta.Rows)
                {
                    total += Convert.ToDecimal(row.Cells[8].Value);
                }
                txtSubtotal.Text = total.ToString();

                float g, h, j;
                g = Convert.ToSingle(txtSubtotal.Text);
                h = Convert.ToSingle(txtIva.Text);
                j = g + (h * (g / 100));
                txtTotal.Text = j.ToString();
            }
            else
            {
                MessageBox.Show("Ingrese IVA","Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(TablaDeVenta.SelectedRows.Count > 0)
            {
                TablaDeVenta.Rows.Remove(TablaDeVenta.CurrentRow);
            }
            else
            {
                MessageBox.Show("Seleccione una fila","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            float n1, n2, a;
            if (txtCantidad.Text != "")
            {
                n1 = Convert.ToInt32(txtCantidad.Text);
                n2 = Convert.ToSingle(txtPrecio.Text);
                a = n1 * n2;
                txtPrecioTotal.Text = a.ToString(); 
                
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.SoloNumeros(e);
        }

        private void txtIva_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.NumerosDecimales(e);
        }

        private void pallet_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.SoloNumeros(e);
        }

        private void btrRegreso_Click(object sender, EventArgs e)
        {
            this.Close(); 
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

