using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportShield : BaseShield
{
    public float teleportRange = 5;

    public override float AdjustDamage(float damage)
    {
        Vector3 position = transform.position;
        position.x = Random.Range(-teleportRange, teleportRange);
        transform.position = position;  
        
        return base.AdjustDamage(damage);
    }
}
