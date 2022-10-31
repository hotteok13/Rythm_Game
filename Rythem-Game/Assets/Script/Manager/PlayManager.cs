using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayManager : MonoBehaviour
{
    private void Update()
    {
        if (gameObject.layer==LayerMask.NameToLayer("Note"))
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                TimingManager.instance.CheckTiming(1,NoteSpeed.instance.key1);
                NoteSpeed.instance.key1 = true;
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                TimingManager.instance.CheckTiming(2, NoteSpeed.instance.key2);
                NoteSpeed.instance.key2 = true;
            }
            if (Input.GetKeyDown(KeyCode.J))
            {
                TimingManager.instance.CheckTiming(3, NoteSpeed.instance.key3);
                NoteSpeed.instance.key3 = true;
            }
            if (Input.GetKeyDown(KeyCode.K))
            {
                TimingManager.instance.CheckTiming(4, NoteSpeed.instance.key4);
                NoteSpeed.instance.key4 = true;
            }

            if (Input.GetKeyUp(KeyCode.D))
            {
                NoteSpeed.instance.key1 = false;
            }
            if (Input.GetKeyUp(KeyCode.F))
            {
                NoteSpeed.instance.key2 = false;
            }
            if (Input.GetKeyUp(KeyCode.J))
            {
                NoteSpeed.instance.key3 = false;
            }
            if (Input.GetKeyUp(KeyCode.K))
            {
                NoteSpeed.instance.key4 = false;
            }
        }


        if (gameObject.layer == LayerMask.NameToLayer("LongNote"))
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                NoteSpeed.instance.long1 = false;
                TimingManager.instance.LongCheckTiming(1, NoteSpeed.instance.key1);
                NoteSpeed.instance.key1 = true;
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                NoteSpeed.instance.long1 = false;
                TimingManager.instance.LongCheckTiming(2, NoteSpeed.instance.key2);
                NoteSpeed.instance.key2 = true;
            }
            if (Input.GetKeyDown(KeyCode.J))
            {
                NoteSpeed.instance.long1 = false;
                TimingManager.instance.LongCheckTiming(3, NoteSpeed.instance.key3);
                NoteSpeed.instance.key3 = true;
            }
            if (Input.GetKeyDown(KeyCode.K))
            {
                NoteSpeed.instance.long1 = false;
                TimingManager.instance.LongCheckTiming(4, NoteSpeed.instance.key4);
                NoteSpeed.instance.key4 = true;
            }

            if (Input.GetKey(KeyCode.D))
            {
                TimingManager.instance.LongCheckTiming(1, NoteSpeed.instance.key1);
            }
            if (Input.GetKey(KeyCode.F))
            {
                TimingManager.instance.LongCheckTiming(2, NoteSpeed.instance.key2);
            }
            if (Input.GetKey(KeyCode.J))
            {
                TimingManager.instance.LongCheckTiming(3, NoteSpeed.instance.key3);
            }
            if (Input.GetKey(KeyCode.K))
            {
                TimingManager.instance.LongCheckTiming(4, NoteSpeed.instance.key4);
            }

            if (Input.GetKeyUp(KeyCode.D))
            {
                NoteSpeed.instance.key1 = false;
                NoteSpeed.instance.long1 = true;
                TimingManager.instance.LongCheckTiming(4, NoteSpeed.instance.key4);
            }
            if (Input.GetKeyUp(KeyCode.F))
            {
                NoteSpeed.instance.key2 = false;
                NoteSpeed.instance.long2 = true;
                TimingManager.instance.LongCheckTiming(4, NoteSpeed.instance.key4);
            }
            if (Input.GetKeyUp(KeyCode.J))
            {
                NoteSpeed.instance.key3 = false;
                NoteSpeed.instance.long3 = true;
                TimingManager.instance.LongCheckTiming(4, NoteSpeed.instance.key4);
            }
            if (Input.GetKeyUp(KeyCode.K))
            {
                NoteSpeed.instance.key4 = false;
                NoteSpeed.instance.long4 = true;
                TimingManager.instance.LongCheckTiming(4, NoteSpeed.instance.key4);
            }
        }
    }

}

