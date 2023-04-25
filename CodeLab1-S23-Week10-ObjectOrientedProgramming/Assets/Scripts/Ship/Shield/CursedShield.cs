using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursedShield : BaseShield
{
    public float shieldStrength = 40;

    public override float AdjustDamage(float damage)
    {

        if (shieldStrength > damage)
        {
            shieldStrength -= damage;
            return 0;
        }

        else if(shieldStrength > 0){ //if there is not enough shield to absord all damage
            damage = damage - shieldStrength; //reduce damage amount
            shieldStrength = 0; //remove remaining shields
            return damage; //return remaining damage
        } else { //if shields are gone
            return damage * 2; //return all the damage
        }

    }
}


