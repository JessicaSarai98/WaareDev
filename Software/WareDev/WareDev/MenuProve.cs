using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Common.cache;
using System.Data.SqlClient; 

namespace WareDev
{
    public partial class MenuProve : Form
    {

        CN_Clientes objetoCN = new CN_Clientes();

        public string idSup = null; 

        private void MostrarProvee()
        {
            CN_Clientes objeto = new CN_Clientes();
            dataGridView1.DataSource = objeto.MostrarSup(); 
        }
        public MenuProve()
        {
            InitializeComponent();
        }

        //nuevo proveedor
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Supplier sup = new Supplier(); 
            string query = "select max(Id) from supplier";
            //jess
            //SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Jessica\Documents\fruteria.mdf; Integrated Security = True; Connect Timeout = 30");
            //karina
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = C:\Users\William carmona\Documents\users.mdf;Integrated Security = True");
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                string pcount = Convert.ToString(cmd.ExecuteScalar());
                if (pcount.Length == 0)
                {
                    sup.IDtxtbox.Text = "1";
                }
                else
                {
                    int pcount1 = Convert.ToInt32(pcount);
                    int pcountAdd = pcount1 + 1;
                    sup.IDtxtbox.Text = pcountAdd.ToString();
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
            
            sup.saveNew.Visible = true;
            sup.saveEdit.Visible = false;
            sup.ShowDialog();
        }

        //Editar proveedor
        private void btnEditar_Click(object sender, EventArgs e)
        {
            
            Supplier sup = new Supplier();
            sup.saveEdit.Visible = true;
            sup.saveNew.Visible = false;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                sup.IDtxtbox.Text = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                sup.Nametxt.Text = dataGridView1.CurrentRow.Cells["name"].Value.ToString();
                sup.RFCtxt.Text = dataGridView1.CurrentRow.Cells["RFC"].Value.ToString();
                sup.phonetxt.Text = dataGridView1.CurrentRow.Cells["phone"].Value.ToString();
                sup.mailtxt.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();
                sup.addrestxt.Text = dataGridView1.CurrentRow.Cells["addres"].Value.ToString();
                sup.countrytxt.Text = dataGridView1.CurrentRow.Cells["country"].Value.ToString();
                sup.statettxt.Text = dataGridView1.CurrentRow.Cells["state"].Value.ToString();
                sup.citytxt.Text = dataGridView1.CurrentRow.Cells["city"].Value.ToString();
                sup.divisa.Text = dataGridView1.CurrentRow.Cells["currency"].Value.ToString();
                
                idSup = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                sup.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor.");
            }
        }

        private void MenuProve_Load(object sender, EventArgs e)
        {
            MostrarProvee();
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Name";
            dataGridView1.Columns[2].HeaderText = "RFC";
            dataGridView1.Columns[3].HeaderText = "Phone";
            dataGridView1.Columns[4].HeaderText = "E-mail";
            dataGridView1.Columns[5].HeaderText = "Address";
            dataGridView1.Columns[6].HeaderText = "Country";
            dataGridView1.Columns[7].HeaderText = "State";
            dataGridView1.Columns[8].HeaderText = "City";
            dataGridView1.Columns[9].HeaderText = "Currency";
            dataGridView1.RowTemplate.Height = 35;
        }

        //áctualizar
        private void button4_Click(object sender, EventArgs e)
        {
            MostrarProvee(); 
        }

        //info supplier
        private void button1_Click(object sender, EventArgs e)
        {
            Supplier sup = new Supplier();
            sup.saveEdit.Visible = false;
            sup.saveNew.Visible = false;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                sup.IDtxtbox.Text = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                sup.Nametxt.Text = dataGridView1.CurrentRow.Cells["name"].Value.ToString();
                sup.RFCtxt.Text = dataGridView1.CurrentRow.Cells["RFC"].Value.ToString();
                sup.phonetxt.Text = dataGridView1.CurrentRow.Cells["phone"].Value.ToString();
                sup.mailtxt.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();
                sup.addrestxt.Text = dataGridView1.CurrentRow.Cells["addres"].Value.ToString();
                sup.countrytxt.Text = dataGridView1.CurrentRow.Cells["country"].Value.ToString();
                sup.statettxt.Text = dataGridView1.CurrentRow.Cells["state"].Value.ToString();
                sup.citytxt.Text = dataGridView1.CurrentRow.Cells["city"].Value.ToString();
                sup.divisa.Text = dataGridView1.CurrentRow.Cells["currency"].Value.ToString();

                idSup = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                sup.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor.");
            }
        }

        //eliminar proveedor
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {


                idSup = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                objetoCN.EliminarSup(idSup);
                MessageBox.Show("Proveedor eliminado.");
                MostrarProvee();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor.");
            } 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
