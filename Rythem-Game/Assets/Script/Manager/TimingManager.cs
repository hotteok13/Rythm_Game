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
    void Start()
    {
        instance = this;
        timingBoxs = new Vector2[4];
        // timingBoxs 배열 4개 생성

        for (int i = 0; i < 4; i++)
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
                            Debug.Log("Perfect");
                            break;
                        case 1:
                            Debug.Log("Great");
                            break;
                        case 2:
                            Debug.Log("Good");
                            break;
                        case 3:
                            Debug.Log("Bad");
                            break;
                    }
                    return;
                }

            }
        }

        Debug.Log("Miss");
    }
    

}