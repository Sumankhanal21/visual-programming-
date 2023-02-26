
To connect a C# console program with ADO.NET in Visual Studio Code, follow these steps:

Create a new console project in Visual Studio Code by navigating to the File menu and selecting New Project. Choose Console Application and give your project a name.

Add the ADO.NET NuGet package to your project by opening the terminal window in Visual Studio Code and running the command: dotnet add package System.Data.SqlClient

In your C# program, include:
using System;
using System.Data.SqlClient;
namespace MyApplication{
    class Program{
        static void Main(string[]args){
string connectionString = "Server=myServerName;Database=myDatabaseName;User Id=myUsername;Password=myPassword;";
SqlConnection connection = new SqlConnection(connectionString);
connection.Open();
string sql = "SELECT * FROM MyTable";
SqlCommand command = new SqlCommand(sql, connection);
SqlDataReader reader = command.ExecuteReader();
while (reader.Read())
{
    Console.WriteLine("{0}\t{1}", reader.GetInt32(0), reader.GetString(1));
}
reader.Close();
connection.Close();
        }
    }
}
