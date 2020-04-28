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

        public DataTable MostrarU()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from data";
            //comando.CommandText = "select Id= "+id+", username='"+username+"', firstName='"+firstName+"', lastName='"+lastName+"' from data ";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla; 
        }
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

        public void Insertar(int id, string name, string rfc, string phone, string email, string address, 
            string city, string state, string country, string cp, string identy, double tasaa, string stat, string 
            vendedor, string pm, string cfdi, string note)
        {
           // SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into clientes values("+id+",'"+name+"','"+rfc+"','"+phone+"','"+email+"','"+address+"','"+city+ "','"+state+"','"+country+ "','"+cp+"','"+identy+"',"+tasaa+",'"+stat+"','"+vendedor+"','"+pm+"','"+cfdi+"','"+note+"')"; 
         
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
        //actualizar datos 
        public void Editar(string name, string RFC, string phone, string email, string address,
            string city, string state, string country, string cp, string identy, double tasaa, string stat, string
            vendedor, string pm, string cfdi, string note, int id)
        {
           // SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "update clientes set name='"+name+"', RFC= '"+RFC+"', phone= '"+phone+ "',email='"+email+ "', address='"+address+"'," +
                "city='"+city+ "', state='"+state+ "', country='"+country+ "', codigopostal='"+cp+ "', identidadfiscal='"+identy+ "', tasa="+tasaa+ ", status='"+stat+"'," +
                "vendedor='"+vendedor+ "',payment='"+pm+ "', CFDI='"+cfdi+ "', note='"+note+ "'  where Id='"+id+"'";
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
            comando.CommandText = "delete from clientes where Id="+id+"";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery(); 

           // comando.Parameters.AddWithValue("Id", id);

            comando.ExecuteNonQuery();
            //comando.Parameters.Clear();
            //conexion.CerrarConexion(); 
        }
    }
}
