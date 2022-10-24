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
        // timingBoxs �迭 5�� ����

        for (int i = 0; i < 5; i++)
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