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
            TimingManager.instance.LongCheckTiming(1, KeyManager.instance.long1);
            KeyManager.instance.long1 = true;
            KeyManager.instance.key1 = true;
        }
        if (Input.GetKeyDown(KeyCode.F) && gameObject.CompareTag("Note2"))
        {
            TimingManager.instance.LongCheckTiming(2, KeyManager.instance.long2);
            KeyManager.instance.long2 = true;
            KeyManager.instance.key2 = true;
        }
        if (Input.GetKeyDown(KeyCode.J) && gameObject.CompareTag("Note3"))
        {
            TimingManager.instance.LongCheckTiming(3, KeyManager.instance.long3);
            KeyManager.instance.long3 = true;
            KeyManager.instance.key3 = true;
        }
        if (Input.GetKeyDown(KeyCode.K) && gameObject.CompareTag("Note4"))
        {
            TimingManager.instance.LongCheckTiming(4, KeyManager.instance.long4);
            KeyManager.instance.long4 = true;
            KeyManager.instance.key4 = true;
        }
        #endregion

        #region Key
        if (Input.GetKey(KeyCode.D) && gameObject.CompareTag("Note1"))
        {
            TimingManager.instance.LongCheckTiming(1, KeyManager.instance.long1);
            NoteMaster.instance.timer1 += Time.deltaTime * NoteMaster.instance.BPM[0] / 10;
        }
        if (Input.GetKey(KeyCode.F) && gameObject.CompareTag("Note2"))
        {
            TimingManager.instance.LongCheckTiming(2, KeyManager.instance.long2);
            NoteMaster.instance.timer2 += Time.deltaTime * NoteMaster.instance.BPM[0] / 10;
        }
        if (Input.GetKey(KeyCode.J) && gameObject.CompareTag("Note3"))
        {
            TimingManager.instance.LongCheckTiming(3, KeyManager.instance.long3);
            NoteMaster.instance.timer3 += Time.deltaTime * NoteMaster.instance.BPM[0] / 10;
        }
        if (Input.GetKey(KeyCode.K) && gameObject.CompareTag("Note4"))
        {
            TimingManager.instance.LongCheckTiming(4, KeyManager.instance.long4);
            NoteMaster.instance.timer4 += Time.deltaTime * NoteMaster.instance.BPM[0] / 10;
        }
        #endregion

        #region KeyUp
        if (Input.GetKeyUp(KeyCode.D) && gameObject.CompareTag("Note1"))
        {
            KeyManager.instance.key1 = false;
            KeyManager.instance.long1 = false;
            TimingManager.instance.LongCheckTiming(1, KeyManager.instance.long1);
            NoteMaster.instance.timer1 = 0;
        }
        if (Input.GetKeyUp(KeyCode.F) && gameObject.CompareTag("Note2"))
        {
            KeyManager.instance.key2 = false;
            KeyManager.instance.long2 = false;
            TimingManager.instance.LongCheckTiming(2, KeyManager.instance.long2);
            NoteMaster.instance.timer2 = 0;
        }
        if (Input.GetKeyUp(KeyCode.J) && gameObject.CompareTag("Note3"))
        {
            KeyManager.instance.key3 = false;
            KeyManager.instance.long3 = false;
            TimingManager.instance.LongCheckTiming(3, KeyManager.instance.long3);
            NoteMaster.instance.timer3 = 0;
        }
        if (Input.GetKeyUp(KeyCode.K) && gameObject.CompareTag("Note4"))
        {
            KeyManager.instance.key4 = false;
            KeyManager.instance.long4 = false;
            TimingManager.instance.LongCheckTiming(4, KeyManager.instance.long4);
            NoteMaster.instance.timer4 = 0;
        }

        #endregion

    }
}
