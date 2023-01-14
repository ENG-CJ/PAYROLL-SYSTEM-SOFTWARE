using System;
using System.Data;
using System.Data.SqlClient;


namespace HIMILO_ICT_PAYROLL_SYSTEM.Controlers
{
    internal class Payroll : IQuery
    {
        public override bool QueryHasError { get; set; }
        public override string ErrorMessage { get; set; }

        public DataTable filterByPeriod(string month, string year)
        {
            var table = new DataTable();
            try
            {
                SqlConnection conn = Connections.GetSqlConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand("filterByPeriod", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@month", month);
                cmd.Parameters.AddWithValue("@year", year);
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



        public DataTable filterbyDepart(string depart)
        {
            var table = new DataTable();
            try
            {
                SqlConnection conn = Connections.GetSqlConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand("filterByDepart", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@depart", depart);

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



        public DataTable showTops(int number)
        {
            var table = new DataTable();
            try
            {
                SqlConnection conn = Connections.GetSqlConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand("showTops", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@top", number);

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
    }
}
