using System;
using UnityEngine;

public class PlayerCombatInput : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // left click
        {
            animator.SetTrigger("FireAttack");
        }

        if (Input.GetMouseButtonDown(1)) // right click
        {
            animator.SetTrigger("MeeleAttack");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("FlyAttack");
        }
    }
}
