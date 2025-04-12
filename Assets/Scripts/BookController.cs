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
    private float x_movement;
    private float y_movement;

    // Start is called before the first frame update
    void Start()
    {
        x_movement = 0.0f;
        y_movement = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        var input = Game.Input.Controls;

        x_movement = input.AimBookX.ReadValue<float>();
        y_movement = input.AimBookY.ReadValue<float>();

        if ((input.AimBookRight.ReadValue<float>() != 0) && (input.AimBookLeft.ReadValue<float>() == 0))
        {
            x_movement = input.AimBookRight.ReadValue<float>();
        }
        else if ((input.AimBookLeft.ReadValue<float>() != 0) && (input.AimBookRight.ReadValue<float>() == 0))
        {
            x_movement = 0 - input.AimBookLeft.ReadValue<float>();
        }

        if ((input.AimBookUp.ReadValue<float>() != 0) && (input.AimBookDown.ReadValue<float>() == 0))
        {
            y_movement = input.AimBookUp.ReadValue<float>();
        }
        else if ((input.AimBookDown.ReadValue<float>() != 0) && (input.AimBookUp.ReadValue<float>() == 0))
        {
            y_movement = 0 - input.AimBookDown.ReadValue<float>();
        }

        float angle = Mathf.Atan2(x_movement, y_movement) * Mathf.Rad2Deg;

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