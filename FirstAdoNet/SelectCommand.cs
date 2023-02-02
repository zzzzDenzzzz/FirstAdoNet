using System.Data.SqlClient;

namespace FirstAdoNet
{
    public class SelectCommand
    {
        public static void SelectAuthors(string connectionString)
        {
            // 1. Создание подключения
            using var connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();

            // 2. Создание команды
            var selectCommand = new SqlCommand(
                @"SELECT Id, FirstName, LastName FROM Authors",
                connection);

            // 3. Выполнение
            using SqlDataReader reader = selectCommand.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader[1] + " " + reader[2]);
                //int id = reader.GetInt32(0);
                //string firstName = reader.GetString(1);
                //string lasttName = reader.GetString(2);
            }
        }
    }
}
