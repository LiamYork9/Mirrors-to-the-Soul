using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DeathScreen : MonoBehaviour
{
    public string gameSceneName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Retry()
    {
        GameManager.Instance.swapped = false;
        GameManager.Instance.isSwapped = false;
         GameManager.Instance.doNOtShift = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void TurnOn()
    {
        gameObject.SetActive(true);
    }

    public void TurnOff()
    {
        gameObject.SetActive(false);
    }

    public void Quit()
    {
        GameManager.Instance.doNOtShift = false;
        Time.timeScale = 1.0f;
         SceneManager.LoadScene(gameSceneName);
    }
}
