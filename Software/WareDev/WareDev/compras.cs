﻿using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data; 


namespace WareDev
{
    public partial class compras : Form
    {
        public compras()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jessica\Documents\fruteria.mdf;Integrated Security=True;Connect Timeout=30");

        //SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = C:\Users\William carmona\Documents\users.mdf;Integrated Security = True");
        SqlCommand cmd;
        SqlCommand cmd1;
        SqlCommand cmd2;
        SqlCommand cmd3;
        DataTable table;
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

        private void btrRegreso_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            AbrirFormInPanel(new Start());
        }

        private void compras_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today;
            SqlCommand cm = new SqlCommand("select name from supplier", connection);
            connection.Open();
            SqlDataReader r = cm.ExecuteReader();
            while (r.Read())
            {
                prov.Items.Add(r["name"].ToString());
            }
            connection.Close();



            string query = "select max(Id) from compras";
            SqlCommand c = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                string pcount = Convert.ToString(c.ExecuteScalar());
                if (this.txtFolioCompra.Text.Equals(""))
                {
                    if (pcount.Length == 0)
                    {
                        txtFolioCompra.Text = "1";
                    }
                    else
                    {
                        int pcount1 = Convert.ToInt32(pcount);
                        int pcountAdd = pcount1 + 1;
                        txtFolioCompra.Text = pcountAdd.ToString();
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            txtCantidad.Enabled = false;
            prov_SelectedIndexChanged(null, null);
            SqlCommand com = new SqlCommand("select * from detalleCompras where Id='" + txtFolioCompra.Text + "'", connection);
            SqlDataAdapter adap = new SqlDataAdapter();
            adap.SelectCommand = com;
            DataTable tabla = new DataTable();
            adap.Fill(tabla);
            dataGridView2.DataSource = tabla;

            this.dataGridView2.Columns[0].HeaderText = "Folio";
            this.dataGridView2.Columns[1].HeaderText = "Tipo";
            this.dataGridView2.Columns[2].HeaderText = "Producto";
            this.dataGridView2.Columns[3].HeaderText = "Descripción";
            this.dataGridView2.Columns[4].HeaderText = "Precio";
            this.dataGridView2.Columns[5].HeaderText = "Cantidad";
            this.dataGridView2.Columns[6].HeaderText = "Total";

           


        }

        private void txtFolioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Sólo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtTotalCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex rx = new Regex(@"^[0-9]+\.[0-9]{2}?", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            if ((rx.IsMatch(txtTotalCompra.Text)) && (e.KeyChar != (char)Keys.Back) || char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private void prov_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand d = new SqlCommand("select Id from supplier where name= '" + prov.Text + "'", connection);
            connection.Open();
            SqlDataReader r = d.ExecuteReader();
            while (r.Read())
            {
                txtNoPro.Text = r["Id"].ToString();
            }
            connection.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if ((this.dateTimePicker1 != null) && (this.prov.Text.Length >= 1) && (this.txtNoPro.Text.Length >= 1))
            {


                connection.Open();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    SqlCommand ag = new SqlCommand("insert into detalleCompras values(@folio,@tipo,@product,@descripcion,@precio,@amountPurchased,@total)", connection);

                    ag.Parameters.Clear();
                    ag.Parameters.AddWithValue("@folio", Convert.ToString(row.Cells["Column7"].Value));
                    ag.Parameters.AddWithValue("@tipo", Convert.ToString(row.Cells["Column1"].Value));
                    ag.Parameters.AddWithValue("@product", Convert.ToString(row.Cells["Column2"].Value));
                    ag.Parameters.AddWithValue("@descripcion", Convert.ToString(row.Cells["Column3"].Value));
                    ag.Parameters.AddWithValue("@precio", Convert.ToString(row.Cells["Column4"].Value));
                    ag.Parameters.AddWithValue("@amountPurchased", Convert.ToString(row.Cells["Column5"].Value));
                    ag.Parameters.AddWithValue("@total", Convert.ToString(row.Cells["Column6"].Value));
                    ag.ExecuteNonQuery();
                }


                string sql = "insert into compras(Id,fecha,provider,numberP,total) values('" + txtFolioCompra.Text + "',@fecha,'" + prov.Text + "','" + txtNoPro.Text + "','" + txtTot.Text + "')";
                cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@fecha", dateTimePicker1.Value);
                cmd.ExecuteNonQuery();
                connection.Close();

                decimal total = 0;
                string a, b;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    connection.Open();
                    total = Convert.ToDecimal(row.Cells[5].Value);
                    a = Convert.ToString(row.Cells[2].Value);
                    b = Convert.ToString(row.Cells[1].Value);

                    if (b.Equals("Materia Prima"))
                    {
                        string sqlQuery1 = "update rawMaterials set amountPurchased= amountPurchased +'" + total + "' where name='" + a + "'";
                        cmd1 = new SqlCommand(sqlQuery1, connection);
                        cmd1.ExecuteNonQuery();
                        //connection.Close();
                    }
                    else if (b.Equals("Producto Terminado"))
                    {
                        string sqlQuery2 = "update FinishedProducts set amountPurchased= amountPurchased+'" + total + "' where name='" + a + "'";
                        cmd2 = new SqlCommand(sqlQuery2, connection);
                        cmd2.ExecuteNonQuery();
                    }
                    else if (b.Equals("Insumo"))
                    {
                        string sqlQuery3 = "update inputs set amountPurchased= amountPurchased+'" + total + "' where name='" + a + "'";
                        cmd3 = new SqlCommand(sqlQuery3, connection);
                        cmd3.ExecuteNonQuery();
                    }
                    connection.Close();
                }

                MessageBox.Show("Se ha agregado la compra");
                this.Close();

            }
            else
            {
                MessageBox.Show("Complete todos los campos.");
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            double n1, n2, a;
            if (txtPrecioUnitario.Text == "") {

                txtCantidad.Text = string.Empty;
                //MessageBox.Show("Ingrese el precio unitario");

            } else if (txtCantidad.Text != "")
            {
                n1 = Convert.ToDouble(txtCantidad.Text);
                n2 = Convert.ToDouble(txtPrecioUnitario.Text);
                a = n1 * n2;
                txtTotalCompra.Text = a.ToString();

            }
        }

        private void txtPrecioUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.NumerosDecimales(e);
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.SoloNumeros(e);
        }

