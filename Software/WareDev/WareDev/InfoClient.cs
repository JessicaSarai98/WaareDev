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

namespace WareDev
{
    public partial class InfoClient : Form
    {
        CN_Clientes objectCN = new CN_Clientes();
        Menuclientescs menu = new Menuclientescs(); 
        public InfoClient()
        {
             InitializeComponent();
        }
       
        

        private void MostrarClientes()
        {
            CN_Clientes objeto = new CN_Clientes();
            //dataGridView1.DataSource = objeto.MostrarCli();
            //Nametxt.Text = UserCache.username; 

        }

        //cargar datos
       /* public void loadUserData()
        {
           IDtxtbox.Text = UserCache.ID.ToString();
            Nametxt.Text = UserCache.username;
            RFCtxt.Text = UserCache.RFC;
            phonetxt.Text = UserCache.phone;
            mailtxt.Text = UserCache.email;
            addrestxt.Text = UserCache.address;
            citytxt.Text = UserCache.city;
            statettxt.Text = UserCache.state;
            countrytxt.Text = UserCache.country;
            CPtxt.Text = UserCache.CP;
            identytxt.Text = UserCache.IF;
            tasatxt.Text = UserCache.tasa.ToString();
            statustxt.Text = UserCache.status;
            vendortxt.Text = UserCache.vendedor;
            paytxt.Text = UserCache.payment;
            cfditxt.Text = UserCache.CFDI;
            note.Text = UserCache.note;
        }*/

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

        //guardado
        private void button2_Click(object sender, EventArgs e)
        {

            Menuclientescs menucliente = new Menuclientescs();

            try
            {
                objectCN.InsertarClie(Nametxt.Text, RFCtxt.Text, phonetxt.Text, mailtxt.Text, addrestxt.Text,
           citytxt.Text, statetxt.Text, countrytxt.Text, CPtxt.Text, identytxt.Text, tasatxt.Text, statustxt.Text,
           vendortxt.Text, paytxt.Text, cfditxt.Text, note.Text);
                MessageBox.Show("Se ha insertado correctamente.");
                 
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo insertar los datos por: " + ex);
            }

        }

        private void Imprimir_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("If you want to modify the same PDF, you must close the document before", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK) 
            {

                Document doc = new Document(PageSize.A5);

                // Indicamos donde vamos a guardar el documento
                string pdfName = @"C:\Users\Jessica\Desktop\" + "Cliente-" + Nametxt.Text + ".pdf";

                //SaveFileDialog save = new SaveFileDialog();
                //save.Filter = "Archivo de pdf |*.pdf";
                //save.InitialDirectory = @"C:\Users\AdriFdez18\Desktop\";
                //save.FileName ="Cliente:"+ Nametxt.Text + ".pdf";

                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(pdfName, FileMode.OpenOrCreate));



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

                //@"C:\Users\AdriFdez18\Desktop\Extra\UI\WaareDev\Imagenes\Informacion.jpeg"
                //Agregar imagen al pdf se debe poner la ruta de la imagen de infromacion esta en la carpta de imagenes del proyecto
                var imagenpath = @"C:\Users\Jessica\Desktop\WareDev\WaareDev\Imagenes\Informacion.jpeg";

                using (FileStream im = new FileStream(imagenpath, FileMode.Open))
                {
                    var jpg = iTextSharp.text.Image.GetInstance(System.Drawing.Image.FromStream(im), System.Drawing.Imaging.ImageFormat.Png);
                    //(x,y)
                    jpg.SetAbsolutePosition(270, 15);
                    jpg.ScalePercent(25, 25);
                    doc.Add(jpg);

                }

                //Agregar imagen al pdf se debe poner la ruta de la imagen de infromacion esta en la carpta de imagenes del proyecto
                var Logopath = @"C:\Users\Jessica\Desktop\WareDev\WaareDev\Imagenes\Logo.jpeg";

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
                table.AddCell(statetxt.Text);
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
                MessageBox.Show("Created PDF sent to the next path:" + pdfName);

                //Dejar en blanco los text.box
                Nametxt.Clear();
                RFCtxt.Clear();
                phonetxt.Clear();
                mailtxt.Clear();
                addrestxt.Clear();
                statetxt.Clear();
                countrytxt.Clear();
                CPtxt.Clear();
                identytxt.Clear();
                tasatxt.Clear();
                paytxt.Clear();
                cfditxt.Clear();
                note.Clear();

                //this.Close();
            }

            else{
                MessageBox.Show("Close the PDF to be modified");
            }
           
        }
        //Editar
        private void SaveEdit_Click(object sender, EventArgs e)
        {
            try
            {
                objectCN.EditarClie(Nametxt.Text, RFCtxt.Text, phonetxt.Text, mailtxt.Text, addrestxt.Text, citytxt.Text, statetxt.Text, countrytxt.Text,
                CPtxt.Text, identytxt.Text, tasatxt.Text, statustxt.Text, vendortxt.Text, paytxt.Text, cfditxt.Text, note.Text, IDtxtbox.Text);
                MessageBox.Show("Se ha editado correctamente.");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo editar los datos por: " + ex);
            }
        }
    }
}
