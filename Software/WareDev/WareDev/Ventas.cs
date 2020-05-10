using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WareDev
{
    public partial class ventas : Form
    {
        public ventas()
        {
            InitializeComponent();
        }
        private void ventas_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today;
        }
        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.contenedor.Controls.Count > 0)
                this.contenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            fh.FormBorderStyle = FormBorderStyle.None;
            this.contenedor.Controls.Add(fh);
            this.contenedor.Tag = fh;
            fh.BringToFront();
            fh.Show();

        }
        private void txtFolio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Sólo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        Regex rx = new Regex(@"^[0-9]+\.[0-9]{2}?", RegexOptions.Compiled | RegexOptions.IgnoreCase);
        private void txtIva_KeyPress(object sender, KeyPressEventArgs e)
        {            
            if ((rx.IsMatch(txtIva.Text)) && (e.KeyChar != (char)Keys.Back) || char.IsLetter(e.KeyChar) )
            {
                e.Handled = true;
                return;
            }
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((rx.IsMatch(txtTotal.Text)) && (e.KeyChar != (char)Keys.Back) || char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtSubtotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((rx.IsMatch(txtSubtotal.Text)) && (e.KeyChar != (char)Keys.Back) || char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private void btrRegreso_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panelTitulo.Visible = false;
            AbrirFormInPanel(new Start());
        }
        FacturaVentas ventas1;
        private void btnFactura_Click(object sender, EventArgs e)
        {
            if (ventas1 == null)
            {
                ventas1 = new FacturaVentas();
                ventas1.Owner = this;
                ventas1.FormClosed += Ventas1_FormClosed;
                ventas1.Show();
            }
            else ventas1.Activate();

        }

        private void Ventas1_FormClosed(object sender, FormClosedEventArgs e)
        {
            ventas1 = null;
        }
    }
}
