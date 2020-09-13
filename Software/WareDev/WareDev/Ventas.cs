using System;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Linq;
using System.IO;


namespace WareDev
{
    public partial class ventas : Form
    {
        public ventas()
        {
            InitializeComponent();
        }

        //SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jessica\Documents\fruteria.mdf;Integrated Security=True;Connect Timeout=30");

        //tcp:OMEN-LAPTOP18\SQLEXPRESS02,49172
        SqlConnection connection = new SqlConnection(@"Server=tcp:OMEN-LAPTOP18\SQLEXPRESS02,49172;DataBase= fruteria; User Id=Cliente ; Password=cliente1234");
        //SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\William carmona\Documents\Desarrollo\Cagada Adrian\WaareDev\BD\fruteria.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlCommand cmd2;
        SqlDataAdapter adapter;
        DataTable table;
        private void ventas_Load(object sender, EventArgs e)
        {
            //dateTimePicker1.Value = DateTime.Today;
            txtCantidad.Enabled = false;

            SqlCommand cm = new SqlCommand("select name from FinishedProducts", connection);
            connection.Open();
            SqlDataReader registro = cm.ExecuteReader();
            while (registro.Read())
            {
                comboBox1.Items.Add(registro["name"].ToString());
            }
            connection.Close();
            SqlCommand d = new SqlCommand("select name from clientes", connection);
            connection.Open();
            SqlDataReader r = d.ExecuteReader();
            while (r.Read())
            {
                comboBox3.Items.Add(r["name"].ToString());
            }
            connection.Close();


            ventas ven = new ventas();
            string query = "select max(Id) from ventas";
            // jess
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jessica\Documents\fruteria.mdf;Integrated Security=True;Connect Timeout=30");
            // karina
            //SqlConnection con = new SqlConnection(@"Server=tcp:OMEN-LAPTOP18\SQLEXPRESS02,49172;DataBase= fruteria; User Id=Cliente ; Password=cliente1234");
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                string pcount = Convert.ToString(cmd.ExecuteScalar());
                if (this.txtFolio.Text.Equals(""))
                {
                    //string pcount = Convert.ToString(cmd.ExecuteScalar());
                    if (pcount.Length == 0)
                    {
                        txtFolio.Text = "1";
                    }
                    else
                    {
                        int pcount1 = Convert.ToInt32(pcount);
                        int pcountAdd = pcount1 + 1;
                        txtFolio.Text = pcountAdd.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            SqlCommand com = new SqlCommand("select * from detalleVenta where folio='" + txtFolio.Text + "'", connection);
            SqlDataAdapter adap = new SqlDataAdapter();
            adap.SelectCommand = com;
            DataTable tabla = new DataTable();
            adap.Fill(tabla);
            dataGridView2.DataSource = tabla;

            this.dataGridView2.Columns[0].HeaderText = "Folio";
            this.dataGridView2.Columns[1].HeaderText = "Pallet x contenido";
            this.dataGridView2.Columns[2].HeaderText = "Tamaño";
            this.dataGridView2.Columns[3].HeaderText = "Medida";
            this.dataGridView2.Columns[4].HeaderText = "Producto";
            this.dataGridView2.Columns[5].HeaderText = "Descripción";
            this.dataGridView2.Columns[6].HeaderText = "Precio";
            this.dataGridView2.Columns[7].HeaderText = "Cajas";
            this.dataGridView2.Columns[8].HeaderText = "Total";
         

            //SqlCommand c = new SqlCommand("select * from FinishedProducts where name='"+txtProducto.Text+"'",connection);
            //SqlDataAdapter ad = new SqlDataAdapter();
            //ad.SelectCommand = c;
            //DataTable tab = new DataTable();
            //ad.Fill(tab);
            //dataGridView3.DataSource = tab; 



            //try
            //{
            //    List<Form> OpenForms = new List<Form>();

            //}
        }

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
        private void txtFolio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Sólo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        Regex rx = new Regex(@"^[0-9]+\.[0-9]{2}?", RegexOptions.Compiled | RegexOptions.IgnoreCase);
        private void txtIva_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((rx.IsMatch(txtIva.Text)) && (e.KeyChar != (char)Keys.Back) || char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((rx.IsMatch(txtTotal.Text)) && (e.KeyChar != (char)Keys.Back) || char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtSubtotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((rx.IsMatch(txtSubtotal.Text)) && (e.KeyChar != (char)Keys.Back) || char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private void btrRegreso_Click(object sender, EventArgs e)
        {
            panelTitulo.Visible = false;
            AbrirFormInPanel(new Start());
            this.Close();
        }
        FacturaVentas ventas1;
        private void btnFactura_Click(object sender, EventArgs e)
        {
            if (ventas1 == null)
            {
                ventas1 = new FacturaVentas();
                ventas1.Owner = this;
                ventas1.FormClosed += Ventas1_FormClosed;
                ventas1.Show();
            }
            else ventas1.Activate();

        }

        public DataTable GetData(string query)
        {
            cmd = new SqlCommand(query, connection);
            adapter = new SqlDataAdapter(cmd);
            table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        private void Ventas1_FormClosed(object sender, FormClosedEventArgs e)
        {
            ventas1 = null;
        }
        DataTable dt = new DataTable();

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 1 && comboBox1.Text.Length >= 1)
            {
                const string message = "¿Estás seguro?";
                const string caption = "Advertencia";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    connection.Open();
                    string sql = "update FinishedProducts set amountPurchased=amountPurchased - @cant where name= '" + comboBox1.Text + "'";
                    cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@cant", textBox1.Text);
                    cmd.ExecuteNonQuery();
                    SqlCommand c = new SqlCommand("select name, size, measure, description, unitPrice, boxes, amountPurchased from FinishedProducts where name ='" + comboBox1.Text + "'", connection);
                    SqlDataAdapter da = new SqlDataAdapter(c);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    this.dataGridView1.Columns[0].HeaderText = "Product's name";
                    this.dataGridView1.Columns[1].HeaderText = "Size";
                    this.dataGridView1.Columns[2].HeaderText = "Measure";
                    this.dataGridView1.Columns[3].HeaderText = "Description";
                    this.dataGridView1.Columns[4].HeaderText = "Price";
                    this.dataGridView1.Columns[5].HeaderText = "Boxes by content";
                    this.dataGridView1.Columns[6].HeaderText = "Amount/CANTIDAD RESTADA";
                    //sumar mientras se va agregando
                    double total = 0;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {

                        total += Convert.ToDouble(row.Cells[4].Value);

                    }
                    textBox2.Text = total.ToString();
                    connection.Close();
                    textBox1.Clear();
                }

            }
            else
            {
                MessageBox.Show("Ingrese una cantidad");
            }
        }

        //Guardar 
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if ((this.dateTimePicker1 != null) && (this.txtIva.Text.Length >= 1) && (this.txtNumCliente.Text.Length >= 1) && (this.comboMoneda.Text.Length >= 1) &&
                (this.comboBox3.Text.Length >= 1) && (this.txtSubtotal.Text.Length >= 1) && (this.txtTotal.Text.Length >= 1) && (this.txtCondiciones.Text.Length >= 1) && (this.txtLugarExpe.Text.Length >= 1))
            {
                connection.Open();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    SqlCommand ag = new SqlCommand("insert into detalleVenta values(@folio,@pallet,@tam,@medida,@producto,@desc, @precio, @cajas,  @total)", connection);

                    ag.Parameters.Clear();
                    ag.Parameters.AddWithValue("@folio", Convert.ToInt32(row.Cells["Folio"].Value));
                    ag.Parameters.AddWithValue("@producto", Convert.ToString(row.Cells["Producto"].Value));
                    //ag.Parameters.AddWithValue("@cantidad", Convert.ToInt32(row.Cells["Column2"].Value));
                    ag.Parameters.AddWithValue("@desc", Convert.ToString(row.Cells["Descripcion"].Value));
                    ag.Parameters.AddWithValue("@pallet", Convert.ToString(row.Cells["Pallet"].Value));
                    ag.Parameters.AddWithValue("@medida", Convert.ToString(row.Cells["Medida"].Value));
                    ag.Parameters.AddWithValue("@tam", Convert.ToString(row.Cells["Tamaño"].Value));
                    ag.Parameters.AddWithValue("@precio", Convert.ToString(row.Cells["Precio"].Value));
                    ag.Parameters.AddWithValue("@total", Convert.ToString(row.Cells["Importe"].Value));
                    ag.Parameters.AddWithValue("@cajas", Convert.ToString(row.Cells["CajaxContenido"].Value));

                    ag.ExecuteNonQuery();
                }
                string sqlQuery = "insert into ventas(Id,date,iva, num,nombreP, currency,cond,lugar,subtotal,total) " +
                    "values('" + txtFolio.Text + "',@fecha,'" + txtIva.Text +"','" + txtNumCliente.Text + "','" + comboBox3.Text + "','" + comboMoneda.Text + "','" + txtCondiciones.Text + "','" + txtLugarExpe.Text + "','" + txtSubtotal.Text + "','" + txtTotal.Text + "')";
                cmd = new SqlCommand(sqlQuery, connection);
                cmd.Parameters.AddWithValue("@fecha", dateTimePicker1.Value.Date);
                cmd.ExecuteNonQuery();
                connection.Close();

                decimal total = 0;
                string a;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    connection.Open();
                    total = Convert.ToDecimal(row.Cells[7].Value);
                    a = Convert.ToString(row.Cells[4].Value);
                    string sqlQuery2 = "update FinishedProducts set amountPurchased= amountPurchased-'" + total + "' where name='" + a + "'";
                    cmd2 = new SqlCommand(sqlQuery2, connection);
                    cmd2.ExecuteNonQuery();
                    connection.Close();
                }
                MessageBox.Show("Se ha agregado la venta");
                this.Close();

            }
            else
            {
                MessageBox.Show("Complete todos los campos");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float n2, t, i;
            if (textBox2.Text != "" && txtIva.Text != "")
            {
                n2 = Convert.ToSingle(textBox2.Text);
                i = Convert.ToSingle(txtIva.Text);
                t = i * n2;
                txtSubtotal.Text = t.ToString();

                double a = t + ((i / 100) * t);
                txtTotal.Text = a.ToString();
            }
            else
            {
                MessageBox.Show("Ingrese el IVA o seleccione la opción de sumar");
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            decimal total = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                total += Convert.ToDecimal(row.Cells[8].Value);

            }
            textBox2.Text = total.ToString();


        }

        private void sumar_Click(object sender, EventArgs e)
        {
            double total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                total += Convert.ToDouble(row.Cells[4].Value);

            }
            textBox2.Text = total.ToString();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand d = new SqlCommand("select RFC from clientes where name= '" + comboBox3.Text + "'", connection);
            connection.Open();
            SqlDataReader r = d.ExecuteReader();
            while (r.Read())
            {
                txtNumCliente.Text = r["RFC"].ToString();
            }
            connection.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        Productos materia;
        private void btnArticulo_Click(object sender, EventArgs e)
        {
            materia = new Productos();
            materia.Owner = this;
            materia.FormClosed += materia_FormClosed;
            txtProducto.Text = string.Empty;
            txtCantidad.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtPallet.Text = string.Empty;
            txtMedida.Text = string.Empty;
            txtSAT.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            textBox3.Text = string.Empty;


            materia.Show();
            txtCantidad.Enabled = true;
        }
        private void materia_FormClosed(object sender, FormClosedEventArgs e)
        {
            materia = null;
        }

        private void btnAgregarProd_Click(object sender, EventArgs e)
        {
            if (txtProducto.Text != "")
            {
                if (txtCantidad.Text != "" && textBox3.Text != "")
                {
                    if (txtUniMedAduana.Text != "")
                    {

                        dataGridView1.Rows.Add(txtFolio.Text, txtPallet.Text, textBox4.Text, textBox5.Text, txtProducto.Text, txtDescripcion.Text, txtPrecio.Text, txtCantidad.Text, textBox3.Text);

                        textBox3.Text = string.Empty;
                        txtProducto.Text = string.Empty;
                        txtCantidad.Text = string.Empty;
                        txtDescripcion.Text = string.Empty;
                        txtPallet.Text = string.Empty;
                        txtMedida.Text = string.Empty;
                        txtSAT.Text = string.Empty;
                        txtPrecio.Text = string.Empty;
                        cantidad.Text = string.Empty;
                        txtCantidad.Enabled = false;
                        textBox4.Text = string.Empty;
                        textBox5.Text = string.Empty;
                        txtUniMedAduana.Text = string.Empty;
                        txtAduana.Text = string.Empty;
                        txtFraccion.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Ingrese la medida");
                    }

                }
                else
                {
                    MessageBox.Show("Ingrese la cantidad a utilizar ");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto para agregarlo a la tabla");
            }

        }



        private void button3_Click(object sender, EventArgs e)
        {
            if (this.txtIva.Text.Length > 1)
            {
                double total = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    total += Convert.ToDouble(row.Cells[8].Value);

                }
                double b, c;
                b = Convert.ToInt32(txtIva.Text);
                c = total + (total * (b / 100));
                txtTotal.Text = c.ToString();
            }
            else
                MessageBox.Show("Ingrese el iva");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }
            else
            {
                MessageBox.Show("Seleccione una fila.");
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            float n1, n2, a;

            if (txtCantidad.Text != "")
            {
                if (Convert.ToDecimal(cantidad.Text) != 0)
                {
                    if ((Convert.ToDecimal(txtCantidad.Text)) <= Convert.ToDecimal(cantidad.Text))
                    {
                        n1 = Convert.ToInt32(txtCantidad.Text);
                        n2 = Convert.ToSingle(txtPrecio.Text);
                        a = n1 * n2;
                        textBox3.Text = a.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Cantidad insuficiente, la cantidad disponible es: " + cantidad.Text);
                        txtCantidad.Text = string.Empty;
                    }
                }
                //else
                //{
                //    MessageBox.Show("No hay cantidad disponible");
                //}
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtIva.Text != "")
            {
                txtProducto.Text = string.Empty;
                txtCantidad.Text = string.Empty;
                txtDescripcion.Text = string.Empty;
                txtPallet.Text = string.Empty;
                txtMedida.Text = string.Empty;
                txtSAT.Text = string.Empty;
                txtPrecio.Text = string.Empty;
                textBox3.Text = string.Empty;
                decimal total = 0;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    total += Convert.ToDecimal(row.Cells[8].Value);

                }
                txtSubtotal.Text = total.ToString();
                //total = sub + (iva*subt)n2 = Convert.ToSingle(textBox2.Text);
                float g, h, j;
                g = Convert.ToSingle(txtSubtotal.Text);
                h = Convert.ToSingle(txtIva.Text);
                j = g + (h * (g / 100));
                txtTotal.Text = j.ToString();
            }
            else
            {
                MessageBox.Show("Ingrese IVA");
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.SoloNumeros(e);
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
        int posX;
        int posY;
        private void panelTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("select * from ventas where Id='"+txtFolio.Text+"'", connection);
            SqlDataAdapter adap = new SqlDataAdapter();
            adap.SelectCommand = com;
            DataTable tabla = new DataTable();
            adap.Fill(tabla);
            dataGridView2.DataSource = tabla; 

        }

        private void txtFolio_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    txtProducto.Text = dataGridView2.CurrentRow.Cells["producto"].Value.ToString();
            //    //CajasContenido.Text = dataGridView2.CurrentRow.Cells["cajas"].Value.ToString();
            //    txtCantidad.Text = dataGridView2.CurrentRow.Cells["cajas"].Value.ToString();
            //    txtDescripcion.Text = dataGridView2.CurrentRow.Cells["desc"].Value.ToString();
            //    textBox5.Text = dataGridView2.CurrentRow.Cells["medida"].Value.ToString();
            //    textBox4.Text = dataGridView2.CurrentRow.Cells["tam"].Value.ToString();
            //    txtPallet.Text = dataGridView2.CurrentRow.Cells["pallet"].Value.ToString();
            //    textBox3.Text = dataGridView2.CurrentRow.Cells["total"].Value.ToString();
            //    txtPrecio.Text = dataGridView2.CurrentRow.Cells["precio"].Value.ToString();
            //    //txtUniMedAduana.Text= dataGridView2.CurrentRow.Cells[""].Value.ToString();
            //    //txtMedida.Text = dataGridView2.CurrentRow.Cells[""].Value.ToString();
            //    //txtSAT.Text = dataGridView2.CurrentRow.Cells[""].Value.ToString();
            //    //txtAduana.Text= dataGridView2.CurrentRow.Cells[""].Value.ToString();
            //    //txtFraccion.Text= dataGridView2.CurrentRow.Cells[""].Value.ToString();
            //    //textBox3.Text = dataGridView2.CurrentRow.Cells[""].Value.ToString();
            //}
            //catch
            //{

            //}
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            if (this.txtProducto.Text.Length >= 1)
            {
                SqlCommand c = new SqlCommand("select * from FinishedProducts where name='" + txtProducto.Text + "'", connection);
                SqlDataAdapter ad = new SqlDataAdapter();
                ad.SelectCommand = c;
                DataTable tab = new DataTable();
                ad.Fill(tab);
                dataGridView3.DataSource = tab;
                if (dataGridView3.Rows.Count != 0)
                {
                    txtMedida.Text = dataGridView3.CurrentRow.Cells["unitOfMeasure"].Value.ToString();
                    txtUniMedAduana.Text = dataGridView3.CurrentRow.Cells["medidaAduana"].Value.ToString();
                    txtSAT.Text = dataGridView3.CurrentRow.Cells["SAT"].Value.ToString();
                    txtAduana.Text = dataGridView3.CurrentRow.Cells["cantAduana"].Value.ToString();
                    txtFraccion.Text = dataGridView3.CurrentRow.Cells["fraccion"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("El producto: '"+txtProducto.Text+"' ya no se encuentra en la base de datos, por lo que no se muestran algunos datos.");
                }
            }
            else
            {
                txtMedida.Text = string.Empty;
                txtUniMedAduana.Text = string.Empty;
                txtSAT.Text = string.Empty;
                txtAduana.Text = string.Empty;
                txtFraccion.Text = string.Empty;

            }



        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
                txtProducto.Text = dataGridView2.CurrentRow.Cells["producto"].Value.ToString();
                //CajasContenido.Text = dataGridView2.CurrentRow.Cells["cajas"].Value.ToString();
                txtCantidad.Text = dataGridView2.CurrentRow.Cells["cajas"].Value.ToString();
                txtDescripcion.Text = dataGridView2.CurrentRow.Cells["desc"].Value.ToString();
                textBox5.Text = dataGridView2.CurrentRow.Cells["medida"].Value.ToString();
                textBox4.Text = dataGridView2.CurrentRow.Cells["tam"].Value.ToString();
                txtPallet.Text = dataGridView2.CurrentRow.Cells["pallet"].Value.ToString();
                textBox3.Text = dataGridView2.CurrentRow.Cells["total"].Value.ToString();
                txtPrecio.Text = dataGridView2.CurrentRow.Cells["precio"].Value.ToString();
                //txtUniMedAduana.Text= dataGridView2.CurrentRow.Cells[""].Value.ToString();
                //txtMedida.Text = dataGridView2.CurrentRow.Cells[""].Value.ToString();
                //txtSAT.Text = dataGridView2.CurrentRow.Cells[""].Value.ToString();
                //txtAduana.Text= dataGridView2.CurrentRow.Cells[""].Value.ToString();
                //txtFraccion.Text= dataGridView2.CurrentRow.Cells[""].Value.ToString();
                //textBox3.Text = dataGridView2.CurrentRow.Cells[""].Value.ToString();
            
           

            
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Si quieres modificar el mismo PDF, cierralo de aplicaciones externas.", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                Document doc = new Document(PageSize.A4);

                // Indicamos donde vamos a guardar el documento

                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.InitialDirectory = @"C:";
                saveFileDialog1.Title = "Guardar Reporte";
                saveFileDialog1.DefaultExt = "pdf";
                saveFileDialog1.Filter = "pdf Files (*.pdf)|*.pdf| All Files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;
                string file = "";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    file = saveFileDialog1.FileName;
                }


                //SaveFileDialog save = new SaveFileDialog();
                //save.Filter = "Archivo de pdf |*.pdf";
                //save.InitialDirectory = @"C:\Users\AdriFdez18\Desktop\";
                //save.FileName ="Cliente:"+ Nametxt.Text + ".pdf";

                if (file.Trim() != "")
                {
                        FileStream fileventas = new FileStream(file,
                        FileMode.OpenOrCreate,
                        FileAccess.ReadWrite,
                        FileShare.ReadWrite);
                        PdfWriter.GetInstance(doc, fileventas);


                    //Margenes del documento 
                    doc.SetMargins(30, 30, 10, 10);


                    // Le colocamos el título y el autor
                    // Esto no será visible en el documento
                    doc.AddTitle("Cotizacion");


                    //Se estipula de fuente de escritura 
                    iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                    //fuente de escritura del titulo 
                    var fuentetitulo = FontFactory.GetFont("Arial", 10, BaseColor.BLACK);


                    // Abrimos el archivo
                    doc.Open();



                    //Espacio entre parrafos
                    var spacer = new Paragraph("")
                    {
                        SpacingBefore = 10f,
                        SpacingAfter = 10f,
                    };


                    //Agregar imagen al pdf se debe poner la ruta de la imagen de infromacion esta en la carpta de imagenes del proyecto
                    var imagenpath = @"C:\Users\AdriFdez18\Desktop\Extra\Ware\WaareDev\Software\WareDev\WareDev\Imagenes\Informacion.jpeg";

                    using (FileStream im = new FileStream(imagenpath, FileMode.Open))
                    {
                        var jpg = iTextSharp.text.Image.GetInstance(System.Drawing.Image.FromStream(im), System.Drawing.Imaging.ImageFormat.Png);
                        //(x,y)
                        jpg.SetAbsolutePosition(450, 0);
                        jpg.ScalePercent(25, 25);
                        doc.Add(jpg);

                    }

                    //Agregar imagen al pdf se debe poner la ruta de la imagen de infromacion esta en la carpta de imagenes del proyecto
                    var Logopath = @"C:\Users\AdriFdez18\Desktop\Extra\Ware\WaareDev\Software\WareDev\WareDev\Imagenes\Logo.jpeg";

                    using (FileStream im = new FileStream(Logopath, FileMode.Open))
                    {
                        var png = iTextSharp.text.Image.GetInstance(System.Drawing.Image.FromStream(im), System.Drawing.Imaging.ImageFormat.Png);
                        //(x,y)
                        png.SetAbsolutePosition(190, 770);
                        png.ScalePercent(15, 15);
                        doc.Add(png);

                    }



                    // Escribimos el encabezamiento en el documento
                    var titulo = new Paragraph("PROMOTORA Y COMERCIALIZADORA COSTA MAYA S.A DE C.V.", fuentetitulo);


                    titulo.SpacingBefore = 0;
                    titulo.Alignment = 2;
                    doc.Add(titulo);
                    doc.Add(Chunk.NEWLINE);
                    doc.Add(spacer);

                    // Creamos la tabla con con la infromacion de cliente y vendedor 

                    var headertable = new PdfPTable(new[] { 3f, 3f, 3f, 3f })
                    {
                        HorizontalAlignment = Left,
                        WidthPercentage = 100,
                        DefaultCell = { MinimumHeight = 22f }

                    };
                    doc.Add(spacer);

                    //Creacion de Tabla de datos de comprador 
                    headertable.AddCell("FECHA");
                    headertable.AddCell(DateTime.Now.ToString());
                    headertable.AddCell("FOLIO");
                    headertable.AddCell(txtFolio.Text);
                    headertable.AddCell("LUGAR DE EXPEDICION");
                    headertable.AddCell(txtLugarExpe.Text);
                    headertable.AddCell("CLIENTE");
                    headertable.AddCell(comboBox3.Text);
                    headertable.AddCell("RFC/ID");
                    headertable.AddCell(txtNumCliente.Text);
                    headertable.AddCell("CONDICION COMERCIAL");
                    headertable.AddCell(txtCondiciones.Text);
                    headertable.AddCell("MONEDA");
                    headertable.AddCell(comboMoneda.Text);


                    doc.Add(headertable);
                    doc.Add(spacer);


                    //Creacion de Tabla de Cotizacion

                    var columCount = dataGridView1.ColumnCount;
                    var columAncho = new[] { 1f, 2f, 2f, 3f, 3f, 3f, 2f, 2f, 2f };


                    var table = new PdfPTable(columAncho)
                    {
                        HorizontalAlignment = Left,
                        WidthPercentage = 100,
                        DefaultCell = { MinimumHeight = 22f }

                    };

                    var cell = new PdfPCell(new Phrase("Informacion de Venta"))
                    {

                        Colspan = columCount,
                        HorizontalAlignment = 1,
                        MinimumHeight = 30f

                    };

                    table.AddCell(cell);

                    //Encabezados del DataGridview
                    dataGridView1.Columns
                        .OfType<DataGridViewColumn>()
                        .ToList()
                        .ForEach(c => table.AddCell(c.Name));

                    //Columnas
                    dataGridView1.Rows
                        .OfType<DataGridViewRow>()
                        .ToList()
                        .ForEach(r =>
                        {
                            var cells = r.Cells.OfType<DataGridViewCell>().ToList();
                            cells.ForEach(c => table.AddCell(c.Value.ToString()));

                        });

                    doc.Add(table);


                    var downtable = new PdfPTable(new[] { .5f, .5f })
                    {
                        HorizontalAlignment = Right,
                        WidthPercentage = 100,
                        DefaultCell = { MinimumHeight = 5f }

                    };
                    doc.Add(spacer);


                    downtable.AddCell("Subtotal");
                    downtable.AddCell(txtSubtotal.Text);
                    downtable.AddCell("IVA");
                    downtable.AddCell(txtIva.Text);
                    downtable.AddCell("Total");
                    downtable.AddCell(txtTotal.Text);

                    doc.Add(downtable);
                    doc.Close();
                }
            }
            else
            {
                MessageBox.Show("Cierre el pdf para poder modificarlo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
