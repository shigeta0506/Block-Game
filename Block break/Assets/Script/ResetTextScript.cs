using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetTextScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Text myText = GetComponent<Text>();
        myText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
