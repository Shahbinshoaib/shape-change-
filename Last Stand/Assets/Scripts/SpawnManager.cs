using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefeb;

    private float spawnManager = 10;
    // Start is called before the first frame update
    void Start()
    {
        float spawnPosX = Random.Range(-spawnManager, spawnManager);
        float spawnPosZ = Random.Range(-spawnManager, spawnManager);

        Instantiate(enemyPrefeb, new Vector3(spawnPosX, 0 , spawnPosZ), enemyPrefeb.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
