using JetBrains.Annotations;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabs;
    public int spawnPosition = 20;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", 0, .3f);
    }
    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        int randomX = Random.Range(-16, 16);
        Instantiate(animalPrefabs[animalIndex], new Vector3(randomX, 0, spawnPosition), animalPrefabs[animalIndex].transform.rotation);
    }
}
