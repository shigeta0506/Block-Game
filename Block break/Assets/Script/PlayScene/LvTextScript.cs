using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LvTextScript : MonoBehaviour
{
    [SerializeField] Text text = default!;

    // 0以下の時はおめでとうと表示
    public void SetLevel(int level)
    {
        if (level <= 0)
        {
            text.text = "おめでとう";
        }
        else
        {
            text.text = string.Format("Lv：{0}", level);
        }
    }
}
