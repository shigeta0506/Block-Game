using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PointTextScript : MonoBehaviour
{
    public Text TextFrame;
    public int point = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TextFrame.text = string.Format("ìæì_ÅF{0}",point);
    }
}
