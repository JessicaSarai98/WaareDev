﻿using System;
using System.Windows.Forms;
using Domain;
using System.Data.SqlClient;

namespace WareDev
{
    public partial class Menuclientescs : Form
    {
        CN_Clientes objetoCN = new CN_Clientes();
        public string idCliente = null;
        
        //public bool Editar = false; 
        public Menuclientescs()
        {
             
            InitializeComponent();
            dataGridView1.Update();
            dataGridView1.Refresh(); 
        }
        

        public void MostrarClientes()
        {
            CN_Clientes objeto = new CN_Clientes();
            //dataGridView1.DataSource = objeto.MostrarCli();
            dataGridView1.DataSource = objeto.MostrarCli();
            
        }

        private void InsertarFilas()
        {
            dataGridView1.Rows.Insert(0, "1", "Rafael Fernandez", "56465","50A40H","adriflb@hotmail.com", "AV. Melgar","","","","","","","","","");
        }

        //carga los datos del cliente seleccionado
            private void btnEditar_Click(object sender, EventArgs e)
            {
            InfoClient client = new InfoClient();
            client.SaveEdit.Visible = true;
            client.save.Visible = false;
            if (dataGridView1.SelectedRows.Count > 0)
            {

                   //Editar = true; 
                   client.IDtxtbox.Text = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                   client.Nametxt.Text = dataGridView1.CurrentRow.Cells["name"].Value.ToString();
                   client.RFCtxt.Text = dataGridView1.CurrentRow.Cells["RFC"].Value.ToString();
                   client.phonetxt.Text = dataGridView1.CurrentRow.Cells["phone"].Value.ToString();
                   client.mailtxt.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();
                   client.addrestxt.Text = dataGridView1.CurrentRow.Cells["address"].Value.ToString();
                   client.citytxt.Text = dataGridView1.CurrentRow.Cells["city"].Value.ToString();
                   client.statetxt.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                   client.countrytxt.Text = dataGridView1.CurrentRow.Cells["country"].Value.ToString();
                   client.CPtxt.Text = dataGridView1.CurrentRow.Cells["codigopostal"].Value.ToString();
                   client.identytxt.Text = dataGridView1.CurrentRow.Cells["identidadfiscal"].Value.ToString();
                   client.tasatxt.Text = dataGridView1.CurrentRow.Cells["tasa"].Value.ToString();
                   client.statustxt.Text = dataGridView1.CurrentRow.Cells["status"].Value.ToString();
                   client.vendortxt.Text = dataGridView1.CurrentRow.Cells["vendedor"].Value.ToString(); 
                   client.paytxt.Text = dataGridView1.CurrentRow.Cells["payment"].Value.ToString();
                   client.cfditxt.Text = dataGridView1.CurrentRow.Cells["CFDI"].Value.ToString();
                   client.note.Text = dataGridView1.CurrentRow.Cells["note"].Value.ToString();
                   idCliente = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                   client.ShowDialog();
                
            

            }
            else 
                MessageBox.Show("seleccione una fila por favor");
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            InfoClient client = new InfoClient(); 

            string query = "select max(Id) from clientes";
            // jess
            //SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Jessica\Documents\fruteria.mdf; Integrated Security = True; Connect Timeout = 30");
                //karina
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = C:\Users\William carmona\Documents\Desarrollo\Cagada Adrian\WaareDev\BD\fruteria.mdf;Integrated Security = True");
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                string pcount = Convert.ToString(cmd.ExecuteScalar());
                if (pcount.Length == 0)
                {
                    client.IDtxtbox.Text = "1";
                }
                else
                {
                    int pcount1 = Convert.ToInt32(pcount);
                    int pcountAdd = pcount1 + 1;
                    client.IDtxtbox.Text = pcountAdd.ToString();
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
            //InfoClient client= new InfoClient();
            client.save.Visible = true;
            client.SaveEdit.Visible = false;
            client.ShowDialog();

            
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = true; 
        }

        //Info client
        private void button1_Click(object sender, EventArgs e)
        {
            InfoClient cli = new InfoClient();
            cli.SaveEdit.Visible = false;
            cli.save.Visible = false;
            if (dataGridView1.SelectedRows.Count > 0)
            {

                //Editar = true; 
                cli.IDtxtbox.Text = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                cli.Nametxt.Text = dataGridView1.CurrentRow.Cells["name"].Value.ToString();
                cli.RFCtxt.Text = dataGridView1.CurrentRow.Cells["RFC"].Value.ToString();
                cli.phonetxt.Text = dataGridView1.CurrentRow.Cells["phone"].Value.ToString();
                cli.mailtxt.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();
                cli.addrestxt.Text = dataGridView1.CurrentRow.Cells["address"].Value.ToString();
                cli.citytxt.Text = dataGridView1.CurrentRow.Cells["city"].Value.ToString();
                cli.statetxt.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                cli.countrytxt.Text = dataGridView1.CurrentRow.Cells["country"].Value.ToString();
                cli.CPtxt.Text = dataGridView1.CurrentRow.Cells["codigopostal"].Value.ToString();
                cli.identytxt.Text = dataGridView1.CurrentRow.Cells["identidadfiscal"].Value.ToString();
                cli.tasatxt.Text = dataGridView1.CurrentRow.Cells["tasa"].Value.ToString();
                cli.statustxt.Text = dataGridView1.CurrentRow.Cells["status"].Value.ToString();
                cli.vendortxt.Text = dataGridView1.CurrentRow.Cells["vendedor"].Value.ToString();
                cli.paytxt.Text = dataGridView1.CurrentRow.Cells["payment"].Value.ToString();
                cli.cfditxt.Text = dataGridView1.CurrentRow.Cells["CFDI"].Value.ToString();
                cli.note.Text = dataGridView1.CurrentRow.Cells["note"].Value.ToString();
                idCliente = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                cli.ShowDialog();
                 

            }
            else
                MessageBox.Show("seleccione una fila por favor");

        }

    

        private void Menuclientescs_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'usersDataSet.clientes' Puede moverla o quitarla según sea necesario.
            //this.clientesTableAdapter.Fill(this.usersDataSet.clientes);
            MostrarClientes();
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Username";
            dataGridView1.Columns[2].HeaderText = "RFC";
            dataGridView1.Columns[3].HeaderText = "Phone";
            dataGridView1.Columns[4].HeaderText = "E-mail";
            dataGridView1.Columns[5].HeaderText = "Address";
            dataGridView1.Columns[6].HeaderText = "City";
            dataGridView1.Columns[7].HeaderText = "State";
            dataGridView1.Columns[8].HeaderText = "Country";
            dataGridView1.Columns[9].HeaderText = "Código Postal";
            dataGridView1.Columns[10].HeaderText = "Identy";
            dataGridView1.Columns[11].HeaderText = "Tasa";
            dataGridView1.Columns[12].HeaderText = "Status";
            dataGridView1.Columns[13].HeaderText = "Celler";
            dataGridView1.Columns[14].HeaderText = "Payment Method";
            dataGridView1.Columns[15].HeaderText = "CFDI";
            dataGridView1.Columns[16].HeaderText = "Note";
            dataGridView1.RowTemplate.Height = 35;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.Update();
            dataGridView1.Refresh(); 
        }

        //Eliminar cliente
        private void button2_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                idCliente = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                objetoCN.EliminarCli(idCliente);
                MessageBox.Show("Cliente eliminado correctamente.");
                MostrarClientes();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor.");
            }
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            MostrarClientes(); 
        }
    }
}

