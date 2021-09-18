using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class analogClock : MonoBehaviour
{
    public Transform MinuteHand;
    public Transform HourHand;

    public void SolveClock()
    {
        if (MinuteHand.eulerAngles.z == 1 && HourHand.eulerAngles.z == 1)
        {
            //
        }
        else
        {
            MinuteHand.rotation = Quaternion.Euler(Vector3.zero);
            HourHand.rotation = Quaternion.Euler(Vector3.zero);
        }
    }
}
