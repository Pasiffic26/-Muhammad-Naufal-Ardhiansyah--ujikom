using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public GameObject projectilePrefab;

    void Update()
    {
        MovePlayer();

        if (Input.GetMouseButtonDown(0))
        {
            ShootProjectile();
        }
    }

    void MovePlayer()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * moveSpeed * Time.deltaTime);
    }

    void ShootProjectile()
    {
        if (projectilePrefab != null)
        {
            GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        }
        else
        {
            Debug.LogError("Projectile prefab is not assigned/Projectile prefab belum di masukkan kedalam player");
        }
    }

}