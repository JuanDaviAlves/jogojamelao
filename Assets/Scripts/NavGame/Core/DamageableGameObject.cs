using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NavGame.Core
{
    public class DamageableGameObject : TouchableGameObject
    {
        public int currentHealth;
        public DefenseStats defenseStats;

        protected virtual void Awake()
        {
            currentHealth = defenseStats.maxHealth;
        }

        public void TakeDamage(int amount)
        {
            amount -= defenseStats.armor;
            amount = Mathf.Clamp(amount, 1, defenseStats.maxHealth);
            currentHealth -= amount;
            if(currentHealth <= 0)
            {
                Die();
            }
        }
        public virtual void Die()
        {
            Destroy(gameObject);
        }
    }
}
