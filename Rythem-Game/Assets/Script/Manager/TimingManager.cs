using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimingManager : MonoBehaviour
{
    public List<GameObject> boxNoteList = new List<GameObject>();


    public static TimingManager instance;
    [SerializeField] Transform center = null; // ���� ������ �߽�
    [SerializeField] RectTransform[] timingRect = null; // �پ��� ���� ����
    Vector2[] timingBoxs = null; // ���� ���� �ּҰ� x, �ִ밪 y
    void Start()
    {
        instance = this;
        timingBoxs = new Vector2[4];
        // timingBoxs �迭 4�� ����

        for (int i = 0; i < 4; i++)
        {
            // center.localPosition.y - timingRect[i].rect.height / 2�� X��ǥ ��
            // center.localPosition.y + timingRect[i].rect.height / 2�� Y��ǥ ��
            timingBoxs[i].Set(center.localPosition.y - timingRect[i].rect.height / 2,
                              center.localPosition.y + timingRect[i].rect.height / 2);
        }
    }

    public void CheckTiming()
    {

        for (int i = 0; i < boxNoteList.Count; i++)
        {
            //boxNoteList[i]�� ���� �ڱ� �ڽ��� ��ġ�� - �θ��� ��ġ���� �ش�
            float t_notePosY = boxNoteList[i].transform.localPosition.y;

            // ���� ���� : Perfect -> Great -> Good -> Bad
            for (int j = 0; j < timingBoxs.Length; j++)
            {
                // timingBoxs[j].x �� ���� ���� ��ǥ x���� ũ�ų� ���ų�
                // timingBoxs[j].y �� ���� ���� ��ǥ y���� �۰ų� ������ ����
                if (timingBoxs[j].x <= t_notePosY && t_notePosY <= timingBoxs[j].y)
                {
                    // ������Ʈ�� ��Ȱ��ȭ
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