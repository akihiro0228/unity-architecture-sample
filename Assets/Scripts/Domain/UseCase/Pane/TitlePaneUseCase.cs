using System;
using Domain.UseCase.Interface.Presenter;
using Domain.UseCase.Interface.Repository;
using VContainer;
using VContainer.Unity;
using UniRx;
using UnityEngine;

namespace Domain.UseCase.Pane
{
    public class TitlePaneUseCase : IDisposable
    {
        private readonly ILoginApiRepository _loginApiRepository;
        private readonly ITitlePanePresenter _titlePanePresenter;
        private readonly CompositeDisposable _selfDisposables;

        [Inject]
        public TitlePaneUseCase(ILoginApiRepository loginApiRepository, ITitlePanePresenter titlePanePresenter)
        {
            _loginApiRepository = loginApiRepository;
            _titlePanePresenter = titlePanePresenter;
            _selfDisposables = new CompositeDisposable();
        }

        public void Initialize()
        {
            _titlePanePresenter.OnClickLoginButtonAsObservable().Subscribe(async _ =>
                {
                    var output = await _loginApiRepository.Login();
                    Debug.Log($"login name is {output.PlayerName}");
                })
                .AddTo(_selfDisposables);
        }

        public void Dispose()
        {
            _selfDisposables.Clear();
        }
    }
}
