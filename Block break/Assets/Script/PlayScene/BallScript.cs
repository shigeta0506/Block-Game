using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BallScript : MonoBehaviour
{
    public float speed = 5f;
    [SerializeField] Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = new Vector3(speed, speed, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = rb.velocity.normalized * speed;
    }
}
