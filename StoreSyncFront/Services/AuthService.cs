using System;
using System.Threading.Tasks;
using StoreSyncFront.Models;

namespace StoreSyncFront.Services;

public class AuthService : IAuthService
{
    private readonly IApiService _apiService;

    public AuthService(IApiService apiService)
    {
        _apiService = apiService;
    }
    
    public async Task<bool> Autenticar(string login, string senha)
    {
        Response response = await _apiService.GetAsync("/todos/3");
        Console.WriteLine(response.Body);
        await Task.Delay(1000);
        return login == "admin" && senha == "123";
    }
}