using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class HighscoreTable : MonoBehaviour
{
    private Color evenColor;

    public Transform container;
    public Transform item;
    public List<ScoreboardItem> scoreboardList;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        LoadScoreboard();
        if (scoreboardList.Count > 0)
        {
            scoreboardList.Sort((x, y) => y.time.CompareTo(x.time));
            evenColor = new Color(0.5803922f, 0f, 0.6705883f, 0.7f);
            for (int i = 0; i < scoreboardList.Count; i++)
            {
                Transform enteryTransform = Instantiate(item, container);
                if (i % 2 == 1)
                    enteryTransform.gameObject.GetComponent<Image>().color = evenColor;
                enteryTransform.GetChild(0).gameObject.GetComponent<Text>().text = scoreboardList[i].name;
                enteryTransform.GetChild(1).gameObject.GetComponent<Text>().text = scoreboardList[i].score.ToString();
            }
        }
    }

    void LoadScoreboard()
    {
        if (File.Exists(Application.persistentDataPath + "/Scoreboard.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file =
              File.Open(Application.persistentDataPath
              + "/Scoreboard.dat", FileMode.Open);
            scoreboardList = bf.Deserialize(file) as List<ScoreboardItem>;
            file.Close();
        }
    }

    public void SaveScoreboard()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/Scoreboard.dat");
        bf.Serialize(file, scoreboardList);
        file.Close();
    }
}

[Serializable]
public class ScoreboardItem
{
    public uint score;
    public string name;
    public DateTime time;
}
