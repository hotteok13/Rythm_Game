using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyManager : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Note1"))
        {
            AddNote.instance.boxNoteList1.Remove(collision.gameObject);
            Destroy(collision.gameObject);
        }
        if (collision.CompareTag("Note2"))
        {
            AddNote.instance.boxNoteList2.Remove(collision.gameObject);
            Destroy(collision.gameObject);
        }
        if (collision.CompareTag("Note3"))
        {
            AddNote.instance.boxNoteList3.Remove(collision.gameObject);
            Destroy(collision.gameObject);
        }
        if (collision.CompareTag("Note4"))
        {
            AddNote.instance.boxNoteList4.Remove(collision.gameObject);
            Destroy(collision.gameObject);
        }
    }
}
