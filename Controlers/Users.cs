using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace HIMILO_ICT_PAYROLL_SYSTEM.Controlers
{
    internal class Users : IQuery
    {
        public string fullName { get; set; }
        public string username { get; set; }
        public string Email { get; set; }
        public string password { get; set; }
        public string userType { get; set; }
        public string status { get; set; }
        public Image UserPhoto { get; set; }

        public string securityQUestion { get; set; }
        public string answer { get; set; }


        public DataTable GetData(object username)
        {
            var data = new DataTable();
            try
            {
                SqlConnection connection = Connections.GetSqlConnection();
                connection.Open();
                SqlCommand command = new SqlCommand("getUsers", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@user", username);
                var ad = new SqlDataAdapter(command);
                ad.Fill(data);
                command.ExecuteNonQuery();

                connection.Close();
                QueryHasError = false;
            }
            catch (Exception ex)
            {
                QueryHasError = true;
                ErrorMessage = ex.Message;
            }
            return data;
        }

        public string updaterEmail { get; set; }

        public override bool QueryHasError { get; set; }
        public override string ErrorMessage { get; set; }


        //
        public string logonUser;
        public string logonEmail;
        public Image logonUserProfile;
        public string logonUserType;
        public string logonStatus;

        // add 
        public void AddUser()
        {
            try
            {
                SqlConnection connection = Connections.GetSqlConnection();
                connection.Open();
                SqlCommand command = new SqlCommand("insertUsers", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@fullname", fullName);
                command.Parameters.AddWithValue("@userName", username);
                command.Parameters.AddWithValue("@email", Email);
                command.Parameters.AddWithValue("@pass", password);
                command.Parameters.AddWithValue("@security", securityQUestion);
                command.Parameters.AddWithValue("@ans", answer);
                command.Parameters.AddWithValue("@User_type", userType);

                if (UserPhoto != null)
                    command.Parameters.AddWithValue("@photo", ImageControler.SaveImageIntoStream(UserPhoto).ToArray());
                else
                    command.Parameters.AddWithValue("@photo", ImageControler.SaveImageIntoStream(Properties.Resources.user_male).ToArray());

                command.ExecuteNonQuery();
                connection.Close();
                QueryHasError = false;
            }
            catch (Exception ex)
            {
                QueryHasError = true;
                ErrorMessage = ex.Message;
            }
        }


        public void updateUser()
        {
            try
            {
                SqlConnection connection = Connections.GetSqlConnection();
                connection.Open();
                SqlCommand command = new SqlCommand("upadateUser", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@fullName", fullName);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@email", Email);

                command.Parameters.AddWithValue("@type", userType);
                command.Parameters.AddWithValue("@security", securityQUestion);
                command.Parameters.AddWithValue("@ans", answer);
                command.Parameters.AddWithValue("@status", status);
                command.Parameters.AddWithValue("@updater", updaterEmail);

                if (UserPhoto != null)
                    command.Parameters.AddWithValue("@Photo", ImageControler.SaveImageIntoStream(UserPhoto).ToArray());
                else
                    command.Parameters.AddWithValue("@Photo", ImageControler.SaveImageIntoStream(Properties.Resources.user_male).ToArray());

                command.ExecuteNonQuery();
                connection.Close();
                QueryHasError = false;
            }
            catch (Exception ex)
            {
                QueryHasError = true;
                ErrorMessage = ex.Message;
            }
        }



        public Image getMyPhoto(string email)
        {
            Image image = null;
            try
            {
                SqlConnection connection = Connections.GetSqlConnection();
                connection.Open();
                SqlCommand command = new SqlCommand("searchMyPhoto", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@email", email);
                var adapter = command.ExecuteReader();
                while (adapter.Read())
                {
                    if (adapter.HasRows)
                        image = ImageControler.GteImageFromStream(adapter[0]);

                }


                connection.Close();
                QueryHasError = false;
            }
            catch (Exception ex)
            {
                QueryHasError = true;
                ErrorMessage = ex.Message;
            }
            return image;
        }


        public bool isValidUser(string __username, string __password)
        {
            var isvalid = false;
            try
            {
                SqlConnection connection = Connections.GetSqlConnection();
                connection.Open();
                SqlCommand command = new SqlCommand("LogonUser", connection);

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@username", __username);
                command.Parameters.AddWithValue("@password", __password);
                var adapter = command.ExecuteReader();
                while (adapter.Read())
                {
                    if (adapter.HasRows)
                    {
                        logonUser = adapter[0].ToString();
                        logonEmail = adapter[1].ToString();
                        logonUserType = adapter[2].ToString();
                        logonStatus = adapter[3].ToString();
                        logonUserProfile = ImageControler.GteImageFromStream(adapter[4]);
                        isvalid = true;
                    }
                }




                // command.ExecuteNonQuery();
                connection.Close();
                QueryHasError = false;
            }
            catch (Exception ex)
            {
                QueryHasError = true;
                ErrorMessage = ex.Message;
            }

            return isvalid;
        }

    }
}
