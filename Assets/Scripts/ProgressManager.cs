using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class ProgressManager : MonoBehaviour
{
    [System.Serializable]
    public class PlayerData
    {
        public int currentlevel = 1;
        public List<string> unlockedExtras = new List<string>();
    }

    public PlayerData myData = new PlayerData();
    private string savePath;

    void Awake()
    {
        savePath = Application.persistentDataPath + "/save.json";
        LoadProgress();
    }

    public void SaveProgress()
    {
        string json = JsonUtility.ToJson(myData, true);
        File.WriteAllText(savePath, json);
        Debug.Log("Saved progrs to:" + savePath);
    }

    public void LoadProgress()
    {
        if (File.Exists(savePath))
        {
            string json = File.ReadAllText(savePath);
            myData =  JsonUtility.FromJson<PlayerData>(json);
            Debug.Log("Game loaded sucessfuly");
        }
    }
}
