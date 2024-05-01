using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameoverScript : MonoBehaviour
{
    [SerializeField] PlayerScript player;
    [SerializeField] public GameObject endButton;
    public int gameovercount = 2;
    public Text gameOverMessage;
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
        if (gameovercount > 0)
        {
            player.count = 0;
            gameovercount--;
        }
        else
        {
            gameOverMessage.text = "Game Over";
           endButton.SetActive(true);
        }

        Destroy(collision.gameObject);
    }
}
