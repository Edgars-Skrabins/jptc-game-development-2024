using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // PascalCase
    // camelCase
    // kebab-case
    // snake_case
    // SCREAMING_SNAKE_CASE

    [SerializeField] private Rigidbody m_rb;
    [SerializeField] private float m_speed;

    private void Start()
    {
        InitializeClassVariables();
    }

    private void InitializeClassVariables()
    {
        m_rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        float xVelocity = Input.GetAxisRaw("Horizontal");
        float yVelocity = Input.GetAxisRaw("Vertical");
        Vector3 velocity = new Vector3(xVelocity, 0f, yVelocity).normalized;
        m_rb.velocity = velocity * m_speed;
    }
}