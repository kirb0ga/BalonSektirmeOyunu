using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] private Image _timerImage;
    [SerializeField] private TextMeshProUGUI _timerText;
    public static int _currentTime;
    public static int _moneytTime;
    [SerializeField] private int _duration;

    void Start()
    {
        _moneytTime = _duration;
        _currentTime = _duration;
        _timerText.text = _currentTime.ToString();
        StartCoroutine(UpdateTime());
    }
    private IEnumerator UpdateTime()
    {
        while (_currentTime >= 0)
        {
            _timerImage.fillAmount = Mathf.InverseLerp(0, _duration, _currentTime);
            _timerText.text = _currentTime.ToString();
            yield return new WaitForSeconds(1f);
            _currentTime--;
        }
        yield return null;
    }
}
