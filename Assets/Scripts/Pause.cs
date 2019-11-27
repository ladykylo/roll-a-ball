using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject pausePanel;

    bool isPause;

    // Start is called before the first frame update
    void Start()
    {
        pausePanel.SetActive(false);
        isPause = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPause)
            {
                MenuContinue();
            }
            else
            {
                MenuPause();
            }
            
        }
    }

   public void MenuPause()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0;
        isPause = true;
    }

   public void MenuContinue()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1;
        isPause = false;
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
