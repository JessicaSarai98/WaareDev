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

        public DataTable MostrarCli()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar(); 
            return tabla;
        }
        public void InsertarClie(string id, string name, string rfc, string phone,
            string email, string address, string city, string state, 
            string country, string cp, string identy, string tasaa, string stat, 
            string vendedor, string pm, string cfdi, string note
            )
        {
            objetoCD.Insertar(Convert.ToInt32(id), name, rfc, phone, email, address, city, state,
                country, cp, identy,Convert.ToInt32(tasaa), stat, vendedor, pm, cfdi, note);
        }

        public void EditarClie(string name, string phone, string email, string id)
        {
            objetoCD.Editar(name, phone, email, Convert.ToInt32(id));
        }
        public void EliminarCli(string id)
        {
            objetoCD.Eliminar(Convert.ToInt32(id));
        }
    }
}
