using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyManager : MonoBehaviour
{
    public bool key1;
    public bool key2;
    public bool key3;
    public bool key4;

    public bool long1;
    public bool long2;
    public bool long3;
    public bool long4;
    public static KeyManager instance;

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

        long1 = false;
        long2 = false;
        long3 = false;
        long4 = false;
    } 
}
