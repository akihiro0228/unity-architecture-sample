using Domain.UseCase.Interface;
using VContainer;
using VContainer.Unity;

namespace Domain.UseCase.Pane
{
    public class TitlePaneEntryPointUseCase : IStartable
    {
        private readonly ITitlePanePresenter _presenter;

        [Inject]
        public TitlePaneEntryPointUseCase(ITitlePanePresenter presenter)
        {
            _presenter = presenter;
        }

        public void Start()
        {
            _presenter.Initialize();
        }
    }
}
