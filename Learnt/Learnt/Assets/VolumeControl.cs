using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeControl : MonoBehaviour
{
    private AudioSource myAudioSource;
    public AudioSettings audioSettings;

    private void OnEnable()
    {
        myAudioSource = GetComponent<AudioSource>();
        UpdateVolume();

        // Subscribe to event.
        audioSettings.OnVolumeChanged += UpdateVolume;
    }
    private void OnDisable()
    {
        // Unsubscribe to event.
        audioSettings.OnVolumeChanged += UpdateVolume;
    }

    private void UpdateVolume()
    {
        myAudioSource.volume = audioSettings.volume;
    }
}
