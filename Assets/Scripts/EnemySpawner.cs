using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject m_enemyGO;
    [SerializeField] private float m_spawnRate;
    private float m_spawnTimer;

    private void Update()
    {
        CountTimer();
        HandleSpawnEnemy();
    }

    private void CountTimer()
    {
        m_spawnTimer += Time.deltaTime;
    }

    private void HandleSpawnEnemy()
    {
        if (m_spawnTimer >= m_spawnRate)
        {
            m_spawnTimer = 0;
            SpawnEnemy();
        }
    }

    [ContextMenu("Spawn enemy")]
    private void SpawnEnemy()
    {
        Instantiate(m_enemyGO, transform.position, Quaternion.identity);
    }
}