using UnityEngine;
using UnityEngine.AI;

public class PumpkinAI : MonoBehaviour
{
    public float fleeDistance = 10f; // Distance at which the AI starts fleeing
    public float speed = 5f;
    private Transform player;
    private NavMeshAgent agent;
    [SerializeField] private Animator animator;

    public GameObject shovel;
    public InteractableItem corpseModeScript;
    private bool isDead = false;

    [SerializeField] AudioSource audio1;
    [SerializeField] AudioSource audio2;
    [SerializeField] AudioSource audio3;
    void Start()
    {
        if (shovel != null)
            shovel.SetActive(false);
        if (corpseModeScript != null)
            corpseModeScript.enabled = false;

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
        if (player != null && isDead == false)
        {
            audio1.volume = 1;
            audio2.volume = 1;
            float distanceToPlayer = Vector3.Distance(transform.position, player.position);

            Debug.Log("Distance to player: " + distanceToPlayer);

            Debug.Log("ObjectiveManager.getObjectiveStatus(WORDENUM.Weapon) to player: " + ObjectiveManager.getObjectiveStatus(WORDENUM.Weapon));

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
                audio1.volume = 0f;
                audio2.volume = 0f;
            }
        }
    }

    public void Die()
    {
        isDead = true;
        audio1.volume = 0f;
        audio2.volume = 0f;
        // Play death animation and sound effect here
        animator.SetBool("pumpdead", true);
        audio3.Play();

        // Show the shovel GameObject
        if (shovel != null)
            shovel.SetActive(true);

        // Enable the InteractableItem script (corpse mode)
        if (corpseModeScript != null)
            corpseModeScript.enabled = true;
    }


}
