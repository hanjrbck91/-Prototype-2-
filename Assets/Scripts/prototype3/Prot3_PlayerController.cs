using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prot3_PlayerController : MonoBehaviour
{
    public Rigidbody playerRb;
    public float forceAmount;
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {

            playerRb.AddForce(Vector3.up * forceAmount,ForceMode.Impulse);
        }
    }
}
