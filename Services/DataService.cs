using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_challenge.Services
{
    public interface IDatabaseService
    {
        Task<List<string>> GetDataFromDatabase();
    }

    public class DatabaseService : IDatabaseService
    {
        private readonly string _connectionString;

        public DatabaseService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<List<string>> GetDataFromDatabase()
        {
            var resultList = new List<string>();

            using (var connection = new MySqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                string query = "SELECT kolomnaam FROM tabelnaam";

                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            resultList.Add(reader.GetString(0));
                        }
                    }
                }
            }

            return resultList;
        }
    }
}

