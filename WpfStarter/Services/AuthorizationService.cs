using System.Threading.Tasks;
using WpfStarter.Models.Security;

namespace WpfStarter.Services
{
    public class AuthorizationService : IAuthorizationService
    {
        public Task<bool> Login(LoginModel model)
        {
            return Task.FromResult(true);
        }
    }
}
