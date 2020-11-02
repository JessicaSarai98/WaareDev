using System;
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
            dataGridView2.Update();
            dataGridView2.Refresh();
        }
        

        public void MostrarClientes()
        {
            CN_Clientes objeto = new CN_Clientes();
            //dataGridView1.DataSource = objeto.MostrarCli();
            dataGridView1.DataSource = objeto.MostrarCli();
            
        }
        public void MostrarClientesFisicos()
        {
            CN_Clientes objeto = new CN_Clientes();
            dataGridView2.DataSource = objeto.MostrarCliFisicos();

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
            //clientes fisicos
            personaFisica fisica = new personaFisica();
            fisica.btnEditCliente.Visible = true;
            fisica.guardarCliente.Visible = false;
            if (dataGridView1.SelectedRows.Count > 0)
            { //Editar = true; 
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

            } if (dataGridView2.SelectedRows.Count > 0) {
                fisica.IDtxtbox.Text = dataGridView2.CurrentRow.Cells["Id"].Value.ToString();
                fisica.txtNombres.Text = dataGridView2.CurrentRow.Cells["nombres"].Value.ToString();
                fisica.txtPapellido.Text = dataGridView2.CurrentRow.Cells["primerApellido"].Value.ToString();
                fisica.txtSapellido.Text = dataGridView2.CurrentRow.Cells["segundoApellido"].Value.ToString();
                fisica.txtFiscal.Text = dataGridView2.CurrentRow.Cells["registroFiscal"].Value.ToString();
                fisica.txtRazon.Text = dataGridView2.CurrentRow.Cells["razonSocial"].Value.ToString();
                fisica.txtCiudad.Text = dataGridView2.CurrentRow.Cells["ciudad"].Value.ToString();
                fisica.txtCalle.Text = dataGridView2.CurrentRow.Cells["calle"].Value.ToString();
                fisica.txtNum.Text = dataGridView2.CurrentRow.Cells["numero"].Value.ToString();
                fisica.txtLada.Text = dataGridView2.CurrentRow.Cells["lada"].Value.ToString();
                fisica.txtTel.Text = dataGridView2.CurrentRow.Cells["telefono"].Value.ToString();
                fisica.txtFax.Text = dataGridView2.CurrentRow.Cells["fax"].Value.ToString();
                fisica.txtCorreo.Text = dataGridView2.CurrentRow.Cells["correo"].Value.ToString();
                idCliente = dataGridView2.CurrentRow.Cells["Id"].Value.ToString();
                fisica.ShowDialog();

            }
            else 
                MessageBox.Show("seleccione una fila por favor");
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            InfoClient client = new InfoClient(); 
            personaFisica fisica = new personaFisica();

            string query1 = "select max(Id) from clientes";
            string query2 = "select max(Id) from clientesFisicos";
            // jess
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\William carmona\Documents\Desarrollo\Cagada Adrian\WaareDev\BD\fruteria.mdf;Integrated Security=True");
            //karina
            //SqlConnection con = new SqlConnection(@"Server=tcp:OMEN-LAPTOP18\SQLEXPRESS02,49172;DataBase= fruteria; User Id=Cliente ; Password=cliente1234");
            SqlCommand cmd1 = new SqlCommand(query1, con);
            SqlCommand cmd2 = new SqlCommand(query2, con);
            DialogResult respuesta = MessageBox.Show("¿Desea agregar a una persona Física?", "Mensaje", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if(respuesta == DialogResult.Yes)
            {
                try
                {
                    con.Open();
                    string pcount1 = Convert.ToString(cmd1.ExecuteScalar());
                    string pcount2 = Convert.ToString(cmd2.ExecuteScalar());
                    int maximo = 0;
                    if (pcount2 != "" && pcount1 != "")
                    {
                        if (Convert.ToInt32(pcount1) > Convert.ToInt32(pcount2))
                        {
                            maximo = Convert.ToInt32(pcount1);
                        }
                        else
                        {
                            maximo = Convert.ToInt32(pcount2);
                        }
                    }

                    if (maximo != 0)
                    {
                        int pcountAdd = maximo + 1;
                        fisica.IDtxtbox.Text = pcountAdd.ToString();
                    }
                    else if (pcount2 != "")
                    {
                        int pcountAdd = Convert.ToInt32(pcount2) + 1;
                        fisica.IDtxtbox.Text = pcountAdd.ToString();
                    }
                    else if (pcount1 != "")
                    {
                        int pcountAdd = Convert.ToInt32(pcount1) + 1;
                        fisica.IDtxtbox.Text = pcountAdd.ToString();
                    }
                    else
                    {

                        fisica.IDtxtbox.Text = "1";
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
                fisica.guardarCliente.Visible = true;
                fisica.ShowDialog();
            }
            if(respuesta == DialogResult.No)
            {
                try
                {
                    con.Open();
                    string pcount1 = Convert.ToString(cmd1.ExecuteScalar());
                    string pcount2 = Convert.ToString(cmd2.ExecuteScalar());
                    int maximo = 0;
                    if (pcount2 != "" && pcount1 != "")
                    {
                        if (Convert.ToInt32(pcount1) > Convert.ToInt32(pcount2))
                        {
                            maximo = Convert.ToInt32(pcount1);
                        }
                        else
                        {
                            maximo = Convert.ToInt32(pcount2);
                        }
                    }

                    if (maximo != 0)
                    {
                        int pcountAdd = maximo + 1;
                        client.IDtxtbox.Text = pcountAdd.ToString();
                    }
                    else if (pcount2 != "")
                    {
                        int pcountAdd = Convert.ToInt32(pcount2) + 1;
                        client.IDtxtbox.Text = pcountAdd.ToString();
                    }
                    else if (pcount1 != "")
                    {
                        int pcountAdd = Convert.ToInt32(pcount1) + 1;
                        client.IDtxtbox.Text = pcountAdd.ToString();
                    }
                    else
                    {

                        client.IDtxtbox.Text = "1";
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
                client.save.Visible = true;
                client.SaveEdit.Visible = false;
                client.ShowDialog();
            }
            

            
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

            personaFisica fisica = new personaFisica();
            fisica.btnEditCliente.Visible = false;
            fisica.guardarCliente.Visible = false;
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
                 

            } else if (dataGridView2.SelectedRows.Count > 0)
            {
                fisica.IDtxtbox.Text = dataGridView2.CurrentRow.Cells["Id"].Value.ToString();
                fisica.txtNombres.Text = dataGridView2.CurrentRow.Cells["nombres"].Value.ToString();
                fisica.txtPapellido.Text = dataGridView2.CurrentRow.Cells["primerApellido"].Value.ToString();
                fisica.txtSapellido.Text = dataGridView2.CurrentRow.Cells["segundoApellido"].Value.ToString();
                fisica.txtFiscal.Text = dataGridView2.CurrentRow.Cells["registroFiscal"].Value.ToString();
                fisica.txtRazon.Text = dataGridView2.CurrentRow.Cells["razonSocial"].Value.ToString();
                fisica.txtCiudad.Text = dataGridView2.CurrentRow.Cells["ciudad"].Value.ToString();
                fisica.txtCalle.Text = dataGridView2.CurrentRow.Cells["calle"].Value.ToString();
                fisica.txtNum.Text = dataGridView2.CurrentRow.Cells["numero"].Value.ToString();
                fisica.txtLada.Text = dataGridView2.CurrentRow.Cells["lada"].Value.ToString();
                fisica.txtTel.Text = dataGridView2.CurrentRow.Cells["telefono"].Value.ToString();
                fisica.txtFax.Text = dataGridView2.CurrentRow.Cells["fax"].Value.ToString();
                fisica.txtCorreo.Text = dataGridView2.CurrentRow.Cells["correo"].Value.ToString();
                idCliente = dataGridView2.CurrentRow.Cells["Id"].Value.ToString();
                fisica.ShowDialog();

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

            MostrarClientesFisicos();
            dataGridView2.Columns[0].HeaderText = "ID";
            dataGridView2.Columns[1].HeaderText = "Nombre(s)";
            dataGridView2.Columns[2].HeaderText = "Primer apellido";
            dataGridView2.Columns[3].HeaderText = "Segundo apellido";
            dataGridView2.Columns[4].HeaderText = "Número de registro fiscal";
            dataGridView2.Columns[5].HeaderText = "Razón social";
            dataGridView2.Columns[6].HeaderText = "Calle";
            dataGridView2.Columns[7].HeaderText = "Número";
            dataGridView2.Columns[8].HeaderText = "Lada";
            dataGridView2.Columns[9].HeaderText = "Teléfono";
            dataGridView2.Columns[10].HeaderText = "Fax";
            dataGridView2.Columns[11].HeaderText = "Email";
            dataGridView2.RowTemplate.Height = 35;

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
                objetoCN.EliminarCli(idCliente, "clientes");
                MessageBox.Show("Cliente eliminado correctamente.");
                MostrarClientes();
            } else if (dataGridView2.SelectedRows.Count > 0)
            {
                idCliente = dataGridView2.CurrentRow.Cells["Id"].Value.ToString();
                objetoCN.EliminarCli(idCliente, "clientesFisicos");
                MessageBox.Show("Cliente eliminado correctamente.");
                MostrarClientesFisicos();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor.");
            }
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            MostrarClientes();
            MostrarClientesFisicos();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.ReadOnly = true;
            dataGridView2.Update();
            dataGridView2.Refresh();
        }
    }
}

