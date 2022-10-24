using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Note : MonoBehaviour
{
    //Note속도
    public float noteSpeed = 400.0f;
    //Note 사진
    private Image noteImage;

    //public static Note instance;

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
    }




}