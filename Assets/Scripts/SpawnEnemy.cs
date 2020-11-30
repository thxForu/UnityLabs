using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnEnemy : MonoBehaviour
{
    
    [SerializeField] private GameObject enemyPrefab;
    private Vector3 terrain;
    private void Start()
    {
        enemyPrefab.GetComponent<BoxCollider>();
        terrain = GameObject.Find("Terrain").GetComponent<Terrain>().terrainData.size;
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        while (true)
        {
            Instantiate(enemyPrefab,new Vector3(Random.Range(-terrain.x/2, terrain.x/2),0.5f,Random.Range(-terrain.z/2, terrain.z/2)),Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
    }
}
