using System;
using System.Data.SqlClient;

namespace DBHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DB Connection Test");

            string connectionString = "Server=tcp:professionaltraining.database.windows.net,1433;Initial Catalog=XmlTestDb;Persist Security Info=False;User ID=ptuser;Password=Training2021!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";


            SqlConnection connection = new SqlConnection(connectionString);


            connection.Open();

            string sql = "select * from users";
            SqlCommand command = new SqlCommand(sql, connection);
            
            SqlDataReader rs = command.ExecuteReader();
            
            while(rs.Read())
            {

                string name = rs.GetString(1);

                Console.WriteLine(name);


            }
            
            connection.Close();


            // System.Data.SqlClient.





        }
    }
}
