// using UnityEngine;
//
// public class PlatformInitializer : MonoBehaviour
// {
//     [Header("UI")]
//     public GameObject pcUI;
//     public GameObject mobileUI;
//
//     [Header("Input")]
//     public MonoBehaviour pcMovementInput;
//     public MonoBehaviour pcCombatInput;
//
//     public MonoBehaviour mobileMovementInput;
//     public MonoBehaviour mobileCombatInput;
//
//     void Awake()
//     {
//         bool isMobile = Application.isMobilePlatform;
//
//         // UI
//         pcUI.SetActive(!isMobile);
//         mobileUI.SetActive(isMobile);
//
//         // Movement input
//         pcMovementInput.enabled = !isMobile;
//         mobileMovementInput.enabled = isMobile;
//
//         // Combat input
//         pcCombatInput.enabled = !isMobile;
//         mobileCombatInput.enabled = isMobile;
//     }
// }

using UnityEngine;

public class PlatformInitializer : MonoBehaviour
{
    [Header("UI")]
    public GameObject pcUI;
    public GameObject mobileUI;

    [Header("Input")]
    public MonoBehaviour pcInputHandler;
    public MonoBehaviour mobileMovementInput;

    void Awake()
    {
        bool isMobile = Application.isMobilePlatform;
        // bool isMobile = true; // Debugging purposes
        
        // UI
        pcUI.SetActive(!isMobile);
        mobileUI.SetActive(isMobile);

        // Input
        pcInputHandler.enabled = !isMobile;
        mobileMovementInput.enabled = isMobile;
    }
}
