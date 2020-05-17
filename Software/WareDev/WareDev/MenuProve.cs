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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Supplier client = new Supplier();
            client.ShowDialog();
        }

        //Editar 
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Supplier sup = new Supplier();
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
        }
    }
}
