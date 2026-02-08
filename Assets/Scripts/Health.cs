using System;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    #region Variables und references

    public float maxHealth = 100f;
    public float currentHealth;

    public UnityEvent onDeath;

    public bool isDead {get; private set;}

    #endregion

    private void Awake()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(float amount)
    {
        if (isDead) return;
        
        currentHealth -= amount;

        if (currentHealth <= 0f)
        {
            currentHealth = 0f;
            Die();
        }
        Debug.Log("TakeDamage called. isDead = " + isDead);

    }

    // void Die()
    // {
    //     if (isDead) return;
    //     isDead = true;
    //     
    //     Debug.Log(gameObject.name + " DIED");
    //     
    //     Animator anim = GetComponent<Animator>();
    //     if (anim) anim.SetTrigger("Death");
    //     
    //     // Disable Movement / AI
    //     var agent =  GetComponent<UnityEngine.AI.NavMeshAgent>();
    //     if (agent) agent.enabled = false;
    //
    //     // only for ai
    //     var ai = GetComponent<AIDragonController>();
    //     if (ai) ai.enabled = false;
    //     
    //
    //     // Disabling player 
    //     var playerMove = GetComponent<PlayerMovement>();
    //     if (playerMove) playerMove.enabled = false;
    //
    //     var playerCombat = GetComponent<PlayerCombatInput>();
    //     if (playerCombat) playerCombat.enabled = false;
    //     
    //     var controller =  GetComponent<CharacterController>();
    //     if (controller) controller.enabled = false;
    //     
    //     // Disable ALL colliders so nothing can hit the corpse
    //     Collider[] cols = GetComponentsInChildren<Collider>(true);
    //     foreach (Collider col in cols)
    //     {
    //         col.enabled = false;
    //     }
    // }
    void Die()
    {
        if (isDead) return;
        isDead = true;

        Debug.Log(gameObject.name + " DIED");
        
        // goes to battleManager
        onDeath?.Invoke();

        // Visuals
        Animator anim = GetComponent<Animator>();
        if (anim) anim.SetTrigger("Death");

        // Disable ALL colliders
        foreach (var col in GetComponentsInChildren<Collider>(true))
            col.enabled = false;
    }

}
