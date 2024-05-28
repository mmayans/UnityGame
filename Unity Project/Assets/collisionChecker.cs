using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionChecker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //Check to see if the tag on the collider is equal to Enemy
        if (other.tag == "tile")
        {
            Debug.Log("tile");
            Debug.Log("trigger");
            
        }
    }

     void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "tile")
        {
            
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Tile");

            Tile t = collision.gameObject.GetComponent<Tile>();

            Debug.Log("collisin");


            t.mine();
            
        }
    }
}
