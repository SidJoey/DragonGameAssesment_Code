using System;
using Terresquall;
using UnityEngine;

public class MobileMovementInputHandler : MonoBehaviour
{
    public PlayerMovementController movement;

    // void OnEnable()
    // {
    //     #if UNITY_STANDALONE
    //         enabled = false;
    //     #endif
    // }

    void Awake()
    {
        movement = GetComponent<PlayerMovementController>();

        if (movement == null)
        {
            Debug.LogError("MobileMovementInputHandler does not have PlayerMovementController");
        }
    }

    void Update()
    {
        Vector2 input = VirtualJoystick.GetAxisRaw(1);
        // Debug.Log("Joystick input: " + input);
        
        movement.SetMovementInput(input);
        
    }
}
