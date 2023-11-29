using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefabToSpawn;

    void Start()
    {
        // Start the spawning 
        StartCoroutine(SpawnPrefabCoroutine());
    }

    IEnumerator SpawnPrefabCoroutine()
    {
        while (true)
        {
            // Spawn the prefab
            Instantiate(prefabToSpawn, transform.position, Quaternion.identity);

            // Wait for 3 seconds
            yield return new WaitForSeconds(3f);
        }
    }
}
