using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyManager : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Note"))
        {

            TimingManager.instance.boxNoteList.Remove(collision.gameObject);
            collision.gameObject.SetActive(false);
            TimingManager.instance.CheckTiming();

        }
    }
}
