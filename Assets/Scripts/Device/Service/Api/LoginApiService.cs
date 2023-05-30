using Cysharp.Threading.Tasks;
using Gateway.Repository.Interface;
using Gateway.ValueObject.Service.Api;

namespace Device.Service.Api
{
    public class LoginApiService : ILoginApiService
    {
        public async UniTask<LoginApiServiceOutput> Login()
        {
            await UniTask.Delay(3000);
            return new LoginApiServiceOutput("Bob");
        }
    }
}
