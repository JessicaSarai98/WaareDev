using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Common.cache;
using System.Net;
using System.Net.Mail;

//Clase responsable de consulta de base de datos
namespace DataAccess
{
    public class UserDao : ConnectionToSql
    {
        //función para agregar usuario y actualizarlo en la db
        public void AddUser(int id, string userName, string pass, string name, string lastname, string mail)
        {
            using (var connection = GetConnection())
            {
                connection.Open(); 
                using (var command= new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "update set username= @userName, password=@pass, firstName=@name, lastName= @lastname, email=@mail where ID=@id";
                    command.Parameters.AddWithValue("@userName", userName);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@lastname", lastname);
                    command.Parameters.AddWithValue("@mail", mail);
                    command.Parameters.AddWithValue("@id", id);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();

                }
            }
        }
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
        public string recoverPassword(string userRequesting)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM data WHERE username= @user or email = @mail";
                    command.Parameters.AddWithValue("@user", userRequesting);
                    command.Parameters.AddWithValue("@mail", userRequesting);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read()==true)
                    {
                        //first name 4, last name 5
                        string userName = reader.GetString(4) + "" + reader.GetString(5);
                        string userMail = reader.GetString(3); //posicion en base de datos email
                        string accountPassword = reader.GetString(2); //posicion en base de datos de password 

                        var mailService = new MailServices.SystemSupportMail();

                        mailService.sendMail(
                            subject: "System: Password recovery request", 
                            body: "Hola, " + userName + "\nSolicitaste recuperar tu contraseña " +
                            ", \n" + "Tu contraseña es: " + accountPassword + "\nSin embargo, " +
                            "te pedimos que cambies de contraseña cuando ingreses al sistema, con el fin de una mejor seguridad. Gracias.",
                            recipientMail: new List<string> { userMail });
                        return "Hola," + userName + "\nSolicitaste recuperar tu contraseña.\n" + "Por favor, ingresa a tu correo: "
                            + userMail + "" + "\n te pedimos que cambies de contraseña cuando ingreses al sistema, con el fin de una mejor seguridad. Gracias.";
                    }
                    else
                    {
                        return "Lo sentimos, no tienes una cuenta o un correo registrado en el sistema";
                    }
            }
        }
    }
}
}
