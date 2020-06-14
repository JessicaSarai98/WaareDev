using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WareDev
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }
        //Jess
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jessica\Documents\fruteria.mdf;Integrated Security=True;Connect Timeout=30");
        // karina
        //SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = C:\Users\William carmona\Documents\users.mdf;Integrated Security = True");
        private void btrRegreso_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void Productos_Load(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand("select name from FinishedProducts", connection);
            connection.Open();
            SqlDataReader registro = cm.ExecuteReader();
            while (registro.Read())
            {
                ComboNombre.Items.Add(registro["name"].ToString());

            }
            connection.Close();

            

        }
        public DataTable GetData(string query)
        {
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }
        private void ComboNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select name, size, measure,description, unitPrice, boxes, amountPurchased, pallet from FinishedProducts where name = '" + ComboNombre.Text + "'  ";
            dataGridView1.DataSource = GetData(query);
            this.dataGridView1.Columns[0].HeaderText = "Name";
            this.dataGridView1.Columns[1].HeaderText = "Size";
            this.dataGridView1.Columns[2].HeaderText = "Measure";
            this.dataGridView1.Columns[3].HeaderText = "Description";
            this.dataGridView1.Columns[4].HeaderText = "Unit Price";
            this.dataGridView1.Columns[5].HeaderText = "Boxes";
            this.dataGridView1.Columns[6].HeaderText = "Amount Purchased";
            this.dataGridView1.Columns[7].HeaderText = "Pallet";
        }



        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            ventas ventas = new ventas();
            string a, b, c, d, f, g, h, k;

            a = this.dataGridView1.CurrentRow.Cells["name"].Value.ToString();
            c = this.dataGridView1.CurrentRow.Cells["description"].Value.ToString();
            d = this.dataGridView1.CurrentRow.Cells["pallet"].Value.ToString();
            g = this.dataGridView1.CurrentRow.Cells["size"].Value.ToString();
            h = this.dataGridView1.CurrentRow.Cells["unitPrice"].Value.ToString();
            k = this.dataGridView1.CurrentRow.Cells["amountPurchased"].Value.ToString();

            foreach ( Form frm in Application.OpenForms)
            {
                if(frm.Name == "ventas")
                {
                    ventas = (ventas)frm;
                    ventas.txtProducto.Text = a;
                    ventas.txtDescripcion.Text = c;
                    ventas.txtPallet.Text = d;
                    ventas.txtTam.Text = g;
                    ventas.txtPrecio.Text = h;
                    ventas.cantidad.Text = k; 
                    this.Close();
                    break;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }
    }
}



    


