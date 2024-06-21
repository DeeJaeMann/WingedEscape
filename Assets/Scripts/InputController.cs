using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    public Jumper controlledJumper;

    public AudioSource audioData;

    // Start is called before the first frame update
    void Start()
    {
        audioData = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetMouseButtonDown(0) )
        {
            controlledJumper.Jump();

            // Plays the jump sound if the player is not null
            if (audioData != null)
            { 
                audioData.Play();
            }
        }
    }
}
