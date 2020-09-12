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
        //karina Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="C:\Users\William carmona\Documents\Desarrollo\Cagada Adrian\WaareDev\BD\fruteria.mdf";Integrated Security=True;Connect Timeout=30
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\William carmona\Documents\Desarrollo\Cagada Adrian\WaareDev\BD\fruteria.mdf;Integrated Security=True;Connect Timeout=30");

        //SqlConnection connection = new SqlConnection(@"Server=tcp:OMEN-LAPTOP18\SQLEXPRESS02,49172;DataBase= fruteria; User Id=Cliente ; Password=cliente1234");
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
                    dataGridView1.Columns[5].HeaderText = "Moneda";
                    dataGridView1.Columns[6].HeaderText = "Condiciones";
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
                    dataGridView1.Columns[2].HeaderText = "Nombre del proveedor";
                    dataGridView1.Columns[3].HeaderText = "Número del proveedor";
                    dataGridView1.Columns[4].HeaderText = "Total";
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
            ventas inf = new ventas();
            compras com = new compras();
            Cotizaciones coti = new Cotizaciones();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (cmdReporte.Text.Equals("Ventas"))
                {
                    inf.txtFolio.Text = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                    inf.dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["date"].Value.ToString();
                    inf.txtIva.Text = dataGridView1.CurrentRow.Cells["iva"].Value.ToString();
                    inf.txtNumCliente.Text = dataGridView1.CurrentRow.Cells["num"].Value.ToString();
                    //inf.txtCajasContenido.Text = dataGridView1.CurrentRow.Cells["cajas"].Value.ToString();
                    inf.comboBox3.Text = dataGridView1.CurrentRow.Cells["nombreP"].Value.ToString();
                    inf.comboMoneda.Text = dataGridView1.CurrentRow.Cells["currency"].Value.ToString();
                    inf.txtCondiciones.Text = dataGridView1.CurrentRow.Cells["cond"].Value.ToString();
                    inf.txtLugarExpe.Text = dataGridView1.CurrentRow.Cells["lugar"].Value.ToString();
                    inf.txtSubtotal.Text = dataGridView1.CurrentRow.Cells["subtotal"].Value.ToString();
                    inf.txtTotal.Text = dataGridView1.CurrentRow.Cells["total"].Value.ToString();
                    //inf.txtCajasContenido.Text = dataGridView1.CurrentRow.Cells[""].Value.ToString(); 

                    inf.dateTimePicker1.Enabled = false;
                    inf.txtIva.Enabled = false;
                    //inf.txtCajasContenido.Enabled = false;
                    inf.comboBox3.Enabled = false;
                    inf.txtLugarExpe.Enabled = false;
                    inf.txtCondiciones.Enabled = false;
                    inf.comboMoneda.Enabled = false;
                    inf.txtPallet.Enabled = false;
                    inf.txtCantidad.Enabled = false;
                    inf.cantidad.Text = "0";

                    inf.button2.Visible = false;
                    inf.btnArticulo.Visible = false;
                    inf.btnMostrar.Visible = true;
                    inf.button4.Visible = false;
                    inf.btnAgregarProd.Visible = false;
                    inf.btnEliminar.Visible = false;
                    inf.btnMostrar.Visible = false;
                    //inf.txtFolio.Visible = false;
                    inf.dataGridView1.Visible = false;
                    inf.dataGridView2.Visible = true;
                    inf.textBox3.Enabled = false;



                    inf.ShowDialog();
                }
                else if (cmdReporte.Text.Equals("Compras"))
                {
                    com.txtFolioCompra.Text = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                    com.dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["fecha"].Value.ToString();
                    //com.txtTipo.Text = dataGridView1.CurrentRow.Cells["tipo"].Value.ToString(); 
                    //com.txtName.Text = dataGridView1.CurrentRow.Cells["product"].Value.ToString();
                    //com.txtPrecioUnitario.Text = dataGridView1.CurrentRow.Cells["price"].Value.ToString();
                    com.prov.Text = dataGridView1.CurrentRow.Cells["provider"].Value.ToString();
                    com.txtNoPro.Text = dataGridView1.CurrentRow.Cells["numberP"].Value.ToString();
                    com.txtTot.Text = dataGridView1.CurrentRow.Cells["total"].Value.ToString();
                    //com.txtCantidad.Text = dataGridView1.CurrentRow.Cells["amountPurchased"].Value.ToString();
                    //com.txtTotalCompra.Text = dataGridView1.CurrentRow.Cells["total"].Value.ToString();
                    //com.txtDescripcion.Text = dataGridView1.CurrentRow.Cells["description"].Value.ToString();

                    com.dateTimePicker1.Enabled = false;
                    com.txtTipo.Enabled = false;
                    com.dataGridView1.Visible = false;
                    com.dataGridView2.Visible = true;
                    com.button2.Visible = false;
                    com.prov.Enabled = false;
                    com.txtTot.Enabled = false;
                    com.txtPrecioUnitario.Enabled = false;
                    com.txtName.Enabled = false;
                    com.txtDescripcion.Enabled = false;
                    com.btnGuardar.Visible = false;
                    com.btrRegreso.Visible = false;
                    com.button1.Visible = false;
                    com.button3.Visible = false;



                    com.ShowDialog();
                }
               else if (cmdReporte.Text.Equals("Cotizaciones"))
                {
                    coti.txtFolio.Text = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                    coti.Date.Text = dataGridView1.CurrentRow.Cells["date"].Value.ToString();
                    coti.pallet.Text = dataGridView1.CurrentRow.Cells["pallet"].Value.ToString();
                    coti.Expiration.Text = dataGridView1.CurrentRow.Cells["expiration"].Value.ToString();
                    coti.IdClient.Text = dataGridView1.CurrentRow.Cells["idCliente"].Value.ToString();
                    coti.ico.Text = dataGridView1.CurrentRow.Cells["icoterm"].Value.ToString();
                    coti.Customer.Text = dataGridView1.CurrentRow.Cells["customerName"].Value.ToString();
                    coti.txtTotal.Text = dataGridView1.CurrentRow.Cells["total"].Value.ToString();
                    coti.txtSubtotal.Text = dataGridView1.CurrentRow.Cells["subtotal"].Value.ToString();
                    coti.divisa.Text = dataGridView1.CurrentRow.Cells["currency"].Value.ToString();
                    coti.txtIva.Text = dataGridView1.CurrentRow.Cells["IVA"].Value.ToString();
                    coti.place.Text = dataGridView1.CurrentRow.Cells["place"].Value.ToString();
                    coti.Condicion.Text = dataGridView1.CurrentRow.Cells["cond"].Value.ToString();
                    coti.textBox1.Text = dataGridView1.CurrentRow.Cells["producto"].Value.ToString();
                    coti.flete.Text = dataGridView1.CurrentRow.Cells["flete"].Value.ToString();

                    coti.txtCan.Text = "0";
                    coti.Date.Enabled = false;
                    coti.pallet.Enabled = false;
                    coti.place.Enabled = false;
                    coti.textBox1.Enabled = false;
                    coti.Expiration.Enabled = false;
                    coti.ico.Enabled = false;
                    coti.divisa.Enabled = false;
                    coti.txtIva.Enabled = false;
                    coti.Customer.Enabled = false;
                    coti.Condicion.Enabled = false;
                    coti.flete.Enabled = false;
                    coti.txtPallet.Enabled = false;
                    coti.txtMedida.Enabled = false; 


                    coti.btnArticulo.Visible = false;
                    coti.btnAgregarProd.Visible = false;
                    coti.btnEliminar.Visible = false;
                    coti.button2.Visible = false;
                    coti.button3.Visible = false;
                    coti.button1.Visible = false;
                    coti.button5.Visible = false;
                    coti.TablaDeVenta.Visible = false;
                    coti.dataGridView1.Visible = true; 

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
