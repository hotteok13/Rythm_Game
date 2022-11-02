using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteMaster : MonoBehaviour
{
    public float noteSpeed = 400.0f;

    public float[] BPM;

    public bool noteSpeedSetting;

    public static NoteMaster instance;
    public float timer1;
    public float timer2;
    public float timer3;
    public float timer4;
    public int waitingTime;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        noteSpeedSetting = false;
        waitingTime = 1;
        timer1 = 0;
        timer2 = 0;
        timer3 = 0;
        timer4 = 0;
    }

}