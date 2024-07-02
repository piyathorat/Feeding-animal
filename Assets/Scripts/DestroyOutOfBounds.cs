using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOf : MonoBehaviour
{
    // Start is called before the first frame update
    private float topBound = 30;
    private float lowerBound = -10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if an object pass the players  view in the game , remove that object
        if(transform.position.z> topBound)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < lowerBound)
        {
            Debug.Log("Game over");
            Destroy(gameObject);
        }
    }
}

