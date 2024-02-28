using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
//rewatch 2.12.00 in 14/2/24 ai class
//game object is th visual that do nothing, need to add conpontent 
//compontent(require game object to have(check inspector if it have NavMeshAgent))
[RequireComponent(typeof(NavMeshAgent))]

public class ClickToMove : MonoBehaviour
{
    //rewatch 2.20.00 14/2 ai class (MovetoObject)?
    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {

        //rewatch 2.09.00 in 14.02.24 ai class 
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        //input is when a button is click
        // get mouse Button (0) mean left click
        if (Input.GetMouseButton(0))
        {
            //ray is a imagination line from the camera toward where the
            //mouse is pointing
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //raycasyHit doest do anything but hitInfo
            //will store info(x,y) of what is htting 
            RaycastHit hitInfo;
            
            // 
            if(Physics.Raycast(ray.origin, ray.direction, out hitInfo))
            {
                // where the aiagent going to where hitInfo(store x,y(detination)) is pointed 
                agent.destination = hitInfo.point;

                //if mouse is clicked on floor, it will be shwn on debug log
                Debug.Log("hit object");
            }

            
        }
    }
}
