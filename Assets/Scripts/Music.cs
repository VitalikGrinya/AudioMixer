using UnityEngine;

public class Music : MonoBehaviour
{
    public bool _isPlaying = false;
    public AudioSource _audio;

    public void Playing()
    {
        if(_isPlaying == false)
        {
            _audio.Play();
            _isPlaying = true;
        }
        else
        {
            _audio.Stop();
            _isPlaying = false;
        }
    }
}
