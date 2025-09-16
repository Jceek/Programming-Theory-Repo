using UnityEngine;
using UnityEngine.Rendering.RenderGraphModule;

public class InheritanceSpawn : MonoBehaviour
{
    public GameObject[] spawnSquad;
    private Vector3 spawnPos;
    private float spawnX;
    private float spawnZ = -11;
    private float spawnY = 1.2f;

    private float xRange = 25;

    private float spawnStart = 5.0f;
    private float spawnDelay = 5.0f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnEverythingAtOnce", spawnStart, spawnDelay);
    }

    // Update is called once per frame
    void Update()
    {


    }
    void SpawnEverythingAtOnce()   
    {
        for (int i = 0; i < spawnSquad.Length; i++)
        {
            spawnX = Random.Range(-xRange, xRange);
            spawnPos = new Vector3(spawnX, spawnY, spawnZ);
            GameObject spawn = spawnSquad[i];
            Instantiate(spawn, spawnPos, Quaternion.Euler(0, 0, 0));
        }
    }
}
