using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    [SerializeField] private Transform _groundCheckOBJ;
    [SerializeField] private Vector3 _groundDistance;
    [SerializeField] private LayerMask _groundMask;
    public bool isGrounded; //public so 'CharacterControllerMove' can acces

    [SerializeField] private CharacterControllerMove _cCMScript;

    void Update()
    {
        isGrounded = Physics.CheckBox(_groundCheckOBJ.position, _groundDistance, _groundCheckOBJ.rotation,_groundMask);

        if (isGrounded && _cCMScript.velocity.y < 0)
        {
            Debug.Log("Ground Checked");
            _cCMScript.velocity.y = -2;
        }

    }
    
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.magenta;
        Gizmos.DrawWireCube (transform.position, _groundDistance);
    }
}
