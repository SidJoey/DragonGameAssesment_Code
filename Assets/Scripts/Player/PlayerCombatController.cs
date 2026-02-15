using UnityEngine;

public class PlayerCombatController : MonoBehaviour
{
    #region Variables and references

    #region References

    private Animator animator;

    [Header("Ability Icons")]
    public AbilityIcon fireIcon;
    public AbilityIcon meleeIcon;
    public AbilityIcon flyIcon;

    #endregion

    private bool isDead;
    // Combat lock
    public bool IsLocked { get; private set; }

    public float attackCooldown = 0.8f;
    float nextAttackTime;
    
    #endregion
    
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void setDead()
    {
        Debug.Log("Set dead has been called");
        isDead = true;
    }
    public void RequestFireAttack()
    {
        TryStartAttack("FireAttack", fireIcon);
    }

    public void RequestMeleeAttack()
    {
        TryStartAttack("MeeleAttack", meleeIcon);
    }

    public void RequestFlyAttack()
    {
        TryStartAttack("FlyAttack", flyIcon);
    }

    void TryStartAttack(string triggerName, AbilityIcon icon)
    {
        if (isDead) return; // checking if dead
        if (IsLocked) return;
        if (Time.time < nextAttackTime) return;

        IsLocked = true;
        animator.SetTrigger(triggerName);

        if (icon != null)
            icon.SetAvailable(false);
    }

    // Called by animation event
    public void EndAttack()
    {
        Debug.Log("EndAttack() called");

        IsLocked = false;
        nextAttackTime = Time.time + attackCooldown;

        fireIcon?.SetAvailable(true);
        meleeIcon?.SetAvailable(true);
        flyIcon?.SetAvailable(true);
    }
}