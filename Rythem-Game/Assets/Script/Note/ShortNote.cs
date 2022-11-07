/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShortNote : MonoBehaviour
{
    void Update()
    {
        #region KeyDown
        if (Input.GetKeyDown(KeyCode.D) && gameObject.CompareTag("Note1"))
        {
            TimingManager.instance.CheckTiming(1, KeyManager.instance.key[0]);
            KeyManager.instance.key[0] = true;
        }
        if (Input.GetKeyDown(KeyCode.F) && gameObject.CompareTag("Note2"))
        {
            TimingManager.instance.CheckTiming(2, KeyManager.instance.key[1]);
            KeyManager.instance.key[1] = true;
        }
        if (Input.GetKeyDown(KeyCode.J) && gameObject.CompareTag("Note3"))
        {
            TimingManager.instance.CheckTiming(3, KeyManager.instance.key[2]);
            KeyManager.instance.key[2] = true;
        }
        if (Input.GetKeyDown(KeyCode.K) && gameObject.CompareTag("Note4"))
        {
            TimingManager.instance.CheckTiming(4, KeyManager.instance.key[3]);
            KeyManager.instance.key[3] = true;
        }
        #endregion
        #region KeyUp
        if (Input.GetKeyUp(KeyCode.D) && gameObject.CompareTag("Note1"))
        {
            KeyManager.instance.key[0] = false;
        }
        if (Input.GetKeyUp(KeyCode.F) && gameObject.CompareTag("Note2"))
        {
            KeyManager.instance.key[1] = false;
        }
        if (Input.GetKeyUp(KeyCode.J) && gameObject.CompareTag("Note3"))
        {
            KeyManager.instance.key[2] = false;
        }
        if (Input.GetKeyUp(KeyCode.K) && gameObject.CompareTag("Note4"))
        {
            KeyManager.instance.key[3] = false;
        }
        #endregion

    }
}
*/