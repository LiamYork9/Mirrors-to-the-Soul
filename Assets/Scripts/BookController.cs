using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class BookController : MonoBehaviour
{
    public float dead_zone;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var input = Game.Input.Controls;
        float x_movement = 0.0f;
        float y_movement = 0.0f;

        //This is sort of a hardcoded deadzone
        if(input.AimBookRight.ReadValue<float>() < -dead_zone || input.AimBookRight.ReadValue<float>() > dead_zone)
        {
            x_movement = (input.AimBookRight.ReadValue<float>());
        }
        if(input.AimBookUp.ReadValue<float>() < -dead_zone || input.AimBookUp.ReadValue<float>() > dead_zone)
        {
            y_movement = (input.AimBookUp.ReadValue<float>());
        }

        float angle = Mathf.Atan2(x_movement, y_movement) * Mathf.Rad2Deg;

        if((x_movement != 0) || (y_movement != 0))
        {
            transform.rotation = Quaternion.Euler(0, 0, 360-angle);
        }
    }
}
