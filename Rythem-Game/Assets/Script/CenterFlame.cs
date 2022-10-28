using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterFlame : MonoBehaviour
{
    // �뷡 �ҽ�
    AudioSource  Audio;
    [SerializeField] AudioClip [] clip;  
    // �뷡 ����
    bool musicStart = false;

    void Start()
    {
        Audio = GetComponent<AudioSource>();
        Audio.clip = clip[0];
    
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!musicStart)
        {
            if (collision.CompareTag("Song"))
            {
                Audio.Play();
                musicStart = true;
                LoadMap.instance.NewLoadMap();
            }
        }
    }
}