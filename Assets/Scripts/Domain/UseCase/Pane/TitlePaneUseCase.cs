using System;
using Domain.UseCase.Interface.Presenter;
using Domain.UseCase.Interface.Repository;
using VContainer;
using VContainer.Unity;
using UniRx;
using UnityEngine;
using System.Threading.Tasks;

namespace Domain.UseCase.Pane
{
    public class TitlePaneUseCase : IDisposable
    {
        public class Response
        {
            public string PlayerName { get; }   
            public Response(string PlayerName)
            {
                this.PlayerName = PlayerName;
            }
        };

        private readonly ILoginApiRepository _loginApiRepository;
        private readonly CompositeDisposable _selfDisposables;

        [Inject]
        public TitlePaneUseCase(ILoginApiRepository loginApiRepository)
        {
            _loginApiRepository = loginApiRepository;
            _selfDisposables = new CompositeDisposable();
        }

        public async Task<Response> InvokeAsync()
        {
            Debug.Log("Login >>>");
            var output = await _loginApiRepository.Login();
            Debug.Log("Login <<<");
            return new Response(output.PlayerName);
        }

        public void Dispose()
        {
            _selfDisposables.Clear();
        }
    }
}
