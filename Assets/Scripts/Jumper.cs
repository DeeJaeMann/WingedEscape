using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    // variables for a Rigidbody2D and a float that we can set in the inspector
    // public means it is shown in the inspector
    // "Rigidbody2D" and "float" are the type of variable
    // "body" and "jumpAmount" are the custom names we give the variables
    public Rigidbody2D body;
    public float jumpAmount = 5;

    private void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    public void Jump()
    {
        body.velocity = new Vector2(0, jumpAmount);
    }
}
