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
        var input = Game.Input.Controls;

        var x_component = input.Shifting.ReadValue<float>();
        Debug.Log("Shift" + x_component);
        if(Input.GetKeyDown(KeyCode.LeftShift))
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

    public void Swapped()
    {
        if(isSwapped)
            {
                Back();
            }
            else
            {
                Swap();
            }
            Debug.Log("fart");
    }
}
