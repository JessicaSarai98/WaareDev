using System;
using System.Windows.Forms;
using Domain;

namespace WareDev
{
    public partial class personaFisica : Form
    {
        CN_Clientes objectCN = new CN_Clientes();
        public personaFisica()
        {
            InitializeComponent();
        }

        private void guardarPro_Click(object sender, EventArgs e)
        {
            try
            {
                objectCN.InsertarSuppFisicos(Convert.ToInt32(IDtxtbox.Text), txtNombres.Text, txtPapellido.Text, txtSapellido.Text, txtFiscal.Text,
                    txtRazon.Text, txtCiudad.Text, txtCalle.Text, txtNum.Text,
                    txtLada.Text, txtTel.Text, txtFax.Text, txtCorreo.Text);
                MessageBox.Show("Se ha insertado correctamente.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo insertar los datos por: " + ex);
            }
        }

        private void guardarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                objectCN.InsertarClieFisico(Convert.ToInt32(IDtxtbox.Text), txtNombres.Text, txtPapellido.Text, txtSapellido.Text, txtFiscal.Text,
                    txtRazon.Text, txtCiudad.Text, txtCalle.Text, txtNum.Text,
                txtLada.Text, txtTel.Text, txtFax.Text, txtCorreo.Text);
                MessageBox.Show("Se ha agregado correctamente.");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar los datos por: \n" + ex);
            }

        }

        private void btnEditCliente_Click(object sender, EventArgs e)
        {
            try
            {
                objectCN.EditarClieFisica(Convert.ToInt32(IDtxtbox.Text), txtNombres.Text, txtPapellido.Text, txtSapellido.Text, txtFiscal.Text,
                    txtRazon.Text, txtCiudad.Text, txtCalle.Text, txtNum.Text,
                txtLada.Text, txtTel.Text, txtFax.Text, txtCorreo.Text);
                MessageBox.Show("Se ha editado correctamente.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo editar los datos por: \n" + ex);
            }
        }

        private void btnEditPro_Click(object sender, EventArgs e)
        {
            try
            {
                objectCN.EditarSupFisicos(Convert.ToInt32(IDtxtbox.Text), txtNombres.Text, txtPapellido.Text, txtSapellido.Text, txtFiscal.Text,
                    txtRazon.Text, txtCiudad.Text, txtCalle.Text, txtNum.Text,
                txtLada.Text, txtTel.Text, txtFax.Text, txtCorreo.Text);
                MessageBox.Show("Se ha editado correctamente.");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo editar los datos por " + ex);
            }
        }
    }
}
