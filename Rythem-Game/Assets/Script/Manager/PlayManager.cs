using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayManager : MonoBehaviour
{
    private void Update()
    {
        if (gameObject.layer==LayerMask.NameToLayer("Note"))
        {
            #region KeyDown
            if (Input.GetKeyDown(KeyCode.D))
            {
                TimingManager.instance.CheckTiming(1, KeyManager.instance.key1);
                KeyManager.instance.key1 = true;
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                TimingManager.instance.CheckTiming(2, KeyManager.instance.key2);
                KeyManager.instance.key2 = true;
            }
            if (Input.GetKeyDown(KeyCode.J))
            {
                TimingManager.instance.CheckTiming(3, KeyManager.instance.key3);
                KeyManager.instance.key3 = true;
            }
            if (Input.GetKeyDown(KeyCode.K))
            {
                TimingManager.instance.CheckTiming(4, KeyManager.instance.key4);
                KeyManager.instance.key4 = true;
            }
            #endregion
            #region KeyUp
            if (Input.GetKeyUp(KeyCode.D))
            {
                KeyManager.instance.key1 = false;
            }
            if (Input.GetKeyUp(KeyCode.F))
            {
                KeyManager.instance.key2 = false;
            }
            if (Input.GetKeyUp(KeyCode.J))
            {
                KeyManager.instance.key3 = false;
            }
            if (Input.GetKeyUp(KeyCode.K))
            {
                KeyManager.instance.key4 = false;
            }
            #endregion
        }


        if (gameObject.layer == LayerMask.NameToLayer("LongNote"))
        {
            #region KeyDown
            if (Input.GetKeyDown(KeyCode.D))
            {
                TimingManager.instance.LongCheckTiming(1, KeyManager.instance.key1);
                KeyManager.instance.long1 = true;
                KeyManager.instance.key1 = true;
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                TimingManager.instance.LongCheckTiming(2, KeyManager.instance.key2);
                KeyManager.instance.long2 = true;
                KeyManager.instance.key2 = true;
            }
            if (Input.GetKeyDown(KeyCode.J))
            {
                TimingManager.instance.LongCheckTiming(3, KeyManager.instance.key3);
                KeyManager.instance.long3 = true;
                KeyManager.instance.key3 = true;
            }
            if (Input.GetKeyDown(KeyCode.K))
            {
                TimingManager.instance.LongCheckTiming(4, KeyManager.instance.key4);
                KeyManager.instance.long4 = true;
                KeyManager.instance.key4 = true;
            }
            #endregion

            #region Key
            if (Input.GetKey(KeyCode.D))
            {
                TimingManager.instance.LongCheckTiming(1, KeyManager.instance.key1);
                NoteMaster.instance.timer1 += Time.deltaTime*NoteMaster.instance.BPM[0]/10;
            }
            if (Input.GetKey(KeyCode.F))
            {
                TimingManager.instance.LongCheckTiming(2, KeyManager.instance.key2);
                NoteMaster.instance.timer2 += Time.deltaTime*NoteMaster.instance.BPM[0]/10;
            }
            if (Input.GetKey(KeyCode.J))
            {
                TimingManager.instance.LongCheckTiming(3, KeyManager.instance.key3);
                NoteMaster.instance.timer3 += Time.deltaTime* NoteMaster.instance.BPM[0]/10;
            }
            if (Input.GetKey(KeyCode.K))
            {
                TimingManager.instance.LongCheckTiming(4, KeyManager.instance.key4);
                NoteMaster.instance.timer4 += Time.deltaTime* NoteMaster.instance.BPM[0]/10;
            }
            #endregion

            #region KeyUp
            if (Input.GetKeyUp(KeyCode.D))
            {
                KeyManager.instance.key1 = false;
                KeyManager.instance.long1 = false;
                TimingManager.instance.LongCheckTiming(4, KeyManager.instance.key4);
                NoteMaster.instance.timer1 = 0;
            }
            if (Input.GetKeyUp(KeyCode.F))
            {
                KeyManager.instance.key2 = false;
                KeyManager.instance.long2 = false;
                TimingManager.instance.LongCheckTiming(4, KeyManager.instance.key4);
                NoteMaster.instance.timer2 = 0;
            }
            if (Input.GetKeyUp(KeyCode.J))
            {
                KeyManager.instance.key3 = false;
                KeyManager.instance.long3 = false;
                TimingManager.instance.LongCheckTiming(4, KeyManager.instance.key4);
                Debug.Log("·Õ³ò Å° ¶«");
                NoteMaster.instance.timer3 = 0;
            }
            if (Input.GetKeyUp(KeyCode.K))
            {
                KeyManager.instance.key4 = false;
                KeyManager.instance.long4 = false;
                TimingManager.instance.LongCheckTiming(4, KeyManager.instance.key4);
                NoteMaster.instance.timer4 = 0;
            }

            #endregion
        }
    }

}

