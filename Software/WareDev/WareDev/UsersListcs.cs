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
    public partial class UsersListcs : Form
    {
        CN_Clientes objectCN = new CN_Clientes();
        public string idCliente = null;
        public UsersListcs()
        {
            InitializeComponent();
        }

        private void UsersListcs_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {

            registro reg = new registro();
            reg.ShowDialog();
        }

        
        public void MostrarUsuarios()
        {
            //CN_Clientes objeto = new CN_Clientes(); 
            //dataGridView1.DataSource = objeto.MostrarUsu();
            //this.dataGridView1.Columns[2].Visible = false; 
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1.Columns[2].Visible = false; 
        }

        //eliminar usuario
        private void button2_Click(object sender, EventArgs e)
        {
            //if (dataGridView1.SelectedRows.Count > 0)
            //{
            //    idCliente = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
            //    Name = dataGridView1.CurrentRow.Cells["username"].Value.ToString(); 
            //    objectCN.EliminarUsu(idCliente);
            //    MessageBox.Show("Usuario "+Name+" eliminado");
            //    MostrarUsuarios(); 

            //}
            //else
            //{
            //    MessageBox.Show("Seleccione una fila."); 
            //}
        }
    }
}
