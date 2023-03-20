using UnityEngine;
using UnityEngine.UI;

public class VolumeChanger : MonoBehaviour
{
    private AudioSource audioSrc;
    private float musicVolume;

    public Slider slider;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
        musicVolume = slider.value;
        audioSrc.volume = musicVolume;
    }

    public void SetVolume(float volume)
    {
        musicVolume = volume;
        audioSrc.volume = musicVolume;
    }

    public void Mute(bool mute)
    {
        if (mute)
        {
            audioSrc.volume = 0;
            slider.SetValueWithoutNotify(0);
        }
        else
            slider.value = musicVolume;
    }
}
