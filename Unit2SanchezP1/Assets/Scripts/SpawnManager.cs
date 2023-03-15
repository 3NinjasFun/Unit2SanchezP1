using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public GameObject[] animalPrefabs2;
    public GameObject[] animalPrefabs3;
    float spawnRangeX = 10;
    float spawnRangeZ = 10;
    float spawnPosZ = 20;
    float spawnPosX = 20;
    float startDelay = 2;
    float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void SpawnRandomAnimal()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Vector3 spawnPos2 = new Vector3(spawnPosX, 0 , Random.Range(2, 15));
        Vector3 spawnPos3 = new Vector3(-spawnPosX, 0, Random.Range(2, 15));

        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPos,
        animalPrefabs[animalIndex].transform.rotation);

        int animalIndex2 = Random.Range(0, animalPrefabs2.Length);
        Instantiate(animalPrefabs2[animalIndex2], spawnPos2,
        animalPrefabs2[animalIndex2].transform.rotation);

        int animalIndex3 = Random.Range(0, animalPrefabs3.Length);
        Instantiate(animalPrefabs3[animalIndex3], spawnPos3,
        animalPrefabs3[animalIndex3].transform.rotation);
    }

}
