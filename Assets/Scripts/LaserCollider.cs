using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserCollider : MonoBehaviour
{
    public PlayerHealth player_health;
    public AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        audioSrc.GetComponent<AudioSource>();
        player_health = FindAnyObjectByType<PlayerHealth>();
        SoundManager.Play(SoundType.LASER);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Player"))
        {
            SoundManager.Play(SoundType.LASERBULLET);
            player_health.DIE();
        }
    }
}
