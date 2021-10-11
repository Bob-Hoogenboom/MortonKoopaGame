using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStateMachine : MonoBehaviour
{
    private AbstractEnemyState _currentState;
    
    private void Update()
    {
        RunStateMachine();
    }

    private void RunStateMachine()
    {
        AbstractEnemyState nextState = _currentState?.RunCurrentState();

        if(nextState != null)
        {
            SwitchToNextState(nextState);
        }
    }

    private void SwitchToNextState(AbstractEnemyState nextState)
    {
        _currentState = nextState;
    }
}
