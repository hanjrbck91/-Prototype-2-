using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Prot3SpawnManager : MonoBehaviour
{
    public GameObject spawnPrefab;
    public Vector3 spawnPos = new Vector3(25, 0, 0);
    public float startDelay = 0f;
    public float repeatDelay = .3f;
    private Prot3_PlayerController controller;

    private void Start()
    {
        controller = GameObject.Find("Player").GetComponent<Prot3_PlayerController>();
        InvokeRepeating("SpawnObstacle", startDelay, repeatDelay);
    }
    void SpawnObstacle()
    {
        if(controller.gameOver ==  false)
        {
            Instantiate(spawnPrefab, spawnPos, spawnPrefab.transform.rotation);
        }
    }

}
