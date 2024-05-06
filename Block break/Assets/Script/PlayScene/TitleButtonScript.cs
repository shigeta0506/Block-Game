using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleButtonScript : MonoBehaviour
{
    public void TitleButton()
    {
        SceneManager.LoadScene("TitleScene");
    }
}
