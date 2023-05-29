using System;
using Domain.UseCase.Interface;
using UniRx;
using VContainer;
using Presentation.Presenter.Interface;
using UnityEngine.SceneManagement;

namespace Presentation.Presenter.Pane
{
    public class TitlePanePresenter : ITitlePanePresenter, IDisposable
    {
        private readonly IButton _toOutGameSceneButton;
        private readonly CompositeDisposable _selfDisposables;

        [Inject]
        public TitlePanePresenter(IButton toOutGameSceneButton)
        {
            _toOutGameSceneButton = toOutGameSceneButton;
            _selfDisposables = new CompositeDisposable();
        }

        public void Initialize()
        {
            _toOutGameSceneButton.OnClickAsObservable().Subscribe(_ =>
            {
                SceneManager.LoadScene("OutGameScene");
            })
            .AddTo(_selfDisposables);
        }

        public void Dispose()
        {
            _selfDisposables.Clear();
        }
    }
}
