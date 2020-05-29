﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace WareDev
{
    public partial class ProductoTerminado : Form
    {
        public ProductoTerminado()
        {
            InitializeComponent();
        }


        SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-SDO1671B;Initial Catalog=users;Integrated Security=True;Pooling=False");
        string imgLocation = "";
        SqlCommand cmd;
        SqlCommand cmd2;
        public byte[] ImageToByteArray(System.Drawing.Image imagen)
        {
            MemoryStream ms = new MemoryStream();
            imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Archivo JPG|*.jpg";
            if (file.ShowDialog() == DialogResult.OK)
            {
                imgLocation = file.FileName.ToString(); 
                FotoProduc.Image = Image.FromFile(file.FileName);
            }
            FotoProduc.Visible = true;
        }

        private void btrRegreso_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductoTerminado_Load(object sender, EventArgs e)
        {
            //dateTimePicker1.Value = DateTime.Today;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if ((this.txtUniMedInsu.Text.Length>=1) && (this.dateTimePicker1!=null) && (this.txtPallet.Text.Length >= 1) && (this.txtCajasContenido.Text.Length >= 1) && (this.txtNameInputs.Text.Length >= 1) && (this.txtCantidadInsumo.Text.Length >= 1) && (this.txtCantiAdquirida.Text.Length >= 1) && (this.txtNombreInsumo.Text.Length >= 1) && (this.txtPrecioInsumo.Text.Length >= 1) && (this.txtDescripcion.Text.Length >= 1) && (this.txtNombreMateria.Text.Length >= 1) && (this.txtCantiMatPrima.Text.Length >= 1))
            {
                if (this.FotoProduc.Image!=null)
                {
                    byte[] images = null;
                    FileStream Streem = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(Streem);
                    images = brs.ReadBytes((int)Streem.Length);

                    int n1, n2, r;
                    n1 = Convert.ToInt32(txtCantiMatPrima.Text);
                    n2 = Convert.ToInt32(existencia.Text);
                    r = n1 - n2;


                    connection.Open();
                    string sqlQuery = "insert into FinishedProducts(date,unitOfMeasure,pallet,boxes,input,quantityUsedI,amountPurchased,name,unitPrice,description,rawMaterial,quantityUsedR,photo) values(@fecha,'" + txtUniMedInsu.Text + "','" + txtPallet.Text + "','" + txtCajasContenido.Text + "','" + txtNameInputs.Text + "','" + txtCantidadInsumo.Text + "','" + txtCantiAdquirida.Text + "','" + txtNombreInsumo.Text + "','" + txtPrecioInsumo.Text + "','" + txtDescripcion.Text + "','" + txtNombreMateria.Text + "','" + txtCantiMatPrima.Text + "',@images)";
                    string sqlQuery2 = "update rawMaterials set amountPurchased='"+r+"' where Id='"+txtNombreMateria.Text+"'";
                    

                    cmd = new SqlCommand(sqlQuery, connection);
                    cmd2 = new SqlCommand(sqlQuery2, connection);
                    cmd.Parameters.Add(new SqlParameter("@images", images));
                    cmd.Parameters.AddWithValue("@fecha", dateTimePicker1.Value.Date);
                    

                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Se ha agregado la materia prima");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Agregue una imagen");
                }
            }
            else
            {
                MessageBox.Show("Complete todos los campos");
            }
            
        }

        private void SaveEdit_Click(object sender, EventArgs e)
        {
            if ((this.txtUniMedInsu.Text.Length >= 1) && (this.dateTimePicker1 != null) && (this.txtPallet.Text.Length >= 1) && (this.txtCajasContenido.Text.Length >= 1) && (this.txtNameInputs.Text.Length >= 1) && (this.txtCantidadInsumo.Text.Length >= 1) && (this.txtCantiAdquirida.Text.Length >= 1) && (this.txtNombreInsumo.Text.Length >= 1) && (this.txtPrecioInsumo.Text.Length >= 1) && (this.txtDescripcion.Text.Length >= 1) && (this.txtNombreMateria.Text.Length >= 1) && (this.txtCantiMatPrima.Text.Length >= 1))
            {

                byte[] byteArrayImagen = ImageToByteArray(FotoProduc.Image);
                connection.Open();

                int n1, n2, r;
                n1 = Convert.ToInt32(txtCantiMatPrima.Text);
                n2 = Convert.ToInt32(existencia.Text);
                r = n2 - n1;

                string sqlQuery = "update FinishedProducts set date=@fecha,unitOfMeasure='" + txtUniMedInsu.Text + "',pallet='" + txtPallet.Text + "',boxes='" + txtCajasContenido.Text + "',input='" + txtNameInputs.Text + "',quantityUsedI='" + txtCantidadInsumo.Text + "',amountPurchased='" + txtCantiAdquirida.Text + "',name='" + txtNombreInsumo.Text + "',unitPrice='" + txtPrecioInsumo.Text + "',description='" + txtDescripcion.Text + "',rawMaterial='" + txtNombreMateria.Text + "',quantityUsedR='" + txtCantiMatPrima.Text + "',photo=@imagen where Id='" + ID.Text + "'";
                string sqlQuery2 = "update rawMaterials set amountPurchased='"+r+ "' where Id='"+txtNombreMateria.Text+"'";
                cmd = new SqlCommand(sqlQuery, connection);
                cmd2 = new SqlCommand(sqlQuery2, connection);

                cmd.Parameters.AddWithValue("@fecha", dateTimePicker1.Value.Date);
                cmd.Parameters.Add("@imagen", byteArrayImagen);

                cmd2.ExecuteNonQuery(); 
                cmd.ExecuteNonQuery();
                 
                connection.Close();
                MessageBox.Show("Se ha editado correctamente");
                
                this.Close();

                
            }
            else
            {
                MessageBox.Show("Ingrese todos los campos.");
            }
        }

        private void existencia_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void exis_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("Select * from rawMaterials where Id=@id",connection);
            com.Parameters.AddWithValue("@id",txtNombreMateria.Text);
            connection.Open();
            SqlDataReader reg = com.ExecuteReader();
            if (reg.Read())
            {
                existencia.Text = reg["amountPurchased"].ToString();
            }
            connection.Close();


        }
    }
    
}
