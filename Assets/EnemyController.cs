using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    NavMeshAgent agent;
    [SerializeField] Transform LevelEnd;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.destination = LevelEnd.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
