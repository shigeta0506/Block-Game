using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockScript : MonoBehaviour
{
    [SerializeField] CountScript count;
    [SerializeField] PointTextScript point;
    [SerializeField] PlayerScript player;
    [SerializeField] LvScript lv;
    private int destroycount = 0;
    private int Blockdestroy = 0;
    // Start is called before the first frame update
    void Start()
    {
        destroycount = 6 * lv.Lv - 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        //何回ブロックにあたったか
        count.allcount++;
        //得点の加算
        point.point += 100; 
        Blockdestroy++;
        //6回以上になったらボールごと消える
        if(count.allcount > destroycount)
        {
            player.count = 0;
            count.allcount = 0;
            lv.Lv++;
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        if (Blockdestroy == lv.Lv)
        {
            Destroy(gameObject);
        }
        //Debug.Log(count.allcount);
        Debug.Log(destroycount);
    }
}
