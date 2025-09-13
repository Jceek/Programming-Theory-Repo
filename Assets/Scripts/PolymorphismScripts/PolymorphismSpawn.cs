using UnityEngine;

public class PolymorphismSpawn : MonoBehaviour
{
    public float spawnStart = 6.0f;
    public float spawnDelay = 5.0f;

    public GameObject catPrefab;
    public GameObject foxPrefab;
    public GameObject dogPrefab;

    private float catSpawnX = -7.0f;
    private float catSpawnZ = -4.6f;
    private float catSpawnY = 0.1f;

    private float foxSpawnX = -5.8f;
    private float foxSpawnZ = -6.3f;
    private float foxSpawnY = 0.1f;

    private float dogSpawnX = -5.0f;
    private float dogSpawnZ = -7.7f;
    private float dogSpawnY = 0.37f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnCat", spawnStart, spawnDelay);
        InvokeRepeating("SpawnFox", spawnStart, spawnDelay);
        InvokeRepeating("SpawnDog", spawnStart, spawnDelay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnFox()
    {
        Vector3 foxSpawn = new Vector3(foxSpawnX, foxSpawnY, foxSpawnZ);
        Instantiate(foxPrefab, foxSpawn, Quaternion.Euler(0, 90, 0));
    }
    public void SpawnCat()
    {
        Vector3 catSpawn = new Vector3(catSpawnX, catSpawnY, catSpawnZ);
        Instantiate(catPrefab, catSpawn, Quaternion.Euler(0, 90, 0));
    }
    public void SpawnDog()
    {
        Vector3 dogSpawn = new Vector3(dogSpawnX, dogSpawnY, dogSpawnZ);
        Instantiate(dogPrefab, dogSpawn, Quaternion.Euler(0, 0, 0));
    }
    public void SpawnRiver()
    {

    }
}
