using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockScript : MonoBehaviour
{
    [SerializeField] DirectorScript director;
    private int hit_count = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        //得点の加算
        director.HitBlock(); 

        // レベルの回数だけ当たったらブロックを消す
        if (director.GetLevel() <= ++hit_count)
        {
            director.BreakBlock();
            Destroy(gameObject);
        }
    }
}
