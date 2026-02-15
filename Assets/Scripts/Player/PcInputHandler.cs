using UnityEngine;

public class PCInputHandler : MonoBehaviour
{
    private PlayerCombatController combat;
    private PlayerMovementController movement;

    void Awake()
    {
        combat = GetComponent<PlayerCombatController>();
        movement = GetComponent<PlayerMovementController>();
    }
    
    // void OnEnable()
    // {
    //     #if UNITY_ANDROID || UNITY_IOS
    //         enabled = false;
    //     #endif
    // }


    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        
        movement.SetMovementInput(new Vector2(h, v));
        movement.SetSprint(Input.GetKey(KeyCode.LeftShift));
        
        #region Combat 

        if (Input.GetMouseButtonDown(0))
            combat.RequestFireAttack();

        if (Input.GetMouseButtonDown(1))
            combat.RequestMeleeAttack();

        if (Input.GetKeyDown(KeyCode.Space))
            combat.RequestFlyAttack();

        #endregion
    }
}