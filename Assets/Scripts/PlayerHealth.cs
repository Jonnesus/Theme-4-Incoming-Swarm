using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int health;
    [SerializeField] private int maxHealth = 100;

    private void Start()
    {
        health = maxHealth;
    }

    private void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Debug.Log("Player Dead");
            Time.timeScale = 0;
        }
    }
}