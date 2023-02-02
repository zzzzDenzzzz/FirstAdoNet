using FirstAdoNet;

// строка подключения
string connectionString = "Data Source=DENIS-PC\\SQLEXPRESS;" +
    " Initial Catalog = Library; Integrated Security = True; Connect Timeout = 30;" +
    " Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";

//InsertCommand.InsertAuthor(connectionString);
//SelectCommand.SelectAuthors(connectionString);
//InsertCommand.InsertAuthorWithParameters(
//    connectionString,
//    "Иван",
//    "Иванов");
//StoredProcedureCommand.ExecuteProcedure(connectionString, 1);