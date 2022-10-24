using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteMaster : MonoBehaviour
{
    public int bpm = 0; // ������� ��Ʈ ����. 1�д� �� ��Ʈ����.
    double currentTime = 0d; // ���� ������ ���� ������ �߿��ؼ� float���� double

    [SerializeField] Transform tfNoteAppear = null; // ��Ʈ ���� ��ġ ������Ʈ
    [SerializeField] GameObject goNote = null; // ������ ��Ʈ ������

    TimingManager theTimingManager;

    public static NoteMaster instance;


    void Start()
    {
        theTimingManager = GetComponent<TimingManager>();
        if (instance == null)
        {
            instance = this;
        }
    }

    void Update()
    {
        // ��ǻ�� �����Ӵ� ��
        currentTime += Time.deltaTime;
    }

    public void NewNote()
    {
        // ��ǻ�� �����Ӵ� ��
        currentTime += Time.deltaTime;

        //currentTIme�� 60��/bpm���� ũ�Ű� ������
        if (currentTime >= 60d / bpm)
        {
            //                              ��Ʈ      ��Ʈ ���� ��ġ        ��Ʈ�� ȸ����
            GameObject t_note = Instantiate(goNote, tfNoteAppear.position, Quaternion.identity);
            //t_note�� ��ġ�� �ڱ� �ڽſ� ��ġ���� �������ش�
            t_note.transform.SetParent(this.transform);
            //t_note�� ũ�⸦ x=1f y=1f z=0f
            t_note.transform.localScale = new Vector3(1f, 1f, 0f);

            theTimingManager.boxNoteList.Add(t_note);

            currentTime -= 60d / bpm;  // currentTime = 0 ���� �������ָ� �ȵȴ�. 
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        NewNote();
    }



}