using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeavyRangedEnemy : MonoBehaviour
{
    [Header("Movement Settings")]
    [SerializeField] private float moveSpeed = 3f;
    [SerializeField] private float attackRange = 7f;
    [SerializeField] private float repositionDistance = 3f;

    [Header("Attack Settings")]
    [SerializeField] private GameObject heavyProjectilePrefab;
    [SerializeField] private Transform firePoint;
    [SerializeField] private float attackCooldown = 2.5f;

    private Transform player;
    private Rigidbody2D rb;
    private float nextAttackTime;
    private bool isRepositioning = false;
    private Vector2 repositionTarget;

    // States
    private enum EnemyState { Approaching, Attacking, Repositioning }
    private EnemyState currentState = EnemyState.Approaching;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        nextAttackTime = Time.time + attackCooldown;
    }

    void Update()
    {
        if (player == null) return;

        float distanceToPlayer = Vector2.Distance(transform.position, player.position);

        switch (currentState)
        {
            case EnemyState.Approaching:
                if (distanceToPlayer <= attackRange)
                {
                    currentState = EnemyState.Attacking;
                }
                else
                {
                    MoveTowardsPlayer();
                }
                break;

            case EnemyState.Attacking:
                if (distanceToPlayer > attackRange)
                {
                    currentState = EnemyState.Approaching;
                }
                else if (Time.time >= nextAttackTime)
                {
                    Attack();
                    nextAttackTime = Time.time + attackCooldown;
                    ChooseRepositionPosition();
                    currentState = EnemyState.Repositioning;
                }
                break;

            case EnemyState.Repositioning:
                if (RepositionEnemy())
                {
                    currentState = EnemyState.Attacking;
                }
                break;
        }

        // Always face the player
        FacePlayer();
    }

    void MoveTowardsPlayer()
    {
        Vector2 direction = (player.position - transform.position).normalized;
        rb.velocity = direction * moveSpeed;
    }

    void FacePlayer()
    {
        Vector2 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90f;
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    void Attack()
    {
        // Create heavy projectile
        GameObject projectile = Instantiate(heavyProjectilePrefab, firePoint.position, transform.rotation);

        // You might want to add some visual/audio effects here
        // For example: Instantiate(attackEffectPrefab, firePoint.position, Quaternion.identity);
    }

    void ChooseRepositionPosition()
    {
        Vector2 playerDirection = (player.position - transform.position).normalized;
        Vector2 perpendicularDirection = new Vector2(-playerDirection.y, playerDirection.x);

        // Randomly choose left or right
        if (Random.value > 0.5f)
        {
            perpendicularDirection = -perpendicularDirection;
        }

        // Calculate reposition target
        repositionTarget = (Vector2)transform.position + perpendicularDirection * repositionDistance;

        // Make sure the target is still within attack range
        float distanceToPlayer = Vector2.Distance(repositionTarget, player.position);
        if (distanceToPlayer > attackRange)
        {
            // Adjust to stay in range
            Vector2 toPlayer = ((Vector2)player.position - repositionTarget).normalized;
            repositionTarget += toPlayer * (distanceToPlayer - attackRange + 0.5f);
        }
    }

    bool RepositionEnemy()
    {
        // Move to reposition target
        Vector2 toTarget = (repositionTarget - (Vector2)transform.position);
        float distanceToTarget = toTarget.magnitude;

        if (distanceToTarget < 0.1f)
        {
            // Reached target
            rb.velocity = Vector2.zero;
            return true;
        }

        // Move towards target
        Vector2 direction = toTarget.normalized;
        rb.velocity = direction * moveSpeed;
        return false;
    }

    // Draw gizmos for debugging
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);

        if (isRepositioning && Application.isPlaying)
        {
            Gizmos.color = Color.green;
            Gizmos.DrawSphere(repositionTarget, 0.3f);
        }
    }
}