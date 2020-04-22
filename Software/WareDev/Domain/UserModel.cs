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
        /*
        private string RFC;
        private string phone;
        private string address;
        private string city;
        private string state;
        private string country;
        private string CP;
        private string identy;
        private float tasa;
        private string status; 
        private string vendedor;
        private string pay;
        private string cfdi;
        private string note; 
        */
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
        /*public UserModel(int ID, string username, string RFC, string phone, string email, 
            string address, string city, string state, string country, string CP, string identy,
            float tasa, string status, string vendedor, string pay, string cfdi, string note)
        {
            ID = ID;
            this.username = username;
            this.RFC = RFC;
            this.phone = phone;
            this.email = email;
            this.address = address;
            this.city = city;
            this.state = state;
            this.country = country;
            this.CP = CP;
            this.identy = identy;
            tasa = tasa;
            this.status = status;
            this.vendedor = vendedor;
            this.pay = pay;
            this.cfdi = cfdi;
            this.note = note;
        }
        public string editUserProfile()
        {
            userDao.editProfile(ID,username, RFC, phone, email, address, city,
             state, country, CP, identy, tasa, status, vendedor, pay, cfdi, note);
                return "Your profile has been successfully updated";
            
        }*/

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
