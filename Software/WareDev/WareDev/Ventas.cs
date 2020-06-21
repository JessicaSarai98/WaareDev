﻿using System;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace WareDev
{
    public partial class ventas : Form
    {
        public ventas()
        {
            InitializeComponent();
        }

        //SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-SDO1671B;Initial Catalog=users;Integrated Security=True;Pooling=False");
        //SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jessica\Documents\fruteria.mdf;Integrated Security=True;Connect Timeout=30");
        // karina
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = C:\Users\William carmona\Documents\users.mdf;Integrated Security = True");
        SqlCommand cmd;
        SqlCommand cmd2;
        SqlDataAdapter adapter;
        DataTable table;
        private void ventas_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today;
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
            //SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Jessica\Documents\fruteria.mdf; Integrated Security = True; Connect Timeout = 30");
            //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jessica\Documents\fruteria.mdf;Integrated Security=True;Connect Timeout=30");
            // karina
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = C:\Users\William carmona\Documents\users.mdf;Integrated Security = True");
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                string pcount = Convert.ToString(cmd.ExecuteScalar());
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
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
                    SqlCommand ag = new SqlCommand("insert into detalleVenta values(@folio,@subtotal,@producto,@cantidad,@desc,@pallet, @medida, @tam,  @precio)", connection);

                    ag.Parameters.Clear();
                    ag.Parameters.AddWithValue("@folio", Convert.ToInt32(row.Cells["Column8"].Value));
                    ag.Parameters.AddWithValue("@producto", Convert.ToString(row.Cells["Column1"].Value));
                        //ag.Parameters.AddWithValue("@cantidad", Convert.ToInt32(row.Cells["Column2"].Value));
                    ag.Parameters.AddWithValue("@desc", Convert.ToString(row.Cells["Column3"].Value));
                    ag.Parameters.AddWithValue("@pallet", Convert.ToString(row.Cells["Column4"].Value));
                    ag.Parameters.AddWithValue("@medida", Convert.ToString(row.Cells["Column5"].Value));
                    ag.Parameters.AddWithValue("@tam", Convert.ToString(row.Cells["Column6"].Value));
                    ag.Parameters.AddWithValue("@precio", Convert.ToString(row.Cells["Column7"].Value));
                    ag.Parameters.AddWithValue("@subtotal", Convert.ToString(row.Cells["Column9"].Value));
                    ag.Parameters.AddWithValue("@cantidad", Convert.ToString(row.Cells["Column2"].Value));

                    ag.ExecuteNonQuery();
                }
                string sqlQuery = "insert into ventas(Id,date,iva,num,nombreP, currency,cond,lugar,subtotal,total) " +
                    "values('" + txtFolio.Text + "',@fecha,'" + txtIva.Text + "','" + txtNumCliente.Text + "','" + comboBox3.Text + "','" + comboMoneda.Text + "','" + txtCondiciones.Text + "','" + txtLugarExpe.Text + "','" + txtSubtotal.Text + "','" + txtTotal.Text + "')";
                cmd = new SqlCommand(sqlQuery, connection);
                cmd.Parameters.AddWithValue("@fecha", dateTimePicker1.Value.Date);
                cmd.ExecuteNonQuery();
                connection.Close();

                decimal total = 0;
                string a; 

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    connection.Open();
                    total = Convert.ToDecimal(row.Cells[2].Value);
                    a = Convert.ToString(row.Cells[1].Value);
                    string sqlQuery2 = "update FinishedProducts set amountPurchased= amountPurchased-'"+total+"' where name='" +a+ "'";
                    cmd2 = new SqlCommand(sqlQuery2,connection);
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
            SqlCommand d = new SqlCommand("select Id from clientes where name= '" + comboBox3.Text + "'", connection);
            connection.Open();
            SqlDataReader r = d.ExecuteReader();
            while (r.Read())
            {
                txtNumCliente.Text = r["Id"].ToString();
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
            materia.Show();
            txtCantidad.Enabled = true;
        }
        private void materia_FormClosed(object sender, FormClosedEventArgs e)
        {
            materia = null;
        }

        private void btnAgregarProd_Click(object sender, EventArgs e)
        {
            if(txtProducto.Text!= "" )
            {
                if (txtCantidad.Text != "" && textBox3.Text != "")
                {
                    if (txtMedida.Text != "")
                    {

                        dataGridView1.Rows.Add(txtFolio.Text, txtProducto.Text, txtCantidad.Text, txtDescripcion.Text, txtPallet.Text, txtMedida.Text, txtTam.Text, txtPrecio.Text, textBox3.Text, txtSubtotal.Text, txtTotal.Text);

                        textBox3.Text = string.Empty;
                        txtProducto.Text = string.Empty;
                        txtCantidad.Text = string.Empty;
                        txtDescripcion.Text = string.Empty;
                        txtPallet.Text = string.Empty;
                        txtMedida.Text = string.Empty;
                        txtTam.Text = string.Empty;
                        txtPrecio.Text = string.Empty;
                        cantidad.Text = string.Empty;
                        txtCantidad.Enabled = false;
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
                double b,c;
                b = Convert.ToInt32(txtIva.Text);
                c = total + (total*(b/100));
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
                else
                {
                    MessageBox.Show("No hay cantidad disponible");
                }
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
                txtTam.Text = string.Empty;
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
    }
}
