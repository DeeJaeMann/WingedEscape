using System;
using UnityEngine;


public class PipeController : MonoBehaviour
{
    // When this pipe is past this left bound, it will respawn
    public float leftXBound = -10;
    // When this pipe respawns, it will appear at this right bound
    public float rightXBound = 20;

    public int variationY = 1;
    // The pipe moves this many units per second
    public float speed = -2;

    public GameObject player;
    public Vector3 originalPosition = new(20, 0, 0);

    // Update is called once every frame
    public void Update()
    {
        if ( player != null)
        { 
            // Move on the x axis every frame
            transform.Translate(speed * Time.deltaTime, 0, 0);

            // This is an if statement! It will only run the code inside its body if the condition is has is true.
            // In this case, it will only run if this pipe controller moved past the left bound
            if (transform.position.x < leftXBound)
            {
                Vector3 newPosition = transform.position;
                newPosition.x = rightXBound;
                newPosition.y = UnityEngine.Random.Range(-variationY, variationY);
                transform.position = newPosition;
            }
        }
        else
        {

            if (transform.position.x < rightXBound)
            {
                transform.Translate(-(speed * Time.deltaTime), 0, 0);
            }

        }
    }
}
