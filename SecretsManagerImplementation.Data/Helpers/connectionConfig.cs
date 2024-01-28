using SecretsManagerImplementation.Data.Entities;

namespace SecretsManagerImplementation.Data.Helpers
{
    public class connectionConfig
    {
        private string sqlConnectionString;
        private string snowflakeConnectionString;
        public connectionConfig()
        {
            var secrets =SecretsManagerHelper.GetSecret<DatabaseConnections>().Result;
            sqlConnectionString = secrets.SQLConnection;
            snowflakeConnectionString = secrets.snowflakeconnection;
        }

        public string getSqlConnection() => sqlConnectionString;
        public string getSnowflakeConnection() => snowflakeConnectionString;
    }
}
