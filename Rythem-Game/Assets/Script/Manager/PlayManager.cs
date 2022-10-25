using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayManager : MonoBehaviour
{
    public GameObject[] Key;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            TimingManager.instance.CheckTiming();
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            TimingManager.instance.CheckTiming();
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            TimingManager.instance.CheckTiming();
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            TimingManager.instance.CheckTiming();
        }
    }
}
