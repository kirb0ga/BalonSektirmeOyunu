using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_Control : MonoBehaviour
{
    [SerializeField] private GameObject WinPanel;
    [SerializeField] private GameObject LosePanel;
    [SerializeField] private TextMeshProUGUI[] _levelText;
    [SerializeField] private TextMeshProUGUI[] _MoneyText;
    private int _Money;
    [SerializeField] private int _multiplier;
    private void Start()
    {
        _levelText[0].text = PlayerPrefs.GetInt("LevelNumber").ToString();
        MoneyText();
    }
    public void Win()
    {
        WinPanel.SetActive(true);
        _Money = Timer._moneytTime;
        _Money = _multiplier * _Money;
        PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") + _Money);
        _levelText[1].text = PlayerPrefs.GetInt("LevelNumber").ToString();
        _levelText[2].text = PlayerPrefs.GetInt("LevelNumber").ToString();
        MoneyText();
        Time.timeScale = 0;
    }
    public void Lose()
    {
        LosePanel.SetActive(true);
        _levelText[3].text = PlayerPrefs.GetInt("LevelNumber").ToString();

        Time.timeScale = 0;
    }
    public void MoneyText()
    {
        _MoneyText[0].text = PlayerPrefs.GetInt("Money").ToString();
        _MoneyText[1].text = PlayerPrefs.GetInt("Money").ToString();
        _MoneyText[2].text = PlayerPrefs.GetInt("Money").ToString();
    }

}
