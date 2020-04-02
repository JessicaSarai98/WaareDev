using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Common.cache;


//Clase responsable de consulta de base de datos
namespace DataAccess
{
    public class UserDao : ConnectionToSql
    {
        public bool Login(string user, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM data WHERE username= @user and password = @pass";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserCache.ID = reader.GetInt32(0);
                            UserCache.username = reader.GetString(1);
                            UserCache.password = reader.GetString(2);
                            UserCache.email = reader.GetString(3);
                            UserCache.firstName = reader.GetString(4);
                            UserCache.lastName = reader.GetString(5);
                        }
                        return true;
                    }
                    else
                        return false;
                        
                }
            }
        }
    }
}
