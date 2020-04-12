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

namespace WareDev
{
    public partial class InfoClient : Form
    {
        CN_Clientes objectCN = new CN_Clientes(); 
        public InfoClient()
        {
            InitializeComponent();
            
        }

        

        private void MostrarClientes()
        {
            CN_Clientes objeto = new CN_Clientes();
            //dataGridView1.DataSource = objetoCN.MostrarCli();

        }

        private void InfoClient_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IDtxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menuclientescs menucliente = new Menuclientescs();
            
            if (menucliente.Editar == false)
            {
                try
                {

                    objectCN.InsertarClie(IDtxtbox.Text, Nametxt.Text, RFCtxt.Text, phonetxt.Text,
                    mailtxt.Text, addrestxt.Text, citytxt.Text, statettxt.Text, countrytxt.Text,
                    CPtxt.Text, identytxt.Text, tasatxt.Text, statustxt.Text, vendortxt.Text
                    , paytxt.Text, cfditxt.Text, note.Text);
                    MessageBox.Show("Se ha insertado corretamente");
                    MostrarClientes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo introducir los datos por: " + ex);
                }
            }
            if (menucliente.Editar == true)
            {
                try
                {
                    objectCN.EditarClie(Nametxt.Text, phonetxt.Text,mailtxt.Text, IDtxtbox.Text);
                    MessageBox.Show("Se edito corretamente");
                    MostrarClientes();
                    menucliente.Editar = false; 
                }
                catch(Exception ex)
                {
                    MessageBox.Show("No se pudo editar los datos por: " + ex);
                }
            }

            //string id, string name, string rfc, string phone,
            //string email, string address, string city, string state,
            //string country, string cp, string identy, string tasaa, string stat,
            //string vendedor, string pm, string cfdi, string note


        }

        private void Imprimir_Click(object sender, EventArgs e)
        {

           


            Document doc = new Document(PageSize.A5);

            // Indicamos donde vamos a guardar el documento
            string pdfName = @"C:\Users\AdriFdez18\Desktop\" + "Cliente-" + Nametxt.Text + ".pdf";

            //SaveFileDialog save = new SaveFileDialog();
            //save.Filter = "Archivo de pdf |*.pdf";
            //save.InitialDirectory = @"C:\Users\AdriFdez18\Desktop\";
            //save.FileName ="Cliente:"+ Nametxt.Text + ".pdf";

            PdfWriter writer = PdfWriter.GetInstance(doc,new FileStream(pdfName, FileMode.OpenOrCreate));

            

            //Margenes del documento 
            doc.SetMargins(30, 30, 10, 10);


            // Le colocamos el título y el autor
            // Esto no será visible en el documento
            doc.AddTitle("Info Client");
            doc.AddCreator(vendortxt.Text); //Se debera pasar por parametro el nomre del usuario 

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


            //Agregar imagen al pdf 
            var imagenpath = @"C:\Users\AdriFdez18\Desktop\Extra\UI\Imagenes\Logo.jpg";

            using (FileStream im = new FileStream(imagenpath, FileMode.Open))
            {
                var jpg = iTextSharp.text.Image.GetInstance(System.Drawing.Image.FromStream(im), System.Drawing.Imaging.ImageFormat.Jpeg);
                //(x,y)
                jpg.SetAbsolutePosition(250, 10);
                jpg.ScalePercent(80, 80);
                doc.Add(jpg);

            }


            // Escribimos el encabezamiento en el documento
            var titulo = new Paragraph("PROMOTORA Y COMERCIALIZADORA COSTA MAYA S.A DE C.V.",fuentetitulo);

            
            titulo.SpacingBefore = 0;
            titulo.Alignment = 1;
            doc.Add(titulo);
            doc.Add(Chunk.NEWLINE);
            doc.Add(spacer);

            // Creamos la tabla con la informacion de el cliente 

            var table = new PdfPTable(new[] { 1f, 2f })
            {
                      HorizontalAlignment = Left,
                      WidthPercentage = 100,
                      
                     
            };
            doc.Add(spacer);

            table.AddCell("Date");
            table.AddCell(DateTime.Now.ToString());
            table.AddCell("Name");
            table.AddCell(Nametxt.Text);
            table.AddCell("RFC");
            table.AddCell(RFCtxt.Text);
            table.AddCell("Phone");
            table.AddCell(phonetxt.Text);
            table.AddCell("E-Mail");
            table.AddCell(mailtxt.Text);
            table.AddCell("Addres");
            table.AddCell(addrestxt.Text);
            table.AddCell("City");
            table.AddCell(citytxt.Text);
            table.AddCell("State");
            table.AddCell(statettxt.Text);
            table.AddCell("Country");
            table.AddCell(countrytxt.Text);
            table.AddCell("CP");
            table.AddCell(CPtxt.Text);
            table.AddCell("Identy");
            table.AddCell(identytxt.Text);
            table.AddCell("Tasa");
            table.AddCell(tasatxt.Text);
            table.AddCell("Status");
            table.AddCell(statustxt.Text);
            table.AddCell("Pay Method");
            table.AddCell(paytxt.Text);
            table.AddCell("CFDI");
            table.AddCell(cfditxt.Text);
            table.AddCell("Note");
            table.AddCell(note.Text);


            doc.Add(table);
            doc.Add(spacer);
            doc.Close();
            writer.Close();
            MessageBox.Show("PDF creado enviado a la siguiente ruta :" + pdfName);

            //Dejar en blanco los text.box
            Nametxt.Clear();
            RFCtxt.Clear();
            phonetxt.Clear();
            mailtxt.Clear();
            addrestxt.Clear();
            statettxt.Clear();
            countrytxt.Clear();
            CPtxt.Clear();
            identytxt.Clear();
            tasatxt.Clear();
            paytxt.Clear();
            cfditxt.Clear();
            note.Clear();

            //this.Close();

        }
    }
}
