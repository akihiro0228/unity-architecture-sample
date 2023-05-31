using Cysharp.Threading.Tasks;
using Gateway.ValueObject.Service.Api.LoginApiService;

namespace Gateway.Repository.Interface
{
    public interface ILoginApiService
    {
        UniTask<LoginOutput> Login();
    }
}
