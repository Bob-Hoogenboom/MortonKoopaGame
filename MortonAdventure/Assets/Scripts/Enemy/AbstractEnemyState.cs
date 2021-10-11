using System;
using UnityEngine;

public abstract class AbstractEnemyState : MonoBehaviour
{
    public bool playerInSight;
    
    
    public abstract AbstractEnemyState RunCurrentState();

    // public void OnCollisionEnter(Collision other);
}
