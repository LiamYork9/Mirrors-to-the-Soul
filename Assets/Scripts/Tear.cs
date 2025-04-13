using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tear : MonoBehaviour
{
    [Range(1, 10)]
    [SerializeField] private float speed = 10f;
    [Range(1, 10)]
    [SerializeField] private float lifeTime = 3f;
    private Rigidbody2D rb2d;

    public PlayerHealth pHealth;

    void Start()
    {
        pHealth = FindAnyObjectByType<PlayerHealth>();
        rb2d = GetComponent<Rigidbody2D>();
        Destroy(gameObject, lifeTime);
    }

    void FixedUpdate()
    {
        rb2d.velocity = transform.up * speed;
    }

     void OnCollisionEnter2D(Collision2D col)
     {
         if(col.gameObject.CompareTag("Player"))
         {
            Destroy(gameObject);
         }

     }
    
}