using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WareDev
{
    public partial class reporte : Form
    {
        public reporte()
        {
            InitializeComponent();
        }
        //jess
        //SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jessica\Documents\fruteria.mdf;Integrated Security=True;Connect Timeout=30");
        //karina
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = C:\Users\William carmona\Documents\users.mdf;Integrated Security = True");
        SqlCommand cmd;
        private void reporte_Load(object sender, EventArgs e)
        {
            desdeTime.Value = DateTime.Today;
            hastaTime.Value = DateTime.Today;
        }

        DataTable dt = new DataTable(); 
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            //connection.Open();
            if (cmdReporte.Text != "")
            {

                if (cmdReporte.Text.Equals("Ventas"))
                {
                    connection.Open();

                    SqlDataAdapter sda1 = new SqlDataAdapter("select  * from ventas where date between @date1 and @date2", connection);

                    sda1.SelectCommand.Parameters.Add(new SqlParameter("@date1", desdeTime.Value));
                    sda1.SelectCommand.Parameters.Add(new SqlParameter("@date2", hastaTime.Value));

                    DataSet d = new DataSet();
                    sda1.Fill(d, "Ventas");
                    dataGridView1.DataSource = d.Tables["Ventas"];
                    dataGridView1.Columns[0].HeaderText = "Folio";
                    dataGridView1.Columns[1].HeaderText = "Fecha";
                    dataGridView1.Columns[2].HeaderText = "IVA";
                    dataGridView1.Columns[3].HeaderText = "Número del proveedor";
                    dataGridView1.Columns[4].HeaderText = "Nombre del proveedor";
                    dataGridView1.Columns[5].HeaderText = "Currency";
                    dataGridView1.Columns[6].HeaderText = "Condicones";
                    dataGridView1.Columns[7].HeaderText = "Lugar";
                    dataGridView1.Columns[8].HeaderText = "Subtotal";
                    dataGridView1.Columns[9].HeaderText = "Total";


                    connection.Close();



                }
                else if (cmdReporte.Text.Equals("Cotizaciones"))
                {
                    connection.Open();

                    SqlDataAdapter sda1 = new SqlDataAdapter("select * from quotations where date between @date1 and @date2", connection);

                    sda1.SelectCommand.Parameters.Add(new SqlParameter("@date1", desdeTime.Value));
                    sda1.SelectCommand.Parameters.Add(new SqlParameter("@date2", hastaTime.Value));

                    DataSet d = new DataSet();
                    sda1.Fill(d, "Cotizaciones");
                    dataGridView1.DataSource = d.Tables["Cotizaciones"];

                    dataGridView1.Columns[0].HeaderText = "Folio";
                    dataGridView1.Columns[1].HeaderText = "Fecha";
                    dataGridView1.Columns[2].HeaderText = "Pallet";
                    dataGridView1.Columns[3].HeaderText = "Valido hasta";
                    dataGridView1.Columns[4].HeaderText = "Número del cliente";
                    dataGridView1.Columns[5].HeaderText = "Icoterm";
                    dataGridView1.Columns[6].HeaderText = "Nombre del cliente";
                    dataGridView1.Columns[7].HeaderText = "Subtotal";
                    dataGridView1.Columns[8].HeaderText = "Total";
                    dataGridView1.Columns[9].HeaderText = "Currency";
                    dataGridView1.Columns[10].HeaderText = "IVA";
                    dataGridView1.Columns[11].HeaderText = "Lugar";
                    dataGridView1.Columns[12].HeaderText = "Condiciones";


                    connection.Close();

                }
                else if (cmdReporte.Text.Equals("Compras"))
                {
                    connection.Open();

                    SqlDataAdapter sda1 = new SqlDataAdapter("select * from compras where fecha between @date1 and @date2", connection);

                    sda1.SelectCommand.Parameters.Add(new SqlParameter("@date1", desdeTime.Value));
                    sda1.SelectCommand.Parameters.Add(new SqlParameter("@date2", hastaTime.Value));

                    DataSet d = new DataSet();
                    sda1.Fill(d, "Compras");
                    dataGridView1.DataSource = d.Tables["Compras"];

                    dataGridView1.Columns[0].HeaderText = "Folio";
                    dataGridView1.Columns[1].HeaderText = "Fecha";
                    dataGridView1.Columns[2].HeaderText = "Nombre del producto";
                    dataGridView1.Columns[3].HeaderText = "Precio unitario";
                    dataGridView1.Columns[4].HeaderText = "Nombre del proveedor";
                    dataGridView1.Columns[5].HeaderText = "Número del proveedor";
                    dataGridView1.Columns[6].HeaderText = "Cantidad disponible";
                    dataGridView1.Columns[7].HeaderText = "Total";
                    //dataGridView1.Columns[8].Visible = false;
                    dataGridView1.Columns[8].HeaderText = "Descripción";
                    connection.Close();
                }

            }
            else
            {
                MessageBox.Show("Seleccione una categoría");
            }
        }
    }
}
