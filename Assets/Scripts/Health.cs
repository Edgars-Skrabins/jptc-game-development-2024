using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] protected int m_health;

    public virtual void TakeDamage(int _damage)
    {
        m_health -= _damage;
        if (m_health <= 0)
        {
            Die();
        }
    }

    protected virtual void Die()
    {
        Destroy(gameObject);
    }
}