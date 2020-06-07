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
using System.Data.SqlClient;

namespace WareDev
{
    public partial class inventarios : Form
    {
        CN_Clientes objetoCN = new CN_Clientes();
        public string idRaw = null;
        public string idInput = null;
        public string idFinished = null;
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jessica\Documents\fruteria.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;

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
            this.dataGridView1.Columns[15].Visible = false;
           
            //TablaMatPrima = objeto.MostrarRaw();

        }

        public void MostrarInputs()
        {
            CN_Clientes objeto = new CN_Clientes();
            dataGridView2.DataSource = objeto.MostrarInp();
            this.dataGridView2.Columns[1].Visible = false;
            this.dataGridView2.Columns[4].Visible = false;
            this.dataGridView2.Columns[7].Visible = false;
            this.dataGridView2.Columns[8].Visible = false;
            this.dataGridView2.Columns[9].Visible = false;



        }

        public void MostrarFinishedP()
        {
            this.dataGridView3.Update();
            this.dataGridView3.Refresh();
            CN_Clientes objeto = new CN_Clientes();
            dataGridView3.DataSource = objeto.MostrarFinished();
            this.dataGridView3.Columns[1].Visible = false;
            this.dataGridView3.Columns[3].Visible = false;
            this.dataGridView3.Columns[4].Visible = false;
            this.dataGridView3.Columns[5].Visible = false;
            this.dataGridView3.Columns[6].Visible = false;
            this.dataGridView3.Columns[10].Visible = false;
            this.dataGridView3.Columns[11].Visible = false;
            this.dataGridView3.Columns[12].Visible = false;
            this.dataGridView3.Columns[13].Visible = false;
            this.dataGridView3.Columns[14].Visible = false;
            this.dataGridView3.Columns[15].Visible = false;
            this.dataGridView3.Columns[16].Visible = false;
        }

