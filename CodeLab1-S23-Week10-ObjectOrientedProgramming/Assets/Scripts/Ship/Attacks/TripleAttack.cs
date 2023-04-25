using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TripleAttack : BaseAttack
{
    //public Vector2 pos1 = new Vector2(0, 1);
    //public Vector2 pos2 = new Vector2(1, 1);
    //public Vector2 pos3 = new Vector2(-1, 1);
    //public override void Attack()
    //{
     //   base.Attack();
    //    SpawnBullet(pos1 + currentPos);
    //     SpawnBullet (pos2 + currentPos); 
    // SpawnBullet (pos3 + currentPos); 
    //}

   public override void SpawnBullet(Vector2 currentPos)
    {
        GameObject bullet1 = Instantiate<GameObject>(bulletPrefab);
        GameObject bullet2 = Instantiate<GameObject>(bulletPrefab);
        GameObject bullet3 = Instantiate<GameObject>(bulletPrefab);

        bullet1.GetComponent<Rigidbody2D>().gravityScale = -1; 
        bullet2.GetComponent<Rigidbody2D>().gravityScale = -1;
        bullet3.GetComponent<Rigidbody2D>().gravityScale = -1;
    }
    
    
    //OR
    public override void Attack()
    {
        BaseAttacker(); 
        Invoke("BaseAttacker", 0.2f);
        Invoke(methodName: "BaseAttacker", 0.4f);
    }

    public void BaseAttacker()
    {
        base.Attack(); 
    }
}
