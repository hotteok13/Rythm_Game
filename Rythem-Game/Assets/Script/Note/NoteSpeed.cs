using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteSpeed : MonoBehaviour
{
    public float noteSpeed = 400.0f;

    public bool key1;
    public bool key2;
    public bool key3;
    public bool key4;

    public static NoteSpeed instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        key1 = false;
        key2 = false;
        key3 = false;
        key4 = false;
    }       
}
