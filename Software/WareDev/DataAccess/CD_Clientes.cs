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
        //insertar clientes
        public void Insertar(string name, string rfc, string phone, string email, string address, 
            string city, string state, string country, string cp, string identy, double tasaa, string stat, string 
            vendedor, string pm, string cfdi, string note)
        {
           // SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into clientes values('"+name+"','"+rfc+"','"+phone+"','"+email+"','"+address+"','"+city+ "','"+state+"','"+country+ "','"+cp+"','"+identy+"',"+tasaa+",'"+stat+"','"+vendedor+"','"+pm+"','"+cfdi+"','"+note+"')"; 
         
           comando.CommandType = CommandType.Text;

            comando.ExecuteNonQuery();
           
        }

        //insertar datos de usuarios
        public void InsertarU(string username, string pass, string email, string firstname, string lastname )
        {
            comando.Connection = conexion.AbrirConexion(); 
            comando.CommandText = "insert into data values('"+username+ "', '"+pass+ "', '"+email+ "', '"+firstname+ "', '"+lastname+"')";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery(); 
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

        //Eliminar clientes
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

        //eliminar usuarios 
        public void EliminarU(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "delete from data where Id="+id+"";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery(); 
        }
    }
}
