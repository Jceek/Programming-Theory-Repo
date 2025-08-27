using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject car;
    public GameObject carReverse;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("SpawnCar", 1);                      // Abstraction from here on out
        InvokeRepeating(("SpawnCar"), 3, 3);
        InvokeRepeating(("SpawnCarReverse"), 3, 3);
        Invoke("SpawnCarReverse", 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // Creating an abstracted method  that we can reuse easily
    void SpawnCar()
    {
        Vector3 spawnPos = new Vector3(10, 1, 10);
        Instantiate(car, spawnPos, Quaternion.Euler(0, -90, 0));
    }
    // Creating an abstracted method  that we can reuse easily
    void SpawnCarReverse()            
    {
        Vector3 spawnPos = new Vector3(-10, 1, -10);
        Instantiate(carReverse, spawnPos, Quaternion.Euler(0, 90, 0));
    }

}

