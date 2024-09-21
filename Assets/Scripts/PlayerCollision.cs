using TMPro;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [Header("Attack settings")]
    [Space(5)]
    [SerializeField] private int m_damage;
    [Space(5)]
    [Header("Score settings")]
    [Space(5)]
    [SerializeField] private TextMeshProUGUI m_scoreTXT;
    [SerializeField] private int m_scoreAdditionAmount;
    private int m_score;

    private void Start()
    {
        UpdateScore(PlayerPrefs.GetInt("SCORE"));
    }

    private void OnCollisionEnter(Collision _collision)
    {
        if (_collision.collider.CompareTag("Enemy"))
        {
            DamageOnCollision(_collision);
        }
    }

    private void DamageOnCollision(Collision _collision)
    {
        if (_collision.gameObject.TryGetComponent(out Health health))
        {
            UpdateScore();
            health.TakeDamage(m_damage);
        }
    }

    private void UpdateScore()
    {
        m_score += m_scoreAdditionAmount;
        PlayerPrefs.SetInt("SCORE", m_score);
        UpdateScoreUI();
    }

    private void UpdateScore(int _score)
    {
        m_score += _score;
        UpdateScoreUI();
    }

    private void UpdateScoreUI()
    {
        m_scoreTXT.text = m_score.ToString();
    }
}