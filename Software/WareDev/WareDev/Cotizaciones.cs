﻿using System;
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
        // SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jessica\Documents\fruteria.mdf;Integrated Security=True;Connect Timeout=30");
        // karina 
        SqlConnection connection = new SqlConnection(@"Server=tcp:OMEN-LAPTOP18\SQLEXPRESS02,49172;DataBase= fruteria; User Id=Cliente ; Password=cliente1234");

        SqlCommand cmd; 
        SqlCommand cmd2; 
        private void cotizaciones_Load(object sender, EventArgs e)
        {
            //Date.Value = DateTime.Today;
            //Expiration.Value = DateTime.Today;
            txtCantidad.Enabled = false;
            SqlCommand cm = new SqlCommand("select Id from clientes", connection);

           

            //leyendp clientes - nombre
            SqlCommand d = new SqlCommand("select name from clientes", connection);
            SqlCommand a = new SqlCommand("Select RFC from clientes where name='" + Customer.Text + "'", connection);

            connection.Open();
            SqlDataReader r = d.ExecuteReader(); 
            
            while (r.Read())
            {
                Customer.Items.Add(r["name"].ToString());

            }
            connection.Close();

            //leyendo name de finished products
            //SqlCommand c = new SqlCommand("Select name from FinishedProducts", connection);
            //connection.Open();
            //SqlDataReader reg = c.ExecuteReader();
            //while (reg.Read())
            //{
            //    comboBox1.Items.Add(reg["name"].ToString());
            //}
            //connection.Close();

            string query = "select max(Id) from quotations";
            SqlCommand cmd = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                string pcount = Convert.ToString(cmd.ExecuteScalar());
                if (this.txtFolio.Text.Equals(""))
                {
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
            SqlCommand com = new SqlCommand("select * from detalleQuo where folio='" + txtFolio.Text + "'", connection);
            SqlDataAdapter adap = new SqlDataAdapter();
            adap.SelectCommand = com;
            DataTable tabla = new DataTable();
            adap.Fill(tabla);
            dataGridView1.DataSource = tabla;

            this.dataGridView1.Columns[0].HeaderText = "Folio";
            this.dataGridView1.Columns[1].HeaderText = "Subtotal";
            this.dataGridView1.Columns[2].HeaderText = "Producto";
            this.dataGridView1.Columns[3].HeaderText = "Cantidad";
            this.dataGridView1.Columns[4].HeaderText = "Descripción";
            this.dataGridView1.Columns[5].HeaderText = "Pallet";
            this.dataGridView1.Columns[6].HeaderText = "Medida";
            this.dataGridView1.Columns[7].HeaderText = "Tamaño";
            this.dataGridView1.Columns[8].HeaderText = "Precio";
            

        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Si quieres modificar el mismo PDF, cierralo de aplicaciones externas.", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                Document doc = new Document(PageSize.A4);

                // Indicamos donde vamos a guardar el documento

                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.InitialDirectory = @"C:";
                saveFileDialog1.Title = "Guardar Reporte";
                saveFileDialog1.DefaultExt = "pdf";
                saveFileDialog1.Filter = "pdf Files (*.pdf)|*.pdf| All Files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;
                string filename = "";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    filename = saveFileDialog1.FileName;
                }


                //SaveFileDialog save = new SaveFileDialog();
                //save.Filter = "Archivo de pdf |*.pdf";
                //save.InitialDirectory = @"C:\Users\AdriFdez18\Desktop\";
                //save.FileName ="Cliente:"+ Nametxt.Text + ".pdf";

                if (filename.Trim() != "")
                {
                    FileStream file = new FileStream(filename,
                        FileMode.OpenOrCreate,
                        FileAccess.ReadWrite,
                        FileShare.ReadWrite);
                PdfWriter.GetInstance(doc, file);


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
                var imagenpath = @"C:\Users\AdriFdez18\Desktop\Extra\Ware\WaareDev\Software\WareDev\WareDev\Imagenes\Informacion.jpeg";

                using (FileStream im = new FileStream(imagenpath, FileMode.Open))
                {
                    var jpg = iTextSharp.text.Image.GetInstance(System.Drawing.Image.FromStream(im), System.Drawing.Imaging.ImageFormat.Png);
                    //(x,y)
                    jpg.SetAbsolutePosition(450, 0);
                    jpg.ScalePercent(25, 25);
                    doc.Add(jpg);

                }

                //Agregar imagen al pdf se debe poner la ruta de la imagen de infromacion esta en la carpta de imagenes del proyecto
                var Logopath = @"C:\Users\AdriFdez18\Desktop\Extra\Ware\WaareDev\Software\WareDev\WareDev\Imagenes\Logo.jpeg";

                using (FileStream im = new FileStream(Logopath, FileMode.Open))
                {
                    var png = iTextSharp.text.Image.GetInstance(System.Drawing.Image.FromStream(im), System.Drawing.Imaging.ImageFormat.Png);
                    //(x,y)
                    png.SetAbsolutePosition(190, 770);
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

                var headertable = new PdfPTable(new[] { 3f, 3f, 3f, 3f })
                {
                    HorizontalAlignment = Left,
                    WidthPercentage = 100,
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
                headertable.AddCell("RCF / ID");
                headertable.AddCell(IdClient.Text);
                headertable.AddCell("PRODUCTO");
                headertable.AddCell(textBox1.Text);
                headertable.AddCell("PALLET");
                headertable.AddCell(pallet.Text);
                headertable.AddCell("ICOTERM");
                headertable.AddCell(ico.Text);
                headertable.AddCell("Divisa");
                headertable.AddCell(divisa.Text);
                headertable.AddCell("Flete x Caja");
                headertable.AddCell(flete.Text);
                

                doc.Add(headertable);
                doc.Add(spacer);

                    if (TablaDeVenta.Visible = Visible)
                    {
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

                    }
                    if(dataGridView1.Visible = Visible)
                    {
                        //Creacion de Tabla de Cotizacion para reportes

                        var colums = dataGridView1.ColumnCount;
                        var columsAncho = new[] { 1f, 2f, 2f, 3f, 1f, 2f, 2f, 2f, 2f };


                        var tableReport = new PdfPTable(columsAncho)
                        {
                            HorizontalAlignment = Left,
                            WidthPercentage = 100,
                            DefaultCell = { MinimumHeight = 22f }

                        };

                        var cellsa = new PdfPCell(new Phrase("Product Quote"))
                        {

                            Colspan = colums,
                            HorizontalAlignment = 1,
                            MinimumHeight = 30f

                        };

                        tableReport.AddCell(cellsa);

                        //Encabezados del DataGridview
                        dataGridView1.Columns
                            .OfType<DataGridViewColumn>()
                            .ToList()
                            .ForEach(c => tableReport.AddCell(c.Name));

                        //Columnas
                        dataGridView1.Rows
                            .OfType<DataGridViewRow>()
                            .ToList()
                            .ForEach(r =>
                            {
                                var cellsre = r.Cells.OfType<DataGridViewCell>().ToList();
                                cellsre.ForEach(c => tableReport.AddCell(c.Value.ToString()));

                            });

                        doc.Add(tableReport);

                    }
                    var downtable = new PdfPTable(new[] { .5f, .5f})
                    {
                        HorizontalAlignment = Right,
                        WidthPercentage = 100,
                        DefaultCell = { MinimumHeight = 5f }

                    };
                    doc.Add(spacer);

                   
                    downtable.AddCell("Subtotal");
                    downtable.AddCell(txtSubtotal.Text);
                    downtable.AddCell("IVA");
                    downtable.AddCell(txtIva.Text);
                    downtable.AddCell("Total");
                    downtable.AddCell(txtTotal.Text);

                    doc.Add(downtable);
                    doc.Close();
                }
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
                    ad.Parameters.AddWithValue("@folio", Convert.ToInt32(row.Cells["Folio"].Value));
                    ad.Parameters.AddWithValue("@subtotal", Convert.ToString(row.Cells["Total"].Value));
                    ad.Parameters.AddWithValue("@producto", Convert.ToString(row.Cells["Producto"].Value));
                    ad.Parameters.AddWithValue("@cantidad", Convert.ToString(row.Cells["Cantidad"].Value));
                    ad.Parameters.AddWithValue("@desc", Convert.ToString(row.Cells["Descripcion"].Value));
                    ad.Parameters.AddWithValue("@pallet", Convert.ToString(row.Cells["Pall"].Value));

                    ad.Parameters.AddWithValue("@medida", Convert.ToString(row.Cells["Size"].Value));
                    ad.Parameters.AddWithValue("@tam", Convert.ToString(row.Cells["Tamaño"].Value));
                    ad.Parameters.AddWithValue("@precio", Convert.ToString(row.Cells["PrecioxUnidad"].Value));
                    
                    ad.ExecuteNonQuery();

                }

            string sqlQuery = "insert into quotations(Id, date, pallet, expiration, idCliente, " +
                    "icoterm, customerName,subtotal,total,currency, IVA,place,cond, producto, flete) " +
                    "values('" + txtFolio.Text + "',@date,'" + pallet.Text + "', @expiration, '" +
                    IdClient.Text + "','" + ico.Text + "','" + Customer.Text + "','" + txtSubtotal.Text +
                    "','" + txtTotal.Text + "','" + divisa.Text + "','" + txtIva.Text + "','" + place.Text +
                    "','" + Condicion.Text + "', '"+textBox1.Text+"', '"+flete.Text+"')";
            cmd = new SqlCommand(sqlQuery, connection);
            cmd.Parameters.AddWithValue("@date", Date.Value);
            cmd.Parameters.AddWithValue("@expiration", Expiration.Value);
            cmd.ExecuteNonQuery();
            connection.Close();

                decimal total = 0;
                string a; 

                foreach(DataGridViewRow row in TablaDeVenta.Rows)
                {
                    connection.Open();
                    total = Convert.ToDecimal(row.Cells[7].Value);
                    a = Convert.ToString(row.Cells[4].Value);
                    string sqlQuery2 = "update FinishedProducts set amountPurchased = amountPurchased - '"+total+"'where name= '"+a+"'";
                    cmd2 = new SqlCommand(sqlQuery2, connection);
                    cmd2.ExecuteNonQuery();
                    connection.Close();
                }

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
            SqlCommand d = new SqlCommand("Select RFC from clientes where name = '"+Customer.Text+"'", connection);
            connection.Open();
            SqlDataReader r = d.ExecuteReader();
            while (r.Read())
            {
                IdClient.Text = r["RFC"].ToString(); 
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
                    if(txtPallet.Text != "")
                    {
                        TablaDeVenta.Rows.Add(txtFolio.Text,txtPallet.Text,txtMedida.Text,txtTam.Text,txtProducto.Text, txtDescripcion.Text,txtPrecio.Text,txtCantidad.Text, txtPrecioTotal.Text);
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
                        MessageBox.Show("Ingrese el pallet", "Mensaje", MessageBoxButtons.OK,
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
                if (Convert.ToDecimal(txtCan.Text) != 0)
                {
                    if (Convert.ToDecimal(txtCantidad.Text) <= Convert.ToDecimal(txtCan.Text))
                    {
                        n1 = Convert.ToInt32(txtCantidad.Text);
                        n2 = Convert.ToSingle(txtPrecio.Text);
                        a = n1 * n2;
                        txtPrecioTotal.Text = a.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Cantidad insuficiente, la cantidad disponible es: " + txtCan.Text);
                        txtCantidad.Text = string.Empty;
                    }
                }
                //else
                //{
                //    MessageBox.Show("No hay cantidad disponible");
                //}

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

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("select * from quotations where Id='" + txtFolio.Text + "'", connection);
            SqlDataAdapter adap = new SqlDataAdapter();
            adap.SelectCommand = com;
            DataTable tabla = new DataTable();
            adap.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProducto.Text = dataGridView1.CurrentRow.Cells["producto"].Value.ToString();
            txtCantidad.Text =  dataGridView1.CurrentRow.Cells["cantidad"].Value.ToString();
            txtDescripcion.Text = dataGridView1.CurrentRow.Cells["desc"].Value.ToString();
            txtPallet.Text =  dataGridView1.CurrentRow.Cells["pallet"].Value.ToString();
            txtMedida.Text = dataGridView1.CurrentRow.Cells["medida"].Value.ToString();
            txtTam.Text = dataGridView1.CurrentRow.Cells["tam"].Value.ToString();
            txtPrecio.Text = dataGridView1.CurrentRow.Cells["precio"].Value.ToString();


        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            //if(this.txtProducto.Text.Length >= 1)
            //{
            //    SqlCommand c = new SqlCommand("select * from FinishedProducts where name= '"+txtProducto.Text+"'", connection);
            //    SqlDataAdapter ad = new SqlDataAdapter();
            //    ad.SelectCommand = c;
            //    DataTable tab = new DataTable();
            //    ad.Fill(tab);
            //    dataGridView1.DataSource = tab; 


            //}
        }
    }
}

