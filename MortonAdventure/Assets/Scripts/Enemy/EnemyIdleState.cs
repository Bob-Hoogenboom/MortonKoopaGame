using System;
using UnityEditor;
using UnityEditor.Build.Reporting;
using UnityEngine;

public class EnemyIdleState : AbstractEnemyState
{
    public EnemyChaseState chaseState;
    public EnemyDeathState deathState;
    
    public override AbstractEnemyState RunCurrentState()
    {
        Debug.Log("IdleState");
        if(playerInSight)
        {
            return chaseState;
        }
        else
        {
            return this;
        }
    }

    // public void OnCollisionEnter(Collision other)
    // {
    //     
    // }
}
