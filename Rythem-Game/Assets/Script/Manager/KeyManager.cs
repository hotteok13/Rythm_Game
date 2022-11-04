using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyManager : MonoBehaviour
{
    public bool [] key;


    public bool [] longNote;
    public static KeyManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        for(int i = 0; i < 4; i++)
        {
            key[i] = false;
            longNote[i] = false;
        }
    } 
}
