using Domain.UseCase.Pane;
using UnityEngine;
using VContainer;
using Presentation.Presenter.Pane;
using VContainer.Unity;
using View.UI.Button;

namespace Application.LifetimeScope.Pane
{
    public class TitlePaneLifetimeScope : VContainer.Unity.LifetimeScope
    {
        [SerializeField]
        private NormalButton _toOutGameSceneButton;

        protected override void Configure(IContainerBuilder builder)
        {
            // EntryPoint
            builder.RegisterEntryPoint<TitlePaneEntryPointUseCase>();

            builder.Register(_ => new TitlePanePresenter(_toOutGameSceneButton), Lifetime.Scoped).AsImplementedInterfaces();
        }
    }
}
