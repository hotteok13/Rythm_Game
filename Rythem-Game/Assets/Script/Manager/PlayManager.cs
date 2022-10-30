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
                if (NoteSpeed.instance.key1 == true)
                {
                    return;
                }
                TimingManager.instance.CheckTiming(1);
                NoteSpeed.instance.key1 = true;
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                if (NoteSpeed.instance.key2 == true)
                {
                    return;
                }
                TimingManager.instance.CheckTiming(2);
                NoteSpeed.instance.key2 = true;
            }
            if (Input.GetKeyDown(KeyCode.J))
            {
                if (NoteSpeed.instance.key3 == true)
                {
                    return;
                }
                TimingManager.instance.CheckTiming(3);
                NoteSpeed.instance.key3 = true;
            }
            if (Input.GetKeyDown(KeyCode.K))
            {
                if (NoteSpeed.instance.key4 == true)
                {
                    return;
                }
                TimingManager.instance.CheckTiming(4);
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
                if (NoteSpeed.instance.key1 == true)
                {
                    return;
                }
                TimingManager.instance.CheckTiming(1);
                NoteSpeed.instance.key1 = true;
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                if (NoteSpeed.instance.key2 == true)
                {
                    return;
                }
                TimingManager.instance.CheckTiming(2);
                NoteSpeed.instance.key2 = true;
            }
            if (Input.GetKeyDown(KeyCode.J))
            {
                if (NoteSpeed.instance.key3 == true)
                {
                    return;
                }
                TimingManager.instance.CheckTiming(3);
                NoteSpeed.instance.key3 = true;
            }
            if (Input.GetKeyDown(KeyCode.K))
            {
                if (NoteSpeed.instance.key4 == true)
                {
                    return;
                }
                TimingManager.instance.CheckTiming(4);
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
    }

}

