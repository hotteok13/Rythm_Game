using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Note : MonoBehaviour
{
    public static Note instacne;
    //Note�ӵ�
    public float noteSpeed = 400.0f;
    //Note ����
    private Image noteImage;


    private void Awake()
    {
        if (instacne == null)
        {
            instacne = this;
        }

    }


    void Start()
    {
        noteImage = GetComponent<Image>();
    }

    public void HideNote()
    {
        noteImage.enabled = false;
    }

    private void Update()
    {
        transform.localPosition += Vector3.down * noteSpeed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Alpha1)&& noteSpeed < 1000)
        {
            noteSpeed += 100;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) &&noteSpeed > 100)
        {
            noteSpeed -= 100;
        }
    }


}