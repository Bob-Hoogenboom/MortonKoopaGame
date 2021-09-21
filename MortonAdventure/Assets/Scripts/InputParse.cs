using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputParse : MonoBehaviour
{
    private PlayerControls _playerInput;
    private PlayerControls.PlayerActions _playerControlsActions;

    [SerializeField] private CharacterControllerMove _charConMove;


    private void Awake()
    {
        _playerInput = new PlayerControls();
        _playerControlsActions = _playerInput.Player;

        _playerControlsActions.Jump.performed += _charConMove.JumpPlayer;
        
        _playerControlsActions.Enable();
    }

    private void FixedUpdate()
    {
        _charConMove.MovePlayer(_playerControlsActions.Move.ReadValue<Vector2>());
    }
}
