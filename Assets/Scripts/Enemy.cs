using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {   
    public Transform target;
    public float speed = 3f; 
    public float rotateSpeed = 0.0025f; 
    private Rigidbody2D rb; 

    void Start() {
        rb = GetComponent<Rigidbody2D>(); 
    }

    void Update() {
        if (!target) {
            GetTarget(); 
        } else {
            RotateTowardsTarget(); 
        }
    }

    private void FixedUpdate() {
        rb.velocity = transform.up * speed; 
    }

    private void RotateTowardsTarget() {
        Vector2 targetDirection = target.position - transform.position; 
        float angle = Mathf.Atan2(targetDirection.y, targetDirection.x) * Mathf.Rad2Deg - 90f; 
        Quaternion q = Quaternion.Euler(new Vector3(0, 0, angle));
        transform.localRotation = Quaternion.Slerp(transform.localRotation, q, rotateSpeed);
    }

    private void GetTarget() {
            target = GameObject.FindGameObjectWithTag("Player").transform; 
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Player"))
        {
            // Do some dmg to player 
        } //else if (other.gameObject.CompareTag("Bullet"))   // replace w/ projectile tag
        {
            // Do some dmg to the enemy
        }
        if (other.gameObject.CompareTag("Barrier"))
        {
            print("Hit a wall");
            speed = 0 - speed;
        }
    }

}
