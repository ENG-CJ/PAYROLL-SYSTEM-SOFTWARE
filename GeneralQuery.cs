using HIMILO_ICT_PAYROLL_SYSTEM.Controlers;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace HIMILO_ICT_PAYROLL_SYSTEM
{
    internal class GeneralQuery : IQuery
    {
        public override bool QueryHasError { get; set; }
        public override string ErrorMessage { get; set; }

        public void Delete(string procedureName, object paramter, object identity)
        {
            try
            {
                SqlConnection connection = Connections.GetSqlConnection();
                connection.Open();
                SqlCommand command = new SqlCommand(procedureName.ToString(), connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue(paramter.ToString(), identity);
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


        public void DeleteDeduction(string empID, object month, object year)
        {
            try
            {
                SqlConnection connection = Connections.GetSqlConnection();
                connection.Open();
                SqlCommand command = new SqlCommand("deleteDeduction", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", empID);
                command.Parameters.AddWithValue("@month", month);
                command.Parameters.AddWithValue("@year", year);
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



        public void addLogFile(string _username, string log_type)
        {
            try
            {
                SqlConnection connection = Connections.GetSqlConnection();
                connection.Open();
                SqlCommand command = new SqlCommand("addLogFile", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@username", _username);
                command.Parameters.AddWithValue("@logType", log_type);
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


        public void CountData(string procedureName, Label displayer)
        {
            int result = 0;
            try
            {
                SqlConnection connection = Connections.GetSqlConnection();
                connection.Open();
                SqlCommand command = new SqlCommand(procedureName.ToString(), connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.HasRows)
                        result = Convert.ToInt32(reader[0]);
                }

                displayer.Text = result.ToString();
                connection.Close();
                QueryHasError = false;
            }
            catch (Exception ex)
            {
                QueryHasError = true;
                ErrorMessage = ex.Message;
            }


        }

        public void GetdData(string procedureName, object paramter, object identity)
        {
            try
            {
                SqlConnection connection = Connections.GetSqlConnection();
                connection.Open();
                SqlCommand command = new SqlCommand(procedureName.ToString(), connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue(paramter.ToString(), identity);
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

        public DataTable search(string procedureName, object paramter, object identity)
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlConnection connection = Connections.GetSqlConnection();
                connection.Open();
                SqlCommand command = new SqlCommand(procedureName.ToString(), connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue(paramter.ToString(), identity);
                SqlDataAdapter sqlData = new SqlDataAdapter(command);
                sqlData.Fill(dataTable);
                command.ExecuteNonQuery();

                connection.Close();
                QueryHasError = false;
            }
            catch (Exception ex)
            {
                QueryHasError = true;
                ErrorMessage = ex.Message;
            }

            return dataTable;
        }


        public DataTable search(string procedureName, object paramter, object param2, object identity, string excepUser)
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlConnection connection = Connections.GetSqlConnection();
                connection.Open();
                SqlCommand command = new SqlCommand(procedureName.ToString(), connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue(paramter.ToString(), identity);
                command.Parameters.AddWithValue(param2.ToString(), excepUser);
                SqlDataAdapter sqlData = new SqlDataAdapter(command);
                sqlData.Fill(dataTable);
                command.ExecuteNonQuery();

                connection.Close();
                QueryHasError = false;
            }
            catch (Exception ex)
            {
                QueryHasError = true;
                ErrorMessage = ex.Message;
            }

            return dataTable;
        }

        public DataTable GetData(string procedureName)
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlConnection connection = Connections.GetSqlConnection();
                connection.Open();
                SqlCommand command = new SqlCommand(procedureName.ToString(), connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataAdapter sqlData = new SqlDataAdapter(command);
                sqlData.Fill(dataTable);
                command.ExecuteNonQuery();

                connection.Close();
                QueryHasError = false;
            }
            catch (Exception ex)
            {
                QueryHasError = true;
                ErrorMessage = ex.Message;
            }

            return dataTable;
        }


        public void BindComboValue(string procedureName, Guna.UI2.WinForms.Guna2ComboBox comboBox)
        {

            try
            {
                SqlConnection connection = Connections.GetSqlConnection();
                connection.Open();
                SqlCommand command = new SqlCommand(procedureName.ToString(), connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                comboBox.Items.Clear();
                var sqlData = command.ExecuteReader();
                while (sqlData.Read())
                {
                    comboBox.Items.Add(sqlData[0].ToString());
                }
                sqlData.Close();


                connection.Close();
                QueryHasError = false;
            }
            catch (Exception ex)
            {
                QueryHasError = true;
                ErrorMessage = ex.Message;
            }

        }

        public DataTable filterName(string procedureName, string param, string value)
        {
            var table = new DataTable();
            try
            {
                SqlConnection connection = Connections.GetSqlConnection();
                connection.Open();
                SqlCommand command = new SqlCommand(procedureName.ToString(), connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue(param, value);

                var adapetr = new SqlDataAdapter(command);

                adapetr.Fill(table);

                command.ExecuteNonQuery();
                connection.Close();
                QueryHasError = false;
            }
            catch (Exception ex)
            {
                QueryHasError = true;
                ErrorMessage = ex.Message;
            }
            return table;
        }


        public DataTable showTopNumber(string procedureName, string param, int value)
        {
            var table = new DataTable();
            try
            {
                SqlConnection connection = Connections.GetSqlConnection();
                connection.Open();
                SqlCommand command = new SqlCommand(procedureName.ToString(), connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue(param, value);

                var adapetr = new SqlDataAdapter(command);

                adapetr.Fill(table);

                command.ExecuteNonQuery();
                connection.Close();
                QueryHasError = false;
            }
            catch (Exception ex)
            {
                QueryHasError = true;
                ErrorMessage = ex.Message;
            }
            return table;
        }


        public void countBonusPaid(Label displayer)
        {
            int result = 0;
            try
            {
                SqlConnection connection = Connections.GetSqlConnection();
                connection.Open();
                SqlCommand command = new SqlCommand("bonusPaid", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.HasRows)
                        result = Convert.ToInt32(reader[0]);
                }

                displayer.Text = OneControl.FormattingNumber(result);
                connection.Close();
                QueryHasError = false;
            }
            catch (Exception ex)
            {
                QueryHasError = true;
                ErrorMessage = ex.Message;
            }


        }


        public void CountSalaryPaid(Label displayer)
        {
            int result = 0;
            try
            {
                SqlConnection connection = Connections.GetSqlConnection();
                connection.Open();
                SqlCommand command = new SqlCommand("totalPayslip", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.HasRows)
                        result = Convert.ToInt32(reader[0]);
                }

                displayer.Text = OneControl.FormattingNumber(result);
                connection.Close();
                QueryHasError = false;
            }
            catch (Exception ex)
            {
                QueryHasError = true;
                ErrorMessage = ex.Message;
            }


        }
    }
}
