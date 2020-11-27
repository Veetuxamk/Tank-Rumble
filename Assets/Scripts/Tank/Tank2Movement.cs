using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank2Movement : MonoBehaviour
{

    public float m_Speed = 12f;

    public AudioSource m_MovementAudio;
    public AudioClip m_EngineIdling;

    public float m_PitchRange = 0.2f;

    private float idleSpeed = 0;

    private Rigidbody m_Rigidbody;              // Reference used to move the tank.

    private float m_OriginalPitch;              // The pitch of the audio source at the start of the scene.

    private void Awake()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }
    private void OnEnable()
    {
        // When the tank is turned on, make sure it's not kinematic.
        m_Rigidbody.isKinematic = false;
    }


    private void OnDisable()
    {
        // When the tank is turned off, set it to kinematic so it stops moving.
        m_Rigidbody.isKinematic = true;
    }


    private void Start()
    {

        // Store the original pitch of the audio source.
        m_OriginalPitch = m_MovementAudio.pitch;
    }


    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
            transform.Translate(Vector3.forward * m_Speed * Time.deltaTime);
        }

        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.eulerAngles = new Vector3(0f, 180f, 0f);
            transform.Translate(Vector3.forward * m_Speed * Time.deltaTime);

        }

        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.eulerAngles = new Vector3(0f, -90f, 0f);
            transform.Translate(Vector3.forward * m_Speed * Time.deltaTime);
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.eulerAngles = new Vector3(0f, 90f, 0f);
            transform.Translate(Vector3.forward * m_Speed * Time.deltaTime);
        }

    }

}