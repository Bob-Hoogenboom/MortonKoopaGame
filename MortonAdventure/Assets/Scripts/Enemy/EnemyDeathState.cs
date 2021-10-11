using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeathState : AbstractEnemyState
{
    public override AbstractEnemyState RunCurrentState()
    {
        return this;
    }
}
