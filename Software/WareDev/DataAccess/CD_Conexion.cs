using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class CD_Conexion
    {

        //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jessica\Documents\fruteria.mdf;Integrated Security=True;Connect Timeout=30
        //@"Data Source = LAPTOP-SDO1671B; Initial Catalog = users; Integrated Security = True; Pooling=False"

        // jess
        //private SqlConnection Conexion = new SqlConnection(@"Data Source = LAPTOP-SDO1671B; Initial Catalog = users; Integrated Security = True; Pooling=False");
        // karina Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = C:\Users\William carmona\Documents\users.mdf;Integrated Security = True; Connect Timeout = 30

        private SqlConnection Conexion = new SqlConnection(@"Data Source = LAPTOP-SDO1671B; Initial Catalog = users; Integrated Security = True; Pooling=False");
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
