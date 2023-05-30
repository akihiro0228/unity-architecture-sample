using Domain.UseCase.Pane;
using VContainer;
using VContainer.Unity;

namespace Presentation.Controller.Pane
{
    public class TitlePaneController : IStartable
    {
        private readonly TitlePaneUseCase _titlePaneUseCase;

        [Inject]
        public TitlePaneController(TitlePaneUseCase titlePaneUseCase)
        {
            _titlePaneUseCase = titlePaneUseCase;
        }

        public void Start()
        {
            _titlePaneUseCase.Initialize();
        }
    }
}