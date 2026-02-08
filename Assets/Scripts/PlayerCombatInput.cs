// using System;
// using UnityEngine;
//
// public class PlayerCombatInput : MonoBehaviour
// {
//     private Animator animator;
//
//     private void Awake()
//     {
//         animator = GetComponent<Animator>();
//     }
//
//     void Update()
//     {
//         if (Input.GetMouseButtonDown(0)) // left click
//         {
//             animator.SetTrigger("FireAttack");
//         }
//
//         if (Input.GetMouseButtonDown(1)) // right click
//         {
//             animator.SetTrigger("MeeleAttack");
//         }
//
//         if (Input.GetKeyDown(KeyCode.Space))
//         {
//             animator.SetTrigger("FlyAttack");
//         }
//     }
// }

using UnityEngine;

public class PlayerCombatInput : MonoBehaviour
{
    private Animator animator;

    // === Combat Lock ===
    public bool IsLocked { get; private set; }

    // === Cooldown ===
    public float attackCooldown = 0.8f;
    float nextAttackTime;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Hard stop if combat is locked or on cooldown
        if (IsLocked) return;
        if (Time.time < nextAttackTime) return;

        if (Input.GetMouseButtonDown(0)) // LEFT CLICK - Fireball
        {
            StartAttack("FireAttack");
        }

        if (Input.GetMouseButtonDown(1)) // RIGHT CLICK - Melee
        {
            StartAttack("MeeleAttack");
        }

        if (Input.GetKeyDown(KeyCode.Space)) // SPACE - Fly Attack
        {
            StartAttack("FlyAttack");
        }
    }

    void StartAttack(string triggerName)
    {
        IsLocked = true;
        animator.SetTrigger(triggerName);
    }

    // === CALLED BY ANIMATION EVENT AT END OF ATTACK ===
    public void EndAttack()
    {
        Debug.Log("EndAttack() called");
        IsLocked = false;
        nextAttackTime = Time.time + attackCooldown;
    }
}
