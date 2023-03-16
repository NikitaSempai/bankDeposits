using System.Data.SqlClient;
using System.Data;
using FilterOfSearch;


namespace BankDeposits
{
    public class PrintTables
    {
        private int pageSize = 0;
        private int pageNumber = 0;
        private string connectionString = @"Data Source= NIKITA\SQLEXPRESS;Initial Catalog=Bank_deposits;Integrated Security=true";       
        private SqlCommandBuilder commandBuilder;
        private SqlDataAdapter adapter;
        private static Search filter = new Search();
        private DataSet ds;
        private static Dictionary<int, string> tableName = new Dictionary<int, string>()
        {
            {1, "Client"},
            {2, "Account"},
            {3, "Deposit"},
            {4, "Interest_Type"},
            {5, "Person"},
            {6, "Role"}
        };

        private static Dictionary<int, string> procedureName = new Dictionary<int, string>()
        {
            {1, "updateClient"},
            {2, "updateAccount"},
            {3, "updateDeposit"},
            {4, "updateInterest_Type"},
            {5, "updatePerson"},
            {6, "updateRole"}
        };
        /// <summary>
        /// Инициализация
        /// </summary>
        /// <param name="dataGridView1">Объект для работы с данными на форме</param>
        /// <param name="tableNumber">Номер текущей таблицы(сущности)</param>
        /// <param name="personRole">Роль пользователя</param>
        /// <param name="addButton">Кнопка "Добавить"</param>
        /// <param name="deleteButton">Кнопка удалить</param>
        /// <param name="saveButton">Кнопка сохранить</param>
        public void Init(DataGridView dataGridView1 , int tableNumber, string personRole, Button addButton , Button deleteButton, Button saveButton)
        {           
            switch (tableNumber)
            {
                case 1:
                case 2:
                    pageSize = 8;
                    break;
                case 3:
                    pageSize = 7;
                    break;
                case 4:
                    pageSize = 4;
                    break;
                case 6:
                    pageSize = 5;
                    break;
                case 5:
                    pageSize = 6;
                    break;
                default:
                    break;
            }
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            if(personRole == "Читатель" || personRole == "Базовая")
            {
                dataGridView1.ReadOnly = true;
                addButton.Visible = false;
                deleteButton.Visible = false;
                saveButton.Visible = false;
            }        
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                adapter = new SqlDataAdapter(GetSql(tableNumber), connection);
                ds = new DataSet();
                adapter.Fill(ds, tableName[tableNumber]);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[tableName[tableNumber] + "_ID"].ReadOnly = true;
            }
        }
        /// <summary>
        ///  кнопка "Вперед" на форме с таблицей
        /// </summary>
        /// <param name="tableNumber">Номер текущей таблицы(сущности)</param>
        public void forwardButton(int tableNumber)
        {
            if (ds.Tables[tableName[tableNumber]].Rows.Count < pageSize) return;
            pageNumber++;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                adapter = new SqlDataAdapter(GetSql(tableNumber), connection);
                ds.Tables[tableName[tableNumber]].Rows.Clear();
                adapter.Fill(ds, tableName[tableNumber]);
            }
        }
        /// <summary>
        /// Кнопка "Назад" на форме с таблицей
        /// </summary>
        /// <param name="tableNumber">Номер текущей таблицы(сущности)</param>
        public void backButton(int tableNumber)
        {
            if (pageNumber == 0) return;
            pageNumber--;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                adapter = new SqlDataAdapter(GetSql(tableNumber), connection);
                ds.Tables[tableName[tableNumber]].Rows.Clear();
                adapter.Fill(ds, tableName[tableNumber]);
            }
        }
        /// <summary>
        /// Запрос на получени данных из бд
        /// </summary>
        /// <param name="tableNumber">Номер текущей таблицы(сущности)</param>
        /// <returns></returns>
        public string GetSql(int tableNumber)
        {
            return "SELECT * FROM " + tableName[tableNumber] + " ORDER BY " + tableName[tableNumber] + "_ID" + " OFFSET ((" + pageNumber + ") * " + pageSize + ") " +
                "ROWS FETCH NEXT " + pageSize + "ROWS ONLY";
        }
        /// <summary>
        /// Кнопка "Добавить" запись на форме с таблицей
        /// </summary>
        public void addButton()
        {
            DataRow row = ds.Tables[0].NewRow();
            ds.Tables[0].Rows.Add(row);
        }
        /// <summary>
        /// Кнопка "Удалить" запись
        /// </summary>
        /// <param name="dataGridView1">объект для работы с данными на форме</param>
        public void deleteButton(DataGridView dataGridView1)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);               
            }
        }
        /// <summary>
        /// Кнопка "Сохранения" изменений
        /// </summary>
        /// <param name="sql">Запрос на получение данных</param>
        /// <param name="tableNumber">Номер текущей таблицы(сущности)</param>
        public void saveButton(string sql, int tableNumber)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    adapter = new SqlDataAdapter(sql, connection);
                    commandBuilder = new SqlCommandBuilder(adapter);
                    adapter.InsertCommand = new SqlCommand(procedureName[tableNumber], connection);
                    adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                    switch (tableNumber)
                    {
                        case 1:
                            adapter.InsertCommand.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar, 50, "Name"));
                            adapter.InsertCommand.Parameters.Add(new SqlParameter("@surname", SqlDbType.NVarChar, 50, "Surname"));
                            adapter.InsertCommand.Parameters.Add(new SqlParameter("@patronymic", SqlDbType.NVarChar, 50, "Patronymic"));
                            adapter.InsertCommand.Parameters.Add(new SqlParameter("@passportNumber", SqlDbType.Int, 0, "Passport_Number"));
                            adapter.InsertCommand.Parameters.Add(new SqlParameter("@Adress", SqlDbType.NVarChar, 50, "Adress"));
                            adapter.InsertCommand.Parameters.Add(new SqlParameter("@Phone", SqlDbType.NVarChar, 16, "Phone"));
                            SqlParameter parameter = adapter.InsertCommand.Parameters.Add("@Client_ID", SqlDbType.Int, 0, "Client_ID");
                            parameter.Direction = ParameterDirection.Output;
                            break;
                        case 2:
                            adapter.InsertCommand.Parameters.Add(new SqlParameter("@openingDate", SqlDbType.Date, 0, "Opening_Date"));
                            adapter.InsertCommand.Parameters.Add(new SqlParameter("@closingDate", SqlDbType.Date, 0, "Closing_Date"));
                            adapter.InsertCommand.Parameters.Add(new SqlParameter("@investmentAmount", SqlDbType.Int, 0, "Investment_Amount"));
                            adapter.InsertCommand.Parameters.Add(new SqlParameter("@clientId", SqlDbType.Int, 0, "Client_ID"));
                            adapter.InsertCommand.Parameters.Add(new SqlParameter("@depositId", SqlDbType.Int, 0, "Deposit_ID"));
                            SqlParameter secondParameter = adapter.InsertCommand.Parameters.Add("@Account_ID", SqlDbType.Int, 0, "Account_ID");
                            secondParameter.Direction = ParameterDirection.Output;
                            break;
                        case 3:
                            adapter.InsertCommand.Parameters.Add(new SqlParameter("@type", SqlDbType.NVarChar, 100, "Type"));
                            adapter.InsertCommand.Parameters.Add(new SqlParameter("@period", SqlDbType.NVarChar, 50, "Period"));
                            adapter.InsertCommand.Parameters.Add(new SqlParameter("@yearRate", SqlDbType.Float, 0, "Year_Rate"));
                            adapter.InsertCommand.Parameters.Add(new SqlParameter("@interestTypeId", SqlDbType.Int, 0, "Interest_Type_ID"));
                            SqlParameter thirdParameter = adapter.InsertCommand.Parameters.Add("@Deposit_ID", SqlDbType.Int, 0, "Deposit_ID");
                            thirdParameter.Direction = ParameterDirection.Output;
                            break;
                        case 4:
                            adapter.InsertCommand.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar, 50, "Name"));
                            SqlParameter fourthParameter = adapter.InsertCommand.Parameters.Add("@Interest_Type_ID", SqlDbType.Int, 0, "Interest_Type_ID");
                            fourthParameter.Direction = ParameterDirection.Output;
                            break;
                        case 5:
                            adapter.InsertCommand.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar, 50, "Name"));
                            adapter.InsertCommand.Parameters.Add(new SqlParameter("@surname", SqlDbType.NVarChar, 50, "Surname"));
                            adapter.InsertCommand.Parameters.Add(new SqlParameter("@patronymic", SqlDbType.NVarChar, 50, "Patronymic"));
                            adapter.InsertCommand.Parameters.Add(new SqlParameter("@Phone", SqlDbType.NVarChar, 16, "Phone"));
                            adapter.InsertCommand.Parameters.Add(new SqlParameter("@position", SqlDbType.NVarChar, 50, "Position"));
                            adapter.InsertCommand.Parameters.Add(new SqlParameter("@roleId", SqlDbType.Int, 0, "Role_ID"));
                            adapter.InsertCommand.Parameters.Add(new SqlParameter("@password", SqlDbType.NVarChar, 50, "Password"));
                            SqlParameter fifthParameter = adapter.InsertCommand.Parameters.Add("@Person_ID", SqlDbType.Int, 0, "Person_ID");
                            fifthParameter.Direction = ParameterDirection.Output;
                            break;
                        case 6:
                            adapter.InsertCommand.Parameters.Add(new SqlParameter("@roleName", SqlDbType.NVarChar, 50, "Role_Name"));
                            SqlParameter sixthParameter = adapter.InsertCommand.Parameters.Add("@Role_ID", SqlDbType.Int, 0, "Role_ID");
                            sixthParameter.Direction = ParameterDirection.Output;
                            break;
                        default:
                            break;
                    }
                    adapter.Update(ds, tableName[tableNumber]);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }
        /// <summary>
        /// Кнопка поиска данных
        /// </summary>
        /// <param name="firstText">Текст первого textBox</param>
        /// <param name="secondText">Текст второго textBox</param>
        /// <param name="accountTable">Таблица для поиска данных</param>
        public void searchButton(TextBox firstText, TextBox secondText, DataGridView accountTable)
        {
            filter.searchButton(firstText, secondText, accountTable);
        }
    }
}
