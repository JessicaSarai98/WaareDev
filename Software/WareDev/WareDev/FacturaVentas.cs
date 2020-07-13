using System;
using System.Windows.Forms;

namespace WareDev
{
    public partial class FacturaVentas : Form
    {
        public FacturaVentas()
        {
            InitializeComponent();
        }
        private void btrRegreso_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
