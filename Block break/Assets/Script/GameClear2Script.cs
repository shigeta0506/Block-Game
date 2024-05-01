using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameClear2Script : MonoBehaviour
{
    [SerializeField] LvScript lv;
    [SerializeField] public GameObject[] childObjects;
    public int flag = 2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //レベルがflagになったらそれに応じたブロックを出現させる
        if (lv.Lv == flag)
        {
            foreach (GameObject child in childObjects)
            {
                if (child != null)
                {
                    child.SetActive(true);
                }
            }
        }

    }
}