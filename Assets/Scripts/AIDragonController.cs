using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AIDragonController : MonoBehaviour
{
    public Transform target;
    public float attackRange = 4f;
    public float attackCooldown = 2.5f;

    private NavMeshAgent agent;
    private Animator animator;
    private float cooldown;

    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (!target) return;

        float dist = Vector3.Distance(transform.position, target.position);

        if (dist > attackRange)
        {
            // Chase
            agent.isStopped = false;
            agent.SetDestination(target.position);

            float speed01 = agent.velocity.magnitude / agent.speed;
            animator.SetFloat("MoveSpeed", speed01);
        }
        else
        {
            // Attack
            agent.isStopped = true;
            animator.SetFloat("MoveSpeed", 0f);

            cooldown -= Time.deltaTime;
            if (cooldown <= 0f)
            {
                ChooseAttack();
                cooldown = attackCooldown;
            }
        }
    }

    void ChooseAttack()
    {
        float roll = Random.value;

        if (roll < 0.6f)
            animator.SetTrigger("MeeleAttack");
        else if (roll < 0.9f)
            animator.SetTrigger("FireAttack");
        else
            animator.SetTrigger("FlyAttack");
    }
}