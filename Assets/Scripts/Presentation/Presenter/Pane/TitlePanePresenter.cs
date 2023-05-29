using System;
using Domain.UseCase.Interface.Presenter;
using UniRx;
using Presentation.Presenter.Interface;

namespace Presentation.Presenter.Pane
{
    public class TitlePanePresenter : ITitlePanePresenter
    {
        private readonly IButton _loginButton;

        public TitlePanePresenter(IButton loginButton)
        {
            _loginButton = loginButton;
        }

        public IObservable<Unit> OnClickLoginButtonAsObservable()
        {
            return _loginButton.OnClickAsObservable();
        }
    }
}
