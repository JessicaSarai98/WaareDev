public class UserDao : ConnectionToSql
{
    public string recoverPassword(string userRequesting)
    {
        using (var connection = GetConnection())
        {
            connection.Open();
            using (var command = new SqlCommand())
            {
                command.Connection = connection;
                command.CommandText = "select *from login where LoginName=@username or Email=@email";
                command.Parameters.AddWithValue("@username", userRequesting);
                command.Parameters.AddWithValue("@email", userRequesting);
                command.CommandType = CommandType.Text;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read() == true)
                {
                    string userName = reader.GetString(3) + ", " + reader.GetString(4);
                    string userMail = reader.GetString(2);
                    string accountPassword = reader.GetString(1);
                    var mailService = new MailServices.SystemSupportMail();
                    mailService.sendMail(
                      subject: "SYSTEM: Password recovery request",
                      body: "Hi, " + userName + "\nYou Requested to Recover your password.\n" +
                      "your current password is: " + accountPassword +
                      "\nHowever, we ask that you change your password inmediately once you enter the system.",
                      recipientMail: new List<string> { userMail }
                      );
                    return "Hi, " + userName + "\nYou Requested to Recover your password.\n" +
                      "Please check your mail: " + userMail +
                      "\nHowever, we ask that you change your password inmediately once you enter the system.";
                }
                else
                    return "Sorry, you do not have an account with that mail or username";
            }
        }
    }
}


