using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace HIMILO_ICT_PAYROLL_SYSTEM.Controlers
{
    public class Bonus : IQuery
    {
        public int bonusID { get; set; }
        public string bonusName { get; set; }
        public string description { get; set; }
        public int amount
        {
            get; set;
        }


        public int RowsNumber;
        public string errorMessage;

        public int bonusIDUpdater { get; set; }


        public int Bonusamount;
        public int deductionAmount;
        public string month;
        public string year;
        public override bool QueryHasError { get; set; }
        public override string ErrorMessage { get; set; }

        public void addBonus()
        {
            try
            {
                SqlConnection conn = Connections.GetSqlConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand("addBonus", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@name", bonusName);
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.Parameters.AddWithValue("@descr", description);
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

        public void updatedbonus()
        {
            try
            {
                SqlConnection conn = Connections.GetSqlConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand("updateBonus", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@name", bonusName);
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.Parameters.AddWithValue("@descr", description);
                cmd.Parameters.AddWithValue("@id", bonusIDUpdater);
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


        public void ShowEmployeeBonus(string id, string _month, string _year)
        {
            try
            {
                SqlConnection conn = Connections.GetSqlConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand("readBonusEmployee", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@month", _month);
                cmd.Parameters.AddWithValue("@year", _year);

                var adapter = new SqlDataAdapter(cmd);
                var table = new DataTable();
                adapter.Fill(table);
                if (table.Columns.Count > 1)
                {
                    RowsNumber = 1;
                    this.Bonusamount = table.Rows[0].Field<int>(0);
                    this.deductionAmount = table.Rows[0].Field<int>(1);
                    this.month = table.Rows[0].Field<string>(2);
                    this.year = table.Rows[0].Field<string>(3);
                }
                else if (table.Columns.Count == 1)
                {
                    RowsNumber = 0;
                    errorMessage = table.Rows[0].Field<string>(0);
                }

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



        public void DisplaySmount(string bonusName, Guna.UI2.WinForms.Guna2TextBox displayer)
        {
            try
            {
                SqlConnection conn = Connections.GetSqlConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand("readBonusPrecentage", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@name", bonusName);
                var adapter = new SqlDataAdapter(cmd);
                var table = new DataTable();
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    displayer.Text = table.Rows[0].Field<int>(0).ToString();
                }




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





        public void UpdateBonusEmployee(int _amount, int _deductions, string _month, string _year, string _id)
        {
            try
            {
                SqlConnection conn = Connections.GetSqlConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand("updateEmplooyeeBonusRealted", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@amount", _amount);
                cmd.Parameters.AddWithValue("@deductions", _deductions);
                cmd.Parameters.AddWithValue("@month", _month);
                cmd.Parameters.AddWithValue("@year", _year);
                cmd.Parameters.AddWithValue("@upadteID", _id);


                var adapter = new SqlDataAdapter(cmd);
                var table = new DataTable();
                adapter.Fill(table);
                if (table.Columns.Count > 0)
                {
                    errorMessage = table.Rows[0].Field<string>(0);
                    RowsNumber = 1;
                }
                else
                    RowsNumber = 0;



                cmd.ExecuteNonQuery();
                conn.Close();

                QueryHasError = false;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());

                //QueryHasError = true;
                //ErrorMessage = ex;
            }


        }





        public void CerateEmployeeBonus(int _amount, int _deductions, string _id)
        {
            try
            {
                SqlConnection conn = Connections.GetSqlConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand("createDeduction", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@empID", _id);
                cmd.Parameters.AddWithValue("@BonusAmount", _amount);
                cmd.Parameters.AddWithValue("@deduction", _deductions);


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

    }
}