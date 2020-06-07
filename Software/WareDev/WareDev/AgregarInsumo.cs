using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WareDev
{
    public partial class Agregar : Form
    {

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jessica\Documents\fruteria.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;
        public Agregar()
        {
            InitializeComponent();
        }

        private void AgregarInsumo_Load(object sender, EventArgs e)
        {

        }

        private void btrRegreso_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCantidad_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Regex rx = new Regex(@"^[0-9]+\.[0-9]{2}?", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            if ((rx.IsMatch(txtCantidad.Text)) && (e.KeyChar != (char)Keys.Back) || char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private void addR_Click(object sender, EventArgs e)
        {
            connection.Open();
            string sqlQuery = "update rawMaterials set amountPurchased = amountPurchased + @cant where name = '"+textBox1.Text+"'";
            cmd = new SqlCommand(sqlQuery, connection);
            cmd.Parameters.AddWithValue("@cant", txtCantidad.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Se ha agregado la cantidad a "+textBox1.Text);
            this.Close();
        }

        private void addI_Click(object sender, EventArgs e)
        {
            connection.Open();
            string sqlQuery = "update inputs set amountPurchased = amountPurchased + @cant where name = '" + textBox1.Text + "'";
            cmd = new SqlCommand(sqlQuery, connection);
            cmd.Parameters.AddWithValue("@cant", txtCantidad.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Se ha agregado la cantidad a " + textBox1.Text);
            this.Close();
            
        }

        private void addF_Click(object sender, EventArgs e)
        {
            connection.Open();
            string sqlQuery = "update FinishedProducts set amountPurchased = amountPurchased + @cant where name = '" + textBox1.Text + "'";
            cmd = new SqlCommand(sqlQuery, connection);
            cmd.Parameters.AddWithValue("@cant", txtCantidad.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Se ha agregado la cantidad a " + textBox1.Text);
            this.Close();
        }
    }
}
