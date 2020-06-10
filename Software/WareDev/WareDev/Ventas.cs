using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            SqlCommand cm = new SqlCommand("select name from FinishedProducts", connection);
            connection.Open();
            SqlDataReader registro = cm.ExecuteReader();
            while (registro.Read())
            {
                comboBox1.Items.Add(registro["name"].ToString());
            }
            connection.Close();

            //SqlCommand c = new SqlCommand("select Id from supplier", connection);
            //connection.Open();
            //SqlDataReader reg = c.ExecuteReader();
            //while (reg.Read())
            //{
            //    comboBox2.Items.Add(reg["Id"].ToString());
            //}
            //connection.Close();

            SqlCommand d = new SqlCommand("select name from supplier", connection);
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
            // karina
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jessica\Documents\fruteria.mdf;Integrated Security=True;Connect Timeout=30");
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




            //string query = "select name from FinishedProducts";
            //comboBox1.DataSource = GetData(query);
            //comboBox1.DisplayMember = "name";

            comboBox1_SelectedIndexChanged(null, null);
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            //string query = "select name, size, measure, description, unitPrice, boxes, amountPurchased from FinishedProducts where name ='" + comboBox1.Text + "'";
            //TablaDeVenta.DataSource = GetData(query);



            //decimal total = 0;

            //foreach (DataGridViewRow row in dataGridView1.Rows)
            //{

            //    total += Convert.ToDecimal(row.Cells[4].Value);

            //}
            //textBox2.Text = total.ToString();




            //decimal n1,n2, t;
            //n1= Convert.ToDecimal(textBox1.Text);
            //n2 = Convert.ToDecimal(textBox2.Text);
            //t = n1 * n2;
            //txtSubtotal.Text = t.ToString(); 

            //this.TablaDeVenta.Columns[0].HeaderText = "Name";
            //this.TablaDeVenta.Columns[1].HeaderText = "Size";
            //this.TablaDeVenta.Columns[2].HeaderText = "Measure";
            //this.TablaDeVenta.Columns[3].HeaderText = "Description";
            //this.TablaDeVenta.Columns[4].HeaderText = "Unit Price";
            //this.TablaDeVenta.Columns[5].HeaderText = "Boxes";
            //this.TablaDeVenta.Columns[6].HeaderText = "Amount Purchased";
        }



        private void TablaDeVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //textBox3.Text = TablaDeVenta.CurrentRow.Cells["Name"].Value.ToString();

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
                    //SqlCommand c = new SqlCommand("select name, size, measure, description, unitPrice, boxes, amountPurchased from FinishedProducts where name ='" + comboBox1.Text + "'", connection);
                    //SqlDataAdapter da = new SqlDataAdapter(c);
                    //da.Fill(dt);
                    //dataGridView1.DataSource = dt;


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
            
            //string query = "select name, size, measure, description, unitPrice, boxes, amountPurchased from FinishedProducts where name ='" + comboBox1.Text + "'";
            //ablaDeVenta.DataSource = GetData(query);
        }

        //Guardar 
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if((this.dateTimePicker1!=null) &&(this.txtIva.Text.Length>=1) && (this.txtNumCliente.Text.Length>= 1) && (this.comboMoneda.Text.Length>= 1) &&
                (this.comboBox3.Text.Length >= 1) && (this.txtSubtotal.Text.Length >= 1) && (this.txtTotal.Text.Length >= 1))
            {
                connection.Open();
                string sqlQuery = "insert into ventas(Id,date,iva,num,nombreP, currency,subtotal,total) " +
                    "values('"+txtFolio.Text+ "',@fecha,'"+txtIva.Text+ "','"+ txtNumCliente.Text+ "','"+comboBox3.Text+ "','"+comboMoneda.Text+ "','"+txtSubtotal.Text+ "','"+txtTotal.Text+"')";
               string sqlQuery2 = "update FinishedProducts set amountPurchased= amountPurchased-@cant where name='"+comboBox1.Text+"'";
                
                cmd = new SqlCommand(sqlQuery, connection);
                cmd.Parameters.AddWithValue("@fecha",dateTimePicker1.Value.Date);

                cmd2 = new SqlCommand(sqlQuery2, connection);
                cmd2.Parameters.AddWithValue("@cant", textBox1.Text);

                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Se ha agregado la venta");
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Complete todos los campos");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //total = sub + (iva*subt)
            //sub = suma de los productos 

            float n2, t, i;



            //n1 = Convert.ToDouble(textBox1.Text);

            //subtotal
            if (textBox2.Text != "" && txtIva.Text != "")
            {
                n2 = Convert.ToSingle(textBox2.Text);
                //t = n1 * n2;
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


            this.dataGridView1.Columns[0].HeaderText = "Name";
            this.dataGridView1.Columns[1].HeaderText = "Size";
            this.dataGridView1.Columns[2].HeaderText = "Measure";
            this.dataGridView1.Columns[3].HeaderText = "Description";
            this.dataGridView1.Columns[4].HeaderText = "Unit Price";
            this.dataGridView1.Columns[5].HeaderText = "Boxes";
            this.dataGridView1.Columns[6].HeaderText = "Amount Purchased";
            decimal total = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                total += Convert.ToDecimal(row.Cells[4].Value);

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
            //int index;
            //index = comboBox3.SelectedIndex;
            //case inde
            SqlCommand d = new SqlCommand("select Id from supplier where name= '" + comboBox3.Text + "'", connection);
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
            if (materia == null)
            {
                materia = new Productos();
                materia.Owner = this;
                materia.FormClosed += materia_FormClosed;
                materia.Show();
            }
            else materia.Activate();
        }
        private void materia_FormClosed(object sender, FormClosedEventArgs e)
        {
            materia = null;
        }

        private void btnAgregarProd_Click(object sender, EventArgs e)
        {

        }
    }
}
