using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Wintext : MonoBehaviour
{
    public WormControler PlayerA;
    public WormControler PlayerB;
    public Text WinText;

    // Start is called before the first frame update
    void Start()
    {
        WinText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerA.health == 0)
        {
            WinText.enabled = true;
            WinText.text = "Blau gewinnt!";
            Invoke("LoadMainscene", 3f);
        }
        else if (PlayerB.health == 0)
        {
            WinText.enabled = true;
            WinText.text = "Rot gewinnt!";
            Invoke("LoadMainscene", 3f);
        }
    }
    void LoadMainscene()
    {
        SceneManager.LoadScene("MainScene");
    }
}
