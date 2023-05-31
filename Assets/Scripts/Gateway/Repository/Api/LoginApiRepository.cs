using Cysharp.Threading.Tasks;
using Domain.UseCase.Interface.Repository;
using Domain.ValueObject.Repository.Api.LoginApiRepository;
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

        public async UniTask<LoginOutput> Login()
        {
            var response = await _loginApiService.Login();
            return new LoginOutput(response.PlayerName);
        }
    }
}
