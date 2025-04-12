using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class GameManager : MonoBehaviour
{

    public bool swapped = false;

    public bool isSwapped = false;

    PlayerControls gamepad;
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
    gamepad = new PlayerControls();

    gamepad.Controls.Shifting.performed += ctx => Swapped();

    }
    public void Update()
    {
        if((Input.GetKeyDown(KeyCode.LeftShift)) || (Input.GetKeyDown(KeyCode.JoystickButton4)))
        {
            Swap();
        }
       
    }

    public void Swap()
    {
        swapped = !swapped;
        isSwapped = !isSwapped;
    }
}
