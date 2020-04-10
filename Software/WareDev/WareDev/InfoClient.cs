using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    }
}
