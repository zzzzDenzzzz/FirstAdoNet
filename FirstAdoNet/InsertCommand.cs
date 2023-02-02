using System.Data.SqlClient;

namespace FirstAdoNet
{
    public class InsertCommand
    {
        public static void InsertAuthor(string connectionString)
        {
            // 1. Создание подключения
            using var connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();

            // 2. Создание команды
            var insretCommand = new SqlCommand(
                @"INSERT INTO Authors VALUES(N'Василий', N'Петров')",
                connection);

            // 3. Выполнение
            insretCommand.ExecuteNonQuery();
        }

        public static void InsertAuthorWithParameters(
            string connectionString,
            string firstName,
            string lastName)
        {
            // 1. Создание подключения
            using var connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();

            // 2. Создание команды
            var command = new SqlCommand(
                @"INSERT INTO Authors VALUES(@firstname, @lastName)",
                connection);
            command.Parameters.AddWithValue("@firstName", firstName);
            command.Parameters.AddWithValue("@lastName", lastName);

            // 3. Выполнение
            command.ExecuteNonQuery();
        }
    }
}
