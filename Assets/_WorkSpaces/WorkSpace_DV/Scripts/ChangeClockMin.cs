using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeClockMin : MonoBehaviour
{
    public Transform MinuteHand;
    public void MinuteChange(float minute)
    {
        float currentRotation = - MinuteHand.eulerAngles.z / 6;
        print(currentRotation);
        float minuteAngle = -360 * ((minute + currentRotation) / 60);

        MinuteHand.rotation = Quaternion.Euler(0, 0, minuteAngle);
    }
}