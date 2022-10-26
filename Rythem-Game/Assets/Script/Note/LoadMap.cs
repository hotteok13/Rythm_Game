using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadMap : MonoBehaviour
{
    [SerializeField] Transform tfNoteAppear;
    [SerializeField] GameObject [] loadMap;

    public static LoadMap instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void NewLoadMap()
    {
        GameObject t_note = Instantiate(loadMap[0], tfNoteAppear.position, Quaternion.identity);
        //t_note�� ��ġ�� �ڱ� �ڽſ� ��ġ���� �������ش�
        t_note.transform.SetParent(this.transform);
        //t_note�� ũ�⸦ x=1f y=1f z=0f
        t_note.transform.localScale = new Vector3(1f, 1f, 0f);
    }
}
