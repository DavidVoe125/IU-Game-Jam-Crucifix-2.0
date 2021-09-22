using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SolveClock : MonoBehaviour
{
    void Start()
    {
        PlayerPrefs.SetInt("ClockHour", 12);
        PlayerPrefs.SetInt("ClockMin", 60);
    }

    public void checkClock()
    {
        if (PlayerPrefs.GetInt("ClockHour") == 12 && PlayerPrefs.GetInt("ClockMin") == 10)
        {
            PlayerPrefs.SetInt("StanduhrRätsel", 1);
            PlayerPrefs.SetInt("kuckuckCheck", 1);
            PlayerPrefs.SetFloat("kuckuckXPos", -3.24f);
            PlayerPrefs.SetFloat("kuckuckYPos", 2.32f);
            PlayerPrefs.SetInt("ClockR", 1);

            SceneManager.LoadScene("Eingangshalle1");
        }
        else
        {
            SoundManagerScript.PlaySound("ClockF");
        }
    }
}
