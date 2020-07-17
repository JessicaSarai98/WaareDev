using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class CD_Conexion
    {
        // jess
        //private SqlConnection Conexion = new SqlConnection(@"Data Source = LAPTOP-SDO1671B; Initial Catalog = users; Integrated Security = True; Pooling=False");
        private SqlConnection Conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jessica\Documents\fruteria.mdf;Integrated Security=True;Connect Timeout=30");
        // karina 
       //private SqlConnection Conexion = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = C:\Users\William carmona\Documents\users.mdf;Integrated Security = True");

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
