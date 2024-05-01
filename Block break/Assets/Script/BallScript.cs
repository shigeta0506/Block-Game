using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{

    public float speed = 5f;
    Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = new Vector3(speed, speed, 0f);

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 velocity = rigidbody.velocity;
        float currentspeed = velocity.magnitude;
       

        if (currentspeed != speed)
        {
            velocity = velocity.normalized * speed;
            rigidbody.velocity = velocity;
        }

    }
}
