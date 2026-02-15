using UnityEngine;

public class BattleManager : MonoBehaviour
{
    public Health playerHealth;
    public Health enemyHealth;

    [Header("End Screens")]
    public GameObject winScreen;
    public GameObject loseScreen;
    public GameObject drawScreen;
    
    bool playerDead;
    bool enemyDead;
    bool battleEnded = false;

    void Awake()
    {
        // Debug.Log("BattleManager Awake");

        // playerHealth.onDeath.AddListener(() => OnBattleEnd("PLAYER"));
        // enemyHealth.onDeath.AddListener(() => OnBattleEnd("ENEMY"));
        playerHealth.onDeath.AddListener(() => OnDeath("PLAYER"));
        enemyHealth.onDeath.AddListener(() => OnDeath("ENEMY"));

    }

    // void OnBattleEnd(string whoDied)
    // {
    //     // Debug.Log("OnBattleEnd ENTERED");
    //
    //     if (battleEnded)
    //     {
    //         // Debug.Log("Battle already ended, returning");
    //         return;
    //     }
    //
    //     battleEnded = true;
    //     // Debug.Log("Battle flag set");
    //
    //     StopAllGameplay();
    //
    //     // Debug.Log("OnBattleEnd EXITED");
    // }


    void StopAllGameplay()
    {
        // Debug.Log("StopAllGameplay ENTERED");

        #region Older Combat & movement disables

        // Disable<PlayerMovement>();
        // Debug.Log("After disabling PlayerMovement");

        // Disable<PlayerCombatInput>();
        // // Debug.Log("After disabling PlayerCombatInput");

        #endregion
        
        Disable<PCInputHandler>();
        Disable<PlayerCombatController>();
        Disable<PlayerMovementController>();
        Disable<MobileMovementInputHandler>();
        Disable<AIDragonController>();
        // Debug.Log("After disabling AIDragonController");

        Disable<UnityEngine.AI.NavMeshAgent>();
        // Debug.Log("After disabling NavMeshAgent");

        // Debug.Log("StopAllGameplay EXITED");
    }
    
    void OnDeath(string who)
    {
        if (battleEnded) return;

        if (who == "PLAYER") playerDead = true;
        if (who == "ENEMY") enemyDead = true;

        Invoke(nameof(ResolveBattle), 0.05f);
    }
    
    void ResolveBattle()
    {
        if (battleEnded) return;

        battleEnded = true;
        StopAllGameplay();

        if (playerDead && enemyDead)
        {
            drawScreen.SetActive(true);
        }
        else if (enemyDead)
        {
            winScreen.SetActive(true);
        }
        else if (playerDead)
        {
            loseScreen.SetActive(true);
        }
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