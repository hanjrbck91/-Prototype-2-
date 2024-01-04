using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutBound : MonoBehaviour
{
    public float upperBound = 30f;
    public float lowerBound = -5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > upperBound)
        {
            Destroy(gameObject);
        }    
        else if(transform.position.z < lowerBound)
        {
            print("Game Over Cz you miss one animal");
            Destroy(gameObject);
        }
    }
}
