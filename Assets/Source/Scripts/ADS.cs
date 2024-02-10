using UnityEngine;
using YG;

public class ADS : MonoBehaviour
{
    [SerializeField] private AudioSource _audio;

    private void OnEnable()
    {
        YandexGame.OpenFullAdEvent += OpenCallback;
        YandexGame.CloseFullAdEvent += CloseCallback;
    }

    private void OnDisable()
    {
        YandexGame.OpenFullAdEvent -= OpenCallback;
        YandexGame.CloseFullAdEvent -= CloseCallback;
    }

    public void Show() =>
        YandexGame.FullscreenShow();

    private void OpenCallback()
    {
        Time.timeScale = 0f;
        _audio.Pause();
    }

    private void CloseCallback()
    {
        Time.timeScale = 1f;
        _audio.UnPause();
    }
}
