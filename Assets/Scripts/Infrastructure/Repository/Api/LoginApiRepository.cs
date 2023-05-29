using Cysharp.Threading.Tasks;
using Domain.UseCase.Interface.Repository;
using Domain.ValueObject.Repository.Api;

namespace Infrastructure.Repository.Api
{
    public class LoginApiRepository : ILoginApiRepository
    {
        public async UniTask<LoginOutput> Login()
        {
            await UniTask.Delay(3000);
            return new LoginOutput("Bob");
        }
    }
}
