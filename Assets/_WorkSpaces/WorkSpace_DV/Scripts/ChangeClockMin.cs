using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeClockMin : MonoBehaviour
{
    public Transform MinuteHand;
    public int roundedMinute;

    public void MinuteChange(float minute)
    {
        float currentRotation = - MinuteHand.eulerAngles.z / 6;
        float minuteAngle = -360 * ((minute + currentRotation) / 60);

        MinuteHand.rotation = Quaternion.Euler(0, 0, minuteAngle);

        currentRotation = -MinuteHand.eulerAngles.z / 6;
        roundedMinute = (int)Math.Round(currentRotation) + 60;
        print(roundedMinute);
        PlayerPrefs.SetInt("ClockMin", roundedMinute);

        SoundManagerScript.PlaySound("ClockT");
    }
}