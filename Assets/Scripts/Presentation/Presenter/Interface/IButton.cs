using System;

namespace Presentation.Presenter.Interface
{
    public interface IButton
    {
        public IObservable<UniRx.Unit> OnClickAsObservable();
    }
}
