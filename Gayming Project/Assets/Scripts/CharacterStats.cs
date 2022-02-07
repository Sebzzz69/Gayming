using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    [SerializeField] protected int health;
    [SerializeField] protected int maxHealth;

    [SerializeField] protected bool isDead;


    private void Start()
    {
        InitVariables();

    }

    //Funktioner för charactär-stats.
    //Detta scripts används i combination
    //med ett annat på en valfri charactär. 

    //Checks health
    public virtual void CheckHealth()
    {
        if (health <= 0)
        {
            health = 0;

            isDead = true;
        }
        if (health >= maxHealth)
            health = maxHealth;
    }

    //ded
    public void Die()
    {
        isDead = true;
        //if (isDead == true)
        //    Destroy(gameObject);
    }

    public void SetHealthTo(int healthToSetTo) 
    {
        health = healthToSetTo;
        CheckHealth(); 
    }

    //subtract damage to current health
    public void TakeDmg(int damage)
    {
        int healthAfterDamage = health - damage;
        SetHealthTo(healthAfterDamage);
    }

    //adds heal amount to current health
    public void Heal(int heal)
    {
        int healthAfterHeal = health + heal;
        SetHealthTo(healthAfterHeal);
    }

    public void InitVariables()
    {
        maxHealth = 100;
        SetHealthTo(maxHealth);
        isDead = false;
    }

    //---

}
