using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "AudioSettings", menuName = "Custom/AudioSettings", order = 1)]
public class AudioSettings : ScriptableObject
{
    // Event
    public Action OnVolumeChanged = delegate { };

    private float _volume = 0.0f;
    // Property
    public float volume
    {
        get
        {
            return _volume;
        }
        set
        {
            if(value != _volume)
            {
                _volume = value;
                OnVolumeChanged();
            }
            _volume = value;
        }
    }
}
