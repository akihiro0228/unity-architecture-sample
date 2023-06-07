using System;
using Domain.UseCase.Interface.Presenter;
using UniRx;
using Presentation.Presenter.Interface;
using Domain.UseCase.Pane;
using UnityEngine;
using VContainer;
using System.Threading.Tasks;

namespace Presentation.Presenter.Pane
{
    public class TitlePanePresenter : ITitlePanePresenter
    {
        private readonly TitlePaneUseCase _titlePaneUseCase;

        [Inject]
        public TitlePanePresenter(TitlePaneUseCase titlePaneUseCase)
        {
            _titlePaneUseCase = titlePaneUseCase;
        }

        public async Task<string> LoginAsync()
        {
            var response = await _titlePaneUseCase.InvokeAsync();
            return response.PlayerName;
        }

        public IObservable<Unit> OnClickLoginButtonAsObservable()
        {
            return null;
        }
    }
}
