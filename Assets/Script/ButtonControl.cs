using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ButtonControl : MonoBehaviour
{
    [SerializeField] private GameObject[] RedButtons;
    [SerializeField] private GameObject[] BlackButtons;
    [SerializeField] private GameObject[] PurpleButtons;
    [SerializeField] private GameObject[] BlueButtons;
    [SerializeField] private GameObject[] YellowButtons;
    [SerializeField] private GameObject[] GreyButtons;
    [SerializeField] private GameObject[] BrowmButtons;
    [SerializeField] private GameObject[] GreenButtons;
    [SerializeField] private GameObject[] OrangeButtons;
    [SerializeField] private GameObject[] PinkButtons;
    [SerializeField] private GameObject[] WhiteButtons;
    [SerializeField] private GameObject[] TurquoiseButtons;
    private void Start()
    {
        Beging();
    }
    public void Beging()
    {
        if (PlayerPrefs.GetInt("RedButton") == 1)
        {
            if (PlayerPrefs.GetInt("Color") == 0)
            {
                RedButtons[0].SetActive(false);
                RedButtons[1].SetActive(true);
                RedButtons[2].SetActive(false);
            }
            else
            {
                RedButtons[0].SetActive(false);
                RedButtons[1].SetActive(false);
                RedButtons[2].SetActive(true);
            }
        }
        else
        {
            RedButtons[0].SetActive(true);
            RedButtons[1].SetActive(false);
            RedButtons[2].SetActive(false);
        }
        if (PlayerPrefs.GetInt("BlackButton") == 1)
        {
            if (PlayerPrefs.GetInt("Color") == 1)
            {
                BlackButtons[0].SetActive(false);
                BlackButtons[1].SetActive(true);
                BlackButtons[2].SetActive(false);
            }
            else
            {
                BlackButtons[0].SetActive(false);
                BlackButtons[1].SetActive(false);
                BlackButtons[2].SetActive(true);
            }
        }
        else
        {
            BlackButtons[0].SetActive(true);
            BlackButtons[1].SetActive(false);
            BlackButtons[2].SetActive(false);
        }
        if (PlayerPrefs.GetInt("PurpleButton") == 1)
        {
            if (PlayerPrefs.GetInt("Color") == 2)
            {
                PurpleButtons[0].SetActive(false);
                PurpleButtons[1].SetActive(true);
                PurpleButtons[2].SetActive(false);
            }
            else
            {
                PurpleButtons[0].SetActive(false);
                PurpleButtons[1].SetActive(false);
                PurpleButtons[2].SetActive(true);
            }
        }
        else
        {
            PurpleButtons[0].SetActive(true);
            PurpleButtons[1].SetActive(false);
            PurpleButtons[2].SetActive(false);
        }
        if (PlayerPrefs.GetInt("BlueButton") == 1)
        {
            if (PlayerPrefs.GetInt("Color") == 3)
            {
                BlueButtons[0].SetActive(false);
                BlueButtons[1].SetActive(true);
                BlueButtons[2].SetActive(false);
            }
            else
            {
                BlueButtons[0].SetActive(false);
                BlueButtons[1].SetActive(false);
                BlueButtons[2].SetActive(true);
            }
        }
        else
        {
            BlueButtons[0].SetActive(true);
            BlueButtons[1].SetActive(false);
            BlueButtons[2].SetActive(false);
        }
        if (PlayerPrefs.GetInt("YellowButton") == 1)
        {
            if (PlayerPrefs.GetInt("Color") == 4)
            {
                YellowButtons[0].SetActive(false);
                YellowButtons[1].SetActive(true);
                YellowButtons[2].SetActive(false);
            }
            else
            {
                YellowButtons[0].SetActive(false);
                YellowButtons[1].SetActive(false);
                YellowButtons[2].SetActive(true);
            }
        }
        else
        {
            YellowButtons[0].SetActive(true);
            YellowButtons[1].SetActive(false);
            YellowButtons[2].SetActive(false);
        }
        if (PlayerPrefs.GetInt("GreyButton") == 1)
        {
            if (PlayerPrefs.GetInt("Color") == 5)
            {
                GreyButtons[0].SetActive(false);
                GreyButtons[1].SetActive(true);
                GreyButtons[2].SetActive(false);
            }
            else
            {
                GreyButtons[0].SetActive(false);
                GreyButtons[1].SetActive(false);
                GreyButtons[2].SetActive(true);
            }
        }
        else
        {
            GreyButtons[0].SetActive(true);
            GreyButtons[1].SetActive(false);
            GreyButtons[2].SetActive(false);
        }
        if (PlayerPrefs.GetInt("BrowmButton") == 1)
        {
            if (PlayerPrefs.GetInt("Color") == 6)
            {
                BrowmButtons[0].SetActive(false);
                BrowmButtons[1].SetActive(true);
                BrowmButtons[2].SetActive(false);
            }
            else
            {
                BrowmButtons[0].SetActive(false);
                BrowmButtons[1].SetActive(false);
                BrowmButtons[2].SetActive(true);
            }
        }
        else
        {
            BrowmButtons[0].SetActive(true);
            BrowmButtons[1].SetActive(false);
            BrowmButtons[2].SetActive(false);
        }
        if (PlayerPrefs.GetInt("GreenButton") == 1)
        {
            if (PlayerPrefs.GetInt("Color") == 7)
            {
                GreenButtons[0].SetActive(false);
                GreenButtons[1].SetActive(true);
                GreenButtons[2].SetActive(false);
            }
            else
            {
                GreenButtons[0].SetActive(false);
                GreenButtons[1].SetActive(false);
                GreenButtons[2].SetActive(true);
            }
        }
        else
        {
            GreenButtons[0].SetActive(true);
            GreenButtons[1].SetActive(false);
            GreenButtons[2].SetActive(false);
        }
        if (PlayerPrefs.GetInt("OrangeButton") == 1)
        {
            if (PlayerPrefs.GetInt("Color") == 8)
            {
                OrangeButtons[0].SetActive(false);
                OrangeButtons[1].SetActive(true);
                OrangeButtons[2].SetActive(false);
            }
            else
            {
                OrangeButtons[0].SetActive(false);
                OrangeButtons[1].SetActive(false);
                OrangeButtons[2].SetActive(true);
            }
        }
        else
        {
            OrangeButtons[0].SetActive(true);
            OrangeButtons[1].SetActive(false);
            OrangeButtons[2].SetActive(false);
        }
        if (PlayerPrefs.GetInt("PinkButton") == 1)
        {
            if (PlayerPrefs.GetInt("Color") == 9)
            {
                PinkButtons[0].SetActive(false);
                PinkButtons[1].SetActive(true);
                PinkButtons[2].SetActive(false);
            }
            else
            {
                PinkButtons[0].SetActive(false);
                PinkButtons[1].SetActive(false);
                PinkButtons[2].SetActive(true);
            }
        }
        else
        {
            PinkButtons[0].SetActive(true);
            PinkButtons[1].SetActive(false);
            PinkButtons[2].SetActive(false);
        }
        if (PlayerPrefs.GetInt("WhiteButton") == 1)
        {
            if (PlayerPrefs.GetInt("Color") == 10)
            {
                WhiteButtons[0].SetActive(false);
                WhiteButtons[1].SetActive(true);
                WhiteButtons[2].SetActive(false);
            }
            else
            {
                WhiteButtons[0].SetActive(false);
                WhiteButtons[1].SetActive(false);
                WhiteButtons[2].SetActive(true);
            }
        }
        else
        {
            WhiteButtons[0].SetActive(true);
            WhiteButtons[1].SetActive(false);
            WhiteButtons[2].SetActive(false);
        }
        if (PlayerPrefs.GetInt("TurquoiseButton") == 1)
        {
            if (PlayerPrefs.GetInt("Color") == 11)
            {
                TurquoiseButtons[0].SetActive(false);
                TurquoiseButtons[1].SetActive(true);
                TurquoiseButtons[2].SetActive(false);
            }
            else
            {
                TurquoiseButtons[0].SetActive(false);
                TurquoiseButtons[1].SetActive(false);
                TurquoiseButtons[2].SetActive(true);
            }
        }
        else
        {
            TurquoiseButtons[0].SetActive(true);
            TurquoiseButtons[1].SetActive(false);
            TurquoiseButtons[2].SetActive(false);
        }

    }

}
