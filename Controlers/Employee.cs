using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace HIMILO_ICT_PAYROLL_SYSTEM.Controlers
{
    internal class Employee : IQuery
    {

        public string employeeID { get; set; }
        public string employeeName { get; set; }
        public string gender { get; set; }
        public DateTime dateOfBirth { get; set; }
        public Int64 mobile { get; set; }
        public string email { get; set; }
        public string location { get; set; }
        // departmemt
        public string departmentname { get; set; }
        public string designation { get; set; }
        public int salary { get; set; }
        public string employeeEmailUpdater { get; set; }
        public DateTime joinedDate { get; set; }
        public Image EmployeeImage { get; set; }

        public string employeeIDUpdater { get; set; }

        // methods

        public override bool QueryHasError { get; set; }
        public override string ErrorMessage { get; set; }

        // add 
        public void AddEmployee()
        {
            try
            {
                SqlConnection connection = Connections.GetSqlConnection();
                connection.Open();
                SqlCommand command = new SqlCommand("addEmployee", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@empID", employeeID);
                command.Parameters.AddWithValue("@empName", employeeName);
                command.Parameters.AddWithValue("@gender", gender);
                command.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
                command.Parameters.AddWithValue("@mobile", mobile);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@location", location);
                command.Parameters.AddWithValue("@departName", departmentname);
                command.Parameters.AddWithValue("@designation", designation);
                command.Parameters.AddWithValue("@salary", salary);
                command.Parameters.AddWithValue("@JoinedDate", joinedDate);
                command.Parameters.AddWithValue("@photo", ImageControler.SaveImageIntoStream(EmployeeImage).ToArray());
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        QueryHasError = true;
                        ErrorMessage = reader[0].ToString();
                    }

                }
                connection.Close();
                //  QueryHasError = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        // update
        public void UpdateEmployee()
        {
            try
            {
                SqlConnection connection = Connections.GetSqlConnection();
                connection.Open();
                SqlCommand command = new SqlCommand("updateemp", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@empName", employeeName);
                command.Parameters.AddWithValue("@gender", gender);

                command.Parameters.AddWithValue("@mobile", mobile);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@location", location);
                command.Parameters.AddWithValue("@departName", departmentname);
                command.Parameters.AddWithValue("@designation", designation);
                command.Parameters.AddWithValue("@salary", salary);

                command.Parameters.AddWithValue("@photo", ImageControler.SaveImageIntoStream(EmployeeImage).ToArray());
                command.Parameters.AddWithValue("@updateID", employeeIDUpdater);

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


        public void Delete(string id)
        {
            try
            {
                SqlConnection connection = Connections.GetSqlConnection();
                connection.Open();
                SqlCommand command = new SqlCommand("deleteEmployee", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", id);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        QueryHasError = true;
                        ErrorMessage = reader[0].ToString();
                    }
                }
                reader.Close();
                connection.Close();
                //  QueryHasError = false;
            }
            catch (Exception ex)
            {
                QueryHasError = true;
                ErrorMessage = ex.Message;
            }
        }


        public bool SearchDeletionEmployee(string id)
        {
            bool isExist = false;
            try
            {
                SqlConnection connection = Connections.GetSqlConnection();
                connection.Open();
                SqlCommand command = new SqlCommand("searchDeletion", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", id);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.HasRows)
                        isExist = true;
                }
                reader.Close();
                connection.Close();
                QueryHasError = false;
            }
            catch (Exception ex)
            {
                QueryHasError = true;
                ErrorMessage = ex.Message;
            }

            return isExist;
        }


        public void GetEmployeeInformation(string id)
        {

            try
            {
                SqlConnection connection = Connections.GetSqlConnection();
                connection.Open();
                SqlCommand command = new SqlCommand("getEmployeeInfo", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", id);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        employeeName = reader[0].ToString();
                        mobile = Convert.ToInt64(reader[1]);
                        email = reader[3].ToString();
                        location = reader[4].ToString();
                        gender = reader[4].ToString();
                        salary = Convert.ToInt32(reader[3]);
                        departmentname = reader[2].ToString();
                        designation = reader[1].ToString();
                        EmployeeImage = ImageControler.GteImageFromStream(reader[0]);
                    }

                }
                reader.Close();
                connection.Close();
                QueryHasError = false;
            }
            catch (Exception ex)
            {
                QueryHasError = true;
                ErrorMessage = ex.Message;
            }


        }



        // throws thratin

        public static bool isTheated()
        {
            try
            {
                SqlConnection connection = Connections.GetSqlConnection();
                connection.Open();
                SqlCommand command = new SqlCommand("getEmployeeInfo", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.HasRows)

                        return true;
                }
                reader.Close();
                connection.Close();

            }
            catch (Exception ex)
            {

            }
            return false;
        }
    }
}
