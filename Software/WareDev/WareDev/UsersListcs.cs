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

        
        private void MostrarUsuarios()
        {
            CN_Clientes objeto = new CN_Clientes(); 
            dataGridView1.DataSource = objeto.MostrarUsu();
            this.dataGridView1.Columns[2].Visible = false; 
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1.Columns[2].Visible = false; 
        }
    }
}
