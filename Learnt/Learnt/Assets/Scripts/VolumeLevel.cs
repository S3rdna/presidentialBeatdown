using UnityEngine;
using System.Collections;
using UnityEngine.UI; // Required when Using UI elements.

public class VolumeLevel : MonoBehaviour
{
    public Slider mainSlider;
    public AudioSettings aud;

    public void Start()
    {
        mainSlider = GetComponent <Slider>();
        mainSlider.onValueChanged.AddListener(delegate { ValueChangeCheck(); });
    }

    public void ValueChangeCheck()
    {
        Debug.Log(mainSlider.value);
        aud.volume = mainSlider.value;
    }
}
