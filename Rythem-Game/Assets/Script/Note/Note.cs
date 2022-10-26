using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Note : MonoBehaviour
{
    public static Note instacne;
    //Note »çÁø
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
        //TimingManager.instance.boxNoteList.Add(gameObject);
        noteImage = GetComponent<Image>();
    }

    public void HideNote()
    {
        noteImage.enabled = false;
    }

    private void Update()
    {
        transform.localPosition += Vector3.down *NoteSpeed.instance.noteSpeed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Alpha1)&& NoteSpeed.instance.noteSpeed < 1000)
        {
            NoteSpeed.instance.noteSpeed += 100;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && NoteSpeed.instance.noteSpeed > 100)
        {
            NoteSpeed.instance.noteSpeed -= 100;
        }
    }


}