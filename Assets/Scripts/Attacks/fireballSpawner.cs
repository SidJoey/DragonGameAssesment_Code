using UnityEngine;

public class FireballSpawner : MonoBehaviour
{
    public GameObject fireballPrefab;
    public Transform firePoint;
    public string enemyTag;

    public void SpawnFireball()
    {
        
        Debug.Log(gameObject.name+" SpawnFireball() called");
        GameObject fb = Instantiate(
            fireballPrefab,
            firePoint.position,
            firePoint.rotation
        );

        fb.GetComponent<Fireball>().enemyTag = enemyTag;
    }
}