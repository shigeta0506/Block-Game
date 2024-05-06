using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PointTextScript : MonoBehaviour
{
    [SerializeField] Text text = default!;

    public void SetPoint(int point)
    {
        text.text = string.Format("得点：{0}", point);
    }
}
