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
        // JESS
        //SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-SDO1671B;Initial Catalog=users;Integrated Security=True;Pooling=False");
        //SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jessica\Documents\fruteria.mdf;Integrated Security=True;Connect Timeout=30");
        // KARINA
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = C:\Users\William carmona\Documents\users.mdf;Integrated Security = True");
        SqlCommand cmd;
        SqlCommand cmd2;
        SqlCommand cmd3;
        SqlCommand cmd4;
        SqlCommand cmd5;
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
            ValidarDatos.SoloNumeros(e);
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
            
            int a, b, c, d, f;
            a = Convert.ToInt32(input.Text);
            b = Convert.ToInt32(raw.Text);
            c = Convert.ToInt32(txtCantidad.Text);
            d = a * c;
            f = b * c;
            if (a <= Convert.ToInt32(inputC.Text))
            {
                if (f <= Convert.ToInt32(rawC.Text))
                {
                    connection.Open();
                    string sqlQuery = "update FinishedProducts set amountPurchased = amountPurchased + @cant where name = '" + textBox1.Text + "'";
                    string sqlQuery1 = "update FinishedProducts set quantityUsedI = '" + d + "' where name = '" + textBox1.Text + "'";
                    string sqlQuery2 = "update FinishedProducts set quantityUsedR = '" + f + "' where name = '" + textBox1.Text + "'";

                    string sqlQuery3 = "update inputs set amountPurchased = amountPurchased - '"+d+"' where name='"+inputN.Text+"'";
                    string sqlQuery4 = "update rawMaterials set amountPurchased = amountPurchased - '" + f + "' where name= '"+rawN.Text+"'";
                    
                    cmd = new SqlCommand(sqlQuery, connection);
                    cmd2 = new SqlCommand(sqlQuery1, connection);
                    cmd3 = new SqlCommand(sqlQuery2, connection);
                    cmd4 = new SqlCommand(sqlQuery3, connection);
                    cmd5 = new SqlCommand(sqlQuery4, connection);

                    cmd.Parameters.AddWithValue("@cant", txtCantidad.Text);
                    //cmd2.Parameters.AddWithValue("@a",input.Text);
                    //cmd3.Parameters.AddWithValue("@f",raw.Text);
                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    cmd3.ExecuteNonQuery();
                    cmd4.ExecuteNonQuery();
                    cmd5.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Se ha agregado la cantidad a " + textBox1.Text);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("No hay suficiente cantidad en Raw");
                }
            }
            else
            {
                MessageBox.Show("No hay suficiente cantidad en input");
            }
        }

        private void titulo_Click(object sender, EventArgs e)
        {
            

        }
    }
}
