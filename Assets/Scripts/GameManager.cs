using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private AudioManager audioManager;

    private bool gameOver = false;
    public bool IsGameOver() { return gameOver; }
    public AudioManager GetAudioManager() { return audioManager; }

    void Start()
    {
        audioManager = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
