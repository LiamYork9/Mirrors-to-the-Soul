using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    public float hp;
    public DimensionsScript dscript;

    public TurnThatOn baller;
    // Start is called before the first frame update
    void Start()
    {
       dscript = FindAnyObjectByType<DimensionsScript>();
       baller = FindAnyObjectByType<TurnThatOn>();

       if(baller == null)
       {
            return;
       }
    }

    // Update is called once per frame
    void Update()
    {
        if(hp <= 0)
        {
            Die();
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Spell"))
        {
            hp -= 1.0f;
        }
        
    }

    public void Die()
    {
        baller.killCount += 1;
        dscript.invertedObjects.Remove(gameObject);
        Destroy(gameObject);
    }
}
