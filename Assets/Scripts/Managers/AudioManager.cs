using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
   
    public AudioSource musicSource;
    public AudioClip musicClip;

    public AudioSource SpecialEffect;
    public AudioClip SpecialEffectClip;

    public static AudioManager instance = null;
    
  

    public void Start()
    {

        musicSource.clip = musicClip;

        SpecialEffect.clip = SpecialEffectClip;

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
        SpecialEffect.clip = clip;

        SpecialEffect.Play();
    }

}


