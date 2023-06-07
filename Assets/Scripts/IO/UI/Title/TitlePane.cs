using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Presentation.Presenter.Pane;
using VContainer;
using TMPro;

public class TitlePane : MonoBehaviour
{
    [SerializeField]
    private Button _button;
    [SerializeField]
    private GameObject _loading;
    [SerializeField]
    private TextMeshProUGUI _playerName;

    private TitlePanePresenter _presenter;

    [Inject]
    public void Construct(TitlePanePresenter presenter)
    {
        _presenter = presenter;

        if(_button != null && _loading != null)
        {
            _button.onClick.AddListener(OnClickAsync);
        }
    }

    private async void OnClickAsync()
    {
        _button.enabled = false;
        _loading.SetActive(true);

        Debug.Log("OnClick");

        var playerName = await _presenter.LoginAsync();
        _playerName.SetText(playerName);

        Debug.Log("Logged in");

        _button.enabled = true;
        _loading.SetActive(false);
    }
}
