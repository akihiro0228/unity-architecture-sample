using Domain.UseCase.Pane;
using Infrastructure.Repository.Api;
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
        private NormalButton _loginButton;

        protected override void Configure(IContainerBuilder builder)
        {
            // EntryPoint
            builder.RegisterEntryPoint<TitlePaneEntryPointUseCase>();

            // Repository
            builder.Register<LoginApiRepository>(Lifetime.Scoped).AsImplementedInterfaces();

            // Presenter
            builder.Register(_ => new TitlePanePresenter(_loginButton), Lifetime.Scoped).AsImplementedInterfaces();
        }
    }
}
