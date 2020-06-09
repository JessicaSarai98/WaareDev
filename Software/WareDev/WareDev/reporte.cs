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

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jessica\Documents\fruteria.mdf;Integrated Security=True;Connect Timeout=30");


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

            dataGridView1.Refresh();
            connection.Open();

            if (cmdReporte.Text.Equals("Sales"))
            {
                connection.Open(); 
                SqlDataAdapter da = new SqlDataAdapter("select * from ventas where date >='" + desdeTime.Text + "' and date <='" + hastaTime.Text + "'", connection);

                DataSet dt = new DataSet();
                da.Fill(dt, "Ventas");
                dataGridView1.DataSource = dt.Tables["Ventas"];
                connection.Close();
                


            }
            else if (cmdReporte.Text.Equals("Quotes"))
            {
                connection.Close();
                SqlDataAdapter d = new SqlDataAdapter("select * from quotations where date >='" +desdeTime.Text+ "' and date <='" + hastaTime.Text + "'", connection) ;

                DataSet de = new DataSet();
                d.Fill(de, "Quotations");
                dataGridView1.DataSource = de.Tables["Quotations"];
                connection.Close(); 
                
            }
           

        }
    }
}
