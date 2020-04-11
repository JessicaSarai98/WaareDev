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

           


            Document doc = new Document(PageSize.LETTER);

            // Indicamos donde vamos a guardar el documento
            string pdfName = @"C:\Users\AdriFdez18\Desktop\" + "Cliente-"+ Nametxt.Text + ".pdf";

            PdfWriter writer = PdfWriter.GetInstance(doc,new FileStream(pdfName, FileMode.OpenOrCreate));

            // Le colocamos el título y el autor
            // Esto no será visible en el documento
            doc.AddTitle("Info Client");
            doc.AddCreator(vendortxt.Text); //Se debera pasar por parametro el nomre del usuario 

            // Abrimos el archivo
            doc.Open();

            //Se estipula de fuente de escritura 
            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            // Escribimos el encabezamiento en el documento
            doc.Add(new Paragraph("Vendedor:"+vendortxt.Text));
            doc.Add(Chunk.NEWLINE);

            // Creamos la tabla con la informacion de el cliente 
            PdfPTable tblClient = new PdfPTable(4);
            tblClient.WidthPercentage = 100;

            // Títulos de las columnas de la tabla
            PdfPCell clNombre = new PdfPCell(new Phrase("Name", _standardFont));
            clNombre.BorderWidth = 0;
            clNombre.BorderWidthBottom = 0.75f;

            PdfPCell clRFC = new PdfPCell(new Phrase("RFC", _standardFont));
            clRFC.BorderWidth = 0;
            clRFC.BorderWidthBottom = 0.70f;

            PdfPCell clPhone = new PdfPCell(new Phrase("Phone", _standardFont));
            clPhone.BorderWidth = 0;
            clPhone.BorderWidthBottom = 0.70f;

            PdfPCell clmail = new PdfPCell(new Phrase("E-Mail", _standardFont));
            clmail.BorderWidth = 0;
            clmail.BorderWidthBottom = 0.70f;

            // Añadimos las celdas a la tabla
            tblClient.AddCell(clNombre);
            tblClient.AddCell(clRFC);
            tblClient.AddCell(clPhone);
            tblClient.AddCell(clmail);

            // Llenamos la tabla con información
            clNombre = new PdfPCell(new Phrase(Nametxt.Text));
            clNombre.BorderWidth = 0;

            clRFC = new PdfPCell(new Phrase(RFCtxt.Text));
            clRFC.BorderWidth = 0;

            clPhone = new PdfPCell(new Phrase(phonetxt.Text));
            clPhone.BorderWidth = 0;

            clmail = new PdfPCell(new Phrase(mailtxt.Text));
            clmail.BorderWidth = 0;

            // Añadimos las celdas a la tabla
            tblClient.AddCell(clNombre);
            tblClient.AddCell(clRFC);
            tblClient.AddCell(clPhone);
            tblClient.AddCell(clmail);

           
            doc.Add(tblClient);       
            doc.Close();
            writer.Close();
            MessageBox.Show("¡PDF creado!");

            //this.Close();

        }
    }
}
