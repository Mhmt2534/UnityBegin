using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefab;

    int startDelay = 2;
    float spawnInterval = 1.5f;

    void Start()
    {
        InvokeRepeating("SpawnAnimal", startDelay, spawnInterval);
    }




    void Update()
    {

    }


    public void SpawnAnimal()
    {
        int animalCome = Random.Range(-15, 15);

        int index = Random.Range(0, animalPrefab.Length);
        Instantiate(animalPrefab[index], new Vector3(animalCome, 0, 19),
            animalPrefab[index].transform.rotation);
    }


}
