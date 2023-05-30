using Domain.UseCase.Pane;
using Gateway.Repository.Api;
using Presentation.Controller.Pane;
using UnityEngine;
using VContainer;
using Presentation.Presenter.Pane;
using VContainer.Unity;
using IO.UI.Button;

namespace Application.LifetimeScope.Pane
{
    public class TitlePaneLifetimeScope : VContainer.Unity.LifetimeScope
    {
        [SerializeField]
        private NormalButton _loginButton;

        protected override void Configure(IContainerBuilder builder)
        {
            // Controller
            builder.RegisterEntryPoint<TitlePaneController>();

            // UseCase
            builder.Register<TitlePaneUseCase>(Lifetime.Scoped).AsImplementedInterfaces().AsSelf();

            // Repository
            builder.Register<LoginApiRepository>(Lifetime.Scoped).AsImplementedInterfaces();

            // Presenter
            builder.Register(_ => new TitlePanePresenter(_loginButton), Lifetime.Scoped).AsImplementedInterfaces();
        }
    }
}
