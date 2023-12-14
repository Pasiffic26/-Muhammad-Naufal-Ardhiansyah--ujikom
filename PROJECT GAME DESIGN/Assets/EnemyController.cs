using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public int maxHP = 3;
    private int currentHP;
    public float moveSpeed = 3.0f;

    void Start()
    {
        currentHP = maxHP;
    }

    void Update()
    {
        MoveStraight();
    }

    void MoveStraight()
    {
        transform.Translate(Vector3.forward * Time.deltaTime);
    }

    public void TakeDamage(int damage)
    {
        currentHP -= damage;

        if (currentHP <= 0)
        {
            Destroy(gameObject);
        }
    }

}