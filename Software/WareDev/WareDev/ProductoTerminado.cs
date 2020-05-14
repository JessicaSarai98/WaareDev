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
    public partial class ProductoTerminado : Form
    {
        public ProductoTerminado()
        {
            InitializeComponent();
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Archivo JPG|*.jpg";
            if (file.ShowDialog() == DialogResult.OK)
                FotoProduc.Image = Image.FromFile(file.FileName);
            FotoProduc.Visible = true;
        }

        private void btrRegreso_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductoTerminado_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today;
        }
    }
}
