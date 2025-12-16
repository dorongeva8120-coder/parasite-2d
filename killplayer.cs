using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int damage = 20;
    public float hitCooldown = 1f; // זמן בין פגיעות בשניות
    private float lastHitTime = -Mathf.Infinity;

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Health player = hitInfo.GetComponent<Health>();
        if (player != null)
        {
            // בודק אם עבר מספיק זמן מאז הפגיעה האחרונה
            if (Time.time - lastHitTime >= hitCooldown)
            {
                player.TakeDamage(damage);
                lastHitTime = Time.time; // מעדכן את הזמן של הפגיעה האחרונה
                Debug.Log("Player took " + damage + " damage!");
            }
        }
    }
}
