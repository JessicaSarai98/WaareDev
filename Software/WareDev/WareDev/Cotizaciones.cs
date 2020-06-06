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

namespace WareDev
{
    public partial class Cotizaciones : Form
    {



        public Cotizaciones()
        {
            InitializeComponent();

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
                headertable.AddCell(Place.Text);
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
    }
}

