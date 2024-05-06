using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WallBottomScript : MonoBehaviour
{
    [SerializeField] DirectorScript director;

    void OnCollisionEnter(Collision collision)
    {
        director.FallBall();
    }
}
