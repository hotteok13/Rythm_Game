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
        transform.localPosition += Vector3.down * NoteMaster.instance.noteSpeed * Time.deltaTime;



        if (Input.GetKeyDown(KeyCode.Alpha1) && NoteMaster.instance.noteSpeed < 1000 && NoteMaster.instance.noteSpeedSetting == false)
        {
            NoteMaster.instance.noteSpeed += 100;
            NoteMaster.instance.notePosition += 100;
            for (int i = 0; i < AddNote.instance.boxNoteList1.Count; i++)
            {
                AddNote.instance.boxNoteList1[i].transform.position = new Vector2(AddNote.instance.boxNoteList1[i].transform.position.x, AddNote.instance.boxNoteList1[i].transform.position.y + (NoteMaster.instance.notePosition * (i+1)));
            }
            for (int i = 0; i < AddNote.instance.boxNoteList2.Count; i++)
            {
                AddNote.instance.boxNoteList2[i].transform.position = new Vector2(AddNote.instance.boxNoteList2[i].transform.position.x, AddNote.instance.boxNoteList2[i].transform.position.y + (NoteMaster.instance.notePosition * (i + 1)));
            }
            for (int i = 0; i < AddNote.instance.boxNoteList3.Count; i++)
            {
                AddNote.instance.boxNoteList3[i].transform.position = new Vector2(AddNote.instance.boxNoteList3[i].transform.position.x, AddNote.instance.boxNoteList3[i].transform.position.y + (NoteMaster.instance.notePosition * (i + 1)));
            }
            for (int i = 0; i < AddNote.instance.boxNoteList4.Count; i++)
            {
                AddNote.instance.boxNoteList4[i].transform.position = new Vector2(AddNote.instance.boxNoteList4[i].transform.position.x, AddNote.instance.boxNoteList4[i].transform.position.y + (NoteMaster.instance.notePosition * (i + 1)));
            }
            NoteMaster.instance.noteSpeedSetting = true;

        }
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            NoteMaster.instance.noteSpeedSetting = false;

        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && NoteMaster.instance.noteSpeed > 100 && NoteMaster.instance.noteSpeedSetting == false)
        {
            NoteMaster.instance.noteSpeed -= 100;
            for (int i = 0; i < AddNote.instance.boxNoteList1.Count; i++)
            {
                AddNote.instance.boxNoteList1[i].transform.position = new Vector2(AddNote.instance.boxNoteList1[i].transform.position.x, AddNote.instance.boxNoteList1[i].transform.position.y - 100);
            }
            NoteMaster.instance.noteSpeedSetting = true;
        }
        if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            NoteMaster.instance.noteSpeedSetting = false;

        }


    }
}