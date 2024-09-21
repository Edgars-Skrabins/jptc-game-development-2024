using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int m_health;

    public void TakeDamage(int _damage)
    {
        m_health -= _damage;
        if (m_health <= 0)
        {
            Destroy(gameObject);
        }
    }
}