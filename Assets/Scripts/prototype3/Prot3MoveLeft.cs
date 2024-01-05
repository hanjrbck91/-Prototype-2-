using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prot3MoveLeft : MonoBehaviour
{
    public float moveSpeed;
    private Prot3_PlayerController controller;
    public float leftBound = -15f;

    // Start is called before the first frame update
    void Start()
    {
        controller = GameObject.Find("Player").GetComponent<Prot3_PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
        }

        if(transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
