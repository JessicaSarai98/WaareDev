﻿using System;
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
            var user = new UserModel();
            var result = user.recoverPassword(txtEmail.Text);
            MessageBox.Show("Enviado: " + txtEmail.Text + ".");
            //lblResult.Text = result; 
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
