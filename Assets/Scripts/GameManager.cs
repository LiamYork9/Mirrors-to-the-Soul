using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public bool swapped = false;

    public bool isSwapped = false;
    public static GameManager Instance { get; private set; } = null;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(isSwapped)
            {
                Back();
            }
            else
            {
                Swap();
            }
        }
       
    }

    public void Swap()
    {
        swapped = true;
        isSwapped = true;
    }

    public void Back()
    {
        swapped = false;
        isSwapped = false;
    }
}
