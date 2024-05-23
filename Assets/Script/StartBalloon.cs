using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartBalloon : MonoBehaviour
{
    [SerializeField] private GameObject[] Balloon;
    private int _activeIndex;
    private void Awake()
    {
        OpenObject();
    }
    public void Starting()
    {
        foreach (GameObject item in Balloon)
        {
            item.SetActive(false);
        }
        Balloon[PlayerPrefs.GetInt("Color")].SetActive(true);
    }
    public void OpenObject()
    {
        if (PlayerPrefs.GetInt("Color") >= 0 && PlayerPrefs.GetInt("Color") < Balloon.Length)
        {
            for (int i = 0; i < Balloon.Length; i++)
            {
                if (i == PlayerPrefs.GetInt("Color"))
                {
                    Balloon[i].SetActive(true); // Seçili objeyi aç
                }
                else
                {
                    Balloon[i].SetActive(false); // Diğerlerini kapat
                }
            }
        }
        else
        {
            Debug.LogError("Geçersiz indeks!"); // Hatalı indeks durumu
        }
    }
}
