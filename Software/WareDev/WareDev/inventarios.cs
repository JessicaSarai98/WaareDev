using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WareDev
{
    public partial class inventarios : Form
    {
        public inventarios()
        {
            InitializeComponent();
        }
        private void inventarios_Load(object sender, EventArgs e)
        {
            TabControl.SelectedTab = TabPage1;
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
    }
}
