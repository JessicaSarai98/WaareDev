using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data.SqlClient;  

namespace Domain

{
    public class CN_Clientes
    {
        private CD_Clientes objetoCD = new CD_Clientes();
        //----------MOSTRAR EN TABLA-----
        //Mostrar usuarios
        public DataTable MostrarUsu()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarU();
            return tabla;
        }
        //Mostrar clientes
        public DataTable MostrarCli()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }

        //Mostrar proveedores
        public DataTable MostrarSup()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarS();
            return tabla; 
        }

        //------NUEVO----------
        //insertar cliente
        public void InsertarClie(string name, string rfc, string phone, string email, string address,
            string city, string state, string country, string cp, string identy, string tasaa, string stat, string
            vendedor, string pm, string cfdi, string note)
        {
            objetoCD.Insertar(name, rfc, phone, email, address, city, state,
                country, cp, identy, Convert.ToDouble(tasaa), stat, vendedor, pm, cfdi, note);
        }
        //insertar datos de usuario
        public void InsertarUsu(string username, string pass, string email, string firstname, string lastname)
        {
            objetoCD.InsertarU(username, pass, email, firstname, lastname);
        }
        
        //insertar datos de proveedor
        public void InsertarSupp(string name, string RFC, string phone, string email, string addres, string country, string state,
           string city, string currency)
        {
            objetoCD.InsertarS(name, RFC, phone, email, addres, country, state, city, currency);
        }

        //-------EDITAR DATOS-------
        //actualizar datos de cliente
        public void EditarClie(string name, string RFC, string phone, string email, string address,
            string city, string state, string country, string cp, string identy, string tasaa, string stat, string
            vendedor, string pm, string cfdi, string note, string id)
        {
            objetoCD.Editar(name, RFC, phone, email, address, city, state, country, cp, identy, Convert.ToDouble(tasaa),
                stat, vendedor, pm, cfdi, note, Convert.ToInt32(id));
        }
       
        //actualizar datos de usuario
        public void EditarUsu(string username, string pass, string email, string firstname, string lastname)
        {
            objetoCD.EditarU(username, pass, email, firstname, lastname);
        }

        //actualizar datos de proveedor

        //eliminar cliente
        public void EliminarCli(string id)
        {
            objetoCD.Eliminar(Convert.ToInt32(id));
        }

        //eliminar usuario 
        public void EliminarUsu(string id)
        {
            objetoCD.EliminarU(Convert.ToInt32(id));
        }
    }
}
