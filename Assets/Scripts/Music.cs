using UnityEngine.UI;
using UnityEngine;

public class Music : MonoBehaviour
{
    public bool _isPlaying = false;
    public AudioSource _audio;

    public void SettingMusic()
    {
        if(_isPlaying == false)
        {
            _audio.Play();
            _isPlaying = true;
        }
        else if(_isPlaying == true)
        {
            _audio.Stop();
            _isPlaying = false;
        }
    }
}
