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
using System.IO;
using System.Globalization;

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
            //this.dataGridView1.Columns[11].Visible = false;
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
            dataGridView1.Columns[11].HeaderText = "Available Quantity";
            dataGridView1.Columns[13].HeaderText = "Price";
            //DataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);
            
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


        private void btnEditar_Click(object sender, EventArgs e)
        {
            MateriaPrima mat = new MateriaPrima();
            mat.btnGuardar.Visible = false;

            if (dataGridView1.SelectedRows.Count > 0)
            {
                mat.ID.Text = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                mat.txtNombre.Text = dataGridView1.CurrentRow.Cells["name"].Value.ToString();
                mat.dateTimePicker1.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                mat.txtUniMedAduana.Text = dataGridView1.CurrentRow.Cells["customsUnitOfMeasure"].Value.ToString();
                mat.txtUniMedida.Text= dataGridView1.CurrentRow.Cells["unitOfMeasure"].Value.ToString();
                mat.txtDescripcion.Text= dataGridView1.CurrentRow.Cells["description"].Value.ToString();
                mat.txtIva.Text= dataGridView1.CurrentRow.Cells["IVA"].Value.ToString();
                mat.txtSat.Text= dataGridView1.CurrentRow.Cells["SAT"].Value.ToString();
                mat.txtFraccion.Text= dataGridView1.CurrentRow.Cells["tariffFraction"].Value.ToString();
                mat.txtEstado.Text= dataGridView1.CurrentRow.Cells["status"].Value.ToString();
                mat.txtPorcentaje.Text= dataGridView1.CurrentRow.Cells["percentage"].Value.ToString();
                mat.txtCantiAdquirida.Text= dataGridView1.CurrentRow.Cells["amountPurchased"].Value.ToString();
                mat.txtCanAduana.Text= dataGridView1.CurrentRow.Cells["customsAmount"].Value.ToString();
                mat.txtPrecio.Text= dataGridView1.CurrentRow.Cells["price"].Value.ToString();
                
                byte[] img = (byte[])dataGridView1.CurrentRow.Cells["photo"].Value;
                MemoryStream ms = new MemoryStream(img);
                mat.FotoProduc.Image = Image.FromStream(ms, true, true);
                mat.ShowDialog(); 

            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor"); 
            }
        }
    }
}
