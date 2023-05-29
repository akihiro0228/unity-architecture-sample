using Cysharp.Threading.Tasks;
using Domain.ValueObject.Repository.Api;

namespace Domain.UseCase.Interface.Repository
{
    public interface ILoginApiRepository
    {
        UniTask<LoginOutput> Login();
    }
}
