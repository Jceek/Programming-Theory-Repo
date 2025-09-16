using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject car;
    public GameObject carReverse;
    private float spawnStart = 2;
    private float spawnDelay = 1.5f;
    private float spawnRange;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        Invoke("SpawnCar", spawnStart -2);                      // ABSTRACTION from here on out
        InvokeRepeating(("SpawnCar"), spawnStart, spawnDelay);
        InvokeRepeating(("SpawnCarReverse"), spawnStart, spawnDelay);
        Invoke("SpawnCarReverse", spawnStart -2);
    }

    // Update is called once per frame
    void Update()
    {
        CalculateSpawn();
    }
       
    // Creating an ABSTRACTION method  that we can reuse easily
    void SpawnCar()
    {
        Vector3 spawnPos = new Vector3(spawnRange, 1, spawnRange);
        Instantiate(car, spawnPos, Quaternion.Euler(0, -90, 0));
    }
    // Creating an ABSTRACTION method  that we can reuse easily
    void SpawnCarReverse()            
    {
        Vector3 spawnPos = new Vector3(-spawnRange, 1, -spawnRange);
        Instantiate(carReverse, spawnPos, Quaternion.Euler(0, 90, 0));
    }
    void CalculateSpawn()
    {
            spawnRange = Random.Range(1, 10);       // ABSTRACTED variable, is being calculated here, then reused everywhere we need it.
    }
}



