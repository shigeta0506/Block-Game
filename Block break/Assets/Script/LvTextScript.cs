using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LvTextScript : MonoBehaviour
{
    [SerializeField] LvScript lv;
    [SerializeField] public GameObject endButton;
    [SerializeField] PlayerScript playerScript;
    public Text TextFrame;
    public Text gameclearMessage;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (lv.Lv <= 3)
        {
            TextFrame.text = string.Format("LvF{0}", lv.Lv);
        }
        else
        {
            TextFrame.text = string.Format("‚¨‚ß‚Å‚Æ‚¤");
            gameclearMessage.text = "Game Clear";
            playerScript.count = 1;
            endButton.SetActive(true);
        }
    }
}