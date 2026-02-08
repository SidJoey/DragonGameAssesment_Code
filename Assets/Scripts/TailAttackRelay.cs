using UnityEngine;

public class TailAttackRelay : MonoBehaviour
{
    public MeeleHitbox tailHitbox;

    public void EnableHitbox()
    {
        tailHitbox.EnableHitbox();
    }

    public void DisableHitbox()
    {
        tailHitbox.DisableHitbox();
    }
}