/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongNote : MonoBehaviour
{
    void Update()
    {
        #region KeyDown
        if (Input.GetKeyDown(KeyCode.D) && gameObject.CompareTag("Note1"))
        {
            TimingManager.instance.LongCheckTiming(1, KeyManager.instance.longNote[0]);
            KeyManager.instance.longNote[0] = true;
            KeyManager.instance.key[0] = true;
        }
        if (Input.GetKeyDown(KeyCode.F) && gameObject.CompareTag("Note2"))
        {
            TimingManager.instance.LongCheckTiming(2, KeyManager.instance.longNote[1]);
            KeyManager.instance.longNote[1] = true;
            KeyManager.instance.key[1] = true;
        }
       if (Input.GetKeyDown(KeyCode.J) && gameObject.CompareTag("Note3"))
       {
           TimingManager.instance.LongCheckTiming(3, KeyManager.instance.longNote[2]);
           KeyManager.instance.longNote[2] = true;
           KeyManager.instance.key[2] = true;
       }
        if (Input.GetKeyDown(KeyCode.K) && gameObject.CompareTag("Note4"))
        {
            TimingManager.instance.LongCheckTiming(4, KeyManager.instance.longNote[3]);
            KeyManager.instance.longNote[3] = true;
            KeyManager.instance.key[3] = true;
        }
        #endregion

        #region Key
        if (Input.GetKey(KeyCode.D) && gameObject.CompareTag("Note1"))
        {
            TimingManager.instance.LongCheckTiming(1, KeyManager.instance.longNote[0]);
            NoteMaster.instance.timer[0] += Time.deltaTime * NoteMaster.instance.BPM[0] / 10;
        }
        if (Input.GetKey(KeyCode.F) && gameObject.CompareTag("Note2"))
        {
            TimingManager.instance.LongCheckTiming(2, KeyManager.instance.longNote[1]);
            NoteMaster.instance.timer[1] += Time.deltaTime * NoteMaster.instance.BPM[0] / 10;
        }
        if (Input.GetKey(KeyCode.J) && gameObject.CompareTag("Note3"))
        {
            TimingManager.instance.LongCheckTiming(3, KeyManager.instance.longNote[2]);
            NoteMaster.instance.timer[2] += Time.deltaTime * NoteMaster.instance.BPM[0] / 10;
        }
        if (Input.GetKey(KeyCode.K) && gameObject.CompareTag("Note4"))
        {
            TimingManager.instance.LongCheckTiming(4, KeyManager.instance.longNote[3]);
            NoteMaster.instance.timer[3] += Time.deltaTime * NoteMaster.instance.BPM[0] / 10;
        }
        #endregion

        #region KeyUp
        if (Input.GetKeyUp(KeyCode.D) && gameObject.CompareTag("Note1"))
        {
            KeyManager.instance.key[0] = false;
            KeyManager.instance.longNote[0] = false;
            TimingManager.instance.LongCheckTiming(1, KeyManager.instance.longNote[0]);
            NoteMaster.instance.timer[0] = 0;
        }
        if (Input.GetKeyUp(KeyCode.F) && gameObject.CompareTag("Note2"))
        {
            KeyManager.instance.key[1] = false;
            KeyManager.instance.longNote[1] = false;
            TimingManager.instance.LongCheckTiming(2, KeyManager.instance.longNote[1]);
            NoteMaster.instance.timer[1] = 0;
        }
        if (Input.GetKeyUp(KeyCode.J) && gameObject.CompareTag("Note3"))
        {
            KeyManager.instance.key[2] = false;
            KeyManager.instance.longNote[2] = false;
            TimingManager.instance.LongCheckTiming(3, KeyManager.instance.longNote[2]);
            NoteMaster.instance.timer[2] = 0;
        }
        if (Input.GetKeyUp(KeyCode.K) && gameObject.CompareTag("Note4"))
        {
            KeyManager.instance.key[3] = false;
            KeyManager.instance.longNote[3] = false;
            TimingManager.instance.LongCheckTiming(4, KeyManager.instance.longNote[3]);
            NoteMaster.instance.timer[3] = 0;
        }

        #endregion

    }
}

*/