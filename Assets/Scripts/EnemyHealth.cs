using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    public float hp;
    public DimensionsScript dscript;
    // Start is called before the first frame update
    void Start()
    {
       dscript = FindAnyObjectByType<DimensionsScript>();
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
        dscript.invertedObjects.Remove(gameObject);
        Destroy(gameObject);
    }
}
