using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MELEETRIGGER : EntityBehaviour
{
    
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameObject.AddComponent<EnemyMeleeBehavior>();
        }
    }

    

 
}

   



