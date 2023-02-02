using System.Data;
using System.Data.SqlClient;

namespace FirstAdoNet
{
    public class StoredProcedureCommand
    {
        public static void ExecuteProcedure(string connectionString, int authorId)
        {
            // 1. Создание подключения
            using var connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            // открытие подключения
            connection.Open();

            // 2. Создание команды
            var command = new SqlCommand(
                "GetBooksNumber",
                connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@AuthorId", authorId);

            var output = new SqlParameter("@BookCount", SqlDbType.Int);
            output.Direction = ParameterDirection.Output;
            command.Parameters.Add(output);

            // 3. Выполнение
            command.ExecuteNonQuery();

            // 4. Считывание ответа
            var result = command.Parameters["@BookCount"].Value.ToString();
            Console.WriteLine(result);
        }
    }
}
