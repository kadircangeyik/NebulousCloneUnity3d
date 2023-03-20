using System;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class PrefSaver : MonoBehaviour
{
    private float musicVolume;
    private float playerColor;
    private string nickname;

    public Slider colorSlider;
    public Slider musicSlider;
    public InputField nameField;

    void Start()
    {
        playerColor = 0;
        musicVolume = 0.5f;
        nickname = "agar";
        LoadGame();
        colorSlider.onValueChanged.AddListener(delegate { SetColor(); });
        musicSlider.onValueChanged.AddListener(delegate { SetMusicVolume(); });
        nameField.onValueChanged.AddListener(delegate { SetNickname(); });
        nameField.placeholder.gameObject.GetComponent<Text>().text = nickname;
    }

    public void SaveGame()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/Preferences.dat");
        SaveData data = new SaveData();
        data.playerColor = playerColor;
        data.musicVolume = musicVolume;
        data.nickname = nickname;
        bf.Serialize(file, data);
        file.Close();
    }

    void SetColor()
    {
        playerColor = colorSlider.value;
    }

    void SetMusicVolume()
    {
        musicVolume = musicSlider.value;
    }

    void SetNickname()
    {
        nickname = nameField.text;
    }

    private void OnDisable()
    {
        SaveGame();
        PlayerPrefs.SetString("nickname", nickname);
    }

    void LoadGame()
    {
        if (File.Exists(Application.persistentDataPath + "/Preferences.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file =
              File.Open(Application.persistentDataPath
              + "/Preferences.dat", FileMode.Open);
            SaveData data = (SaveData)bf.Deserialize(file);
            file.Close();
            playerColor = data.playerColor;
            musicVolume = data.musicVolume;
            nickname = data.nickname;
            colorSlider.SetValueWithoutNotify(playerColor);
            musicSlider.SetValueWithoutNotify(musicVolume);
        }
    }
}

[Serializable]
class SaveData
{
    public float playerColor;
    public float musicVolume;
    public string nickname;
}
