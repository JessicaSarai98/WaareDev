using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccess
{
    public abstract class ConnectionToSql
    {
        private readonly string connectionString;
        
        // cadena de conexion a base de datos
        public ConnectionToSql()
        {
            //jess
            //connectionString = @"Data Source=LAPTOP-SDO1671B;Initial Catalog=users;Integrated Security=True;Pooling=False";
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jessica\Documents\fruteria.mdf;Integrated Security=True;Connect Timeout=30";
            // karina
           // connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = C:\Users\William carmona\Documents\users.mdf;Integrated Security = True";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
