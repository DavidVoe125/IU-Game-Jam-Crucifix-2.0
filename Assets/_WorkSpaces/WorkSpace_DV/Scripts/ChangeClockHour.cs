using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeClockHour : MonoBehaviour
{
    public Transform HourHand;
    public int roundedhour;

    public void HourChange(float hour)
    {
        float currentRotation = - HourHand.eulerAngles.z / 30;
        float minuteAngle = - 360 * ((hour + currentRotation) / 12);

        HourHand.rotation = Quaternion.Euler(0, 0, minuteAngle);

        currentRotation = -HourHand.eulerAngles.z / 30;
        roundedhour = (int)Math.Round(currentRotation) + 12;
        print(roundedhour);
        PlayerPrefs.SetInt("ClockHour", roundedhour);

        SoundManagerScript.PlaySound("ClockT");
    }
}
