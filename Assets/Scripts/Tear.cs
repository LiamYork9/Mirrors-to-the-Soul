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

    public DimensionsScript invers;

    public float currentTime;

    public AudioSource audioSrc;

    void Start()
    {
        audioSrc.GetComponent<AudioSource>();
        pHealth = FindAnyObjectByType<PlayerHealth>();
        rb2d = GetComponent<Rigidbody2D>();
        invers = FindAnyObjectByType<DimensionsScript>();
        invers.invertedObjects.Add(gameObject);
        Destroy(gameObject, lifeTime);
        SoundManager.Play(SoundType.PROJECTILE);
    }

    void FixedUpdate()
    {
        currentTime += Time.fixedDeltaTime;

        rb2d.velocity = transform.up * speed;

        if(currentTime >= 2.0f)
        {
            invers.invertedObjects.Remove(gameObject);
        }
    }

     void OnCollisionEnter2D(Collision2D col)
     {
        
         if(col.gameObject.CompareTag("Player"))
         {
            invers.invertedObjects.Remove(gameObject);
            Destroy(gameObject);
         }

     }
    
}