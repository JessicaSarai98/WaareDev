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
    public partial class inventarios : Form
    {
        CN_Clientes objetoCN = new CN_Clientes(); 

        public inventarios()
        {
            InitializeComponent();
        }
        public void MostrarRaw()
        {
            CN_Clientes objeto = new CN_Clientes();
            dataGridView1.DataSource = objeto.MostrarRaw();
            this.dataGridView1.Columns[2].Visible = false;
            this.dataGridView1.Columns[3].Visible = false;
            this.dataGridView1.Columns[5].Visible = false;
            this.dataGridView1.Columns[6].Visible = false;
            this.dataGridView1.Columns[8].Visible = false;
            this.dataGridView1.Columns[9].Visible = false;
            this.dataGridView1.Columns[10].Visible = false;
            this.dataGridView1.Columns[11].Visible = false;
            this.dataGridView1.Columns[12].Visible = false;
            this.dataGridView1.Columns[14].Visible = false;
            //TablaMatPrima = objeto.MostrarRaw();

        }
        private void inventarios_Load(object sender, EventArgs e)
        {
            TabControl.SelectedTab = TabPage1;
            MostrarRaw(); 
            DataTable dt = new DataTable();
            dt = (DataTable)dataGridView1.DataSource;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Name";
            dataGridView1.Columns[4].HeaderText = "Unit of measure";
            dataGridView1.Columns[7].HeaderText = "SAT key";
            dataGridView1.Columns[13].HeaderText = "Price";

        }
        private void btnMPrima_CheckedChanged(object sender, EventArgs e)
        {
            TabControl.SelectedTab = TabPage1;
        }

        private void btnPTerminado_CheckedChanged(object sender, EventArgs e)
        {
            TabControl.SelectedTab = tabPage2;
        }

        private void btnInsumos_CheckedChanged(object sender, EventArgs e)
        {
            TabControl.SelectedTab = tabPage3;
        }
        MateriaPrima materia;
        Agregar agregar;
        private void Abrir_Agregar()
        {
            if (agregar == null)
            {
                agregar = new Agregar();
                agregar.Owner = this;
                agregar.FormClosed += materia_FormClosed;
                agregar.Show();
            }
            else materia.Activate();
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Abrir_Agregar();
            agregar.titulo.Text = "Add quantity of raw material: PONER AQUÍ EL NOMBRE DEL PRODUCTO QUE HAYA SELECCIADO " +
                "EN LA TABLA";
        }
        private void materia_FormClosed(object sender, FormClosedEventArgs e)
        {
            materia = null;
            agregar = null;
            insumos = null;
        }

        private void BtnPDF_Click(object sender, EventArgs e)
        {
            if (materia == null)
            {
                materia = new MateriaPrima();
                materia.Owner = this;
                materia.FormClosed += materia_FormClosed;
                materia.Show();
            }
            else materia.Activate();
        }
        Insumos insumos;
        private void btnAgregarIns_Click(object sender, EventArgs e)
        {
            if (insumos == null)
            {
                insumos = new Insumos();
                insumos.Owner = this;
                insumos.FormClosed += materia_FormClosed;
                insumos.Show();
            }
            else insumos.Activate();
        }

        private void btnAgreInsum_Click(object sender, EventArgs e)
        {
            Abrir_Agregar();
            agregar.titulo.Text = "Add quantity of Inputs: PONER AQUÍ EL NOMBRE DEL PRODUCTO QUE HAYA SELECCIADO " +
                "EN LA TABLA";
        }

        private void btnAddCantiProducto_Click(object sender, EventArgs e)
        {
            Abrir_Agregar();
            agregar.titulo.Text = "Add quantity of Finished products: PONER AQUÍ EL NOMBRE DEL PRODUCTO QUE HAYA SELECCIADO " +
                "EN LA TABLA";
        }
        ProductoTerminado producto;
        private void btnAddProductos_Click(object sender, EventArgs e)
        {
            if (producto == null)
            {
                producto = new ProductoTerminado();
                producto.Owner = this;
                producto.FormClosed += materia_FormClosed;
                producto.Show();
            }
            else producto.Activate();
        }

        private void TablaMatPrima_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //this.dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill); 
        }
    }
}
