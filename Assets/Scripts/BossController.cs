using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossController : MonoBehaviour
{
    public float min=2f;
	public float max=3f;
    // Start is called before the first frame update
    void Start()
    {
        min=transform.position.x-7;
		max=transform.position.x+7;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.PingPong(Time.time*2,max-min)+min, transform.position.y, transform.position.z);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        var collided = collision.gameObject;

        if(collided.CompareTag("Player"))
        {
            collided.SetActive(false);
        }
    }
}
