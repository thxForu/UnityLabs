using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnEnemy : MonoBehaviour
{
    
    [SerializeField] private GameObject enemyPrefab;
    private Vector3 terrain;
    private void Start()
    {
        
        enemyPrefab.GetComponent<BoxCollider>();
        terrain = GameObject.Find("Terrain").GetComponent<Terrain>().terrainData.size/2;
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        while (true)
        {
            Instantiate(enemyPrefab,
                new Vector3(Random.Range(-terrain.x, terrain.x), 0.5f, Random.Range(-terrain.z, terrain.z)), Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
    }
}
