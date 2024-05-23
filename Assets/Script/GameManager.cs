using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private UI_Control _UI_Control;
    private bool _go = true;
    private void Awake()
    {
        Time.timeScale = 0;
    }
    void Update()
    {
        if (Timer._currentTime == 0)
        {
            WinGo();
        }
    }
    private void DamageTouch()
    {
         _UI_Control.Lose();
    }
    public void TheBalloonPopped()
    {
        _UI_Control.Lose();
    }
    private void WinGo()
    {
        if (_go)
        {
            _UI_Control.Win();
            _go = false;
        }
    }
}
