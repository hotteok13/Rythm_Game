using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddNote : MonoBehaviour
{
    public List<GameObject> boxNoteList = new List<GameObject>();

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
        if (collision.gameObject.CompareTag("Note"))
        {
            boxNoteList.Add(collision.gameObject);
        }
        
    }
}
