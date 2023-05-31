using Cysharp.Threading.Tasks;
using Domain.UseCase.Interface.Repository;
using Domain.ValueObject.Repository.Api;
using Gateway.Repository.Interface;
using VContainer;

namespace Gateway.Repository.Api
{
    public class LoginApiRepository : ILoginApiRepository
    {
        private readonly ILoginApiService _loginApiService;

        [Inject]
        public LoginApiRepository(ILoginApiService loginApiService)
        {
            _loginApiService = loginApiService;
        }

        public async UniTask<LoginApiRepositoryOutput> Login()
        {
            var response = await _loginApiService.Login();
            return new LoginApiRepositoryOutput(response.PlayerName);
        }
    }
}
