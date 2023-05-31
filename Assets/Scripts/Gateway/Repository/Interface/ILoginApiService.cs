using Cysharp.Threading.Tasks;
using Gateway.ValueObject.Service.Api;

namespace Gateway.Repository.Interface
{
    public interface ILoginApiService
    {
        UniTask<LoginApiServiceOutput> Login();
    }
}
