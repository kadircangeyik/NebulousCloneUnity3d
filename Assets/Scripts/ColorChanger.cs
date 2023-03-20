using UnityEngine;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour
{
    public Slider slider;
    public Image image;

    void Start()
    {
        image.color = Color.HSVToRGB(slider.value, 1, 1);
        slider.onValueChanged.AddListener(delegate { SetColor(); });
    }

    void SetColor()
    {
        image.color = Color.HSVToRGB(slider.value, 1, 1);
    }

    private void OnDisable()
    {
        PlayerPrefs.SetFloat("color", slider.value);
    }
}
