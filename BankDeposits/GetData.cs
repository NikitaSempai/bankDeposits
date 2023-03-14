using System.Data.SqlClient;


namespace BankDeposits
{
    public class GetData
    {
        private const string connectionString = @"Data Source= NIKITA\SQLEXPRESS;Initial Catalog=Bank_deposits;Integrated Security=true";
        private List<string> loginPasswordData = new List<string>();
        private string roleName = "";

        public List<string> getAllLoginsAndPassword()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "select phone, password from Person";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string phone = reader.GetString(0);
                        string password = reader.GetString(1);
                        loginPasswordData.AddRange(new[] { phone, password });
                    }
                }
                reader.Close();
                return loginPasswordData;
            }
        }
        
        public string getRole(string number)
        {
            int roleId = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = String.Format("select Role_ID from Person where phone = '{0}'", number);
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        roleId = reader.GetInt32(0);
                    }
                }
                reader.Close();
                string secondQuery = String.Format("select Role_Name from role where Role_ID IN ({0})", roleId);
                SqlCommand newCmd = new SqlCommand(secondQuery, connection);
                SqlDataReader newReader = newCmd.ExecuteReader();
                if (newReader.HasRows)
                {
                    while (newReader.Read())
                    {
                        roleName = newReader.GetString(0);                       
                    }
                }
                newReader.Close();
            }
            return roleName;
        }
    }
}
