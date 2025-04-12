using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float move_speed;
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        var input = Game.Input.Controls;

        transform.Translate(Vector3.up * move_speed * input.MoveUp.ReadValue<float>() * Time.deltaTime);
        transform.Translate(Vector3.down * move_speed * input.MoveDown.ReadValue<float>() * Time.deltaTime);
        transform.Translate(Vector3.right * move_speed * input.MoveRight.ReadValue<float>() * Time.deltaTime);
        transform.Translate(Vector3.left * move_speed * input.MoveLeft.ReadValue<float>() * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        var collided = collision.gameObject;
        Debug.Log("Collided");
        if(collided.CompareTag("Boss"))
        {
            Destroy(gameObject);
        }
    }
}
