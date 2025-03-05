using System.Threading.Tasks;

namespace StoreSyncFront.Services;

public interface IAuthService
{
    Task<bool> Autenticar(string login, string senha);
}