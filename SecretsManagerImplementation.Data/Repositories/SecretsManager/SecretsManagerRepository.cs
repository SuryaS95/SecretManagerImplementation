using SecretsManagerImplementation.Data.Helpers;
using SecretsManagerImplementation.Data.DBContext;

namespace SecretsManagerImplementation.Data.Repositories.SecretsManager
{
    public class SecretsManagerRepository : ISecretsManagerRepository
    {
        private readonly connectionConfig _connectionConfig;
        private readonly DatabaseContext _dbContext;
        public SecretsManagerRepository(connectionConfig connectionConfig, DatabaseContext dbContext)
        {
            _connectionConfig = connectionConfig;
            _dbContext = dbContext;
        }
        public string GetTheStoredSecret()
        {
            var connectionStringFromSecretsManager = _connectionConfig.getSnowflakeConnection();
            //using var connection = _dbContext.createConnection(connectionStringFromSecretsManager);
            return connectionStringFromSecretsManager;
        }
    }
}
