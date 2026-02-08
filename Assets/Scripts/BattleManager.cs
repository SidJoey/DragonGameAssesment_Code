using UnityEngine;

public class BattleManager : MonoBehaviour
{
    public Health playerHealth;
    public Health enemyHealth;

    bool battleEnded = false;

    void Awake()
    {
        // Debug.Log("BattleManager Awake");

        playerHealth.onDeath.AddListener(() => OnBattleEnd("PLAYER"));
        enemyHealth.onDeath.AddListener(() => OnBattleEnd("ENEMY"));
    }

    void OnBattleEnd(string whoDied)
    {
        // Debug.Log("OnBattleEnd ENTERED");

        if (battleEnded)
        {
            // Debug.Log("Battle already ended, returning");
            return;
        }

        battleEnded = true;
        // Debug.Log("Battle flag set");

        StopAllGameplay();

        // Debug.Log("OnBattleEnd EXITED");
    }


    void StopAllGameplay()
    {
        // Debug.Log("StopAllGameplay ENTERED");

        Disable<PlayerMovement>();
        // Debug.Log("After disabling PlayerMovement");

        Disable<PlayerCombatInput>();
        // Debug.Log("After disabling PlayerCombatInput");

        Disable<AIDragonController>();
        // Debug.Log("After disabling AIDragonController");

        Disable<UnityEngine.AI.NavMeshAgent>();
        // Debug.Log("After disabling NavMeshAgent");

        // Debug.Log("StopAllGameplay EXITED");
    }


    void Disable<T>() where T : Behaviour
    {
        T comp = FindObjectOfType<T>();
        if (comp)
        {
            // Debug.Log("Disabling " + typeof(T).Name);
            comp.enabled = false;
        }
        else
        {
            // Debug.Log("Could NOT find " + typeof(T).Name);
        }
    }
}