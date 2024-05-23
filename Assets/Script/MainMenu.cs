using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private void Start()
    {
        if (!PlayerPrefs.HasKey("Level"))  
        {
            PlayerPrefs.SetInt("Level", 1);
            PlayerPrefs.SetInt("Color",0);
            PlayerPrefs.SetInt("Money",10000);
            PlayerPrefs.SetInt("LevelNumber",1);
            PlayerPrefs.SetInt("RedButton", 1);
            PlayerPrefs.SetInt("BlackButton", 0);
            PlayerPrefs.SetInt("PurpleButton", 0);
            PlayerPrefs.SetInt("BlueButton", 0);
            PlayerPrefs.SetInt("YellowButton", 0);
            PlayerPrefs.SetInt("GreyButton", 0);
            PlayerPrefs.SetInt("BrowmButton", 0);
            PlayerPrefs.SetInt("GreenButton", 0);
            PlayerPrefs.SetInt("OrangeButton", 0);
            PlayerPrefs.SetInt("PinkButton", 0);
            PlayerPrefs.SetInt("WhiteButton", 0);
            PlayerPrefs.SetInt("TurquoiseButton", 0);
        }
        SceneManager.LoadScene(PlayerPrefs.GetInt("Level"));
    }
}
