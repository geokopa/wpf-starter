using System.Threading.Tasks;
using WpfStarter.Models.Security;

namespace WpfStarter.Services
{
    public interface IAuthorizationService
    {
        Task<bool> Login(LoginModel model);
    }
}
