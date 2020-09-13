using System;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
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
            menu.dataGridView1.DataSource = objeto.MostrarCli();
            Nametxt.Text = UserCache.username;

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

        //guardado
        private void button2_Click(object sender, EventArgs e)
        {

            Menuclientescs menucliente = new Menuclientescs();

            try
            {
                objectCN.InsertarClie(IDtxtbox.Text,Nametxt.Text, RFCtxt.Text, phonetxt.Text, mailtxt.Text, addrestxt.Text,
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
                string file = "";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    file = saveFileDialog1.FileName;
                }


                //SaveFileDialog save = new SaveFileDialog();
                //save.Filter = "Archivo de pdf |*.pdf";
                //save.InitialDirectory = @"C:\Users\AdriFdez18\Desktop\";
                //save.FileName ="Cliente:"+ Nametxt.Text + ".pdf";

                if (file.Trim() != "")
                {
                    FileStream fileventas = new FileStream(file,
                    FileMode.OpenOrCreate,
                    FileAccess.ReadWrite,
                    FileShare.ReadWrite);
                    PdfWriter.GetInstance(doc, fileventas);


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

                    var table = new PdfPTable(new[] { 3f, 3f, 3f, 3f })
                    {
                        HorizontalAlignment = Left,
                        WidthPercentage = 100,
                        DefaultCell = { MinimumHeight = 22f }

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

                }

            }

            else{
                MessageBox.Show("Cierra para modificar");
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
                MessageBox.Show("No se pudo editar los datos por: \n" + ex);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                objectCN.InsertarClie(IDtxtbox.Text,Nametxt.Text, RFCtxt.Text, phonetxt.Text, mailtxt.Text, addrestxt.Text, citytxt.Text, statetxt.Text, countrytxt.Text,
                CPtxt.Text, identytxt.Text, tasatxt.Text, statustxt.Text, vendortxt.Text, paytxt.Text, cfditxt.Text, note.Text);
                MessageBox.Show("Se ha agregado correctamente.");
                this.Close();
                
            }catch(Exception ex)
            {
                MessageBox.Show("No se pudo agregar los datos por: \n"+ex);
            }
        }

        private void tasatxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.NumerosDecimales(e);

        }
        int posX;
        int posY;
        private void panel2_MouseMove(object sender, MouseEventArgs e)
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
