using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float m_speed;
    [SerializeField] private Rigidbody m_rb;

    private void Update()
    {
        MoveCubeTowardsPlayer();
        LookTowardsPlayer();
    }

    private void MoveCubeTowardsPlayer()
    {
        Vector3 directionToPlayer = Player.Instance.GetPlayerPosition() - transform.position;
        m_rb.velocity = directionToPlayer * m_speed;
    }

    private void LookTowardsPlayer()
    {
        transform.LookAt(Player.Instance.GetPlayerTF());
    }
}