// using System;
// using UnityEngine;
//
// [RequireComponent(typeof(CharacterController))]
// public class PlayerMovement : MonoBehaviour
// {
//     #region Variables and References
//
//     public float moveSpeed = 6f;
//     public float rotationSpeed = 12f;
//     public float gravity = 20f;
//
//     private CharacterController controller;
//     private Animator animator;
//     private Vector3 velocity;
//
//     #endregion
//
//     private void Awake()
//     {
//         controller = GetComponent<CharacterController>();
//         animator = GetComponent<Animator>();
//     }
//
//     private void Update()
//     {
//         float h = Input.GetAxisRaw("Horizontal");
//         float v = Input.GetAxisRaw("Vertical");
//         
//         Vector3 input = new Vector3(h, 0, v);
//         float speed01 = Mathf.Clamp01(input.magnitude);
//         
//         // animators
//         animator.SetFloat("MoveSpeed", speed01);
//         
//         // movement
//         if (speed01 > 0.1f)
//         {
//             Vector3 moveDir = input.normalized;
//             
//             // checking for if player is sprinting
//             if (Input.GetKey(KeyCode.LeftShift))
//             {
//                 moveSpeed = 12f;
//             }
//             else
//             {
//                 moveSpeed = 6f;
//             }
//             
//             // move
//             controller.Move(moveDir * moveSpeed * Time.deltaTime);
//             
//             // rotate towards where moving
//             Quaternion targetRot = Quaternion.LookRotation(moveDir);
//             transform.rotation = Quaternion.Slerp(transform.rotation, targetRot, rotationSpeed * Time.deltaTime);
//         }
//         
//         // applying gravity to ground controller
//         velocity.y -= gravity * Time.deltaTime;
//         controller.Move(velocity * Time.deltaTime);
//         
//         if (controller.isGrounded)
//             velocity.y = -2f;
//     }
// }
