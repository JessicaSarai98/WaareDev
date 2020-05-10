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
    public partial class reporte : Form
    {
        public reporte()
        {
            InitializeComponent();
        }

        private void reporte_Load(object sender, EventArgs e)
        {
            desdeTime.Value = DateTime.Today;
            hastaTime.Value = DateTime.Today;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            panel2.Visible = true; 
            int indice = cmdReporte.SelectedIndex;
            lblTitulo.Text = cmdReporte.Items[indice].ToString();
        }
    }
}
