using Cysharp.Threading.Tasks;
using Gateway.Repository.Interface;
using Gateway.ValueObject.Service.Api;

namespace Device.Service.Api
{
    public class LoginApiService : ILoginApiService
    {
        public async UniTask<LoginApiServiceOutput> Login()
        {
            await UniTask.SwitchToThreadPool();

            // API通信処理は別スレッドへ移譲
            await UniTask.Delay(3000);

            await UniTask.SwitchToMainThread();

            return new LoginApiServiceOutput("Bob");
        }
    }
}
