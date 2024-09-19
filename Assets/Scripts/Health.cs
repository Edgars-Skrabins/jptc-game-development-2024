using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    private int health = 100;

    public void TakeDamage(int _damage)
    {
        Debug.Log("Got hit!");
        health -= _damage;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
