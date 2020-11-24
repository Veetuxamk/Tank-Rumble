using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource efxSource;

    public AudioSource musicSource;

    public AudioSource fireSource;

    public AudioSource engineSource;




    public AudioClip efxClip;

    public AudioClip musicClip;

    public AudioClip fireClip;

    public AudioClip engineClip;


    public static AudioManager instance = null;
    
    public float lowePitchRange = .95f;

    public float highPitchRange = 1.05f;

    public void Start()
    {

        musicSource.clip = musicClip;

        efxSource.clip = efxClip;

        engineSource.clip = engineClip;

        fireSource.clip = fireClip;



    }
    private void Awake()
    {
        if(instance == null)
        {instance = this;}

        else if (instance != this)
        { Destroy(gameObject); }

        DontDestroyOnLoad(gameObject);
    }

public void PlaySingle(AudioClip clip)
    {
        efxSource.clip = clip;

        efxSource.Play();
    }

}


