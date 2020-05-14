using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WareDev
{
    public partial class Agregar : Form
    {
        public Agregar()
        {
            InitializeComponent();
        }

        private void AgregarInsumo_Load(object sender, EventArgs e)
        {

        }

        private void btrRegreso_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCantidad_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Regex rx = new Regex(@"^[0-9]+\.[0-9]{2}?", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            if ((rx.IsMatch(txtCantidad.Text)) && (e.KeyChar != (char)Keys.Back) || char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }
    }
}
