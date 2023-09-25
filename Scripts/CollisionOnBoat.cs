using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionOnBoat : MonoBehaviour
{
    // Start is called before the first frame update
    public new ParticleSystem particleSystem;
    public int maxHealth = 10;
    public int currentHealth;

    public HealthBar healthBar;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("CannonBallEnemy"))
        {
            // Debug.Log("Collision on player");
            TakeDamage(1);
            Destroy();
        }
            
    }

    private void Destroy()
    {
        Instantiate(particleSystem, transform.position, Quaternion.identity);
        
        Destroy(particleSystem);
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }
}
