using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private int damage = 1000;
    private void OnCollisionEnter(Collision _collision)
    {
        if (_collision.collider.CompareTag("Enemy"))
        {
            Health health = _collision.collider.gameObject.GetComponent<Health>();
            health.TakeDamage(damage);
        }
    }
}
