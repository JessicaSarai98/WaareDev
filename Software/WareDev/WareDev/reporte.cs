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
    public partial class reporte : Form
    {
        public reporte()
        {
            InitializeComponent();
        }
        //jess
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jessica\Documents\fruteria.mdf;Integrated Security=True;Connect Timeout=30");
        //karina
        //SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = C:\Users\William carmona\Documents\users.mdf;Integrated Security = True");
        SqlCommand cmd;
        private void reporte_Load(object sender, EventArgs e)
        {
            desdeTime.Value = DateTime.Today;
            hastaTime.Value = DateTime.Today;


            //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jessica\Documents\fruteria.mdf;Integrated Security=True;Connect Timeout=30");

            //SqlCommand cmd = new SqlCommand("select * from sys.tables ", connection);
            //connection.Open();
            //SqlDataReader registro = cmd.ExecuteReader();
            //while (registro.Read())
            //{
            //    cmdReporte.Items.Add(registro.ToString());
            //}
            //connection.Close();
        }

        DataTable dt = new DataTable(); 
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //panel2.Visible = true;
            // int indice = cmdReporte.SelectedIndex;
            //lblTitulo.Text = cmdReporte.Items[indice].ToString();
            //dataGridView1.Rows.Clear(); 

            ////connection.Open();
            ////string sqlQuery = "select * from FinishedProducts where name like('" + txtNomProdTerm.Text + "%')";
            ////cmd = new SqlCommand(sqlQuery, connection);
            ////cmd.ExecuteNonQuery();

            ////DataTable dt = new DataTable();
            ////SqlDataAdapter da = new SqlDataAdapter(cmd);
            ////da.Fill(dt);
            ////dataGridView3.DataSource = dt;
            ////connection.Close();

            dataGridView1.Refresh();
            //connection.Open();
            if (cmdReporte.Text != "")
            {

                if (cmdReporte.Text.Equals("Sales"))
                {
                    connection.Open();

                    SqlDataAdapter sda1 = new SqlDataAdapter("select  * from ventas where date between @date1 and @date2", connection);

                    sda1.SelectCommand.Parameters.Add(new SqlParameter("@date1", desdeTime.Value));
                    sda1.SelectCommand.Parameters.Add(new SqlParameter("@date2", hastaTime.Value));

                    DataSet d = new DataSet();
                    sda1.Fill(d, "Sales");
                    dataGridView1.DataSource = d.Tables["Sales"];
                    dataGridView1.Columns[0].HeaderText = "Folio";
                    dataGridView1.Columns[1].HeaderText = "Date";
                    dataGridView1.Columns[2].HeaderText = "IVA";
                    dataGridView1.Columns[3].HeaderText = "Provider Number";
                    dataGridView1.Columns[4].HeaderText = "Provider Name";
                    dataGridView1.Columns[5].HeaderText = "Currency";
                    dataGridView1.Columns[6].HeaderText = "Conditions";
                    dataGridView1.Columns[7].HeaderText = "Place";
                    dataGridView1.Columns[8].HeaderText = "Subtotal";
                    dataGridView1.Columns[9].HeaderText = "Total";


                    connection.Close();



                }
                else if (cmdReporte.Text.Equals("Quotes"))
                {
                    connection.Open();

                    SqlDataAdapter sda1 = new SqlDataAdapter("select * from quotations where date between @date1 and @date2", connection);

                    sda1.SelectCommand.Parameters.Add(new SqlParameter("@date1", desdeTime.Value));
                    sda1.SelectCommand.Parameters.Add(new SqlParameter("@date2", hastaTime.Value));

                    DataSet d = new DataSet();
                    sda1.Fill(d, "Quotes");
                    dataGridView1.DataSource = d.Tables["Quotes"];

                    dataGridView1.Columns[0].HeaderText = "Folio";
                    dataGridView1.Columns[1].HeaderText = "Date";
                    dataGridView1.Columns[2].HeaderText = "Pallet";
                    dataGridView1.Columns[3].HeaderText = "Expiration";
                    dataGridView1.Columns[4].HeaderText = "Customer Number";
                    dataGridView1.Columns[5].HeaderText = "Icoterm";
                    dataGridView1.Columns[6].HeaderText = "Customer Name";
                    dataGridView1.Columns[7].HeaderText = "Subtotal";
                    dataGridView1.Columns[8].HeaderText = "Total";
                    dataGridView1.Columns[9].HeaderText = "Currency";
                    dataGridView1.Columns[10].HeaderText = "IVA";
                    dataGridView1.Columns[11].HeaderText = "Place";
                    dataGridView1.Columns[12].HeaderText = "Conditions";


                    connection.Close();

                }
                else if (cmdReporte.Text.Equals("Shopping"))
                {
                    connection.Open();

                    SqlDataAdapter sda1 = new SqlDataAdapter("select * from compras where fecha between @date1 and @date2", connection);

                    sda1.SelectCommand.Parameters.Add(new SqlParameter("@date1", desdeTime.Value));
                    sda1.SelectCommand.Parameters.Add(new SqlParameter("@date2", hastaTime.Value));

                    DataSet d = new DataSet();
                    sda1.Fill(d, "Shopping");
                    dataGridView1.DataSource = d.Tables["Shopping"];

                    dataGridView1.Columns[0].HeaderText = "Folio";
                    dataGridView1.Columns[1].HeaderText = "Date";
                    dataGridView1.Columns[2].HeaderText = "Product Name";
                    dataGridView1.Columns[3].HeaderText = "Price Unit";
                    dataGridView1.Columns[4].HeaderText = "Provider Name";
                    dataGridView1.Columns[5].HeaderText = "Provider Number";
                    dataGridView1.Columns[6].HeaderText = "Amount Purchased";
                    dataGridView1.Columns[7].HeaderText = "Total";
                    //dataGridView1.Columns[8].Visible = false;
                    dataGridView1.Columns[8].HeaderText = "Description";
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
