using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data; 
using System.Data.SqlClient;  

namespace Domain

{
    public class CN_Clientes
    {
        private CD_Clientes objetoCD = new CD_Clientes(); 

        public DataTable MostrarUsu()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarU();
            return tabla; 
        }
        public DataTable MostrarCli()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar(); 
            return tabla;
        }
        public void InsertarClie( string name, string rfc, string phone, string email, string address, 
            string city, string state, string country, string cp, string identy, string tasaa, string stat, string 
            vendedor, string pm, string cfdi, string note)
        {
            objetoCD.Insertar(name, rfc, phone, email, address, city, state,
                country, cp, identy,Convert.ToDouble(tasaa), stat, vendedor, pm, cfdi, note);
        }
        
        //insertar datos de usuario
        public void InsertarUsu(string username, string pass, string email, string firstname, string lastname)
        {
            objetoCD.InsertarU(username, pass, email, firstname, lastname);
        }
        //actualizar datos de cliente
        public void EditarClie(string name, string RFC, string phone, string email, string address,
            string city, string state, string country, string cp, string identy, string tasaa, string stat, string
            vendedor, string pm, string cfdi, string note, string id)
        {
            objetoCD.Editar(name, RFC, phone, email, address, city, state, country, cp, identy, Convert.ToDouble(tasaa),
                stat, vendedor, pm, cfdi, note,Convert.ToInt32(id));
        }

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
