using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    bool releaseDog = true;

    private void Start()
    {
        InvokeRepeating("TimeDelay", 2, 2);
    }
    // Update is called once per frame
    void Update()
    {
        if (releaseDog)
        {
            // On spacebar press, send dog
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                releaseDog = false;
            }
            

        }
    }
    void TimeDelay()
    {
        releaseDog = !releaseDog;
    }
}
