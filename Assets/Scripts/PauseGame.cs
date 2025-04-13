using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public GameObject pause;

    public bool isPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if((Input.GetKeyDown(KeyCode.Escape)) || (Input.GetKeyDown(KeyCode.JoystickButton9)))
        {
             if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }

        }
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        isPaused = false;
        pause.SetActive(false);
    }

    public void Pause()
    {
        Time.timeScale = 0.0f;
        isPaused = true;
        pause.SetActive(true);
    }
}
