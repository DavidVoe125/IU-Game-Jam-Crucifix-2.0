using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeClockHour : MonoBehaviour
{
    public Transform HourHand;
    public void HourChange(float hour)
    {
        float currentRotation = - HourHand.eulerAngles.z / 30;
        print(currentRotation);
        float minuteAngle = - 360 * ((hour + currentRotation) / 12);

        HourHand.rotation = Quaternion.Euler(0, 0, minuteAngle);
    }
}
