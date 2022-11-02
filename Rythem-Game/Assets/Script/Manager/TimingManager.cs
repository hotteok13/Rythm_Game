using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimingManager : MonoBehaviour
{


    public static TimingManager instance;
    [SerializeField] Transform center = null; // 판정 범위의 중심
    [SerializeField] RectTransform[] timingRect = null; // 다양한 판정 범위
    Vector2[] timingBoxs = null; // 판정 범위 최소값 x, 최대값 y

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        
        timingBoxs = new Vector2[5];
        // timingBoxs 배열 5개 생성

        for (int i = 0; i < 5; i++)
        {
            // center.localPosition.y - timingRect[i].rect.height / 2는 X좌표 값
            // center.localPosition.y + timingRect[i].rect.height / 2는 Y좌표 값
            timingBoxs[i].Set(center.localPosition.y - timingRect[i].rect.height / 2,
                              center.localPosition.y + timingRect[i].rect.height / 2);
        }
    }

    public void CheckTiming(int key,bool cheak)
    {
        if (cheak == true)
        {
            return;
        }

        switch (key)
        {
            case 1:
                for (int i = 0; i < AddNote.instance.boxNoteList1.Count; i++)
                {
                    float t_notePosY = AddNote.instance.boxNoteList1[i].transform.position.y - 225;
                    // 판정 순서 : Perfect -> Great -> Good -> Bad
                    for (int j = 0; j < timingBoxs.Length; j++)
                    {
                        // timingBoxs[j].x 의 값이 판정 좌표 x보다 크거나 같거나
                        // timingBoxs[j].y 의 값이 판정 좌표 y보다 작거나 같으면 실행
                        if (timingBoxs[j].x <= t_notePosY && t_notePosY <= timingBoxs[j].y)
                        {
                            // 컴포넌트를 비활성화
                            AddNote.instance.boxNoteList1[i].GetComponent<Note>().HideNote();
                            AddNote.instance.boxNoteList1.RemoveAt(i);
                            switch (j)
                            {
                                case 0:
                                    TextManager.instance.noteAccuracyText.text = "Perfect";
                                    TextManager.instance.comboCount++;
                                    TextManager.instance.accuracyCount += 100.00f;
                                    TextManager.instance.count++;
                                    break;
                                case 1:
                                    TextManager.instance.noteAccuracyText.text = "Great";
                                    TextManager.instance.comboCount++;
                                    TextManager.instance.accuracyCount += 80.00f;
                                    TextManager.instance.count++;
                                    break;
                                case 2:
                                    TextManager.instance.noteAccuracyText.text = "Good";
                                    TextManager.instance.comboCount++;
                                    TextManager.instance.accuracyCount += 50.00f;
                                    TextManager.instance.count++;
                                    break;
                                case 3:
                                    TextManager.instance.noteAccuracyText.text = "Bad";
                                    TextManager.instance.comboCount++;
                                    TextManager.instance.accuracyCount += 20.00f;
                                    TextManager.instance.count++;
                                    break;
                                case 4:
                                    TextManager.instance.noteAccuracyText.text = "Miss";
                                    TextManager.instance.comboCount = 0;
                                    TextManager.instance.accuracyCount += 0f;
                                    TextManager.instance.count++;
                                    break;
                            }
                            return;
                        }
                    }
                }
                break;
            case 2:
                for (int i = 0; i < AddNote.instance.boxNoteList2.Count; i++)
                {

                    float t_notePosY = AddNote.instance.boxNoteList2[i].transform.position.y - 225;

                    // 판정 순서 : Perfect -> Great -> Good -> Bad
                    for (int j = 0; j < timingBoxs.Length; j++)
                    {
                        // timingBoxs[j].x 의 값이 판정 좌표 x보다 크거나 같거나
                        // timingBoxs[j].y 의 값이 판정 좌표 y보다 작거나 같으면 실행
                        if (timingBoxs[j].x <= t_notePosY && t_notePosY <= timingBoxs[j].y)
                        {
                            // 컴포넌트를 비활성화
                            AddNote.instance.boxNoteList2[i].GetComponent<Note>().HideNote();
                            AddNote.instance.boxNoteList2.RemoveAt(i);

                            switch (j)
                            {
                                case 0:
                                    TextManager.instance.noteAccuracyText.text = "Perfect";
                                    TextManager.instance.comboCount++;
                                    TextManager.instance.accuracyCount += 100.00f;
                                    TextManager.instance.count++;
                                    break;
                                case 1:
                                    TextManager.instance.noteAccuracyText.text = "Great";
                                    TextManager.instance.comboCount++;
                                    TextManager.instance.accuracyCount += 80.00f;
                                    TextManager.instance.count++;
                                    break;
                                case 2:
                                    TextManager.instance.noteAccuracyText.text = "Good";
                                    TextManager.instance.comboCount++;
                                    TextManager.instance.accuracyCount += 50.00f;
                                    TextManager.instance.count++;
                                    break;
                                case 3:
                                    TextManager.instance.noteAccuracyText.text = "Bad";
                                    TextManager.instance.comboCount++;
                                    TextManager.instance.accuracyCount += 20.00f;
                                    TextManager.instance.count++;
                                    break;
                                case 4:
                                    TextManager.instance.noteAccuracyText.text = "Miss";
                                    TextManager.instance.comboCount = 0;
                                    TextManager.instance.accuracyCount += 0f;
                                    TextManager.instance.count++;
                                    break;
                            }
                            return;
                        }
                    }
                }
                break;
            case 3:
                for (int i = 0; i < AddNote.instance.boxNoteList3.Count; i++)
                {

                    float t_notePosY = AddNote.instance.boxNoteList3[i].transform.position.y - 225;

                    // 판정 순서 : Perfect -> Great -> Good -> Bad
                    for (int j = 0; j < timingBoxs.Length; j++)
                    {
                        // timingBoxs[j].x 의 값이 판정 좌표 x보다 크거나 같거나
                        // timingBoxs[j].y 의 값이 판정 좌표 y보다 작거나 같으면 실행
                        if (timingBoxs[j].x <= t_notePosY && t_notePosY <= timingBoxs[j].y)
                        {
                            // 컴포넌트를 비활성화
                            AddNote.instance.boxNoteList3[i].GetComponent<Note>().HideNote();
                            AddNote.instance.boxNoteList3.RemoveAt(i);

                            switch (j)
                            {
                                case 0:
                                    TextManager.instance.noteAccuracyText.text = "Perfect";
                                    TextManager.instance.comboCount++;
                                    TextManager.instance.accuracyCount += 100.00f;
                                    TextManager.instance.count++;
                                    break;
                                case 1:
                                    TextManager.instance.noteAccuracyText.text = "Great";
                                    TextManager.instance.comboCount++;
                                    TextManager.instance.accuracyCount += 80.00f;
                                    TextManager.instance.count++;
                                    break;
                                case 2:
                                    TextManager.instance.noteAccuracyText.text = "Good";
                                    TextManager.instance.comboCount++;
                                    TextManager.instance.accuracyCount += 50.00f;
                                    TextManager.instance.count++;
                                    break;
                                case 3:
                                    TextManager.instance.noteAccuracyText.text = "Bad";
                                    TextManager.instance.comboCount++;
                                    TextManager.instance.accuracyCount += 20.00f;
                                    TextManager.instance.count++;
                                    break;
                                case 4:
                                    TextManager.instance.noteAccuracyText.text = "Miss";
                                    TextManager.instance.comboCount = 0;
                                    TextManager.instance.accuracyCount += 0f;
                                    TextManager.instance.count++;
                                    break;
                            }
                            return;
                        }
                    }
                }
                break;
            case 4:
                for (int i = 0; i < AddNote.instance.boxNoteList4.Count; i++)
                {

                    float t_notePosY = AddNote.instance.boxNoteList4[i].transform.position.y - 225;

                    // 판정 순서 : Perfect -> Great -> Good -> Bad
                    for (int j = 0; j < timingBoxs.Length; j++)
                    {
                        // timingBoxs[j].x 의 값이 판정 좌표 x보다 크거나 같거나
                        // timingBoxs[j].y 의 값이 판정 좌표 y보다 작거나 같으면 실행
                        if (timingBoxs[j].x <= t_notePosY && t_notePosY <= timingBoxs[j].y)
                        {
                            // 컴포넌트를 비활성화
                            AddNote.instance.boxNoteList4[i].GetComponent<Note>().HideNote();
                            AddNote.instance.boxNoteList4.RemoveAt(i);

                            switch (j)
                            {
                                case 0:
                                    TextManager.instance.noteAccuracyText.text = "Perfect";
                                    TextManager.instance.comboCount++;
                                    TextManager.instance.accuracyCount += 100.00f;
                                    TextManager.instance.count++;
                                    break;
                                case 1:
                                    TextManager.instance.noteAccuracyText.text = "Great";
                                    TextManager.instance.comboCount++;
                                    TextManager.instance.accuracyCount += 80.00f;
                                    TextManager.instance.count++;
                                    break;
                                case 2:
                                    TextManager.instance.noteAccuracyText.text = "Good";
                                    TextManager.instance.comboCount++;
                                    TextManager.instance.accuracyCount += 50.00f;
                                    TextManager.instance.count++;
                                    break;
                                case 3:
                                    TextManager.instance.noteAccuracyText.text = "Bad";
                                    TextManager.instance.comboCount++;
                                    TextManager.instance.accuracyCount += 20.00f;
                                    TextManager.instance.count++;
                                    break;
                                case 4:
                                    TextManager.instance.noteAccuracyText.text = "Miss";
                                    TextManager.instance.comboCount = 0;
                                    TextManager.instance.accuracyCount += 0f;
                                    TextManager.instance.count++;
                                    break;
                            }
                            return;
                        }
                    }
                }
                break;
        }
    }

    public void LongCheckTiming(int key,bool cheak)
    {
        if (cheak == false)
        {
            switch (key)
            {
                case 1:
                    for (int i = 0; i < AddNote.instance.boxNoteList1.Count; i++)
                    {
                        float t_notePosY = AddNote.instance.boxNoteList1[i].transform.position.y - 225;
                        // 판정 순서 : Perfect -> Great -> Good -> Bad
                        for (int j = 0; j < timingBoxs.Length; j++)
                        {
                            // timingBoxs[j].x 의 값이 판정 좌표 x보다 크거나 같거나
                            // timingBoxs[j].y 의 값이 판정 좌표 y보다 작거나 같으면 실행
                            if (timingBoxs[j].x <= t_notePosY && t_notePosY <= timingBoxs[j].y)
                            {
                                // 컴포넌트를 비활성화
                                if (KeyManager.instance.long1 == true)
                                {
                                    AddNote.instance.boxNoteList1[0].GetComponent<Note>().HideNote();
                                    AddNote.instance.boxNoteList1.RemoveAt(0);
                                }
                                switch (j)
                                {
                                    case 0:
                                        TextManager.instance.noteAccuracyText.text = "Perfect";
                                        TextManager.instance.comboCount++;
                                        TextManager.instance.accuracyCount += 100.00f;
                                        TextManager.instance.count++;
                                        break;
                                    case 1:
                                        TextManager.instance.noteAccuracyText.text = "Great";
                                        TextManager.instance.comboCount++;
                                        TextManager.instance.accuracyCount += 80.00f;
                                        TextManager.instance.count++;
                                        break;
                                    case 2:
                                        TextManager.instance.noteAccuracyText.text = "Good";
                                        TextManager.instance.comboCount++;
                                        TextManager.instance.accuracyCount += 50.00f;
                                        TextManager.instance.count++;
                                        break;
                                    case 3:
                                        TextManager.instance.noteAccuracyText.text = "Bad";
                                        TextManager.instance.comboCount++;
                                        TextManager.instance.accuracyCount += 20.00f;
                                        TextManager.instance.count++;
                                        break;
                                    case 4:
                                        TextManager.instance.noteAccuracyText.text = "Miss";
                                        TextManager.instance.comboCount = 0;
                                        TextManager.instance.accuracyCount += 0f;
                                        TextManager.instance.count++;
                                        break;
                                }
                                return;
                            }
                        }
                    }
                    break;
                case 2:
                    for (int i = 0; i < AddNote.instance.boxNoteList2.Count; i++)
                    {

                        float t_notePosY = AddNote.instance.boxNoteList2[i].transform.position.y - 225;

                        // 판정 순서 : Perfect -> Great -> Good -> Bad
                        for (int j = 0; j < timingBoxs.Length; j++)
                        {
                            // timingBoxs[j].x 의 값이 판정 좌표 x보다 크거나 같거나
                            // timingBoxs[j].y 의 값이 판정 좌표 y보다 작거나 같으면 실행
                            if (timingBoxs[j].x <= t_notePosY && t_notePosY <= timingBoxs[j].y)
                            {
                                // 컴포넌트를 비활성화
                                if (KeyManager.instance.long2 == true)
                                {
                                    AddNote.instance.boxNoteList2[0].GetComponent<Note>().HideNote();
                                    AddNote.instance.boxNoteList2.RemoveAt(0);
                                }
                                switch (j)
                                {
                                    case 0:
                                        TextManager.instance.noteAccuracyText.text = "Perfect";
                                        TextManager.instance.comboCount++;
                                        TextManager.instance.accuracyCount += 100.00f;
                                        TextManager.instance.count++;
                                        break;
                                    case 1:
                                        TextManager.instance.noteAccuracyText.text = "Great";
                                        TextManager.instance.comboCount++;
                                        TextManager.instance.accuracyCount += 80.00f;
                                        TextManager.instance.count++;
                                        break;
                                    case 2:
                                        TextManager.instance.noteAccuracyText.text = "Good";
                                        TextManager.instance.comboCount++;
                                        TextManager.instance.accuracyCount += 50.00f;
                                        TextManager.instance.count++;
                                        break;
                                    case 3:
                                        TextManager.instance.noteAccuracyText.text = "Bad";
                                        TextManager.instance.comboCount++;
                                        TextManager.instance.accuracyCount += 20.00f;
                                        TextManager.instance.count++;
                                        break;
                                    case 4:
                                        TextManager.instance.noteAccuracyText.text = "Miss";
                                        TextManager.instance.comboCount = 0;
                                        TextManager.instance.accuracyCount += 0f;
                                        TextManager.instance.count++;
                                        break;
                                }
                                return;
                            }
                        }
                    }
                    break;
                case 3:
                    for (int i = 0; i < AddNote.instance.boxNoteList3.Count; i++)
                    {

                        float t_notePosY = AddNote.instance.boxNoteList3[i].transform.position.y - 225;

                        // 판정 순서 : Perfect -> Great -> Good -> Bad
                        for (int j = 0; j < timingBoxs.Length; j++)
                        {
                            // timingBoxs[j].x 의 값이 판정 좌표 x보다 크거나 같거나
                            // timingBoxs[j].y 의 값이 판정 좌표 y보다 작거나 같으면 실행
                            if (timingBoxs[j].x <= t_notePosY && t_notePosY <= timingBoxs[j].y)
                            {
                                // 컴포넌트를 비활성화
                                if (KeyManager.instance.long3 == true)
                                {
                                    AddNote.instance.boxNoteList3[0].GetComponent<Note>().HideNote();
                                    AddNote.instance.boxNoteList3.RemoveAt(0);
                                }
                                switch (j)
                                {
                                    case 0:
                                        TextManager.instance.noteAccuracyText.text = "Perfect";
                                        TextManager.instance.comboCount++;
                                        TextManager.instance.accuracyCount += 100.00f;
                                        TextManager.instance.count++;
                                        break;
                                    case 1:
                                        TextManager.instance.noteAccuracyText.text = "Great";
                                        TextManager.instance.comboCount++;
                                        TextManager.instance.accuracyCount += 80.00f;
                                        TextManager.instance.count++;
                                        break;
                                    case 2:
                                        TextManager.instance.noteAccuracyText.text = "Good";
                                        TextManager.instance.comboCount++;
                                        TextManager.instance.accuracyCount += 50.00f;
                                        TextManager.instance.count++;
                                        break;
                                    case 3:
                                        TextManager.instance.noteAccuracyText.text = "Bad";
                                        TextManager.instance.comboCount++;
                                        TextManager.instance.accuracyCount += 20.00f;
                                        TextManager.instance.count++;
                                        break;
                                    case 4:
                                        TextManager.instance.noteAccuracyText.text = "Miss";
                                        TextManager.instance.comboCount = 0;
                                        TextManager.instance.accuracyCount += 0f;
                                        TextManager.instance.count++;
                                        break;
                                }
                                return;
                            }
                        }
                    }
                    break;
                case 4:
                    for (int i = 0; i < AddNote.instance.boxNoteList4.Count; i++)
                    {

                        float t_notePosY = AddNote.instance.boxNoteList4[i].transform.position.y - 225;

                        // 판정 순서 : Perfect -> Great -> Good -> Bad
                        for (int j = 0; j < timingBoxs.Length; j++)
                        {
                            // timingBoxs[j].x 의 값이 판정 좌표 x보다 크거나 같거나
                            // timingBoxs[j].y 의 값이 판정 좌표 y보다 작거나 같으면 실행
                            if (timingBoxs[j].x <= t_notePosY && t_notePosY <= timingBoxs[j].y)
                            {
                                // 컴포넌트를 비활성화
                                if (KeyManager.instance.long4 == true)
                                {
                                    AddNote.instance.boxNoteList4[0].GetComponent<Note>().HideNote();
                                    AddNote.instance.boxNoteList4.RemoveAt(0);
                                }
                                switch (j)
                                {
                                    case 0:
                                        TextManager.instance.noteAccuracyText.text = "Perfect";
                                        TextManager.instance.comboCount++;
                                        TextManager.instance.accuracyCount += 100.00f;
                                        TextManager.instance.count++;
                                        break;
                                    case 1:
                                        TextManager.instance.noteAccuracyText.text = "Great";
                                        TextManager.instance.comboCount++;
                                        TextManager.instance.accuracyCount += 80.00f;
                                        TextManager.instance.count++;
                                        break;
                                    case 2:
                                        TextManager.instance.noteAccuracyText.text = "Good";
                                        TextManager.instance.comboCount++;
                                        TextManager.instance.accuracyCount += 50.00f;
                                        TextManager.instance.count++;
                                        break;
                                    case 3:
                                        TextManager.instance.noteAccuracyText.text = "Bad";
                                        TextManager.instance.comboCount++;
                                        TextManager.instance.accuracyCount += 20.00f;
                                        TextManager.instance.count++;
                                        break;
                                    case 4:
                                        TextManager.instance.noteAccuracyText.text = "Miss";
                                        TextManager.instance.comboCount = 0;
                                        TextManager.instance.accuracyCount += 0f;
                                        TextManager.instance.count++;
                                        break;
                                }
                                return;
                            }
                        }
                    }
                    break;
            }
        }
        else
        {
            switch (key)
            {
                case 1:
                    for (int i = 0; i < AddNote.instance.boxNoteList1.Count; i++)
                    {
                        float t_notePosY = AddNote.instance.boxNoteList1[i].transform.position.y - 225;
                        // 판정 순서 : Perfect -> Great -> Good -> Bad
                        for (int j = 0; j < timingBoxs.Length; j++)
                        {
                            // timingBoxs[j].x 의 값이 판정 좌표 x보다 크거나 같거나
                            // timingBoxs[j].y 의 값이 판정 좌표 y보다 작거나 같으면 실행
                            if (timingBoxs[j].x <= t_notePosY && t_notePosY <= timingBoxs[j].y)
                            {
                                switch (j)
                                {
                                    case 0:
                                        if (NoteMaster.instance.timer1 > NoteMaster.instance.waitingTime)
                                        {
                                            TextManager.instance.comboCount++;
                                            NoteMaster.instance.timer1 = 0;
                                        }
                                        break;
                                    case 1:
                                        if (NoteMaster.instance.timer1 > NoteMaster.instance.waitingTime)
                                        {
                                            TextManager.instance.comboCount++;
                                            NoteMaster.instance.timer1 = 0;
                                        }
                                        break;
                                    case 2:
                                        if (NoteMaster.instance.timer1 > NoteMaster.instance.waitingTime)
                                        {
                                            TextManager.instance.comboCount++;
                                            NoteMaster.instance.timer1 = 0;
                                        }
                                        break;
                                    case 3:
                                        if (NoteMaster.instance.timer1 > NoteMaster.instance.waitingTime)
                                        {
                                            TextManager.instance.comboCount++;
                                            NoteMaster.instance.timer1 = 0;
                                        }
                                        break;
                                    case 4:
                                        TextManager.instance.comboCount = 0;
                                        break;
                                }
                                return;
                            }
                        }
                    }
                    break;
                case 2:
                    for (int i = 0; i < AddNote.instance.boxNoteList2.Count; i++)
                    {

                        float t_notePosY = AddNote.instance.boxNoteList2[i].transform.position.y - 225;

                        // 판정 순서 : Perfect -> Great -> Good -> Bad
                        for (int j = 0; j < timingBoxs.Length; j++)
                        {
                            // timingBoxs[j].x 의 값이 판정 좌표 x보다 크거나 같거나
                            // timingBoxs[j].y 의 값이 판정 좌표 y보다 작거나 같으면 실행
                            if (timingBoxs[j].x <= t_notePosY && t_notePosY <= timingBoxs[j].y)
                            {
                                // 컴포넌트를 비활성화

                                switch (j)
                                {
                                    case 0:
                                        if (NoteMaster.instance.timer2 > NoteMaster.instance.waitingTime)
                                        {
                                            TextManager.instance.comboCount++;
                                            NoteMaster.instance.timer2 = 0;
                                        }
                                        break;
                                    case 1:
                                        if (NoteMaster.instance.timer2 > NoteMaster.instance.waitingTime)
                                        {
                                            TextManager.instance.comboCount++;
                                            NoteMaster.instance.timer2 = 0;
                                        }
                                        break;
                                    case 2:
                                        if (NoteMaster.instance.timer2 > NoteMaster.instance.waitingTime)
                                        {
                                            TextManager.instance.comboCount++;
                                            NoteMaster.instance.timer2 = 0;
                                        }
                                        break;
                                    case 3:
                                        if (NoteMaster.instance.timer2 > NoteMaster.instance.waitingTime)
                                        {
                                            TextManager.instance.comboCount++;
                                            NoteMaster.instance.timer2 = 0;
                                        }
                                        break;
                                    case 4:
                                        TextManager.instance.comboCount = 0;
                                        break;
                                }
                                return;
                            }
                        }
                    }
                    break;
                case 3:
                    for (int i = 0; i < AddNote.instance.boxNoteList3.Count; i++)
                    {

                        float t_notePosY = AddNote.instance.boxNoteList3[i].transform.position.y - 225;

                        // 판정 순서 : Perfect -> Great -> Good -> Bad
                        for (int j = 0; j < timingBoxs.Length; j++)
                        {
                            // timingBoxs[j].x 의 값이 판정 좌표 x보다 크거나 같거나
                            // timingBoxs[j].y 의 값이 판정 좌표 y보다 작거나 같으면 실행
                            if (timingBoxs[j].x <= t_notePosY && t_notePosY <= timingBoxs[j].y)
                            {
                                // 컴포넌트를 비활성화

                                switch (j)
                                {
                                    case 0:
                                        if (NoteMaster.instance.timer3 > NoteMaster.instance.waitingTime)
                                        {
                                            TextManager.instance.comboCount++;
                                            NoteMaster.instance.timer3 = 0;
                                        }
                                        break;
                                    case 1:
                                        if (NoteMaster.instance.timer3 > NoteMaster.instance.waitingTime)
                                        {
                                            TextManager.instance.comboCount++;
                                            NoteMaster.instance.timer3 = 0;
                                        }
                                        break;
                                    case 2:
                                        if (NoteMaster.instance.timer3 > NoteMaster.instance.waitingTime)
                                        {
                                            TextManager.instance.comboCount++;
                                            NoteMaster.instance.timer3 = 0;
                                        }
                                        break;
                                    case 3:
                                        if (NoteMaster.instance.timer3 > NoteMaster.instance.waitingTime)
                                        {
                                            TextManager.instance.comboCount++;
                                            NoteMaster.instance.timer3 = 0;
                                        }
                                        break;
                                    case 4:
                                        TextManager.instance.comboCount = 0;
                                        break;
                                }
                                return;
                            }
                        }
                    }
                    break;
                case 4:
                    for (int i = 0; i < AddNote.instance.boxNoteList4.Count; i++)
                    {

                        float t_notePosY = AddNote.instance.boxNoteList4[i].transform.position.y - 225;

                        // 판정 순서 : Perfect -> Great -> Good -> Bad
                        for (int j = 0; j < timingBoxs.Length; j++)
                        {
                            // timingBoxs[j].x 의 값이 판정 좌표 x보다 크거나 같거나
                            // timingBoxs[j].y 의 값이 판정 좌표 y보다 작거나 같으면 실행
                            if (timingBoxs[j].x <= t_notePosY && t_notePosY <= timingBoxs[j].y)
                            {
                                // 컴포넌트를 비활성화

                                switch (j)
                                {
                                    case 0:
                                        if (NoteMaster.instance.timer4 > NoteMaster.instance.waitingTime)
                                        {
                                            TextManager.instance.comboCount++;
                                            NoteMaster.instance.timer4 = 0;
                                        }
                                        break;
                                    case 1:
                                        if (NoteMaster.instance.timer4 > NoteMaster.instance.waitingTime)
                                        {
                                            TextManager.instance.comboCount++;
                                            NoteMaster.instance.timer4 = 0;
                                        }
                                        break;
                                    case 2:
                                        if (NoteMaster.instance.timer4 > NoteMaster.instance.waitingTime)
                                        {
                                            TextManager.instance.comboCount++;
                                            NoteMaster.instance.timer4 = 0;
                                        }
                                        break;
                                    case 3:
                                        if (NoteMaster.instance.timer4 > NoteMaster.instance.waitingTime)
                                        {
                                            TextManager.instance.comboCount++;
                                            NoteMaster.instance.timer4 = 0;
                                        }
                                        break;
                                    case 4:
                                        TextManager.instance.comboCount = 0;
                                        break;
                                }
                                return;
                            }
                        }
                    }
                    break;
            }
        }
    }



}