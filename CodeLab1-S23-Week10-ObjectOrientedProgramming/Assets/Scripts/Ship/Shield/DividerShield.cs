using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DividerShield : BaseShield
{
    public float divideBy = 2f;


    public override float AdjustDamage(float damage)
    {
        return damage / divideBy;

    }
}

