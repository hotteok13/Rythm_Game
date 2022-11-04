using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteMaster : MonoBehaviour
{
    public float noteSpeed = 400.0f;

    public float[] BPM;

    public bool noteSpeedSetting;

    public static NoteMaster instance;
    public float [] timer;
    public int waitingTime;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        noteSpeedSetting = false;
        waitingTime = 1;
        for(int i = 0; i < 4; i++)
        {
            timer[i] = 0.0f;
        }
    }

}