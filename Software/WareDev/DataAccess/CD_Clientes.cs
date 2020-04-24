using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class CD_Clientes
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from clientes";
            //comando.CommandType = CommandType.StoredProcedure;

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void Insertar(string name, string rfc, string phone, string email, string address, 
            string city, string state, string country, string cp, string identy, double tasaa, string stat, string 
            vendedor, string pm, string cfdi, string note)
        {
           // SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into clientes values('"+name+"','"+rfc+"','"+phone+"','"+email+"','"+address+"','"+city+ "','"+state+"','"+country+ "','"+cp+"','"+identy+"',"+tasaa+",'"+stat+"','"+vendedor+"','"+pm+"','"+cfdi+"','"+note+"')"; 
         
           comando.CommandType = CommandType.Text;

           /* comando.Parameters.AddWithValue("@Id", ID);
            comando.Parameters.AddWithValue("@name", name);
            comando.Parameters.AddWithValue("@RFC", rfc);
            comando.Parameters.AddWithValue("@phone", phone);
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@address", address);
            comando.Parameters.AddWithValue("@city", city);
            comando.Parameters.AddWithValue("@state", state);
            comando.Parameters.AddWithValue("@country", country);
            comando.Parameters.AddWithValue("@codigopostal", cp);
            comando.Parameters.AddWithValue("@identidadfiscal", identy);
            comando.Parameters.AddWithValue("@tasa", tasaa);
            comando.Parameters.AddWithValue("@status", stat);
            comando.Parameters.AddWithValue("@vendedor",vendedor);
            comando.Parameters.AddWithValue("@payment", pm);
            comando.Parameters.AddWithValue("@CFDI", cfdi);
            comando.Parameters.AddWithValue("@note", note);*/
            comando.ExecuteNonQuery();
            //comando.Parameters.Clear();
            //conexion.CerrarConexion(); 

        }
        public void Editar(string name, string phone, string email, int id)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "update data set name=@name, phone=@phone,email=@email where Id=@id";
            comando.CommandType = CommandType.Text;
            
            /*comando.Parameters.AddWithValue("@name", name);
            comando.Parameters.AddWithValue("@phone",phone);
            comando.Parameters.AddWithValue("@email", email);*/
            comando.ExecuteNonQuery();
            
            //comando.Parameters.Clear();
            //conexion.CerrarConexion(); 
        }
        public void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarCliente";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("Id", id);

            comando.ExecuteNonQuery();
            //comando.Parameters.Clear();
            //conexion.CerrarConexion(); 
        }
    }
}
