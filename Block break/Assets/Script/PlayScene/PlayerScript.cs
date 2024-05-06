using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerScript : MonoBehaviour
{ 
    [SerializeField] Rigidbody rb = default!;
    [SerializeField] DirectorScript director = default!;
    [SerializeField] float mySpeed = 20f;

    bool isEnableToShot = true;
    //[SerializeField]
    //private float bounce = 10f;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(Input.GetAxis("Horizontal") * mySpeed, 0f, 0f);

        if (Input.GetKeyDown(KeyCode.Space) && isEnableToShot)
        {
            director.ShootBall(this.transform.position);
            isEnableToShot = false;
        }
    }

    public void EnableToShot()
    {
        isEnableToShot = true;
    }
}