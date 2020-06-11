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

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jessica\Documents\fruteria.mdf;Integrated Security=True;Connect Timeout=30");

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
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //ventas ven = new ventas();
            //DataGridViewRow rellenar = dataGridView1.Rows[e.RowIndex];
            //ven.txtProducto.Text = rellenar.Cells["name"].Value.ToString();
            //ven.txtCantidad.Text = rellenar.Cells["amountPurchased"].Value.ToString();
            //ven.txtDescripcion.Text = rellenar.Cells["description"].Value.ToString();
            //ven.txtPallet.Text = rellenar.Cells["pallet"].Value.ToString();
            //ven.txtMedida.Text = rellenar.Cells["measure"].Value.ToString();
            //ven.txtTam.Text = rellenar.Cells["size"].Value.ToString();
            //ven.txtPrecio.Text = rellenar.Cells["unitPrice"].Value.ToString();
            ////this.Hide();
            //ven.Show();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            ventas ven = new ventas();
            string a, b, c, d, f, g, h;

            a = Convert.ToString(this.dataGridView1.CurrentRow.Cells["name"].Value);
            b = Convert.ToString(this.dataGridView1.CurrentRow.Cells["amountPurchased"].Value);
            c = Convert.ToString(this.dataGridView1.CurrentRow.Cells["description"].Value);
            d = Convert.ToString(this.dataGridView1.CurrentRow.Cells["pallet"].Value);
            f = Convert.ToString(this.dataGridView1.CurrentRow.Cells["measure"].Value);
            g = Convert.ToString(this.dataGridView1.CurrentRow.Cells["size"].Value);
            h = Convert.ToString(this.dataGridView1.CurrentRow.Cells["unitPrice"].Value);
            ven.setArticulo(a, b, c, d, f, g, h);
            //this.Hide();
            ven.Show(); 
            //ventas ven = new ventas();

            //if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            //{
            //    dataGridView1.CurrentRow.Selected = true;
            //     DataGridViewRow rellenar = dataGridView1.Rows[e.RowIndex];
            //    //ven.txtProducto.Text = dataGridView1.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();

            //    ven.txtProducto.Text = dataGridView1.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();
            //    ven.txtCantidad.Text = dataGridView1.Rows[e.RowIndex].Cells["amountPurchased"].FormattedValue.ToString();
            //    ven.txtDescripcion.Text = dataGridView1.Rows[e.RowIndex].Cells["description"].FormattedValue.ToString();
            //    ven.txtPallet.Text = dataGridView1.Rows[e.RowIndex].Cells["pallet"].FormattedValue.ToString();
            //    ven.txtMedida.Text = dataGridView1.Rows[e.RowIndex].Cells["measure"].FormattedValue.ToString();
            //    ven.txtTam.Text = dataGridView1.Rows[e.RowIndex].Cells["size"].FormattedValue.ToString();
            //    ven.txtPrecio.Text = dataGridView1.Rows[e.RowIndex].Cells["unitPrice"].FormattedValue.ToString();
            //    ven.Show();


            //}

        }

        private void dataGridView1_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    ventas ven = new ventas();
            //    foreach (ventas f in Application.OpenForms)
            //    {
            //        if (f.Name == "ventas")
            //        {
            //            ven = (ventas)f;
            //            ven.txtProducto.Text = dataGridView1.CurrentRow.Cells["name"].Value.ToString();
            //            this.Close();
            //            break;

            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //   MessageBox.Show(ex.Message);
            //}

            //ventas ven = ventas.GetInstancia();
            //string a, b, c, d, f, g, h;

            //a = Convert.ToString(this.dataGridView1.CurrentRow.Cells["name"].Value);
            //b = Convert.ToString(this.dataGridView1.CurrentRow.Cells["amountPurchased"].Value);
            //c = Convert.ToString(this.dataGridView1.CurrentRow.Cells["description"].Value);
            //d = Convert.ToString(this.dataGridView1.CurrentRow.Cells["pallet"].Value);
            //f = Convert.ToString(this.dataGridView1.CurrentRow.Cells["measure"].Value);
            //g = Convert.ToString(this.dataGridView1.CurrentRow.Cells["size"].Value);
            //h = Convert.ToString(this.dataGridView1.CurrentRow.Cells["unitPrice"].Value);
            //this.textBox1.Text = dataGridView1.CurrentRow.Cells["name"].Value.ToString();
            //ven.txtIva.Text = dataGridView1.CurrentRow.Cells["name"].Value.ToString(); 

            //ven.setArticulo(a, b, c, d, f, g, h);
            //this.Hide();
        }

            private void BtnAgregar_Click(object sender, EventArgs e)
            {

            }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

    }
}



    


