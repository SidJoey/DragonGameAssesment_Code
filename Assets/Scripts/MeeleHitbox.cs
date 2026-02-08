using UnityEngine;

public class MeeleHitbox : MonoBehaviour
{
    // V1
    // public float damage = 25f;
    // public string enemyTag;
    //
    // bool hasHit;
    //
    // void OnEnable()
    // {
    //     hasHit = false;
    // }
    //
    // void OnTriggerEnter(Collider other)
    // {
    //     if (hasHit) return;
    //     if (!other.CompareTag(enemyTag)) return;
    //
    //     Health h = other.GetComponentInParent<Health>();
    //     if (h == null || h.isDead) return;
    //
    //     h.TakeDamage(damage);
    //     hasHit = true;
    // }
    //
    // public void EnableHitbox()
    // {
    //     gameObject.SetActive(true);
    // }
    //
    // public void DisableHitbox()
    // {
    //     gameObject.SetActive(false);
    // }
    
    
    // V2
    // ignore all that is not tagged enemy
    // public float damage = 25f;
    // public string enemyTag;
    //
    // bool hasHit;
    //
    // void OnEnable()
    // {
    //     hasHit = false;
    //     Debug.Log($"{gameObject.name} ENABLED");
    // }
    //
    // void OnDisable()
    // {
    //     Debug.Log($"{gameObject.name} DISABLED");
    // }
    //
    // void OnTriggerEnter(Collider other)
    // {
    //     Debug.Log($"TAIL TRIGGER ENTER with: {other.name} | Tag: {other.tag}");
    //
    //     if (hasHit)
    //     {
    //         Debug.Log("TAIL BLOCKED: already hit once");
    //         return;
    //     }
    //
    //     if (!other.CompareTag(enemyTag))
    //     {
    //         Debug.Log($"TAIL BLOCKED: tag mismatch (expected {enemyTag})");
    //         return;
    //     }
    //
    //     Health h = other.GetComponentInParent<Health>();
    //
    //     if (h == null)
    //     {
    //         Debug.Log("TAIL BLOCKED: no Health found in parent");
    //         return;
    //     }
    //
    //     if (h.isDead)
    //     {
    //         Debug.Log("TAIL BLOCKED: target already dead");
    //         return;
    //     }
    //
    //     Debug.Log("TAIL DAMAGE APPLIED");
    //     h.TakeDamage(damage);
    //     hasHit = true;
    // }
    //
    // public void EnableHitbox()
    // {
    //     gameObject.SetActive(true);
    // }
    //
    // public void DisableHitbox()
    // {
    //     gameObject.SetActive(false);
    // }
    
    public float damage = 25f;
    public string enemyTag;

    bool hasHit;

    void OnEnable()
    {
        hasHit = false;
    }

    void OnTriggerEnter(Collider other)
    {
        // Ignore everything except the intended target
        if (!other.CompareTag(enemyTag)) return;
        if (hasHit) return;
        
        Debug.Log("Hit on: "+other.gameObject.name);

        Health h = other.GetComponentInParent<Health>();
        if (h == null || h.isDead) return;

        h.TakeDamage(damage);
        hasHit = true;
    }

    public void EnableHitbox()
    {
        gameObject.SetActive(true);
    }

    public void DisableHitbox()
    {
        gameObject.SetActive(false);
    }


}