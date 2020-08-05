using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic; 

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
                    dataGridView1.Columns[3].HeaderText = "Número del cliente";
                    dataGridView1.Columns[4].HeaderText = "Nombre del cliente";
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

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
                InfoVentas inf = new InfoVentas();
                inf.txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            
           
            //try
            //{
            //    List<Form> OpenForms = new List<Form>();
            //    InfoVentas inf = new InfoVentas();

            //    foreach (Form frm in Application.OpenForms)
            //    {
            //        if (cmdReporte.Text.Equals("Ventas"))
            //        {
            //            inf = (InfoVentas)frm;

            //            inf.txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString(); 

            //        }
            //    }
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            InfoVentas infor = new InfoVentas(); 

          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InfoVentas inf = new InfoVentas();
            InfoCompras com = new InfoCompras();
            InfoCotizaciones coti = new InfoCotizaciones(); 
            if (dataGridView1.SelectedRows.Count >0)
            {
               if (cmdReporte.Text.Equals("Ventas"))
                {
                    inf.txtId.Text = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                    inf.txtDate.Text = dataGridView1.CurrentRow.Cells["date"].Value.ToString();
                    inf.txtIva.Text = dataGridView1.CurrentRow.Cells["iva"].Value.ToString();
                    inf.txtNum.Text = dataGridView1.CurrentRow.Cells["num"].Value.ToString();
                    inf.txtNombre.Text = dataGridView1.CurrentRow.Cells["nombreP"].Value.ToString();
                    inf.txtCurrency.Text = dataGridView1.CurrentRow.Cells["currency"].Value.ToString();
                    inf.txtCond.Text = dataGridView1.CurrentRow.Cells["cond"].Value.ToString();
                    inf.txtLugar.Text = dataGridView1.CurrentRow.Cells["lugar"].Value.ToString();
                    inf.txtSubtotal.Text = dataGridView1.CurrentRow.Cells["subtotal"].Value.ToString();
                    inf.txtTotal.Text = dataGridView1.CurrentRow.Cells["total"].Value.ToString();
                    inf.ShowDialog(); 
                  }
               else if (cmdReporte.Text.Equals("Compras"))
                {
                    com.txtId.Text = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                    com.txtFecha.Text = dataGridView1.CurrentRow.Cells["fecha"].Value.ToString();
                    com.txtProduct.Text = dataGridView1.CurrentRow.Cells["product"].Value.ToString();
                    com.txtPrice.Text = dataGridView1.CurrentRow.Cells["price"].Value.ToString();
                    com.txtProvider.Text = dataGridView1.CurrentRow.Cells["provider"].Value.ToString();
                    com.txtNumberP.Text = dataGridView1.CurrentRow.Cells["numberP"].Value.ToString();
                    com.txtAmountPurchased.Text = dataGridView1.CurrentRow.Cells["amountPurchased"].Value.ToString();
                    com.txtTotal.Text = dataGridView1.CurrentRow.Cells["total"].Value.ToString();
                    com.txtDescription.Text = dataGridView1.CurrentRow.Cells["description"].Value.ToString();
                    com.ShowDialog();
                }
               else if (cmdReporte.Text.Equals("Cotizaciones"))
                {
                    coti.txtId.Text = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                    coti.txtDate.Text = dataGridView1.CurrentRow.Cells["date"].Value.ToString();
                    coti.txtPallet.Text = dataGridView1.CurrentRow.Cells["pallet"].Value.ToString();
                    coti.txtExpiration.Text = dataGridView1.CurrentRow.Cells["expiration"].Value.ToString();
                    coti.txtIdClient.Text = dataGridView1.CurrentRow.Cells["idCliente"].Value.ToString();
                    coti.txtIcoterm.Text = dataGridView1.CurrentRow.Cells["icoterm"].Value.ToString();
                    coti.txtCustomerName.Text = dataGridView1.CurrentRow.Cells["customerName"].Value.ToString();
                    coti.txtTotal.Text = dataGridView1.CurrentRow.Cells["total"].Value.ToString();
                    coti.txtSubtotal.Text = dataGridView1.CurrentRow.Cells["subtotal"].Value.ToString();
                    coti.txtCurrency.Text = dataGridView1.CurrentRow.Cells["currency"].Value.ToString();
                    coti.txtIva.Text = dataGridView1.CurrentRow.Cells["IVA"].Value.ToString();
                    coti.txtPlace.Text = dataGridView1.CurrentRow.Cells["place"].Value.ToString();
                    coti.txtCond.Text = dataGridView1.CurrentRow.Cells["cond"].Value.ToString();
                    coti.txtProducto.Text = dataGridView1.CurrentRow.Cells["producto"].Value.ToString();
                    coti.txtFlete.Text = dataGridView1.CurrentRow.Cells["flete"].Value.ToString();
                    coti.ShowDialog(); 
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }
    }
}
