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
using Common.cache; 

namespace WareDev
{
    public partial class Menuclientescs : Form
    {
        CN_Clientes objetoCN = new CN_Clientes();
        public string idCliente = null;
        public bool Editar = false; 
        public Menuclientescs()
        {
            InitializeComponent();
        }

        private void MostrarClientes()
        {
            CN_Clientes objeto = new CN_Clientes();
            dataGridView1.DataSource = objetoCN.MostrarCli(); 

        }

        private void InsertarFilas()
        {
            dataGridView1.Rows.Insert(0, "1", "Rafael Fernandez", "56465","50A40H","adriflb@hotmail.com", "AV. Melgar","","","","","","","","","");
        }

        //carga los datos del cliente seleccionado
            private void btnEditar_Click(object sender, EventArgs e)
            {
            InfoClient client = new InfoClient();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                //client.loadUserData(); 
                /*client.IDtxtbox.Text = UserCache.ID.ToString();
                client.Nametxt.Text = UserCache.username;
                client.RFCtxt.Text = UserCache.RFC;
                client.phonetxt.Text = UserCache.phone;
                client.mailtxt.Text = UserCache.email;
                client.addrestxt.Text = UserCache.address;
                client.citytxt.Text = UserCache.city;
                client.statettxt.Text = UserCache.state;
                client.countrytxt.Text = UserCache.country;
                client.CPtxt.Text = UserCache.CP;
                client.identytxt.Text = UserCache.IF;
                client.tasatxt.Text = UserCache.tasa.ToString();
                client.statustxt.Text = UserCache.status;
                client.vendortxt.Text = UserCache.vendedor;
                client.paytxt.Text = UserCache.payment;
                client.cfditxt.Text = UserCache.CFDI;
                client.note.Text = UserCache.note; */
               

                Editar = true; 
                client.IDtxtbox.Text = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                client.Nametxt.Text = dataGridView1.CurrentRow.Cells["name"].Value.ToString();
                client.RFCtxt.Text = dataGridView1.CurrentRow.Cells["RFC"].Value.ToString();
                client.phonetxt.Text = dataGridView1.CurrentRow.Cells["phone"].Value.ToString();
                client.mailtxt.Text = dataGridView1.CurrentRow.Cells["email"].Value.ToString();
                client.addrestxt.Text = dataGridView1.CurrentRow.Cells["address"].Value.ToString();
                client.citytxt.Text = dataGridView1.CurrentRow.Cells["city"].Value.ToString();
                client.statetxt.Text = dataGridView1.CurrentRow.Cells["state"].Value.ToString();
                client.countrytxt.Text = dataGridView1.CurrentRow.Cells["country"].Value.ToString();
                client.CPtxt.Text = dataGridView1.CurrentRow.Cells["codigopostal"].Value.ToString();
                client.identytxt.Text = dataGridView1.CurrentRow.Cells["identidadfiscal"].Value.ToString();
                client.tasatxt.Text = dataGridView1.CurrentRow.Cells["tasa"].Value.ToString();
                client.statustxt.Text = dataGridView1.CurrentRow.Cells["status"].Value.ToString();
                client.vendortxt.Text = dataGridView1.CurrentRow.Cells["vendedor"].Value.ToString(); 
                client.paytxt.Text = dataGridView1.CurrentRow.Cells["payment"].Value.ToString();
                client.cfditxt.Text = dataGridView1.CurrentRow.Cells["CFDI"].Value.ToString();
                client.note.Text = dataGridView1.CurrentRow.Cells["note"].Value.ToString();
                idCliente = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                client.ShowDialog();

            }
            else
                MessageBox.Show("seleccione una fila por favor");
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            InfoClient client= new InfoClient();
            client.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Menuclientescs_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'usersDataSet.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.usersDataSet.clientes);
            MostrarClientes(); 
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

