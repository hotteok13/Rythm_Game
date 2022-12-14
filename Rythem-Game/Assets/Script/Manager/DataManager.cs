using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Data
{
    public int money;
}

public class DataManager : MonoBehaviour
{
    public static DataManager instance;

    public Data data = new Data();
    public Note note = new Note();

    private void Awake()
    {
        Load();
    }

    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        //파일 생성
        // 모바일, PC, WebGl 해당 경로가 정확하게 배치되어서 저장시켜줍니다.
        
        //현재 PC의 경로에 저장 Json
        
    }

    private void Update()
    {
        
        
    }

    public void Save()
    {
        string json = JsonUtility.ToJson(note);

        //암호화
        byte[] bytes = System.Text.Encoding.UTF8.GetBytes(json);
        string code = System.Convert.ToBase64String(bytes);

        File.WriteAllText(Application.persistentDataPath + "/GameData.json",json);
    }

    public void Load()
    {
        string jsonData = File.ReadAllText(Application.persistentDataPath + "GameData.json");

        byte[] bytes = System.Convert.FromBase64String(jsonData);
        string code = System.Text.Encoding.UTF8.GetString(bytes);

        note = JsonUtility.FromJson<Note>(jsonData);
    }

}
