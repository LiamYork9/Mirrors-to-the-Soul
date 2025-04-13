using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class GameManager : MonoBehaviour
{

    public bool swapped = false;

    public bool isSwapped = false;

    public AudioSource audioSrc;

    PlayerControls gamepad;
    public static GameManager Instance { get; private set; } = null;
    private void Awake()
    {
        audioSrc = GetComponent<AudioSource>();
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
        if((Input.GetKeyDown(KeyCode.LeftShift)) || (Input.GetKeyDown(KeyCode.JoystickButton4)))
        {
            SoundManager.Play(SoundType.SWAP);
            Swap();
        }
       
    }

    public void Swap()
    {
        swapped = !swapped;
        isSwapped = !isSwapped;
    }
}
