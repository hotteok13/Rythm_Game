using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterFlame : MonoBehaviour
{
    // 노래 소스
    AudioSource myAudio;
    // 노래 시작
    bool musicStart = false;

    void Start()
    {
        myAudio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!musicStart)
        {
            if (collision.CompareTag("Note"))
            {
                myAudio.Play();
                musicStart = true;
            }
        }
    }
}