        //principal
        private void inventarios_Load(object sender, EventArgs e)
        {
            TabControl.SelectedTab = TabPage1;
            MostrarRaw();
            DataTable dt = new DataTable();
            dt = (DataTable)dataGridView1.DataSource;

            dataGridView1.Refresh();
            dataGridView1.Update(); 

            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Name";
            dataGridView1.Columns[4].HeaderText = "Unit of measure";
            dataGridView1.Columns[7].HeaderText = "SAT key";
            dataGridView1.Columns[11].HeaderText = "Available Quantity";
            dataGridView1.Columns[13].HeaderText = "Price";
            
            //this.dataGridView1.Visible = true; 
            //this.dataGridView2.Visible = false;


            //DataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);

        }
        private void btnMPrima_CheckedChanged(object sender, EventArgs e)
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
            this.dataGridView1.Visible = true;
            this.dataGridView2.Visible = false;

         

        }

        ////boton de insumos (no de prod terminados)
        private void btnPTerminado_CheckedChanged(object sender, EventArgs e)
        {
            TabControl.SelectedTab = tabPage2;
            MostrarInputs();
            DataTable dt = new DataTable();
            dataGridView2.Columns[0].HeaderText = "ID";
            dataGridView2.Columns[2].HeaderText = "Unit of Meausre";
            dataGridView2.Columns[3].HeaderText = "Available Quantity";
            dataGridView2.Columns[5].HeaderText = "Name";
            dataGridView2.Columns[6].HeaderText = "Price";
            this.dataGridView2.Visible = true;
            this.dataGridView1.Visible = false;

        }

        ////boton de prod terminados (no insumos)
        private void btnInsumos_CheckedChanged(object sender, EventArgs e)
        {
            TabControl.SelectedTab = tabPage3;
            MostrarFinishedP();
            DataTable dt = new DataTable();
            dataGridView3.Columns[0].HeaderText = "ID";
            dataGridView3.Columns[2].HeaderText = "Unit of Measure";
            dataGridView3.Columns[7].HeaderText = "Available Quantity";
            dataGridView3.Columns[8].HeaderText = "Name";
            dataGridView3.Columns[9].HeaderText = "Price";
            
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

        //agregar cantidad - raw
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            //Abrir_Agregar();
            if (dataGridView1.SelectedRows.Count > 0)
            {

               
                Abrir_Agregar();

                agregar.titulo.Text = "Add quantity of Raw Materials: "+dataGridView1.CurrentRow.Cells["name"].Value.ToString();
                agregar.textBox1.Text = dataGridView1.CurrentRow.Cells["name"].Value.ToString();
                agregar.addI.Visible = false;
                agregar.addF.Visible = false;
                //"Add quantity of raw material: PONER AQUÍ EL NOMBRE DEL PRODUCTO QUE HAYA SELECCIADO " +
                    //"EN LA TABLA";

            }
            else
                MessageBox.Show("Seleccione una fila por favor");
           

        }
        private void materia_FormClosed(object sender, FormClosedEventArgs e)
        {
            materia = null;
            agregar = null;
            insumos = null;
        }

        //Agregar materia prima
        private void BtnPDF_Click(object sender, EventArgs e)
        {
            if (materia == null)
            {
                materia = new MateriaPrima();
                materia.Owner = this;
                materia.FormClosed += materia_FormClosed;
                materia.SaveEdit.Visible = false;
                materia.ID.Visible = false;
                materia.mat.Visible = false;
                materia.Show();
            }
            else materia.Activate();
        }

        //agregar insumos
        Insumos insumos;
        private void btnAgregarIns_Click(object sender, EventArgs e)
        {
            if (insumos == null)
            {
                insumos = new Insumos();
                insumos.Owner = this;
                insumos.FormClosed += materia_FormClosed;
                insumos.SaveEditinputs.Visible = false;
                insumos.IDinputs.Visible = false;
                insumos.ins.Visible = false;
                insumos.Show();
            }
            else insumos.Activate();
        }


        //agregar cantidad - inputs
        private void btnAgreInsum_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                Abrir_Agregar();
                agregar.titulo.Text = "Add quantity of Inputs: " + dataGridView2.CurrentRow.Cells["name"].Value.ToString();
                agregar.textBox1.Text = dataGridView2.CurrentRow.Cells["name"].Value.ToString();
                agregar.addR.Visible = false;
                agregar.addF.Visible = false;

            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }

        //Agregar cantidad - Finished products
        private void btnAddCantiProducto_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                Abrir_Agregar();
                agregar.titulo.Text = "Add quantity of Finished products: " + dataGridView3.CurrentRow.Cells["name"].Value.ToString();
                agregar.textBox1.Text = dataGridView3.CurrentRow.Cells["name"].Value.ToString();
                agregar.addI.Visible = false;
                agregar.addR.Visible = false;
            }
            else
                MessageBox.Show("Selecciona una fila por favor");

        }

       

        //agregar producto terminado
        ProductoTerminado producto;
        private void btnAddProductos_Click(object sender, EventArgs e)
        {
            if (producto == null)
            {
                producto = new ProductoTerminado();
                producto.Owner = this;
                producto.FormClosed += materia_FormClosed;
                producto.SaveEdit.Visible = false;
                producto.fin.Visible = false;
                //producto.existencia.Visible = false;
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

        //editar materia prima

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MateriaPrima mat = new MateriaPrima();
            mat.btnGuardar.Visible = false;
            mat.txtCantiAdquirida.Enabled = false;
            mat.mat.Visible = false; 
            

            if (dataGridView1.SelectedRows.Count > 0)
            {
                mat.ID.Text = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                mat.txtNombre.Text = dataGridView1.CurrentRow.Cells["name"].Value.ToString();

                mat.dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["date"].Value.ToString());

                mat.txtUniMedAduana.Text = dataGridView1.CurrentRow.Cells["customsUnitOfMeasure"].Value.ToString();
                mat.txtUniMedida.Text = dataGridView1.CurrentRow.Cells["unitOfMeasure"].Value.ToString();
                mat.txtDescripcion.Text = dataGridView1.CurrentRow.Cells["description"].Value.ToString();
                mat.txtIva.Text = dataGridView1.CurrentRow.Cells["IVA"].Value.ToString();
                mat.txtSat.Text = dataGridView1.CurrentRow.Cells["SAT"].Value.ToString();
                mat.txtFraccion.Text = dataGridView1.CurrentRow.Cells["tariffFraction"].Value.ToString();
                mat.txtEstado.Text = dataGridView1.CurrentRow.Cells["status"].Value.ToString();
                mat.txtPorcentaje.Text = dataGridView1.CurrentRow.Cells["percentage"].Value.ToString();
                mat.txtCantiAdquirida.Text = dataGridView1.CurrentRow.Cells["amountPurchased"].Value.ToString();
                mat.txtCanAduana.Text = dataGridView1.CurrentRow.Cells["customsAmount"].Value.ToString();
                mat.txtPrecio.Text = dataGridView1.CurrentRow.Cells["price"].Value.ToString();
                

                byte[] img = (byte[])dataGridView1.CurrentRow.Cells["photo"].Value;
                MemoryStream ms = new MemoryStream(img);
                mat.FotoProduc.Image = Image.FromStream(ms, true, true);
                mat.ID.Visible = false;
                mat.ShowDialog();

            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }
        //editar insumo
        private void btnEditInsu_Click(object sender, EventArgs e)
        {
            Insumos ins = new Insumos();
            ins.btnGuardar.Visible = false;
            ins.txtCanAdqInsumos.Enabled = false;
            ins.ins.Visible = false;

            if (dataGridView2.SelectedRows.Count > 0)
            {
                ins.IDinputs.Text = dataGridView2.CurrentRow.Cells["Id"].Value.ToString();

                ins.dateTimePicker1.Value = Convert.ToDateTime(dataGridView2.CurrentRow.Cells["date"].Value.ToString());
                ins.txtUniMedInsu.Text = dataGridView2.CurrentRow.Cells["unitOfMeasure"].Value.ToString();
                ins.txtCanAdqInsumos.Text = dataGridView2.CurrentRow.Cells["amountPurchased"].Value.ToString();
                ins.txtDesInsumo.Text = dataGridView2.CurrentRow.Cells["description"].Value.ToString();
                ins.txtNombreInsumo.Text = dataGridView2.CurrentRow.Cells["name"].Value.ToString();
                ins.txtPrecioInsumo.Text = dataGridView2.CurrentRow.Cells["unitPrice"].Value.ToString();
                ins.txtCostoTotalInsumo.Text = dataGridView2.CurrentRow.Cells["total"].Value.ToString();

                byte[] img = (byte[])dataGridView2.CurrentRow.Cells["photo"].Value;
                MemoryStream ms = new MemoryStream(img);

                ins.FotoProduc.Image = Image.FromStream(ms, true, true);
                ins.IDinputs.Visible = false;
                ins.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }

        }
        //editar prod terminado
        private void btnEditProdTer_Click(object sender, EventArgs e)
        {
            ProductoTerminado prod = new ProductoTerminado();
            prod.btnGuardar.Visible = false;
            prod.txtCantidadInsumo.Enabled = false;
            prod.txtCantiMatPrima.Enabled = false;
            prod.comboBox1.Enabled = false;
            prod.comboBox2.Enabled = false;
            prod.existencia.Visible = false;
            prod.exis.Visible = false;
            prod.exisI.Visible = false;
            prod.existenciaI.Visible = false;
            prod.fin.Visible = false;
            
            if (dataGridView3.SelectedRows.Count > 0)
            {
                prod.ID.Text = dataGridView3.CurrentRow.Cells["Id"].Value.ToString();
                prod.dateTimePicker1.Value=Convert.ToDateTime(dataGridView3.CurrentRow.Cells["date"].Value.ToString());
                prod.txtUniMedInsu.Text= dataGridView3.CurrentRow.Cells["unitOfMeasure"].Value.ToString();
                prod.txtPallet.Text= dataGridView3.CurrentRow.Cells["pallet"].Value.ToString();
                prod.txtCajasContenido.Text= dataGridView3.CurrentRow.Cells["boxes"].Value.ToString();
                prod.comboBox2.Text= dataGridView3.CurrentRow.Cells["input"].Value.ToString();
                prod.txtCantidadInsumo.Text= dataGridView3.CurrentRow.Cells["quantityUsedI"].Value.ToString();
                prod.txtCantiAdquirida.Text= dataGridView3.CurrentRow.Cells["amountPurchased"].Value.ToString();
                prod.txtNombreInsumo.Text= dataGridView3.CurrentRow.Cells["name"].Value.ToString();
                prod.txtPrecioInsumo.Text= dataGridView3.CurrentRow.Cells["unitPrice"].Value.ToString();
                prod.txtDescripcion.Text= dataGridView3.CurrentRow.Cells["description"].Value.ToString();
                prod.comboBox1.Text= dataGridView3.CurrentRow.Cells["rawMaterial"].Value.ToString();
                prod.txtCantiMatPrima.Text= dataGridView3.CurrentRow.Cells["quantityUsedR"].Value.ToString();
                prod.txtSize.Text = dataGridView3.CurrentRow.Cells["size"].Value.ToString();
                prod.txtMeasure.Text = dataGridView3.CurrentRow.Cells["measure"].Value.ToString(); 


                prod.txtCantiAdquirida.Enabled = false;

                byte[] img = (byte[])dataGridView3.CurrentRow.Cells["photo"].Value;
                MemoryStream ms = new MemoryStream(img);
                
                prod.FotoProduc.Image = Image.FromStream(ms, true, true);
                prod.ID.Visible = false;
                prod.ShowDialog();
                dataGridView3.Update();
                dataGridView3.Refresh();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        //eliminar materia prima
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idRaw = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                objetoCN.EliminarRaw(idRaw);
                MessageBox.Show("Materia prima eliminada");
                MostrarRaw();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }
        //eliminar insumo
        private void btnBorrarInsu_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                idInput = dataGridView2.CurrentRow.Cells["Id"].Value.ToString();
                objetoCN.EliminarInp(idInput);
                MessageBox.Show("Insumo eliminado");
                MostrarInputs();
            }else 
            MessageBox.Show("Seleccione una fila");
        }

        //eliminar prod terminado
        private void btnElimProdTerm_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                idFinished = dataGridView3.CurrentRow.Cells["Id"].Value.ToString();
                objetoCN.EliminarF(idFinished);
                MessageBox.Show("Producto eliminado");
                MostrarFinishedP();
            }
            else
                MessageBox.Show("Seleccione una fila");
        }

        //se va a eliminar el boton de buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        //Buscar en textbox nombre
        private void txtNombreB_KeyUp(object sender, KeyEventArgs e)
        {
            connection.Open();

            string sqlQuery = "SELECT * from rawMaterials where name like('" + txtNombreB.Text + "%')";
            cmd = new SqlCommand(sqlQuery, connection);
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();

        }

        //buscar en textbox Unit of measure
        private void txtUnidadB_KeyUp(object sender, KeyEventArgs e)
        {
            connection.Open();
            string sqlQuery = "SELECT * from rawMaterials where unitOfMeasure like('" + txtUnidadB.Text + "%') ";
            cmd = new SqlCommand(sqlQuery, connection);
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();

        }

        //textbox insumo - buscar 
        private void txtNameInsumo_KeyUp(object sender, KeyEventArgs e)
        {
            connection.Open();
            string sqlQuery = "select * from inputs where name like('"+txtNameInsumo.Text+"%')";
            cmd = new SqlCommand(sqlQuery, connection);
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            connection.Close();

        }

        //textbox prod terminado -buscar
        private void txtNomProdTerm_KeyUp(object sender, KeyEventArgs e)
        {
            connection.Open();
            string sqlQuery = "select * from FinishedProducts where name like('"+txtNomProdTerm.Text+"%')";
            cmd = new SqlCommand(sqlQuery, connection);
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView3.DataSource = dt;
            connection.Close();
        }

        private void txtNomProdTerm_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
