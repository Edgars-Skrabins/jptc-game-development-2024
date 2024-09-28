using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float m_speed;
    [SerializeField] private Rigidbody m_rb;

    [Space(5)]
    [Header("Debug")]
    [Space(5)]
    [SerializeField] private float m_debugRayLength;
    [SerializeField] private Color m_color;

    private void Update()
    {
        MoveCubeTowardsPlayer();
        LookTowardsPlayer();

#if UNITY_EDITOR
        DebugShowForwardDirection();
#endif
    }

    private void DebugShowForwardDirection()
    {
        Vector3 forward = transform.forward * m_debugRayLength;
        Debug.DrawRay(transform.position, forward, m_color);
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