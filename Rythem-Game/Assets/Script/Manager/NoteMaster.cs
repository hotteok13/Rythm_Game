using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteMaster : MonoBehaviour
{
    public int bpm = 0; // 리듬게임 비트 단위. 1분당 몇 비트인지.
    double currentTime = 0d; // 리듬 게임은 오차 적은게 중요해서 float보단 double

    [SerializeField] Transform tfNoteAppear = null; // 노트 생성 위치 오브젝트
    [SerializeField] GameObject goNote = null; // 생성할 노트 프리팹

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
        // 컴퓨터 프레임당 초
        currentTime += Time.deltaTime;
    }

    public void NewNote()
    {
        // 컴퓨터 프레임당 초
        currentTime += Time.deltaTime;

        //currentTIme이 60초/bpm보다 크거가 같으면
        if (currentTime >= 60d / bpm)
        {
            //                              노트      노트 생성 위치        노트의 회전값
            GameObject t_note = Instantiate(goNote, tfNoteAppear.position, Quaternion.identity);
            //t_note에 위치를 자기 자신에 위치에서 생성해준다
            t_note.transform.SetParent(this.transform);
            //t_note에 크기를 x=1f y=1f z=0f
            t_note.transform.localScale = new Vector3(1f, 1f, 0f);

            theTimingManager.boxNoteList.Add(t_note);

            currentTime -= 60d / bpm;  // currentTime = 0 으로 리셋해주면 안된다. 
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        NewNote();
    }



}