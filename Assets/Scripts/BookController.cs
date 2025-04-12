using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class BookController : MonoBehaviour
{
    public float dead_zone;
    public GameObject spellPrefab;
    public Transform spawnPt;

    // Start is called before the first frame update
    void Start()
    {
        x_component = 0.0f;
        y_component = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        var input = Game.Input.Controls;
        float x_movement = 0.0f;
        float y_movement = 0.0f;


        x_movement = input.AimBookX.ReadValue<float>();
        y_movement = input.AimBookY.ReadValue<float>();

        if ((input.AimBookRight.ReadValue<float>() != 0) && (input.AimBookLeft.ReadValue<float>() == 0))
        {
            x_component = input.AimBookRight.ReadValue<float>();
        }
        else if ((input.AimBookLeft.ReadValue<float>() != 0) && (input.AimBookRight.ReadValue<float>() == 0))
        {
            x_component = 0 - input.AimBookLeft.ReadValue<float>();
        }

        if ((input.AimBookUp.ReadValue<float>() != 0) && (input.AimBookDown.ReadValue<float>() == 0))
        {
            y_component = input.AimBookUp.ReadValue<float>();
        }
        else if ((input.AimBookDown.ReadValue<float>() != 0) && (input.AimBookUp.ReadValue<float>() == 0))
        {
            y_component = 0 - input.AimBookDown.ReadValue<float>();
        }
        if ((x_component != 0) || (y_component != 0))
        {
            prev_x = x_component;
            prev_y = y_component;
        }

        float angle = Mathf.Atan2(prev_x, prev_y) * Mathf.Rad2Deg;

        if ((x_movement != 0) || (y_movement != 0))
        {
            transform.rotation = Quaternion.Euler(0, 0, 360 - angle);
        }

        if (input.Shoot.WasPressedThisFrame())
        {
            var spell = Instantiate(spellPrefab);
            spell.transform.position = spawnPt.position;
            spell.transform.rotation = Quaternion.Euler(0, 0, 360 - angle);
        }
    }
}