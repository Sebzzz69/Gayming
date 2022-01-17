using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : CharacterStats
{
    private PlayerHUD hud;

    private void Start()
    {
        GetReferences();
    }

    private void GetReferences()
    {
        hud = GetComponent<PlayerHUD>();
    }


}
