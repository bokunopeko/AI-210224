using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    // delta mean the change of or different between 2 number

    public Vector3 deltaPosition;
    public float speed;
    public float waitTime;

    private Vector3 _closedPosition;
    private Vector3 _openPosition;



    void Start()
    {
        //when game start, the door will be at closed position
        _closedPosition = transform.position;
        _openPosition = transform.position + deltaPosition;

    }

    public void OpenTheDoor()
    {
        //transform.position is the current position of the game
        //delta time is amount of second between frame 
        transform.position = Vector3.MoveTowards(transform.position, _openPosition, speed * Time.deltaTime);
    }
}
  

