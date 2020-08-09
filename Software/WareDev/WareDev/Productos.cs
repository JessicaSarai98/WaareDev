 using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WareDev
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }
        //Jess
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jessica\Documents\fruteria.mdf;Integrated Security=True;Connect Timeout=30");
        
        // karina
        // SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = C:\Users\William carmona\Documents\users.mdf;Integrated Security = True");
        private void btrRegreso_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void Productos_Load(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand("select name from FinishedProducts", connection);
            connection.Open();
            SqlDataReader registro = cm.ExecuteReader();
            while (registro.Read())
            {
                ComboNombre.Items.Add(registro["name"].ToString());

            }
            connection.Close();

            
            

        }
        public DataTable GetData(string query)
        {
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }
        private void ComboNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select name, size, measure,description, unitPrice, amountPurchased, medidaAduana,SAT, cantAduana, unitOfMeasure, fraccion  from FinishedProducts where name = '" + ComboNombre.Text + "'  ";
            dataGridView1.DataSource = GetData(query);
            this.dataGridView1.Columns[0].HeaderText = "Nombre";
            this.dataGridView1.Columns[1].HeaderText = "Tamaño";
            this.dataGridView1.Columns[2].HeaderText = "Medida";
            this.dataGridView1.Columns[3].HeaderText = "Descripción";
            this.dataGridView1.Columns[4].HeaderText = "Precio unitario";
            this.dataGridView1.Columns[5].HeaderText = "Cantidad adquirida";
            this.dataGridView1.Columns[6].HeaderText = "Unidad de Medida Aduana";
            this.dataGridView1.Columns[7].HeaderText = "Clave SAT";
            this.dataGridView1.Columns[8].HeaderText = "Cantidad Aduana";
            this.dataGridView1.Columns[9].HeaderText = "Unidad de Medida";
            this.dataGridView1.Columns[10].HeaderText = "Fracción Arrancelaria"; 

        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                List<Form> OpenForms = new List<Form>();

                ventas ventas = new ventas();
                Cotizaciones cot = new Cotizaciones(); 
                foreach (Form frm in Application.OpenForms)
                {
                    
                    if(frm.Name == "ventas")
                    {
                        
                        ventas = (ventas)frm;
                       
                        ventas.txtProducto.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                        ventas.txtDescripcion.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                       // ventas.txtPallet.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                        ventas.textBox5.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                        ventas.textBox4.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                        ventas.txtPrecio.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                        ventas.cantidad.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                        ventas.txtUniMedAduana.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                        ventas.txtSAT.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                        ventas.txtAduana.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                        ventas.txtFraccion.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                        ventas.txtMedida.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();

                        
                        this.Close();
                        
                        break;

                    }

                    else if (frm.Name == "Cotizaciones")
                    {

                        cot = (Cotizaciones)frm;

                        cot.txtProducto.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                        cot.txtDescripcion.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                        cot.txtMedida.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                        //cot.txtPallet.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                        cot.txtTam.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                        cot.txtPrecio.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                        cot.txtCan.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

                       
                        this.Close();
                        break;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
    }
}



    


