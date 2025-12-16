using UnityEngine;

public class Health : MonoBehaviour
{
    public int HealthPoints = 100;

    public void TakeDamage(int damage)
    {
        HealthPoints -= damage;
        Debug.Log("Player took " + damage + " damage. HP left: " + HealthPoints);

        if (HealthPoints <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        if (HealthPoints <= 0)
        Destroy (gameObject);
    }
}
