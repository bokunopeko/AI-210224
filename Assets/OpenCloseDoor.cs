using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEditorInternal;
using UnityEngine;

public class OpenCloseDoor : MonoBehaviour
{
   public enum DoorState
    {
        Opening,
        Open,
        Closing,
        Close
    }

    public DoorState state;

    private Vector3 closedPosition;
    private Vector3 openPosition;
    public float speed = 5f;
    public Vector3 deltaPosition = new Vector3 (0f, 0f, 0f);

    float timer = 0;
    public float delay = 3f;


    private void Start()
    {
        state = DoorState.Close;

        closedPosition = transform.position;
        openPosition = transform.position + deltaPosition;
    }
    
    void Update()
    {

        switch(state)
        {
            case DoorState.Opening: 
                OpenTheDoor(openPosition);

                if (Vector3.Distance(transform.position, openPosition) < 0.01f)
                {
                    timer = 0;
                    state = DoorState.Open;
                }
                break;

            case DoorState.Open:
                timer += Time.deltaTime;

                if(timer > delay)
                {
                    state = DoorState.Closing;
                }
                break;

            case DoorState.Closing:
                OpenTheDoor(closedPosition);

                if (Vector3.Distance(transform.position, closedPosition) < 0.01f)
                {
                    timer = 0;
                    state = DoorState.Close;
                }
                break;

            case DoorState.Close:
                timer += Time.deltaTime;

                if (timer > delay)
                {
                    state = DoorState.Opening;
                }

                break;

            default:
                //if its not one og te other cases
                //in this witch it does nothing
                break;

        }
        //perious code ^ 
        //if (state == DoorState.Close)
        //{
        //    OpenTheDoor(openPosition);

        //    if (Vector3.Distance(transform.position, openPosition) < 0.01f)
        //        {
        //        state = DoorState.Open;
        //        }
        //}

        //else if (state == DoorState.Open)
        //{
        //    OpenTheDoor(closedPosition);

        //    if (Vector3.Distance(transform.position, closedPosition) < 0.01f)
        //    {
        //        state = DoorState.Close;
        //    }
        
    }

    public void OpenTheDoor(Vector3 targetPosition)
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    }

}
