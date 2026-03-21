using UnityEngine;
using UnityEngine.AI;

public class PumpkinRunFromPlayer : MonoBehaviour
{
    public float fleeDistance = 10f; // Distance at which the AI starts fleeing
    public float speed = 5f;
    private Transform player;
    private NavMeshAgent agent;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        agent = GetComponent<NavMeshAgent>();
        if (agent != null)
        {
            agent.speed = speed;
        }
    }

    void Update()
    {
        if (player != null)
        {
            float distanceToPlayer = Vector3.Distance(transform.position, player.position);

            // Check if the player is too close
            if (distanceToPlayer < fleeDistance)
            {
                // Calculate the direction away from the player
                Vector3 runDirection = transform.position - player.position;
                // Normalize the direction and extend it to find a potential destination point
                Vector3 destinationPoint = transform.position + runDirection.normalized * fleeDistance;

                // Set the agent's destination to move to the calculated point
                if (agent != null)
                {
                    agent.SetDestination(destinationPoint);
                }
            }
        }
    }
}
