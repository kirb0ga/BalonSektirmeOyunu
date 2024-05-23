using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyManager : MonoBehaviour
{
    [SerializeField] private bool Player2;
    public GameObject Panel;
    private bool _onClick = true;
    [SerializeField] private Button[] ColorButton;
    [SerializeField] private Button[] UseButton;
    [SerializeField] private ButtonControl _ButtonControl;
    [SerializeField] private StartBalloon[] _StartBalloon;
    [SerializeField] private UI_Control UI;
    private void Start()
    {
        BuyButtoon();
        UseButtons();
    }
    private void Update()
    {
        bool isActive = Panel.activeSelf;
        if (isActive)
        {
            if (Input.touchCount == 0)
            {
                _onClick = true;
            }
            
        }
    }
    private void Starting()
    {
        _StartBalloon[0].OpenObject();
        if (Player2)
        {
            _StartBalloon[1].OpenObject();

        }
    }
    private void BuyButtoon()
    {
        ColorButton[0].onClick.AddListener(RedColorBalloon);
        ColorButton[1].onClick.AddListener(BlackColorBalloon);
        ColorButton[2].onClick.AddListener(PurpleColorBalloon);
        ColorButton[3].onClick.AddListener(BlueColorBalloon);
        ColorButton[4].onClick.AddListener(YellowColorBalloon);
        ColorButton[5].onClick.AddListener(GreyColorBalloon);
        ColorButton[6].onClick.AddListener(BrowmColorBalloon);
        ColorButton[7].onClick.AddListener(GreenColorBalloon);
        ColorButton[8].onClick.AddListener(OrangeColorBalloon);
        ColorButton[9].onClick.AddListener(PinkColorBalloon);
        ColorButton[10].onClick.AddListener(WhiteColorBalloon);
        ColorButton[11].onClick.AddListener(TurquoiseColorBalloon);
    }
    #region Color
    private void RedColorBalloon()
    {
        if (_onClick)
        {
            _onClick = false;
        }
    }
    private void BlackColorBalloon()
    {
        if (_onClick)
        {
            _onClick = false;
            if (PlayerPrefs.GetInt("BlackButton") == 0)
            {
                if (PlayerPrefs.GetInt("Money") >= 100)
                {
                    PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 100);
                    PlayerPrefs.SetInt("Color", 1);
                    PlayerPrefs.SetInt("BlackButton", PlayerPrefs.GetInt("BlackButton") + 1);
                    UI.MoneyText();
                    _ButtonControl.Beging();
                    Starting();
                }
            }
        }
    }
    private void PurpleColorBalloon()
    {
        if (_onClick)
        {
            _onClick = false;
            if (PlayerPrefs.GetInt("PurpleButton") == 0)
            {
                if (PlayerPrefs.GetInt("Money") >= 100)
                {
                    PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 100);
                    PlayerPrefs.SetInt("Color", 2);
                    PlayerPrefs.SetInt("PurpleButton", PlayerPrefs.GetInt("PurpleButton") + 1);
                    UI.MoneyText();
                    _ButtonControl.Beging();
                    Starting();
                }
            }
        }
    }
    private void BlueColorBalloon()
    {
        if (_onClick)
        {
            _onClick = false;
            if (PlayerPrefs.GetInt("BlueButton") == 0)
            {
                if (PlayerPrefs.GetInt("Money") >= 100)
                {
                    PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 100);
                    PlayerPrefs.SetInt("Color", 3);
                    PlayerPrefs.SetInt("BlueButton", PlayerPrefs.GetInt("BlueButton") + 1);
                    UI.MoneyText();
                    _ButtonControl.Beging();
                    Starting();
                }
            }
        }
    }
    private void YellowColorBalloon()
    {
        if (_onClick)
        {
            _onClick = false;
            if (PlayerPrefs.GetInt("YellowButton") == 0)
            {
                if (PlayerPrefs.GetInt("Money") >= 100)
                {
                    PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 100);
                    PlayerPrefs.SetInt("Color", 4);
                    PlayerPrefs.SetInt("YellowButton", PlayerPrefs.GetInt("YellowButton") + 1);
                    UI.MoneyText();
                    _ButtonControl.Beging();
                    Starting();
                }
            }
        }
    }
    private void GreyColorBalloon()
    {
        if (_onClick)
        {
            _onClick = false;
            if (PlayerPrefs.GetInt("GreyButton") == 0)
            {
                if (PlayerPrefs.GetInt("Money") >= 100)
                {
                    PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 100);
                    PlayerPrefs.SetInt("Color", 5);
                    PlayerPrefs.SetInt("GreyButton", PlayerPrefs.GetInt("GreyButton") + 1);
                    UI.MoneyText();
                    _ButtonControl.Beging();
                    Starting();
                }
            }
        }
    }
    private void BrowmColorBalloon()
    {
        if (_onClick)
        {
            _onClick = false;
            if (PlayerPrefs.GetInt("BrowmButton") == 0)
            {
                if (PlayerPrefs.GetInt("Money") >= 100)
                {
                    PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 100);
                    PlayerPrefs.SetInt("Color", 6);
                    PlayerPrefs.SetInt("BrowmButton", PlayerPrefs.GetInt("BrowmButton") + 1);
                    UI.MoneyText();
                    _ButtonControl.Beging();
                    Starting();
                }
            }
        }
    }
    private void GreenColorBalloon()
    {
        if (_onClick)
        {
            _onClick = false;
            if (PlayerPrefs.GetInt("GreenButton") == 0)
            {
                if (PlayerPrefs.GetInt("Money") >= 100)
                {
                    PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 100);
                    PlayerPrefs.SetInt("Color", 7);
                    PlayerPrefs.SetInt("GreenButton", PlayerPrefs.GetInt("GreenButton") + 1);
                    UI.MoneyText();
                    _ButtonControl.Beging();
                    Starting();
                }
            }
        }
    }
    private void OrangeColorBalloon()
    {
        if (_onClick)
        {
            _onClick = false;
            if (PlayerPrefs.GetInt("OrangeButton") == 0)
            {
                if (PlayerPrefs.GetInt("Money") >= 100)
                {
                    PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 100);
                    PlayerPrefs.SetInt("Color", 8);
                    PlayerPrefs.SetInt("OrangeButton", PlayerPrefs.GetInt("OrangeButton") + 1);
                    UI.MoneyText();
                    _ButtonControl.Beging();
                    Starting();
                }
            }
        }
    }
    private void PinkColorBalloon()
    {
        if (_onClick)
        {
            _onClick = false;
            if (PlayerPrefs.GetInt("PinkButton") == 0)
            {
                if (PlayerPrefs.GetInt("Money") >= 100)
                {
                    PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 100);
                    PlayerPrefs.SetInt("Color", 9);
                    PlayerPrefs.SetInt("PinkButton", PlayerPrefs.GetInt("PinkButton") + 1);
                    UI.MoneyText();
                    _ButtonControl.Beging();
                    Starting();
                }
            }
        }
    }
    private void WhiteColorBalloon()
    {
        if (_onClick)
        {
            _onClick = false;
            if (PlayerPrefs.GetInt("WhiteButton") == 0)
            {
                if (PlayerPrefs.GetInt("Money") >= 100)
                {
                    PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 100);
                    PlayerPrefs.SetInt("Color", 10);
                    PlayerPrefs.SetInt("WhiteButton", PlayerPrefs.GetInt("WhiteButton") + 1);
                    UI.MoneyText();
                    _ButtonControl.Beging();
                    Starting();
                }
            }
        }
    }
    private void TurquoiseColorBalloon()
    {
        if (_onClick)
        {
            _onClick = false;
            if (PlayerPrefs.GetInt("TurquoiseButton") == 0)
            {
                if (PlayerPrefs.GetInt("Money") >= 100)
                {
                    PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - 100);
                    PlayerPrefs.SetInt("Color", 11);
                    PlayerPrefs.SetInt("TurquoiseButton", PlayerPrefs.GetInt("TurquoiseButton") + 1);
                    UI.MoneyText();
                    _ButtonControl.Beging();
                    Starting();
                }
            }
        }
    }
    #endregion
    private void UseButtons()
    {
        UseButton[0].onClick.AddListener(RedUseBalloon);
        UseButton[1].onClick.AddListener(BlackUseBalloon);
        UseButton[2].onClick.AddListener(PurpleUseBalloon);
        UseButton[3].onClick.AddListener(BlueUseBalloon);
        UseButton[4].onClick.AddListener(YellowUseBalloon);
        UseButton[5].onClick.AddListener(GreyUseBalloon);
        UseButton[6].onClick.AddListener(BrowmUseBalloon);
        UseButton[7].onClick.AddListener(GreenUseBalloon);
        UseButton[8].onClick.AddListener(OrangeUseBalloon);
        UseButton[9].onClick.AddListener(PinkUseBalloon);
        UseButton[10].onClick.AddListener(WhiteUseBalloon);
        UseButton[11].onClick.AddListener(TurquoiseUseBalloon);
    }
    #region Use
    private void RedUseBalloon()
    {
        if (_onClick)
        {
            _onClick = false; 
            if (PlayerPrefs.GetInt("RedButton") != 0)
            {
                PlayerPrefs.SetInt("Color", 0);
                _ButtonControl.Beging();
                Starting();
            }
        }
    }
    private void BlackUseBalloon()
    {
        if (_onClick)
        {
            _onClick = false;
            if (PlayerPrefs.GetInt("BlackButton") != 0)
            {
                PlayerPrefs.SetInt("Color", 1);
                _ButtonControl.Beging();
                Starting();
            }
        }
    }
    private void PurpleUseBalloon()
    {
        if (_onClick)
        {
            _onClick = false;
            if (PlayerPrefs.GetInt("PurpleButton") != 0)
            {
                PlayerPrefs.SetInt("Color", 2);
                _ButtonControl.Beging();
                Starting();
            }
        }
    }
    private void BlueUseBalloon()
    {
        if (_onClick)
        {
            _onClick = false;
            if (PlayerPrefs.GetInt("BlueButton") != 0)
            {
                PlayerPrefs.SetInt("Color", 3);
                _ButtonControl.Beging();
                Starting();
            }
        }
    }
    private void YellowUseBalloon()
    {
        if (_onClick)
        {
            _onClick = false;
            if (PlayerPrefs.GetInt("YellowButton") != 0)
            {
                PlayerPrefs.SetInt("Color", 4);
                _ButtonControl.Beging();
                Starting();
            }
        }
    }
    private void GreyUseBalloon()
    {
        if (_onClick)
        {
            _onClick = false;
            if (PlayerPrefs.GetInt("GreyButton") != 0)
            {
                PlayerPrefs.SetInt("Color", 5);
                _ButtonControl.Beging();
                Starting();
            }
        }
    }
    private void BrowmUseBalloon()
    {
        if (_onClick)
        {
            _onClick = false;
            if (PlayerPrefs.GetInt("BrowmButton") != 0)
            {
                PlayerPrefs.SetInt("Color", 6);
                _ButtonControl.Beging();
                Starting();
            }
        }
    }
    private void GreenUseBalloon()
    {
        if (_onClick)
        {
            _onClick = false;
            if (PlayerPrefs.GetInt("GreenButton") != 0)
            {
                PlayerPrefs.SetInt("Color", 7);
                _ButtonControl.Beging();
                Starting();
            }
        }
    }
    private void OrangeUseBalloon()
    {
        if (_onClick)
        {
            _onClick = false;
            if (PlayerPrefs.GetInt("OrangeButton") != 0)
            {
                PlayerPrefs.SetInt("Color", 8);
                _ButtonControl.Beging();
                Starting();
            }
        }
    }
    private void PinkUseBalloon()
    {
        if (_onClick)
        {
            _onClick = false;
            if (PlayerPrefs.GetInt("PinkButton") != 0)
            {
                PlayerPrefs.SetInt("Color", 9);
                _ButtonControl.Beging();
                Starting();
            }
        }
    }
    private void WhiteUseBalloon()
    {
        if (_onClick)
        {
            _onClick = false;
            if (PlayerPrefs.GetInt("WhiteButton") != 0)
            {
                PlayerPrefs.SetInt("Color", 10);
                _ButtonControl.Beging();
                Starting();
            }
        }
    }
    private void TurquoiseUseBalloon()
    {
        if (_onClick)
        {
            _onClick = false;
            if (PlayerPrefs.GetInt("TurquoiseButton") != 0)
            {
                PlayerPrefs.SetInt("Color", 11);
                _ButtonControl.Beging();
                Starting();
            }

        }
    }
    #endregion
}
