using System;
using Presentation.Presenter.Interface;
using UniRx;
using UnityEngine;

namespace IO.UI.Button
{
    public class NormalButton : MonoBehaviour, IButton
    {
        [SerializeField]
        private UnityEngine.UI.Button _button;

        public IObservable<Unit> OnClickAsObservable()
        {
            return _button.OnClickAsObservable();
        }
    }
}
