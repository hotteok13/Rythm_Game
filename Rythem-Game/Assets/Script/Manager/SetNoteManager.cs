using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetNoteManager : MonoBehaviour
{
    public static SetNoteManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }    
    }

    void Update()
    {
        for (int i = 0; i < AddNote.instance.boxNoteList1.Count; i++)
        {
            if (gameObject.CompareTag("Note1"))
            {
                if (AddNote.instance.boxNoteList1[i].layer == LayerMask.NameToLayer("LongNote")&&KeyManager.instance.key[0]==false)
                {
                    if (Input.GetKeyDown(KeyCode.D))
                    {
                        TimingManager.instance.LongCheckTiming(1, KeyManager.instance.longNote[0]);
                        KeyManager.instance.longNote[0] = true;
                    }

                    if (Input.GetKey(KeyCode.D))
                    {
                        TimingManager.instance.LongCheckTiming(1, KeyManager.instance.longNote[0]);
                        NoteMaster.instance.timer[0] += Time.deltaTime * NoteMaster.instance.BPM[0] / 10;
                    }

                    if (Input.GetKeyUp(KeyCode.D))
                    {
                        KeyManager.instance.longNote[0] = false;
                        TimingManager.instance.LongCheckTiming(1, KeyManager.instance.longNote[0]);
                        NoteMaster.instance.timer[0] = 0;
                    }
                }

                else if (AddNote.instance.boxNoteList1[i].layer == LayerMask.NameToLayer("Note"))
                {
                    if (Input.GetKeyDown(KeyCode.D))
                    {
                        TimingManager.instance.CheckTiming(1, KeyManager.instance.key[0]);
                        KeyManager.instance.key[0] = true;
                        //KeyManager.instance.longNote[0] = true;
                    }
                    if (Input.GetKeyUp(KeyCode.D))
                    {
                        KeyManager.instance.key[0] = false;
                        //KeyManager.instance.longNote[0] = false;
                    }
                    break;
                }
                
            }
        }
        for (int i = 0; i < AddNote.instance.boxNoteList2.Count; i++)
        {
            if (gameObject.CompareTag("Note2"))
            {
                if (AddNote.instance.boxNoteList2[i].layer == LayerMask.NameToLayer("LongNote"))
                {
                    if (Input.GetKeyDown(KeyCode.F))
                    {
                        TimingManager.instance.LongCheckTiming(2, KeyManager.instance.longNote[1]);
                        KeyManager.instance.longNote[1] = true;
                        KeyManager.instance.key[1] = true;
                    }

                    if (Input.GetKey(KeyCode.F))
                    {
                        TimingManager.instance.LongCheckTiming(2, KeyManager.instance.longNote[1]);
                        NoteMaster.instance.timer[1] += Time.deltaTime * NoteMaster.instance.BPM[0] / 10;
                    }

                    if (Input.GetKeyUp(KeyCode.F))
                    {
                        KeyManager.instance.key[1] = false;
                        KeyManager.instance.longNote[1] = false;
                        TimingManager.instance.LongCheckTiming(2, KeyManager.instance.longNote[1]);
                        NoteMaster.instance.timer[1] = 0;
                    }
                }

                else if (AddNote.instance.boxNoteList2[i].layer == LayerMask.NameToLayer("Note"))
                {
                    if (Input.GetKeyDown(KeyCode.F))
                    {
                        TimingManager.instance.CheckTiming(2, KeyManager.instance.key[1]);
                        KeyManager.instance.key[1] = true;
                    }

                    if (Input.GetKeyUp(KeyCode.F))
                    {
                        KeyManager.instance.key[1] = false;
                    }
                }
            }
        }
        for (int i = 0; i < AddNote.instance.boxNoteList3.Count; i++)
        {
            if (gameObject.CompareTag("Note3"))
            {
                if (AddNote.instance.boxNoteList3[i].layer == LayerMask.NameToLayer("LongNote"))
                {
                    if (Input.GetKeyDown(KeyCode.J))
                    {
                        TimingManager.instance.LongCheckTiming(3, KeyManager.instance.longNote[2]);
                        KeyManager.instance.longNote[2] = true;
                        KeyManager.instance.key[2] = true;
                    }

                    if (Input.GetKey(KeyCode.J))
                    {
                        TimingManager.instance.LongCheckTiming(3, KeyManager.instance.longNote[2]);
                        NoteMaster.instance.timer[2] += Time.deltaTime * NoteMaster.instance.BPM[0] / 10;
                    }

                    if (Input.GetKeyUp(KeyCode.J))
                    {
                        KeyManager.instance.key[2] = false;
                        KeyManager.instance.longNote[2] = false;
                        TimingManager.instance.LongCheckTiming(3, KeyManager.instance.longNote[2]);
                        NoteMaster.instance.timer[2] = 0;
                    }
                }

                else if (AddNote.instance.boxNoteList3[i].layer == LayerMask.NameToLayer("Note"))
                {
                    if (Input.GetKeyDown(KeyCode.J))
                    {
                        TimingManager.instance.CheckTiming(3, KeyManager.instance.key[2]);
                        KeyManager.instance.key[2] = true;
                    }

                    if (Input.GetKeyUp(KeyCode.J))
                    {
                        KeyManager.instance.key[2] = false;
                    }
                }
            }
        }
        for (int i = 0; i < AddNote.instance.boxNoteList4.Count; i++)
        {
            if (gameObject.CompareTag("Note4"))
            {
                if (AddNote.instance.boxNoteList4[i].layer == LayerMask.NameToLayer("LongNote"))
                {
                    if (Input.GetKeyDown(KeyCode.K))
                    {
                        TimingManager.instance.LongCheckTiming(4, KeyManager.instance.longNote[3]);
                        KeyManager.instance.longNote[3] = true;
                        KeyManager.instance.key[3] = true;
                    }

                    if (Input.GetKey(KeyCode.K))
                    {
                        TimingManager.instance.LongCheckTiming(4, KeyManager.instance.longNote[3]);
                        NoteMaster.instance.timer[3] += Time.deltaTime * NoteMaster.instance.BPM[0] / 10;
                    }

                    if (Input.GetKeyUp(KeyCode.K))
                    {
                        KeyManager.instance.key[3] = false;
                        KeyManager.instance.longNote[3] = false;
                        TimingManager.instance.LongCheckTiming(4, KeyManager.instance.longNote[3]);
                        NoteMaster.instance.timer[3] = 0;
                    }
                }

                else if (AddNote.instance.boxNoteList4[i].layer == LayerMask.NameToLayer("Note"))
                {
                    if (Input.GetKeyDown(KeyCode.K))
                    {
                        TimingManager.instance.CheckTiming(4, KeyManager.instance.key[3]);
                        KeyManager.instance.key[3] = true;
                    }

                    if (Input.GetKeyUp(KeyCode.K))
                    {
                        KeyManager.instance.key[3] = false;
                    }
                }

            }
        }


    }
}
