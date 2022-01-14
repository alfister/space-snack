using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToSnack : MonoBehaviour
{
    Transform snack;
    Transform player;
    Transform pal;
    UnityEngine.AI.NavMeshAgent agent;
    Animator anim;

    void Awake()
    {
        snack = GameObject.FindGameObjectWithTag("Snack").transform;
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Astronaut").transform;
        pal = GetComponent<Transform>();
        anim = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        if (SnacksFound.helpNeeded)
        {
            agent.SetDestination(snack.position);
        } else
        {
            Vector3 distFromPlayer = new Vector3(2, 0, 1);
            agent.SetDestination(player.position + distFromPlayer);
            anim.SetFloat("Move", agent.velocity.magnitude);
        }
    }
}
