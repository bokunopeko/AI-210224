using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveToObject : MonoBehaviour
{
    private NavMeshAgent agent;
    public GameObject followObject;




    // Start is called before the first frame update
    void Start()
    {
        //when the game object is create in the game
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = followObject.transform.position;

    }
}
