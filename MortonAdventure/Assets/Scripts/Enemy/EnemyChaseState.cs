using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChaseState : AbstractEnemyState
{
    public EnemyIdleState idleState;
    public EnemyDeathState deathState;
    
    public override AbstractEnemyState RunCurrentState()
    {
        Debug.Log("chaseState");
        if(!playerInSight)
        {
            return idleState;
        }
        return this;
    }
}
