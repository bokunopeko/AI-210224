using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItems : MonoBehaviour
{
    public int collectedObject = 0;

    public OpenDoor door;

    void Start()
    {
        



    }

    
    private void Update()
    {
        
        if(collectedObject >= 3)
        {
            door.OpenTheDoor();
        }


    }
    

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Collectable")
        {
            collectedObject++;
            Destroy(collision.gameObject);
        }
        //it will show what object you hit
        Debug.Log("Collided with: " + collision.gameObject.name);
    }

    private void OnCollisionExit(Collision collision)
    {
        
    }
}
