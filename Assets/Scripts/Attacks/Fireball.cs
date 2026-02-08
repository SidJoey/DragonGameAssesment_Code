using UnityEngine;

public class Fireball : MonoBehaviour
{
    public float speed = 15f;
    public float damage = 20f;
    public float lifetime = 4f;
    public string enemyTag;

    void Start()
    {
        Destroy(gameObject, lifetime);
    }

    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }

//     void OnTriggerEnter(Collider other)
//     {
//         if (other.CompareTag(enemyTag))
//         {
//             Health h = other.GetComponent<Health>();
//             if (h) h.TakeDamage(damage);
//         }
//
//         Destroy(gameObject);
//     }
// }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Fireball hit: " + other.name);

        if (other.CompareTag(enemyTag))
        {
            Health h = other.GetComponent<Health>();
            if (h) h.TakeDamage(damage);
        }

        Destroy(gameObject);
    }

}