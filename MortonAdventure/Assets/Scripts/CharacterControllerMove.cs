using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Utility;

public class CharacterControllerMove : MonoBehaviour
{
    [SerializeField]
    private float
        _speed,
        _jumpHeight,
        _gravity = -9.81f;

    [Space]
    [SerializeField] private GroundChecker _gGScript;
    [SerializeField] private CharacterController _charController;
    public Vector3 velocity; //public so 'GroundChecker' can acces


    private void Update()
    {
        velocity.y += _gravity * Time.deltaTime;
        _charController.Move(velocity * Time.deltaTime);
    }

    public void JumpPlayer(InputAction.CallbackContext context)
    {
        //jump logic
        if (_gGScript.isGrounded)
        {
            velocity.y = Mathf.Sqrt(_jumpHeight * -2 * _gravity);
        }
            
        print("Jumpies");
    }
    
    public void MovePlayer(Vector2 Dir)
    {
        if (Vector.IsLengthZero(Dir)) return;

        float x = Dir.x;
        float z = Dir.y;

        Vector3 move = transform.right * x + transform.forward * z;
        _charController.Move(move * _speed * Time.deltaTime);

    }
    
}
