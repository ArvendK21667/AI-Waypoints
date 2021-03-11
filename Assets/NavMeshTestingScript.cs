using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshTestingScript : MonoBehaviour
{

    [SerializeField] NavMeshAgent myAgent;
    [SerializeField] Transform goal;
    // Update is called once per frame
    void Update()
    {
        myAgent.destination = goal.position;
    }
}
