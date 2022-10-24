using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    public int comboCount;
    public int count;
    public float accuracyCount;
    public float accuracy;

    [SerializeField] Text comboText;
    [SerializeField] Text accuracyText;
    public  Text noteAccuracyText;

    
    public static TextManager instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        accuracyCount = 0.0f;
        comboCount = 0;
        count = 0;
        accuracy = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (count == 0)
        {
            accuracyText.text = accuracy.ToString("F2")+"%";
            comboText.text = comboCount.ToString();
        }
        else
        {
            accuracy = accuracyCount / count;
            accuracyText.text = accuracy.ToString("F2") + "%";
            comboText.text = comboCount.ToString();
        }
    }

    
}
