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
    public partial class olvidoContra : Form
    {
        public olvidoContra()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            UserModel user = new UserModel();
            var result = user.recoverPassword(txtEmail.Text);
            lblResult.Text = result;
            
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void olvidoContra_Load(object sender, EventArgs e)
        {

        }
    }
}
