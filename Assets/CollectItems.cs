using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItems : MonoBehaviour
{
    public int collectedbject = 0;

    void Start()
    {
        



    }

    
    void Update()
    {
        



    }
    

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Collectable")
        {
            collectedbject++;
            Destroy(collision.gameObject);
        }
        //it will show what object you hit
        Debug.Log("Collided with: " + collision.gameObject.name);
    }

    private void OnCollisionExit(Collision collision)
    {
        
    }
}
