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

namespace WareDev
{
    public partial class Menuclientescs : Form
    {
        CN_Clientes objetoCN = new CN_Clientes(); 
        
     
        public Menuclientescs()
        {
            InitializeComponent();
        }

        private void MostrarClientes()
        {
            CN_Clientes objeto = new CN_Clientes();
            dataGridView1.DataSource = objetoCN.MostrarCli(); 

        }

        private void InsertarFilas()
        {
            dataGridView1.Rows.Insert(0, "1", "Rafael Fernandez", "56465","50A40H","adriflb@hotmail.com", "AV. Melgar","","","","","","","","","");
        }

            private void btnEditar_Click(object sender, EventArgs e)
        {
            InfoClient client = new InfoClient();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                client.IDtxtbox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                client.Nametxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                client.phonetxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                client.RFCtxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                client.mailtxt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                client.addrestxt.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                client.citytxt.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                client.statettxt.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                client.countrytxt.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                client.CPtxt.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                client.identytxt.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                client.tasatxt.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                client.statustxt.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
                client.paytxt.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
                client.cfditxt.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
                client.note.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();

                client.ShowDialog();

            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            InfoClient client= new InfoClient();
            client.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Menuclientescs_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'usersDataSet.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.usersDataSet.clientes);
            MostrarClientes(); 
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

