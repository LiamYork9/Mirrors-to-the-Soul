using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerHealth : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;

    public DeathScreen death;
    // Start is called before the first frame update
    void Start()
    {
        death = FindAnyObjectByType<DeathScreen>();
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        death.TurnOff();
    }

    // Update is called once per frame
    void Update()
    {
        if(currentHealth <= 0)
        {
            DIE();
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.CompareTag("Enemy")){
        TakeDamage(10);
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    public void DIE()
    {
        
        death.TurnOn();
        Destroy(gameObject);
    }
}
