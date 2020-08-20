using System;
using System.Windows.Forms;
using Domain;
using System.Data.SqlClient;
using System.Drawing;
using System.IO; 


namespace WareDev
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }


        //Funcion para crear Forms hijos 
        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.contenedor.Controls.Count > 0)
                this.contenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            fh.FormBorderStyle = FormBorderStyle.None;
            this.contenedor.Controls.Add(fh);
            this.contenedor.Tag = fh;
            fh.BringToFront();
            fh.Show();

        }

        public void MostrarR()
        {
            CN_Clientes objeto = new CN_Clientes();
            dataGridView1.DataSource = objeto.MostrarRS();
        }

        private void Start_Load(object sender, EventArgs e)
        {
            MostrarR();

            dataGridView1.Columns[0].HeaderText = "Nombre del Producto";
            dataGridView1.Columns[1].HeaderText = "Cantidad disponible";
            dataGridView1.Columns[2].HeaderText = "Descripción";
            dataGridView1.Columns[3].HeaderText = "Almacén";

            SqlCommand comando = new SqlCommand();
            SqlCommand comando1 = new SqlCommand();
            SqlCommand comando2 = new SqlCommand();

            // jess
            //string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jessica\Documents\fruteria.mdf;Integrated Security=True;Connect Timeout=30";
            // karina
            string con = @"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = C:\Users\William carmona\Documents\Desarrollo\Cagada Adrian\WaareDev\BD\fruteria.mdf;Integrated Security = True";


            SqlConnection conn = new SqlConnection(con);
            comando.Connection = conn;
            comando1.Connection = conn;
            comando2.Connection = conn;

            comando.CommandText = "SELECT COUNT(*) FROM rawMaterials";
            comando1.CommandText = "SELECT COUNT(*) FROM inputs";
            comando2.CommandText = "SELECT COUNT(*) FROM FinishedProducts";

            conn.Open();
            textBox1.Text = comando.ExecuteScalar().ToString();
            textBox2.Text = comando1.ExecuteScalar().ToString();
            textBox3.Text = comando2.ExecuteScalar().ToString();
            conn.Close();
        }
        ventas ventas;
        private void btnVentas_Click(object sender, EventArgs e)
        {
            if (ventas == null)
            {
                ventas = new ventas();
                ventas.Owner = this;
                ventas.FormClosed += ventas_FormClosed;
                ventas.dateTimePicker1.Value = DateTime.Today;
                ventas.Show();
            }
            else ventas.Activate();
        }

        private void ventas_FormClosed(object sender, FormClosedEventArgs e)
        {
            ventas = null;
            cotizaciones = null;
        }
        compras compras;

        private void button2_Click(object sender, EventArgs e)
        {
            //if(boxCompras.Text.Equals("Producto Terminado")){
            if (compras == null)
            {
                compras = new compras();
                compras.Owner = this;
                compras.FormClosed += ventas_FormClosed;
                compras.dateTimePicker1.Value = DateTime.Today;
                //compras.Show();
                AbrirFormInPanel(new compras());
            }
            else compras.Activate();

        }
        
            
            //AbrirFormInPanel(new compras());

            //}

            //if (boxCompras.Text.Equals("Materia Prima"))
            //{

            //    AbrirFormInPanel(new compras());

            //}

            //if (boxCompras.Text.Equals("Insumos"))
            //{

            //    AbrirFormInPanel(new compras());

            //}
            

        

        Cotizaciones cotizaciones;
        private void button1_Click(object sender, EventArgs e)
        {
            if (cotizaciones == null)
            {
                cotizaciones = new Cotizaciones();
                cotizaciones.Owner = this;
                cotizaciones.FormClosed += ventas_FormClosed;
                cotizaciones.Date.Value = DateTime.Today;
                cotizaciones.Expiration.Value = DateTime.Today; 
                cotizaciones.Show();
            }
            else cotizaciones.Activate();
        }
    }
}
