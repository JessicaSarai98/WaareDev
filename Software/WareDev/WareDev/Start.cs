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
using System.Data.SqlClient;


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
            //dataGridView1.DataSource = objeto.MostrarIS();
            //dataGridView1.DataSource = objeto.MostrarFPS();


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
            //string con = "Data Source=LAPTOP-SDO1671B;Initial Catalog=users;Integrated Security=True;Pooling=False";
            // karina Data Source = (LocalDB)-MSSQLLocalDB; Initial Catalog = users;Integrated Security = True; Connect Timeout = 30
            string con = "Data Source=LAPTOP-SDO1671B;Initial Catalog=users;Integrated Security=True;Pooling=False";



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

        private void btnVentas_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new ventas());
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new compras());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new ganancias());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void exis_Click(object sender, EventArgs e)
        {
            //SqlCommand comando = new SqlCommand();
            //SqlCommand comando1 = new SqlCommand();
            //SqlCommand comando2 = new SqlCommand();

            //string con = "Data Source=LAPTOP-SDO1671B;Initial Catalog=users;Integrated Security=True;Pooling=False";
            //SqlConnection conn = new SqlConnection(con);
            //comando.Connection = conn;
            //comando1.Connection = conn;
            //comando2.Connection = conn;

            //comando.CommandText = "SELECT COUNT(*) FROM rawMaterials";
            //comando1.CommandText = "SELECT COUNT(*) FROM inputs";
            //comando2.CommandText = "SELECT COUNT(*) FROM FinishedProducts";

            //conn.Open();
            //textBox1.Text = comando.ExecuteScalar().ToString();
            //textBox2.Text = comando1.ExecuteScalar().ToString();
            //textBox3.Text = comando2.ExecuteScalar().ToString();
            //conn.Close();
        }
    }
}
