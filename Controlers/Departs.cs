using System;
using System.Data;
using System.Data.SqlClient;

namespace HIMILO_ICT_PAYROLL_SYSTEM.Controlers
{
    internal class Departs : IQuery
    {
        public int DepartmentId { get; set; }
        public String DepartmentName { get; set; }

        public bool __HasRows = false;
        public string messageQuery;

        public int Updater { get; set; }
        public override bool QueryHasError { get; set; }
        public override string ErrorMessage { get; set; }

        public void AddDepartment()
        {
            try
            {
                SqlConnection conn = Connections.GetSqlConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand("addDepart", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@departID", DepartmentId);
                cmd.Parameters.AddWithValue("@depname", DepartmentName);


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


        public void DeleteDepartment(int _id)
        {
            try
            {
                SqlConnection conn = Connections.GetSqlConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand("deleteDepart", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", _id);

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        messageQuery = reader[0].ToString();
                        __HasRows = true;
                    }
                }


                conn.Close();
                QueryHasError = false;
            }
            catch (System.Exception ex)
            {

                QueryHasError = true;
                ErrorMessage = ex.Message;
            }

        }


        public void UpdateDepartment()
        {
            try
            {
                SqlConnection conn = Connections.GetSqlConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand("updateDepart", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@depID", DepartmentId);
                cmd.Parameters.AddWithValue("@depName", DepartmentName);
                cmd.Parameters.AddWithValue("@updateID", Updater);
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


        public class DepartmentDesignation : Departs
        {
            public string name;
            public int updater;



            public void addDesignation()
            {

                try
                {
                    SqlConnection conn = Connections.GetSqlConnection();
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("addDesignation", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@name", name);

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



            public bool FindDepart(string _name)
            {
                DepartmentDesignation dep = new DepartmentDesignation();
                try
                {
                    SqlConnection conn = Connections.GetSqlConnection();
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("findDesignation", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@name", _name);
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader.HasRows)
                            return true;
                    }


                    conn.Close();
                    dep.QueryHasError = false;

                }
                catch (System.Exception ex)
                {
                    dep.QueryHasError = true;
                    dep.ErrorMessage = ex.Message;
                }


                return false;
            }


            public void updateDesignation()
            {
                DepartmentDesignation dep = new DepartmentDesignation();
                try
                {
                    SqlConnection conn = Connections.GetSqlConnection();
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("updatedDesignation", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@updater", updater);

                    cmd.ExecuteNonQuery();
                    conn.Close();


                }
                catch (System.Exception ex)
                {
                    dep.QueryHasError = true;
                    dep.ErrorMessage = ex.Message;
                }



            }
        }




    }
}
