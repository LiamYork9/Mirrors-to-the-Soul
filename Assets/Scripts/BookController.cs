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
    private float x_component;
    private float y_component;
    private float prev_x = 0.0f;
    private float prev_y = 0.0f;
    private float shootCD;
    public int maxMana = 100;
    public int currentMana;
    public ManaBar manaBar;
    public DimensionsScript getBool;

    // Start is called before the first frame update
    void Start()
    {
        x_component = 0.0f;
        y_component = 0.0f;
        shootCD = 0f;
        currentMana = maxMana;
        manaBar.SetMaxMana(maxMana);
    }

    // Update is called once per frame
    void Update()
    {
        var input = Game.Input.Controls;
        shootCD -= Time.deltaTime;

        x_component = input.AimBookX.ReadValue<float>();
        y_component = input.AimBookY.ReadValue<float>();

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

        if ((x_component != 0) || (y_component != 0))
        {
            transform.rotation = Quaternion.Euler(0, 0, 360 - angle);
        }

        if (currentMana != 0)
        {
            if ((input.Shoot.WasPressedThisFrame()) && (shootCD <= 0))
            {
                var spell = Instantiate(spellPrefab);
                spell.transform.position = spawnPt.position;
                spell.transform.rotation = Quaternion.Euler(0, 0, 360 - angle);
                shootCD = 0.5f;
                if (GameManager.Instance.swapped == false)
                {
                    Debug.Log("not Swapped");
                    UseMana(10);
                }
            }
            if (GameManager.Instance.swapped == true)
            {
                Debug.Log("Add Mana");
                manaBar.SetMana(((int)getBool.currentTime * 10) + currentMana);
                currentMana = manaBar.GetMana();
            }
        }
    }

    void UseMana(int UsedMana)
    {
        currentMana -= UsedMana;
        manaBar.SetMana(currentMana);
    }
}