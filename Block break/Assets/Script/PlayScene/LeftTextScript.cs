using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeftTextScript : MonoBehaviour
{
    [SerializeField] Text text = default!;

    public void SetLeft(int left)
    {
        text.text = string.Format("残機：{0}", left);        
    }
}
