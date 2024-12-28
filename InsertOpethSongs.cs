using Microsoft.Data.SqlClient;
using System;
using System.IO;

namespace spotify
{
    public class InsertOpethSongs
    {
        public static void InsertSongs()
        {
            string connectionString = "Data Source=.\\SQLEXPRESS; Initial Catalog=spotify; Integrated Security=True; TrustServerCertificate=True; Encrypt=False";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    Console.WriteLine("Connected to database successfully!");

                    // Read and execute the SQL script
                    string sqlScript = File.ReadAllText("insert_opeth_songs.sql");
                    using (SqlCommand command = new SqlCommand(sqlScript, connection))
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine("Opeth songs inserted successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static void Main()
        {
            InsertSongs();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
} 
