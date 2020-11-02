using System;
using System.Windows.Forms;
using Domain;
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
        private void MostrarProveeFisicos()
        {
            CN_Clientes objeto = new CN_Clientes();
            dataGridView2.DataSource = objeto.MostrarSupFisicos();
        }
        public MenuProve()
        {
            InitializeComponent();
        }

        //nuevo proveedor
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Supplier sup = new Supplier();
            personaFisica fisica = new personaFisica();
            string query1 = "select max(Id) from supplier";
            string query2 = "select max(Id) from ProveedorFisicos";
            //jess
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\William carmona\Documents\Desarrollo\Cagada Adrian\WaareDev\BD\fruteria.mdf;Integrated Security=True");
            //karina
            //SqlConnection con = new SqlConnection(@"Server=tcp:OMEN-LAPTOP18\SQLEXPRESS02,49172;DataBase= fruteria; User Id=Cliente ; Password=cliente1234");
            SqlCommand cmd1 = new SqlCommand(query1, con);
            SqlCommand cmd2 = new SqlCommand(query2, con); 
            DialogResult respuesta = MessageBox.Show("¿Desea agregar a una persona Física?", "Mensaje", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (respuesta == DialogResult.No)
            {
                try
                {
                    con.Open();
                    string pcount1 = Convert.ToString(cmd1.ExecuteScalar());
                    string pcount2 = Convert.ToString(cmd2.ExecuteScalar());
                    int maximo =0;
                    if(pcount2 != "" && pcount1 != "")
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
                        sup.IDtxtbox.Text = pcountAdd.ToString();
                    }
                    else if (pcount2 != "")
                    {
                        int pcountAdd = Convert.ToInt32(pcount2) + 1;
                        sup.IDtxtbox.Text = pcountAdd.ToString();
                    }
                    else if (pcount1 != "")
                    {
                        int pcountAdd = Convert.ToInt32(pcount1) + 1;
                        sup.IDtxtbox.Text = pcountAdd.ToString();
                    }
                    else
                    {

                        sup.IDtxtbox.Text = "1";
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
            if (respuesta == DialogResult.Yes)
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
                    } else if (pcount2 != "")
                    {
                        int pcountAdd = Convert.ToInt32(pcount2) + 1;
                        fisica.IDtxtbox.Text = pcountAdd.ToString();
                    }
                    else if(pcount1 != "")
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

                fisica.guardarPro.Visible = true;
                fisica.btnEditPro.Visible = false;
                fisica.ShowDialog();
            }
        }

        //Editar proveedor
        private void btnEditar_Click(object sender, EventArgs e)
        {
            
            Supplier sup = new Supplier();
            personaFisica fisica = new personaFisica();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                sup.saveEdit.Visible = true;
                sup.saveNew.Visible = false;
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
            }else if (dataGridView2.SelectedRows.Count > 0)
            {
                fisica.btnEditPro.Visible = true;
                fisica.guardarPro.Visible = false;
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
                idSup = dataGridView2.CurrentRow.Cells["Id"].Value.ToString();
                fisica.ShowDialog();
            } else
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

            MostrarProveeFisicos();
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

        //áctualizar
        private void button4_Click(object sender, EventArgs e)
        {
            MostrarProvee();
            MostrarProveeFisicos();
        }

        //info supplier
        private void button1_Click(object sender, EventArgs e)
        {
            Supplier sup = new Supplier();
            personaFisica fisica = new personaFisica();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                sup.saveEdit.Visible = false;
                sup.saveNew.Visible = false;
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
            } else if (dataGridView2.SelectedRows.Count > 0)
            {
                fisica.btnEditPro.Visible = false;
                fisica.guardarPro.Visible = false;
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
                idSup = dataGridView2.CurrentRow.Cells["Id"].Value.ToString();
                fisica.ShowDialog();

            } else
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
            else if (dataGridView2.SelectedRows.Count > 0)
            {
                idSup = dataGridView2.CurrentRow.Cells["Id"].Value.ToString();
                objetoCN.EliminarSupFisica(idSup);
                MessageBox.Show("Proveedor eliminado.");
                MostrarProveeFisicos();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor.");
            } 
        }
    }
}
