using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Entity
{
<<<<<<< Updated upstream
=======
    
    public Hitbox EnemyMHitbox { get; private set; }
    public Hitbox EnemyMelee;

>>>>>>> Stashed changes
    public override void OnHit(Hitbox hitbox)
    {
        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override EntityType GetEntityType()
    {
        return EntityType.Enemy;
    }
}

