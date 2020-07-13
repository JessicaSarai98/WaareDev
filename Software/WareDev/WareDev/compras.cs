using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WareDev
{
    public partial class compras : Form
    {
        public compras()
        {
            InitializeComponent();
        }

        //SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jessica\Documents\fruteria.mdf;Integrated Security=True;Connect Timeout=30");

        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = C:\Users\William carmona\Documents\users.mdf;Integrated Security = True");
        SqlCommand cmd;
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
            SqlCommand cm = new SqlCommand("select name from supplier",connection);
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
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close(); 
            }
            txtCantidad.Enabled = false;
            prov_SelectedIndexChanged(null, null);
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
            SqlCommand d = new SqlCommand("select Id from supplier where name= '"+prov.Text+"'", connection);
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
            if ((this.dateTimePicker1 != null) &&(this.txtName.Text.Length>=1) && (this.txtPrecioUnitario.Text.Length>=1) && (this.prov.Text.Length>=1) && (this.txtNoPro.Text.Length>=1) && (this.txtCantidad.Text.Length>=1) && (this.txtDescripcion.Text.Length>=1) && (this.txtTotalCompra.Text.Length>=1))
            {
                connection.Open();
                string sql = "insert into compras(Id,fecha,product,price,provider,numberP,amountPurchased,total,description) values('"+txtFolioCompra.Text+ "',@fecha,'"+txtName.Text+ "','"+txtPrecioUnitario.Text+ "','"+prov.Text+ "','"+txtNoPro.Text+ "','"+txtCantidad.Text+"','"+txtTotalCompra.Text+"','"+txtDescripcion.Text+"')";
                cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@fecha",dateTimePicker1.Value);
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Se ha agregado la compra");
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Complete todos los campos");
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            double  n1, n2, a;
            if (txtPrecioUnitario.Text=="") {
                
                txtCantidad.Text = string.Empty;
                MessageBox.Show("Ingrese el precio unitario");
                
            }else if(txtCantidad.Text != "")
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

        }
    }
}
