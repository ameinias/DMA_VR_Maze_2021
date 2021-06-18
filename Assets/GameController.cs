using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    static GameController singleton;
    public static bool hasKey = false;
    public GameObject keyIcon;
    public GameObject gameOverPanel;
    

    // Start is called before the first frame update
    void Start()
    {
        singleton = this;
        hasKey = false;
        keyIcon.SetActive(false);
        gameOverPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            Application.Quit();
        }
    
    }

    public static void KeyIcon(bool value)
    {
        singleton.keyIcon.SetActive(value);

    }

    public void Restart()
    {

        Application.Quit();
    }

    public void Win()
    {
        gameOverPanel.SetActive(true);
    }

}
