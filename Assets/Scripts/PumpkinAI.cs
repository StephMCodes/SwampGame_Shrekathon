using UnityEngine;
using UnityEngine.AI;

public class PumpkinAI : MonoBehaviour
{
    public float fleeDistance = 10f; // Distance at which the AI starts fleeing
    public float speed = 5f;
    private Transform player;
    private NavMeshAgent agent;
    private Animator animator;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        agent = GetComponent<NavMeshAgent>();
        if (agent != null)
        {
            agent.speed = speed;
        }
        animator = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        if (player != null)
        {
            float distanceToPlayer = Vector3.Distance(transform.position, player.position);

            // Check if the player is too close
            if (distanceToPlayer < fleeDistance && ObjectiveManager.getObjectiveStatus(WORDENUM.Weapon))
            {
                animator.SetBool("playernear", true);

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
            else {
                //If player is not close
                animator.SetBool("playernear", false);

            }
        }
    }

    public void Die() 
    {

        Debug.Log("Dieinmgggg");

        //Play death animation and sound effect here
        animator.SetBool("pumpdead", true);
        //Wait a few seconds and activate an InteractableItem (pumpkin corpse) so they can pick him up


    }


}
