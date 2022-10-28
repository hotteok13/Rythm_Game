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
        }
        if (collision.gameObject.CompareTag("Note2"))
        {
            boxNoteList2.Add(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Note3"))
        {
            boxNoteList3.Add(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Note4"))
        {
            boxNoteList4.Add(collision.gameObject);
        }
    }
}
