using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject target;

    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        if (target == null)
        {
            target = GameObject.FindGameObjectWithTag("Player");
        }
    }

    // Update is called once per frame
    void Update()
    {
       

        if (target)
        {
            if (agent.pathStatus != NavMeshPathStatus.PathInvalid)
            {
                agent.destination = target.transform.position;
            }
        }

    }
}
