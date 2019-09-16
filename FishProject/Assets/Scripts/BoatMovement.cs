using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatMovement : MonoBehaviour
{
    public float speed;
    public float turnspeed;
    void Start ()
    {
    }

    void FixedUpdate ()
    {
        transform.Translate(0f,
                            0f,
                            speed*Input.GetAxis("Vertical")*Time.deltaTime); 
        transform.Rotate(0f,
                         turnspeed*Input.GetAxis("Horizontal")*Time.deltaTime,
                         0f);
    }
}
