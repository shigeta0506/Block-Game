using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndButtonScript : MonoBehaviour
{
    public void ClickEndButton()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
