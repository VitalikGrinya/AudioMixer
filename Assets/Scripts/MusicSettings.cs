using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicSettings : MonoBehaviour
{
    public AudioMixerGroup Mixer;

    public void ToggleMusic(bool isPlaying)
    {
        if (isPlaying)
            Mixer.audioMixer.SetFloat("BackgroundVolume", -80);
        else
            Mixer.audioMixer.SetFloat("BackgroundVolume", 0);
    }

    public void ChangeMasterVolume(float volume)
    {
        Mixer.audioMixer.SetFloat("MasterVolume", Mathf.Lerp(-80, 0, volume));
    }

    public void ChangeMelodyVolume(float volume)
    {
        Mixer.audioMixer.SetFloat("MusicVolume", Mathf.Lerp(-80, 0, volume));
    }

    public void ChangeBackgroundVolume(float volume)
    {
        Mixer.audioMixer.SetFloat("BackgroundVolume", Mathf.Lerp(-80, 0, volume));
    }
}
