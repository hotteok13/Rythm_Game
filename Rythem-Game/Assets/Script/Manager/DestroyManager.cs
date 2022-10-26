using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyManager : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Note"))
        {

            AddNote.instance.boxNoteList.Remove(collision.gameObject);
            Destroy(collision.gameObject);
            TimingManager.instance.CheckTiming();

        }
    }
}
