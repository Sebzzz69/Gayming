using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : CharacterStats
{
    private PlayerHUD hud;

    private void Start()
    {
        GetReferences();
        InitVariables();
    }

    private void GetReferences()
    {
        hud = GetComponent<PlayerHUD>();
    }

    public override void CheckHealth()
    {
        base.CheckHealth();
        hud.UpdateHealth(health, maxHealth);  
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
            TakeDmg(10);

        if (Input.GetKeyDown(KeyCode.Y))
            Heal(10);

        if (isDead == true)
            Destroy(gameObject);
    }

}// slut på class playerstats
