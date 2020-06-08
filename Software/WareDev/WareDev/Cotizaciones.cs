using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Runtime.InteropServices;
using System.IO;
using Domain;
using Common.cache;
using Org.BouncyCastle.Asn1.Crmf;
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

            SqlCommand cm = new SqlCommand("select Id from clientes", connection);

            connection.Open();
            SqlDataReader registro = cm.ExecuteReader();
            //leyendo clientes - id client
            while (registro.Read())
            {
                IdClient.Items.Add(registro["Id"].ToString());
                

            }
            connection.Close();

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
            //SqlConnection c = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jessica\Documents\fruteria.mdf;Integrated Security=True;Connect Timeout=30");
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
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            



            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("If you want to modify the same PDF, you must close the document before", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                Document doc = new Document(PageSize.A5);

                // Indicamos donde vamos a guardar el documento

                string pdfName = Customer.Text + ".pdf";


                //SaveFileDialog save = new SaveFileDialog();
                //save.Filter = "Archivo de pdf |*.pdf";
                //save.InitialDirectory = @"C:\Users\AdriFdez18\Desktop\";
                //save.FileName ="Cliente:"+ Nametxt.Text + ".pdf";

                //PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(pdfName, FileMode.OpenOrCreate));



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
                var imagenpath = @"C:\Users\AdriFdez18\Desktop\Extra\UI\WaareDev\Imagenes\Informacion.jpeg";

                using (FileStream im = new FileStream(imagenpath, FileMode.Open))
                {
                    var jpg = iTextSharp.text.Image.GetInstance(System.Drawing.Image.FromStream(im), System.Drawing.Imaging.ImageFormat.Png);
                    //(x,y)
                    jpg.SetAbsolutePosition(270, 15);
                    jpg.ScalePercent(25, 25);
                    doc.Add(jpg);

                }

                //Agregar imagen al pdf se debe poner la ruta de la imagen de infromacion esta en la carpta de imagenes del proyecto
                var Logopath = @"C:\Users\AdriFdez18\Desktop\Extra\UI\WaareDev\Imagenes\Logo.jpeg";

                using (FileStream im = new FileStream(Logopath, FileMode.Open))
                {
                    var png = iTextSharp.text.Image.GetInstance(System.Drawing.Image.FromStream(im), System.Drawing.Imaging.ImageFormat.Png);
                    //(x,y)
                    png.SetAbsolutePosition(0, 525);
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
                headertable.AddCell(ico.Text);
                headertable.AddCell("PRODUCTO");
                headertable.AddCell(producto.Text);
                headertable.AddCell("PALLET");
                headertable.AddCell(pallet.Text);
                headertable.AddCell("ICOTERM");
                headertable.AddCell(ico.Text);
                headertable.AddCell("Currency");
                headertable.AddCell(divisa.Text);

                doc.Add(headertable);
                doc.Add(spacer);


                //Creacion de Tabla de Cotizacion

                var columCount = TablaDeVenta.ColumnCount;
                var columAncho = new[] { 2.5f, 1f, 1f, 2f, .75f };


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




                //Dejar en blanco los text.box


                //this.Close();
            }

            else
            {
                MessageBox.Show("Close the PDF to be modified");
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
            producto.Text = string.Empty;
            IdClient.Text = string.Empty;
            ico.Text = string.Empty;
            TablaDeVenta.DataSource = null;


        }

        private void AddARow(DataTable table)
        {
            DataRow newRow = table.NewRow();
            table.Rows.Add(newRow);
        }
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable(); 
        private void agregar_Click(object sender, EventArgs e)
        {
            
            connection.Open();
            SqlCommand c = new SqlCommand("select name, size, measure, description, unitPrice, boxes, amountPurchased from FinishedProducts where name ='" + comboBox1.Text + "'", connection); 
            SqlDataAdapter da = new SqlDataAdapter(c);
            da.Fill(dt);
            
            //DataRow dr;

            //dr = dt2.NewRow();
            //dr[0] = producto.Text;
            //dt2.Rows.Add(dr); 

            //foreach(var item in dt2.Rows)
            //{
            //    dt.ImportRow((DataRow)item);
            //}

            TablaDeVenta.DataSource = dt;
            this.TablaDeVenta.Columns[1].HeaderText = "Product's name";
            this.TablaDeVenta.Columns[2].HeaderText = "Size";
            this.TablaDeVenta.Columns[3].HeaderText = "Measure";
            this.TablaDeVenta.Columns[4].HeaderText = "Description";
            this.TablaDeVenta.Columns[5].HeaderText = "Price";
            this.TablaDeVenta.Columns[6].HeaderText = "Boxes per acount";
            this.TablaDeVenta.Columns[7].HeaderText = "Amount";
            //int p = Convert.ToInt32(producto.Text);
            
            //dt.Rows.Add(producto.Text);
            //TablaDeVenta.DataSource = dt; 


            //TablaDeVenta.Rows.Add(producto.Text);
           // int a = da.Fill(dt);|
            //TablaDeVenta.Rows[a].Cells[0].Value = p;
            

            connection.Close();
            
        
            
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (TablaDeVenta.SelectedRows.Count > 0)
            {
                TablaDeVenta.Rows.Remove(TablaDeVenta.CurrentRow);
            }
            else
            {
                MessageBox.Show("Seleccione una fila.");
            }
        }

        private void TablaDeVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.TablaDeVenta.Columns[0].HeaderText = "Product's name";
            this.TablaDeVenta.Columns[1].HeaderText = "Size";
            this.TablaDeVenta.Columns[2].HeaderText = "Measure";
            this.TablaDeVenta.Columns[3].HeaderText = "Description";
            this.TablaDeVenta.Columns[4].HeaderText = "Unit Price";
            this.TablaDeVenta.Columns[5].HeaderText = "Boxes per Content";
            this.TablaDeVenta.Columns[6].HeaderText = "Amount";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if ((this.Date != null) && (this.pallet.Text.Length >= 1) && (this.place.Text.Length >= 1) && (this.Condicion.Text.Length >= 1) && (this.Expiration != null) && (this.IdClient.Text.Length >= 1) && (this.ico.Text.Length >= 1) && (this.Customer.Text.Length >= 1) && (this.txtSubtotal.Text.Length >= 1) && (this.txtTotal.Text.Length >= 1) && (this.divisa.Text.Length >= 1) && (this.producto.Text.Length >= 1))
            {
                connection.Open();

                string sqlQuery = "insert into quotations(Id,date,pallet, expiration,idCliente,icoterm,customerName, subtotal,total,currency,product,place,cond)values('" + txtFolio.Text + "',@fecha1,'" + pallet.Text + "',@fecha2,'"+IdClient.Text + "','"+ico.Text+"','" + Customer.Text+ "','"+txtSubtotal.Text+ "','"+txtTotal.Text+ "','"+divisa.Text+ "','"+producto.Text+ "','"+place.Text+ "','"+Condicion.Text+"')";
                cmd = new SqlCommand(sqlQuery,connection);
                cmd.Parameters.AddWithValue("@fecha1",Date.Value.Date);
                cmd.Parameters.AddWithValue("@fecha2",Expiration.Value.Date);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Se ha agregado la cotización");
           
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Complete todos los campos");
            }
        }

        private void LoadComboBox2()
        {
            DataRow dr;
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

        private void IdClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string val = IdClient.SelectedValue.ToString();
            //LoadComboBox2(); 

        }
    }
}

