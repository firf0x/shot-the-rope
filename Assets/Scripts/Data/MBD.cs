using System.Collections.Generic;
using UnityEngine;

public class MBD : MonoBehaviour
{
    private void OnApplicationQuit()
    {
        Data.Instance.Save();
        Debug.Log("Сохранил");
    }
}

[System.Serializable]
public class Data
{
    public int xp;
    public string rank;
    public List<bool> skins;

    private static Data _instance;

    public static Data Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = Load();
            }
            return _instance;
        }
    }

    private Data()
    {
        xp = 0;
        rank = "тут будет enum";
        skins = new List<bool>();
    }

    private static Data Load()
    {
        string jsonString = PlayerPrefs.GetString("PlayerData");
        if (!string.IsNullOrEmpty(jsonString))
        {
            return JsonUtility.FromJson<Data>(jsonString);
        }
        else
        {
            return new Data();
        }
    }

    public void Save()
    {
        string jsonString = JsonUtility.ToJson(this);
        PlayerPrefs.SetString("PlayerData", jsonString);
        PlayerPrefs.Save();
    }
}
