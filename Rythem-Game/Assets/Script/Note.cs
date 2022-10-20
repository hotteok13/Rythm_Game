using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Note : MonoBehaviour
{
    //Note�ӵ�
    public float noteSpeed = 400.0f;
    //Note ����
    private Image noteImage;

    void Start()
    {
        noteImage = GetComponent<Image>();
    }

    public void HideNote()
    {
        noteImage.enabled = false;
    }

    void Update()
    {
        transform.localPosition += Vector3.down * noteSpeed * Time.deltaTime;
    }

    
}