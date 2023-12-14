using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 10f;
    public int damage = 1;

    void Update()
    {
        MoveForward();
    }

    void MoveForward()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the projectile collides with an enemy (adjust the tag accordingly)
        if (other.CompareTag("Enemy"))
        {
            // Deal damage to the enemy
            other.GetComponent<EnemyController>().TakeDamage(damage);
            
            // Destroy the projectile on collision with an enemy
            Destroy(gameObject);
        }
    }
}