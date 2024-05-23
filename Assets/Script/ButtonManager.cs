using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] private Button[] _button;
    [SerializeField] private GameObject[] _panels;
    private bool _start = true;
    private bool _next = true;
    private bool _retryNext = true;
    private bool _retry = true;
    private void Start()
    {
        _button[0].onClick.AddListener(StartGame);
        _button[1].onClick.AddListener(Next);
        _button[2].onClick.AddListener(Retry);
        _button[3].onClick.AddListener(RetryNext);
        _button[4].onClick.AddListener(BuyPanel);
        _button[5].onClick.AddListener(BuyPanelClose);
    }
    private void BuyPanel()
    {
        _panels[2].SetActive(true);
    }
    private void BuyPanelClose()
    {
        _panels[2].SetActive(false);
    }
    private void Next()
    {
        if (_next)
        {
            PlayerPrefs.SetInt("Level", PlayerPrefs.GetInt("Level") + 1);
            PlayerPrefs.SetInt("LevelNumber", PlayerPrefs.GetInt("LevelNumber") + 1);
            SceneManager.LoadScene(PlayerPrefs.GetInt("Level"));
            _next = false;
        }
    }
    private void RetryNext()
    {
        if (_retryNext)
        {
            PlayerPrefs.SetInt("Level", 1);
            PlayerPrefs.SetInt("LevelNumber", PlayerPrefs.GetInt("LevelNumber") + 1);
            SceneManager.LoadScene(PlayerPrefs.GetInt("Level"));
            _retryNext = false;
        }
    }
    private void Retry()
    {
        if (_retry)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            _retry = false;
        }
    }
    private void StartGame()
    {
        if (_start)
        {
            _panels[0].SetActive(false);
            _panels[1].SetActive(true);
            Time.timeScale = 1;
            _start = false;
        }

        
    }
}
