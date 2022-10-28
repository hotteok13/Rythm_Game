using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayManager : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            TimingManager.instance.CheckTiming(1);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            TimingManager.instance.CheckTiming(2);
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            TimingManager.instance.CheckTiming(3);
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            TimingManager.instance.CheckTiming(4);
        }
    }

}

