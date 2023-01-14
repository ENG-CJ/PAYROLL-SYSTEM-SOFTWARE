using Guna.UI2.WinForms;
using MessagesDLL;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
namespace HIMILO_ICT_PAYROLL_SYSTEM
{
    public class Validations
    {
        public static Messages msg1 = new Messages();
        public static bool ValidPassLength(string password, int max, int min)
        {
            return password.Length >= min && password.Length <= max;

        }
        public static bool HasValidName(string text)
        {
            foreach (char txt in text)
            {
                if (text.Any(c => !char.IsLetter(txt) && !char.IsWhiteSpace(txt)))
                    return false;

            }
            return true;
        }
        public static bool isCurrentMonth(DateTime date)
        {

            return (date.Date.Equals(DateTime.Now.Date));
            //bool isValid = false;
            //try
            //{

            //    var conn = Connections.GetSqlConnection();
            //    conn.Open();
            //    var command = new SqlCommand("isValidCurrentMonth", conn);
            //    command.CommandType = CommandType.StoredProcedure;
            //    command.Parameters.AddWithValue("@date", date);
            //    var reader = command.ExecuteReader();
            //    while (reader.Read())
            //    {

            //        var msg = reader[0].ToString();
            //        if (msg == "valid")
            //            isValid = true;
            //    }
            //    conn.Close();
            //    reader.Close();


            //}
            //catch(Exception ex)
            //{
            //    msg1.ShowError(ex.Message, "Error");
            //}
            //return isValid;

        }

        public static bool ValidDateOfBirth(DateTime date)
        {
            int year = (DateTime.Now.Year - date.Year);
            return year >= 25 && year <= 60;
        }

        public static bool IsValidEmail(string email)
        {
            return !email.StartsWith("@gmail.com") && email.EndsWith("@gmail.com");
        }

        public static bool isValidMobile(string mobile)
        {
            bool isValid = false;
            if (mobile.StartsWith("252"))
                isValid = true;
            return isValid;
        }

        public static bool isValidLength(string mobile)
        {
            bool isLength = false;
            if (mobile.Length == 12 || mobile.Length == 13)
                isLength = true;
            return isLength;
        }

        public static bool NotChecked(Guna2RadioButton male, Guna2RadioButton female)
        {
            return male.Checked == false && female.Checked == false;
        }

        public static bool NotChecked(RadioButton male, RadioButton female)
        {
            return male.Checked == false && female.Checked == false;
        }


        public static bool IsValidAge(int age, int max, int min)
        {
            bool isValid = false;

            if (age >= min && age <= max)
                isValid = true;
            return isValid;
        }

        public static bool validateAllBlanks(params Guna2TextBox[] textBoxes)
        {
            foreach (var text in textBoxes)
                if (text.Text == "")
                    return true;
            return false;
        }

        public static bool ComboNotSelectedValue(string targetValue, params Guna2ComboBox[] comboBoxes)
        {
            foreach (var value in comboBoxes)
            {
                if (value.Text == targetValue)
                    return true;
            }

            return false;
        }

        public static bool ImageNotSelected(params PictureBox[] images)
        {
            foreach (var image in images)
            {
                if (image.Image == null)
                    return true;
            }
            return false;
        }
        public static bool NoDateSelected(params Guna2DateTimePicker[] guna2DateTimePickers)
        {
            foreach (var dates in guna2DateTimePickers)
            {
                if (dates.Value == null)
                    return true;
            }
            return false;
        }


        public static bool NoDateSelected(params DateTimePicker[] dateTimePickers)
        {
            foreach (var dates in dateTimePickers)
            {
                if (dates.Value == null)
                    return true;
            }
            return false;
        }

        public static bool HasNumeric(string targetValue)
        {
            foreach (char c in targetValue)
            {
                if (char.IsNumber(c))
                    return true;
            }
            return false;
        }

        public static bool HasCharacters(string targetValue)
        {
            foreach (char c in targetValue)
            {
                if (char.IsLetter(c))
                    return true;
            }
            return false;
        }
        public static bool isExistUser(string username)
        {
            var conn = Connections.GetSqlConnection();
            conn.Open();
            var command = new SqlCommand("findUsername", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@username", username);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader.HasRows)
                    return true;
            }
            conn.Close();
            reader.Close();

            return false;
        }

        public static bool isExistEmail(string email)
        {
            var conn = Connections.GetSqlConnection();
            conn.Open();
            var command = new SqlCommand("findEmail", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@email", email);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader.HasRows)
                    return true;
            }
            conn.Close();
            reader.Close();

            return false;

        }

        public static bool isExistDepartment(string departmentName)
        {
            var conn = Connections.GetSqlConnection();
            conn.Open();
            var command = new SqlCommand("searchDepart", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@name", departmentName);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader.HasRows)
                    return true;
            }
            conn.Close();
            reader.Close();

            return false;

        }

        public static bool isExistBonusName(string bonusName)
        {
            var conn = Connections.GetSqlConnection();
            conn.Open();
            var command = new SqlCommand("findBonus", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@name", bonusName);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader.HasRows)
                    return true;
            }
            conn.Close();
            reader.Close();

            return false;

        }


        public static bool MinMaxchecker(int targetValue, int min, int max)
        {
            if (targetValue >= min && targetValue <= max)
                return true;

            return false;
        }


        public static bool isConverted(string targetValue)
        {
            long temp;
            var convereted = false;
            if (long.TryParse(targetValue, out temp))
            {
                temp = long.Parse(targetValue);
                convereted = true;
            }

            return convereted;
        }
    }
}
