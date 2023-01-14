using System;
using System.Data;
using System.Data.SqlClient;

namespace HIMILO_ICT_PAYROLL_SYSTEM.Controlers
{
    internal class Attendance : IQuery
    {

        public int attenDanceID { get; set; }
        public int employeeID { get; set; }
        public string Status { get; set; }
        public DateTime dateTime { get; set; }

        public int attendanceUpdater { get; set; }


        public override bool QueryHasError { get; set; }
        public override string ErrorMessage { get; set; }

        public void takeAttendance(string _id, string _status, DateTime _date)
        {
            try
            {
                SqlConnection conn = Connections.GetSqlConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand("addAttendance", conn);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@empID", _id);
                cmd.Parameters.AddWithValue("@status", _status);
                cmd.Parameters.AddWithValue("@date", _date);
                cmd.ExecuteNonQuery();
                conn.Close();
                QueryHasError = false;

            }
            catch (System.Exception ex)
            {

                QueryHasError = true;
                ErrorMessage = ex.Message;
            }

        }



        public DataTable filterDepartments(string _department_name)
        {
            var table = new DataTable();
            try
            {
                SqlConnection conn = Connections.GetSqlConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand("filterEmploye", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@departName", _department_name);
                var adapter = new SqlDataAdapter(cmd);

                adapter.Fill(table);

                cmd.ExecuteNonQuery();
                conn.Close();
                QueryHasError = false;

            }
            catch (Exception ex)
            {

                QueryHasError = true;
                ErrorMessage = ex.Message;
            }
            return table;
        }

        public DataTable filterDepartment(string _department_name)
        {
            var table = new DataTable();
            try
            {
                SqlConnection conn = Connections.GetSqlConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand("filterDepartEmployee", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@depart", _department_name);
                var adapter = new SqlDataAdapter(cmd);

                adapter.Fill(table);

                cmd.ExecuteNonQuery();
                conn.Close();
                QueryHasError = false;

            }
            catch (Exception ex)
            {

                QueryHasError = true;
                ErrorMessage = ex.Message;
            }
            return table;
        }


        public DataTable filterDateAttendance(DateTime dateTime)
        {
            var table = new DataTable();
            try
            {
                SqlConnection conn = Connections.GetSqlConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand("filterDate", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date", dateTime);
                var adapter = new SqlDataAdapter(cmd);

                adapter.Fill(table);
                cmd.ExecuteNonQuery();
                conn.Close();
                QueryHasError = false;

            }
            catch (Exception ex)
            {

                QueryHasError = true;
                ErrorMessage = ex.Message;
            }
            return table;
        }


        public DataTable showTopNumber(int top)
        {
            var table = new DataTable();
            try
            {
                SqlConnection conn = Connections.GetSqlConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand("showTopNumber", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@top", top);
                var adapter = new SqlDataAdapter(cmd);

                adapter.Fill(table);
                cmd.ExecuteNonQuery();
                conn.Close();
                QueryHasError = false;

            }
            catch (Exception ex)
            {

                QueryHasError = true;
                ErrorMessage = ex.Message;
            }
            return table;
        }

        public bool isTooked(DateTime _date)
        {
            try
            {
                SqlConnection conn = Connections.GetSqlConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand("istaked", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date", _date);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.HasRows)
                        return true;
                }

                reader.Close();
                conn.Close();
                QueryHasError = false;

            }
            catch (System.Exception ex)
            {

                QueryHasError = true;
                ErrorMessage = ex.Message;
            }
            return false;
        }




    }
}
