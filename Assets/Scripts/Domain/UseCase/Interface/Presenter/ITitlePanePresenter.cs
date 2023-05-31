using System;

namespace Domain.UseCase.Interface.Presenter
{
    public interface ITitlePanePresenter
    {
        IObservable<UniRx.Unit> OnClickLoginButtonAsObservable();
    }
}
