using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerController))]
public class PlayerMovement : MonoBehaviour
{
    PlayerController controller;

    void Start() => controller = GetComponent<PlayerController>();

    public void OnHorizontalMovement(InputValue inputValue) => controller.Move(inputValue.Get<float>());

    public void OnJump(InputValue inputValue)
    {
        if (inputValue.isPressed) controller.Jump();
    }
}
