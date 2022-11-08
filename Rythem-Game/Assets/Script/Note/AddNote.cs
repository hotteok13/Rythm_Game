using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddNote : MonoBehaviour
{
    public List<GameObject> boxNoteList1 = new List<GameObject>();
    public List<GameObject> boxNoteList2= new List<GameObject>();
    public List<GameObject> boxNoteList3 = new List<GameObject>();
    public List<GameObject> boxNoteList4 = new List<GameObject>();

    public static AddNote instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Note1"))
        {
            boxNoteList1.Add(collision.gameObject);
            for(int i = 0; i < AddNote.instance.boxNoteList1.Count; i++)
            {
                if (collision.gameObject == AddNote.instance.boxNoteList1[i])
                {
                    collision.transform.position = new Vector2(AddNote.instance.boxNoteList1[i].transform.position.x, AddNote.instance.boxNoteList1[i].transform.position.y + NoteMaster.instance.notePosition*(i+1));
                }
            }
        }
        if (collision.gameObject.CompareTag("Note2"))
        {
            boxNoteList2.Add(collision.gameObject);
            for (int i = 0; i < AddNote.instance.boxNoteList2.Count; i++)
            {
                if (collision.gameObject == AddNote.instance.boxNoteList2[i])
                {
                    collision.transform.position = new Vector2(AddNote.instance.boxNoteList2[i].transform.position.x, AddNote.instance.boxNoteList2[i].transform.position.y + NoteMaster.instance.notePosition * (i + 1));
                }
            }
        }
        if (collision.gameObject.CompareTag("Note3"))
        {
            boxNoteList3.Add(collision.gameObject);
            for (int i = 0; i < AddNote.instance.boxNoteList3.Count; i++)
            {
               if (collision.gameObject == AddNote.instance.boxNoteList3[i])
                {
                    collision.transform.position = new Vector2(AddNote.instance.boxNoteList3[i].transform.position.x, AddNote.instance.boxNoteList3[i].transform.position.y + NoteMaster.instance.notePosition * (i + 1));
                }
            }
        }
        if (collision.gameObject.CompareTag("Note4"))
        {
            boxNoteList4.Add(collision.gameObject);
            for (int i = 0; i < AddNote.instance.boxNoteList4.Count; i++)
            {
                if (collision.gameObject == AddNote.instance.boxNoteList4[i])
                {
                    collision.transform.position = new Vector2(AddNote.instance.boxNoteList4[i].transform.position.x, AddNote.instance.boxNoteList4[i].transform.position.y + NoteMaster.instance.notePosition * (i + 1));
                }
            }
        }
    }
}
