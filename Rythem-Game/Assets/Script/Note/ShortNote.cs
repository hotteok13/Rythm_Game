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
            TimingManager.instance.CheckTiming(1, KeyManager.instance.key1);
            KeyManager.instance.key1 = true;
        }
        if (Input.GetKeyDown(KeyCode.F) && gameObject.CompareTag("Note2"))
        {
            TimingManager.instance.CheckTiming(2, KeyManager.instance.key2);
            KeyManager.instance.key2 = true;
        }
        if (Input.GetKeyDown(KeyCode.J) && gameObject.CompareTag("Note3"))
        {
            TimingManager.instance.CheckTiming(3, KeyManager.instance.key3);
            KeyManager.instance.key3 = true;
        }
        if (Input.GetKeyDown(KeyCode.K) && gameObject.CompareTag("Note4"))
        {
            TimingManager.instance.CheckTiming(4, KeyManager.instance.key4);
            KeyManager.instance.key4 = true;
        }
        #endregion
        #region KeyUp
        if (Input.GetKeyUp(KeyCode.D) && gameObject.CompareTag("Note1"))
        {
            KeyManager.instance.key1 = false;
        }
        if (Input.GetKeyUp(KeyCode.F) && gameObject.CompareTag("Note2"))
        {
            KeyManager.instance.key2 = false;
        }
        if (Input.GetKeyUp(KeyCode.J) && gameObject.CompareTag("Note3"))
        {
            KeyManager.instance.key3 = false;
        }
        if (Input.GetKeyUp(KeyCode.K) && gameObject.CompareTag("Note4"))
        {
            KeyManager.instance.key4 = false;
        }
        #endregion

    }
}
