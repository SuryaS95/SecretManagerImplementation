using Microsoft.AspNetCore.Mvc;
using SecretsManagerImplementation.Data.Repositories.SecretsManager;

namespace SecretsManagerImplementation.Controllers
{
    [Route("SecretsManager")]
    public class SecretsManagerController : Controller
    {
        private readonly ISecretsManagerRepository _secretsManagerRepository;
        public SecretsManagerController(ISecretsManagerRepository secretsManagerRepository)
        {
            _secretsManagerRepository= secretsManagerRepository;
        }

        [HttpGet]
        public string DisplayRetrievedSecrets()
        {
            return _secretsManagerRepository.GetTheStoredSecret();
        }
    }
}
