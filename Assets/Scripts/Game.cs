using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Game : MonoBehaviour
{
    public static PlayerControls Input { get; private set; }
    // Start is called before the first frame update
    void Start()
    {
        Input = new PlayerControls();
        Input.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
