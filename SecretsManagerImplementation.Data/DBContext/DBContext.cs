using Snowflake.Data.Client;
using System.Data;

namespace SecretsManagerImplementation.Data.DBContext
{
    public class DatabaseContext
    {
        public IDbConnection createConnection(string connectionString)
        {
            using var connection = new SnowflakeDbConnection();
            connection.ConnectionString = connectionString;
            return connection;
        }

    }
}
