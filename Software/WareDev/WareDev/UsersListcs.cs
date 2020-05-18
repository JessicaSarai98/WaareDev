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
        public string idUser = null;

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
            reg.saveEdit.Visible = false;
            reg.button3.Visible = true; 
            reg.ShowDialog();
        }

        
        public void MostrarUsuarios()
        {
            CN_Clientes objeto = new CN_Clientes();
            dataGridView1.DataSource = objeto.MostrarUsu();
            this.dataGridView1.Columns[2].Visible = false;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // dataGridView1.Columns[2].Visible = false;
        }

        //eliminar usuario
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idUser = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                Name = dataGridView1.CurrentRow.Cells["username"].Value.ToString();
                objectCN.EliminarUsu(idUser);
                MessageBox.Show("Usuario " + Name + " eliminado");
                MostrarUsuarios();

            }
            else
            {
                MessageBox.Show("Seleccione una fila.");
            }
        }

        //info user 
        private void button3_Click(object sender, EventArgs e)
        {
            registro reg = new registro();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                reg.usertxt.Text = dataGridView1.CurrentRow.Cells["username"].Value.ToString();
                reg.passtxt.Text = dataGridView1.CurrentRow.Cells["password"].Value.ToString();
                reg.passconfirmtxt.Text = dataGridView1.CurrentRow.Cells["password"].Value.ToString();
                reg.emailtxt.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();
                reg.nametxt.Text = dataGridView1.CurrentRow.Cells["firstName"].Value.ToString();
                reg.lasttxt.Text = dataGridView1.CurrentRow.Cells["lastName"].Value.ToString();
                reg.ShowDialog(); 
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }
        //editar usuario
        private void btnEditar_Click(object sender, EventArgs e)
        {
            registro reg = new registro();
            reg.saveEdit.Visible = true;
            reg.button3.Visible = false; 
            
            if (dataGridView1.SelectedRows.Count > 0)
            {
                reg.ID.Text = dataGridView1.CurrentRow.Cells["Id"].Value.ToString(); 
                reg.usertxt.Text = dataGridView1.CurrentRow.Cells["username"].Value.ToString();
                reg.passtxt.Text = dataGridView1.CurrentRow.Cells["password"].Value.ToString();
                reg.passconfirmtxt.Text = dataGridView1.CurrentRow.Cells["password"].Value.ToString();
                reg.emailtxt.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();
                reg.nametxt.Text = dataGridView1.CurrentRow.Cells["firstName"].Value.ToString();
                reg.lasttxt.Text = dataGridView1.CurrentRow.Cells["lastName"].Value.ToString();
                idUser = dataGridView1.CurrentRow.Cells["Id"].Value.ToString(); 
                reg.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void act_Click(object sender, EventArgs e)
        {
            MostrarUsuarios(); 
        }
    }
}
