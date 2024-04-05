using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicSettings : MonoBehaviour
{
    public AudioMixerGroup Mixer;

    private float _minVolumeValue = -80;
    private float _maxVolumeValue = 0;


    public void ToggleMusic(bool isPlaying)
    {
        if (isPlaying)
            Mixer.audioMixer.SetFloat("BackgroundVolume", _minVolumeValue);
        else
            Mixer.audioMixer.SetFloat("BackgroundVolume", _maxVolumeValue);
    }

    public void ChangeMasterVolume(float volume)
    {
        Mixer.audioMixer.SetFloat("MasterVolume", Mathf.Lerp(_minVolumeValue, _maxVolumeValue, volume));
    }

    public void ChangeMelodyVolume(float volume)
    {
        Mixer.audioMixer.SetFloat("MusicVolume", Mathf.Lerp(_minVolumeValue, _maxVolumeValue, volume));
    }

    public void ChangeBackgroundVolume(float volume)
    {
        Mixer.audioMixer.SetFloat("BackgroundVolume", Mathf.Lerp(_minVolumeValue, _maxVolumeValue, volume));
    }
}
