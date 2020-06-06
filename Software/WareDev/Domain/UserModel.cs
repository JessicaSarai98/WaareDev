using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess; 
//realiza la lógica de negocio, validaciones y seguridad
namespace Domain
{
    public class UserModel
    {
        UserDao userDao = new UserDao();

        private int ID;
        private string username;
        private string password;
        private string firstName;
        private string lastName;
        private string email;
   
        public UserModel(int ID, string username, string password, string firstName, string lastName, string email)
        {
            ID = ID;
            this.username = username;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
        }
        public UserModel()
        {

        }
        

        public string AddUserProfile()
        {
            try
            {
                userDao.AddUser(ID, username, password, firstName, lastName, email);
                LoginUser(username, password);
                return "Your profile has been sucessfully updated";
            }
            catch(Exception ex)
            {
                return "Username is alredy registered, try another";
            }
        }

        public bool LoginUser(string user, string pass)
        {
            return userDao.Login(user, pass);
        }
        public string recoverPassword(string userRequesting)
        {
            return userDao.recoverPassword(userRequesting);
        }
    }
}
