using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallleftScript : MonoBehaviour
{
    [SerializeField]
    private float bounce = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        // 当たった相手のRigidbodyのx軸方向に力を加える。
        // 今回はx軸のマイナス方向に力を加えて跳ね返す。
        collision.rigidbody.AddForce(bounce, 0f, 0f, ForceMode.Impulse);
    }
}