        private void txtPrecioUnitario_TextChanged(object sender, EventArgs e)
        {
            txtCantidad.Enabled = true;
            if (txtPrecioUnitario.Text != "" && txtCantidad.Text != "")
            {
                double n3, n4, b;
                n3 = Convert.ToDouble(txtCantidad.Text);
                n4 = Convert.ToDouble(txtPrecioUnitario.Text);
                b = n4 * n3;
                txtTotalCompra.Text = b.ToString();
            }

        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.SoloLetras(e);
        }

        private void txtUniMedida_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtTipo.Enabled == true)
            {
                txtName.Items.Clear();
                const string message = "¿El producto de compra ya está dado de alta en el inventario?";
                const string captiom = "Advertencia";
                if (txtTipo.Text.Equals("Materia Prima"))
                {
                    var result = MessageBox.Show(message, captiom, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.No)
                    {
                        SqlCommand j = new SqlCommand("select name from rawMaterials", connection);
                        connection.Open();
                        SqlDataReader r = j.ExecuteReader();
                        while (r.Read())
                        {

                            txtName.Items.Add(r["name"].ToString());
                        }
                        connection.Close();
                    }
                    else
                    {
                        MateriaPrima m = new MateriaPrima();
                        this.Close();
                        m.Show();
                    }
                }

                else if (txtTipo.Text.Equals("Producto Terminado"))
                {
                    var result2 = MessageBox.Show(message, captiom, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result2 == DialogResult.No)
                    {
                        SqlCommand g = new SqlCommand("select name from FinishedProducts", connection);
                        connection.Open();
                        SqlDataReader y = g.ExecuteReader();
                        while (y.Read())
                        {
                            txtName.Items.Add(y["name"].ToString());
                        }
                        connection.Close();
                    }
                    else
                    {
                        ProductoExistente prod = new ProductoExistente();
                        this.Close();
                        prod.Show();

                    }
                }
                else if (txtTipo.Text.Equals("Insumo"))
                {
                    var result3 = MessageBox.Show(message, captiom, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result3 == DialogResult.No)
                    {
                        SqlCommand k = new SqlCommand("select name from inputs", connection);
                        connection.Open();
                        SqlDataReader z = k.ExecuteReader();
                        while (z.Read())
                        {
                            txtName.Items.Add(z["name"].ToString());
                        }
                        connection.Close();
                    }
                    else
                    {
                        Insumos ins = new Insumos();
                        this.Close();
                        ins.Show();
                    }
                }
            }
        }

        private void txtName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((this.txtTipo.Text.Length >= 1)&&(this.txtName.Text.Length>=1)&&(this.txtDescripcion.Text.Length>=1)&&(this.txtPrecioUnitario.Text.Length >= 1)&&(this.txtCantidad.Text.Length >= 1)&&(this.prov.Text.Length >= 1)&&(this.txtNoPro.Text.Length >= 1)&&(this.txtTotalCompra.Text.Length >= 1)) {
                dataGridView1.Rows.Add(txtFolioCompra.Text, txtTipo.Text, txtName.Text, txtDescripcion.Text, txtPrecioUnitario.Text, txtCantidad.Text, txtTotalCompra.Text);
                txtTipo.Text = string.Empty;
                txtName.Text = string.Empty;
                txtPrecioUnitario.Text = string.Empty;
                //prov.Text = string.Empty;
                //txtNoPro.Text = string.Empty;
                txtCantidad.Text = string.Empty;
                txtTotalCompra.Text = string.Empty;
                txtDescripcion.Text = string.Empty;
                decimal tot = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    tot += Convert.ToDecimal(row.Cells[6].Value);
                }
                txtTot.Text = tot.ToString();
            }
            else
            {
                MessageBox.Show("Complete todos los campos.");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtTipo.Text = dataGridView1.CurrentRow.Cells["tipo"].Value.ToString();
            //txtName.Text = dataGridView1.CurrentRow.Cells["producto"].Value.ToString();
            //txtPrecioUnitario.Text = dataGridView1.CurrentRow.Cells["precio"].Value.ToString();
            //prov.Text = dataGridView1.CurrentRow.Cells["provider"].Value.ToString();
            //txtNoPro.Text = dataGridView1.CurrentRow.Cells["numberP"].Value.ToString();
            //txtCantidad.Text = dataGridView1.CurrentRow.Cells["amountPurchased"].Value.ToString();
            //txtTotalCompra.Text = dataGridView1.CurrentRow.Cells["total"].Value.ToString();
            //txtDescripcion.Text = dataGridView1.CurrentRow.Cells["descripcion"].Value.ToString();

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTipo.Text = dataGridView2.CurrentRow.Cells["tipo"].Value.ToString();
            txtName.Text = dataGridView2.CurrentRow.Cells["product"].Value.ToString();
            txtPrecioUnitario.Text = dataGridView2.CurrentRow.Cells["precio"].Value.ToString();
            //prov.Text = dataGridView2.CurrentRow.Cells["provider"].Value.ToString();
            //txtNoPro.Text = dataGridView2.CurrentRow.Cells["numberP"].Value.ToString();
            txtCantidad.Text = dataGridView2.CurrentRow.Cells["amountPurchased"].Value.ToString();
            txtTotalCompra.Text = dataGridView2.CurrentRow.Cells["total"].Value.ToString();
            txtDescripcion.Text = dataGridView2.CurrentRow.Cells["descripcion"].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                decimal tot = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    tot += Convert.ToDecimal(row.Cells[6].Value);
                }
                txtTot.Text = tot.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila.");
            }
        }
    }
}
