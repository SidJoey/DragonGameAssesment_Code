using UnityEngine;
// I am adding this script just so that the debugging is easier 
public class AnimationCombatRelay : MonoBehaviour
{
    public PlayerCombatInput playerCombat;

    public void EndAttack()
    {
        if (playerCombat != null)
        {
            playerCombat.EndAttack();
        }
            
    }
}
