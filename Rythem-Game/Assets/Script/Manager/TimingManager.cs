using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimingManager : MonoBehaviour
{
    public List<GameObject> boxNoteList = new List<GameObject>();


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

    public void CheckTiming()
    {

        for (int i = 0; i < boxNoteList.Count; i++)
        {
            //boxNoteList[i]에 값을 자기 자신의 위치값 - 부모의 위치값을 준다
            float t_notePosY = boxNoteList[i].transform.localPosition.y;

            // 판정 순서 : Perfect -> Great -> Good -> Bad
            for (int j = 0; j < timingBoxs.Length; j++)
            {
                // timingBoxs[j].x 의 값이 판정 좌표 x보다 크거나 같거나
                // timingBoxs[j].y 의 값이 판정 좌표 y보다 작거나 같으면 실행
                if (timingBoxs[j].x <= t_notePosY && t_notePosY <= timingBoxs[j].y)
                {
                    // 컴포넌트를 비활성화
                    boxNoteList[i].GetComponent<Note>().HideNote();
                    boxNoteList.RemoveAt(i);

                    switch (j)
                    {
                        case 0:
                            TextManager.instance.noteAccuracyText.text = "Perfect";
                            TextManager.instance.comboCount++;
                            TextManager.instance.accuracyCount += 100.00f;
                            TextManager.instance.count++;
                            break;
                        case 1:
                            TextManager.instance.noteAccuracyText.text="Great";
                            TextManager.instance.comboCount++;
                            TextManager.instance.accuracyCount += 80.00f;
                            TextManager.instance.count++;
                            break;
                        case 2:
                            TextManager.instance.noteAccuracyText.text="Good";
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
                            TextManager.instance.comboCount=0;
                            TextManager.instance.accuracyCount += 0f;
                            TextManager.instance.count++;
                            break;
                    }
                    return;
                }

            }
        }
    }
    

}