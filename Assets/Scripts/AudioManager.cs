using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour
{

    public AudioClip level1Music;
    public AudioClip level2Music;

    void Awake() {
        DontDestroyOnLoad(transform.gameObject);
    }

    public void PlayLevel1Back()
    {
        audio.clip = level1Music;
        audio.Play();
    }
    
}
