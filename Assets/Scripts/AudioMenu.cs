using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioMenu : MonoBehaviour
{
    [SerializeField]
    AudioSource music;
    [SerializeField]
    public enum tipo {
        Playmusic,
        Stopmusic,
        Pausemusic
    }
    [SerializeField]
    tipo Estado;
    void OnTriggerStay(Collider other)
    {
        switch (Estado){
            case tipo.Playmusic: 
            music.Play();
            break;
            case tipo.Stopmusic:
            music.Stop();
            break;
            case tipo.Pausemusic:
            music.Pause();
            break;
       }
    }
}
